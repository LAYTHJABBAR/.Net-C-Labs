namespace customerbill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlCalculated = new System.Windows.Forms.Panel();
            this.txtCalculated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblw2 = new System.Windows.Forms.Label();
            this.txtKWH2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnlOffPeak = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblw1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtKWH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCalculated.SuspendLayout();
            this.pnlOffPeak.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(137, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Application Calculate a Customer Power Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(102, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Select One of the Customer Plans and then Enter how many KWH was Used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInformation);
            this.panel1.Controls.Add(this.lblInformation);
            this.panel1.Location = new System.Drawing.Point(343, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 152);
            this.panel1.TabIndex = 3;
            // 
            // txtInformation
            // 
            this.txtInformation.BackColor = System.Drawing.Color.Black;
            this.txtInformation.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.ForeColor = System.Drawing.Color.Transparent;
            this.txtInformation.Location = new System.Drawing.Point(9, 28);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(1);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(405, 120);
            this.txtInformation.TabIndex = 1;
            this.txtInformation.Text = " ";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Red;
            this.lblInformation.Location = new System.Drawing.Point(9, 7);
            this.lblInformation.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(327, 19);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Information About the Comercial Power Plan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radIndustrial);
            this.panel2.Controls.Add(this.radCommercial);
            this.panel2.Controls.Add(this.radResidential);
            this.panel2.Location = new System.Drawing.Point(222, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 152);
            this.panel2.TabIndex = 4;
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(8, 112);
            this.radIndustrial.Margin = new System.Windows.Forms.Padding(1);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(80, 17);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommercial.Location = new System.Drawing.Point(8, 65);
            this.radCommercial.Margin = new System.Windows.Forms.Padding(1);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(92, 17);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResidential.Location = new System.Drawing.Point(8, 16);
            this.radResidential.Margin = new System.Windows.Forms.Padding(1);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(88, 17);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please Select Your Plan";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(10, 368);
            this.btnReset.Margin = new System.Windows.Forms.Padding(1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 42);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(272, 368);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(124, 368);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 42);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pnlCalculated
            // 
            this.pnlCalculated.Controls.Add(this.txtCalculated);
            this.pnlCalculated.Controls.Add(this.label7);
            this.pnlCalculated.Location = new System.Drawing.Point(519, 355);
            this.pnlCalculated.Margin = new System.Windows.Forms.Padding(1);
            this.pnlCalculated.Name = "pnlCalculated";
            this.pnlCalculated.Size = new System.Drawing.Size(241, 69);
            this.pnlCalculated.TabIndex = 12;
            this.pnlCalculated.Visible = false;
            // 
            // txtCalculated
            // 
            this.txtCalculated.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculated.Location = new System.Drawing.Point(87, 19);
            this.txtCalculated.Margin = new System.Windows.Forms.Padding(1);
            this.txtCalculated.Multiline = true;
            this.txtCalculated.Name = "txtCalculated";
            this.txtCalculated.Size = new System.Drawing.Size(125, 31);
            this.txtCalculated.TabIndex = 1;
            this.txtCalculated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Your Bill is :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Author: Layth Al-Shareefi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date: April - 2020";
            // 
            // lblw2
            // 
            this.lblw2.AutoSize = true;
            this.lblw2.Location = new System.Drawing.Point(1, 13);
            this.lblw2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblw2.Name = "lblw2";
            this.lblw2.Size = new System.Drawing.Size(164, 14);
            this.lblw2.TabIndex = 15;
            this.lblw2.Text = "KWH Used in Off-Peak Hours";
            // 
            // txtKWH2
            // 
            this.txtKWH2.Location = new System.Drawing.Point(177, 10);
            this.txtKWH2.Margin = new System.Windows.Forms.Padding(1);
            this.txtKWH2.Multiline = true;
            this.txtKWH2.Name = "txtKWH2";
            this.txtKWH2.Size = new System.Drawing.Size(114, 28);
            this.txtKWH2.TabIndex = 16;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(307, 13);
            this.lbl2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(250, 14);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Type here Only KWH Used in off-peak hours";
            // 
            // pnlOffPeak
            // 
            this.pnlOffPeak.Controls.Add(this.lblw2);
            this.pnlOffPeak.Controls.Add(this.lbl2);
            this.pnlOffPeak.Controls.Add(this.txtKWH2);
            this.pnlOffPeak.Location = new System.Drawing.Point(189, 307);
            this.pnlOffPeak.Margin = new System.Windows.Forms.Padding(1);
            this.pnlOffPeak.Name = "pnlOffPeak";
            this.pnlOffPeak.Size = new System.Drawing.Size(570, 44);
            this.pnlOffPeak.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblw1);
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Controls.Add(this.txtKWH);
            this.panel3.Location = new System.Drawing.Point(189, 259);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 46);
            this.panel3.TabIndex = 19;
            // 
            // lblw1
            // 
            this.lblw1.AutoSize = true;
            this.lblw1.Location = new System.Drawing.Point(1, 13);
            this.lblw1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblw1.Name = "lblw1";
            this.lblw1.Size = new System.Drawing.Size(69, 14);
            this.lblw1.TabIndex = 15;
            this.lblw1.Text = "KWH Used ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(307, 13);
            this.lbl1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(231, 14);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Type here Only KWH Used in Peak hours";
            // 
            // txtKWH
            // 
            this.txtKWH.Location = new System.Drawing.Point(177, 10);
            this.txtKWH.Margin = new System.Windows.Forms.Padding(1);
            this.txtKWH.Multiline = true;
            this.txtKWH.Name = "txtKWH";
            this.txtKWH.Size = new System.Drawing.Size(114, 28);
            this.txtKWH.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(774, 472);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlOffPeak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlCalculated);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(790, 483);
            this.Name = "Form1";
            this.Text = "Customer Power Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCalculated.ResumeLayout(false);
            this.pnlCalculated.PerformLayout();
            this.pnlOffPeak.ResumeLayout(false);
            this.pnlOffPeak.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel pnlCalculated;
        private System.Windows.Forms.TextBox txtCalculated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblw2;
        private System.Windows.Forms.TextBox txtKWH2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnlOffPeak;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblw1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtKWH;
    }
}

