namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbPGTEST = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbPGS = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbPGPR = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbPGT = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbPGNT = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bPGG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbPGTEST
            // 
            this.rtbPGTEST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPGTEST.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbPGTEST.Location = new System.Drawing.Point(12, 447);
            this.rtbPGTEST.Name = "rtbPGTEST";
            this.rtbPGTEST.Size = new System.Drawing.Size(801, 124);
            this.rtbPGTEST.TabIndex = 31;
            this.rtbPGTEST.Text = "2-(3+5);\n2 + (6 * 3);\n(3 + 2)*2 + 5;\n2.0E-2+0.5;\n5+10";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Test: ";
            // 
            // rtbPGS
            // 
            this.rtbPGS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPGS.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbPGS.Location = new System.Drawing.Point(278, 38);
            this.rtbPGS.Name = "rtbPGS";
            this.rtbPGS.Size = new System.Drawing.Size(636, 390);
            this.rtbPGS.TabIndex = 29;
            this.rtbPGS.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Status:";
            // 
            // rtbPGPR
            // 
            this.rtbPGPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbPGPR.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbPGPR.Location = new System.Drawing.Point(11, 208);
            this.rtbPGPR.Name = "rtbPGPR";
            this.rtbPGPR.Size = new System.Drawing.Size(258, 220);
            this.rtbPGPR.TabIndex = 23;
            this.rtbPGPR.Text = "S -> E ;\nE -> E + E\nE -> E - E\nE -> E * E\nE -> E / E\nE -> - E  %prec UMINUS\nE -> " +
    "( E )\nE -> num";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Production Rules:";
            // 
            // rtbPGT
            // 
            this.rtbPGT.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbPGT.Location = new System.Drawing.Point(11, 100);
            this.rtbPGT.Name = "rtbPGT";
            this.rtbPGT.Size = new System.Drawing.Size(258, 87);
            this.rtbPGT.TabIndex = 21;
            this.rtbPGT.Text = "equal, =\nmultiple, *\ndivide, /\nplus, +\nminus, -\nnum, num\nop_open, (\nop_close, )\ne" +
    "nd, ;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Terminals: ";
            // 
            // rtbPGNT
            // 
            this.rtbPGNT.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbPGNT.Location = new System.Drawing.Point(11, 25);
            this.rtbPGNT.Name = "rtbPGNT";
            this.rtbPGNT.Size = new System.Drawing.Size(258, 52);
            this.rtbPGNT.TabIndex = 19;
            this.rtbPGNT.Text = "S, E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Non-terminals: ";
            // 
            // bPGG
            // 
            this.bPGG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPGG.Location = new System.Drawing.Point(815, 447);
            this.bPGG.Name = "bPGG";
            this.bPGG.Size = new System.Drawing.Size(99, 124);
            this.bPGG.TabIndex = 32;
            this.bPGG.Text = "Generate";
            this.bPGG.UseVisualStyleBackColor = true;
            this.bPGG.Click += new System.EventHandler(this.bPGG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 599);
            this.Controls.Add(this.bPGG);
            this.Controls.Add(this.rtbPGTEST);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtbPGS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbPGPR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbPGT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbPGNT);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPGTEST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbPGS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbPGPR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbPGT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbPGNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bPGG;
    }
}

