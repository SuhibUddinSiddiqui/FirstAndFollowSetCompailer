using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ParserGenerator
    {
        List<ParserProduction> production_rules;
        public StringBuilder GlobalPrinter = new StringBuilder();
        public readonly static ParserProduction EmptyString = new ParserProduction { index = -2 };

        public ParserGenerator()
        {
            production_rules = new List<ParserProduction>();
            production_rules.Add(new ParserProduction { index = 0, production_name = "S'" });

        }
        public ParserProduction CreateNewProduction(string name = "", bool is_terminal = true)
        {
            var pp = new ParserProduction { index = production_rules.Count, production_name = name, isterminal = is_terminal };
            production_rules.Add(pp);
            return pp;
        }
        public void PushStarts(ParserProduction pp)
        {
            // Augment stats node
            production_rules[0].sub_productions.Add(new List<ParserProduction> { pp });
        }
        public void Generate()
        {
            var FIRST = new List<HashSet<int>>();
            foreach (var rule in production_rules)
                FIRST.Add(first_terminals(rule.index));

            var FOLLOW = new List<HashSet<int>>();
            for (int i = 0; i < production_rules.Count; i++)
                FOLLOW.Add(new HashSet<int>());
            FOLLOW[0].Add(-1); // -1: Sentinel

            // 1. B -> a A b, Add FIRST(b) to FOLLOW(A)
            for (int i = 0; i < production_rules.Count; i++)
                if (!production_rules[i].isterminal)
                    foreach (var rule in production_rules[i].sub_productions)
                        for (int j = 0; j < rule.Count - 1; j++)
                            if (rule[j].isterminal == false || rule[j + 1].isterminal)
                                foreach (var r in FIRST[rule[j + 1].index])
                                    FOLLOW[rule[j].index].Add(r);

            // 2. B -> a A b and empty -> FIRST(b), Add FOLLOW(B) to FOLLOW(A)
            for (int i = 0; i < production_rules.Count; i++)
                if (!production_rules[i].isterminal)
                    foreach (var rule in production_rules[i].sub_productions)
                        if (rule.Count > 2 && rule[rule.Count - 2].isterminal == false && FIRST[rule.Last().index].Contains(EmptyString.index))
                            foreach (var r in FOLLOW[i])
                                FOLLOW[rule[rule.Count - 2].index].Add(r);

            // 3. B -> a A, Add FOLLOW(B) to FOLLOW(A)
            for (int i = 0; i < production_rules.Count; i++)
                if (!production_rules[i].isterminal)
                    foreach (var rule in production_rules[i].sub_productions)
                        if (rule.Last().isterminal == false)
                            foreach (var r in FOLLOW[i])
                                if (rule.Last().index > 0)
                                    FOLLOW[rule.Last().index].Add(r);

#if true
            print_header("FISRT, FOLLOW SETS");
            print_hs(FIRST, "FIRST");
            print_hs(FOLLOW, "FOLLOW");
#endif
        }
        private HashSet<int> first_terminals(int index)
        {
            var result = new HashSet<int>();
            var q = new Queue<int>();
            var visit = new List<bool>();
            visit.AddRange(Enumerable.Repeat(false, production_rules.Count));
            q.Enqueue(index);

            while (q.Count != 0)
            {
                var p = q.Dequeue();
                if (p < 0 || visit[p]) continue;
                visit[p] = true;

                if (p < 0 || production_rules[p].isterminal)
                    result.Add(p);
                else
                    production_rules[p].sub_productions.Where(x => x.Count > 0).ToList().ForEach(y => q.Enqueue(y[0].index));
            }

            return result;
        }
        private void print_header(string head_text)
        {
            GlobalPrinter.Append("\r\n" + new string('=', 50) + "\r\n\r\n");
            int spaces = 50 - head_text.Length;
            int padLeft = spaces / 2 + head_text.Length;
            GlobalPrinter.Append(head_text.PadLeft(padLeft).PadRight(50));
            GlobalPrinter.Append("\r\n\r\n" + new string('=', 50) + "\r\n");
        }
        private void print_hs(List<HashSet<int>> lhs, string prefix)
        {
            for (int i = 0; i < lhs.Count; i++)
                if (lhs[i].Count > 0)
                    GlobalPrinter.Append(
                        $"{prefix}({production_rules[i].production_name})={{{string.Join(",", lhs[i].ToList().Select(x => x == -1 ? "$" : production_rules[x].production_name))}}}\r\n");
        }
    }
}

