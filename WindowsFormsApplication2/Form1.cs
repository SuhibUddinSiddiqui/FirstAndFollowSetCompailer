using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication2;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bPGG_Click(object sender, EventArgs e)
        {
            try
            {
                var gen = new ParserGenerator();
                
                var non_terminals = new Dictionary<string, ParserProduction>();
                var terminals = new Dictionary<string, ParserProduction>();

                terminals.Add("''", ParserGenerator.EmptyString);

                foreach (var nt in rtbPGNT.Text.Split(','))
                    non_terminals.Add(nt.Trim(), gen.CreateNewProduction(nt.Trim(), false));

                foreach (var t in rtbPGT.Lines)
                {
                    if (t.Trim() == "") continue;

                    var name = t.Split(',')[0];
                    var pp = t.Substring(name.Length + 1).Trim();

                    terminals.Add(pp, gen.CreateNewProduction(name.Trim()));
                }

                var prec = new Dictionary<string, List<Tuple<ParserProduction, int>>>();

                foreach (var pp in rtbPGPR.Lines)
                {
                    if (pp.Trim() == "") continue;

                    var split = pp.Split(new[] { "->" }, StringSplitOptions.None);
                    var left = split[0].Trim();
                    var right = split[1].Split(' ');

                    var prlist = new List<ParserProduction>();
                    bool stay_prec = false;
                    foreach (var ntt in right)
                    {
                        if (string.IsNullOrEmpty(ntt)) continue;
                        if (ntt == "%prec") { stay_prec = true; continue; }
                        if (stay_prec)
                        {
                            if (!prec.ContainsKey(ntt))
                                prec.Add(ntt, new List<Tuple<ParserProduction, int>>());
                            prec[ntt].Add(new Tuple<ParserProduction, int>(non_terminals[left], non_terminals[left].sub_productions.Count));
                            continue;
                        }
                        if (non_terminals.ContainsKey(ntt))
                            prlist.Add(non_terminals[ntt]);
                        else if (terminals.ContainsKey(ntt))
                            prlist.Add(terminals[ntt]);
                        else
                        {
                            rtbPGS.Text = $"Production rule build error!\r\n{ntt} is neither non-terminal nor terminal!\r\nDeclare the token-name!";
                            return;
                        }
                    }
                    non_terminals[left].sub_productions.Add(prlist);
                }

                //for (int i = rtbPGC.Lines.Length - 1; i >= 0; i--)
                //{
                //    var line = rtbPGC.Lines[i].Trim();
                //    if (line == "") continue;
                //    var tt = line.Split(' ')[0];
                //    var rr = line.Substring(tt.Length).Trim().Split(',');

                //    var left = true;
                //    var items1 = new List<Tuple<ParserProduction, int>>();
                //    var items2 = new List<ParserProduction>();

                //    if (tt == "%right") left = false;

                //    foreach (var ii in rr.Select(x => x.Trim()))
                //    {
                //        if (string.IsNullOrEmpty(ii)) continue;
                //        if (terminals.ContainsKey(ii))
                //            items2.Add(terminals[ii]);
                //        else if (prec.ContainsKey(ii))
                //            items1.AddRange(prec[ii]);
                //        else
                //        {
                //            rtbPGS.Text = $"Conflict rule applying error!\r\n{ii} is neither terminal nor %prec!\r\nDeclare the token-name!";
                //            return;
                //        }
                //    }

                //    if (items1.Count > 0)
                //        gen.PushConflictSolver(left, items1.ToArray());
                //    else
                //        gen.PushConflictSolver(left, items2.ToArray());
                //}

                rtbPGS.Clear();
                gen.GlobalPrinter.Clear();
                gen.PushStarts(non_terminals[rtbPGNT.Text.Split(',')[0].Trim()]);
               


                    gen.Generate();
                
                
                rtbPGS.AppendText(gen.GlobalPrinter.ToString());
                
            }
            catch (Exception ex)
            {
                rtbPGS.AppendText("Generate Error!\r\n" + ex.Message + "\r\n" + ex.StackTrace);
            }
        }
    }
}
