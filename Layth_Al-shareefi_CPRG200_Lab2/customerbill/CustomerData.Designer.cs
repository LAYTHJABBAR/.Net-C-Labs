namespace customerbill
{
    partial class CustomerData
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlCalculated = new System.Windows.Forms.Panel();
            this.txtCalculated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblw2 = new System.Windows.Forms.Label();
            this.txtKWH2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnlOffPeak = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblw1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtKWH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIamount = new System.Windows.Forms.Label();
            this.lblCOamount = new System.Windows.Forms.Label();
            this.lblRamount = new System.Windows.Forms.Label();
            this.lblCamount = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtCNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlCalculated.SuspendLayout();
            this.pnlOffPeak.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.radIndustrial);
            this.panel2.Controls.Add(this.radCommercial);
            this.panel2.Controls.Add(this.radResidential);
            this.panel2.Location = new System.Drawing.Point(20, 239);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 90);
            this.panel2.TabIndex = 4;
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(8, 65);
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
            this.radCommercial.Location = new System.Drawing.Point(8, 38);
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
            this.radResidential.Location = new System.Drawing.Point(8, 12);
            this.radResidential.Margin = new System.Windows.Forms.Padding(1);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(88, 17);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 401);
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
            this.btnExit.Location = new System.Drawing.Point(267, 401);
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
            this.btnCalculate.Location = new System.Drawing.Point(120, 401);
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
            this.pnlCalculated.Location = new System.Drawing.Point(5, 336);
            this.pnlCalculated.Margin = new System.Windows.Forms.Padding(1);
            this.pnlCalculated.Name = "pnlCalculated";
            this.pnlCalculated.Size = new System.Drawing.Size(182, 59);
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
            this.txtCalculated.Size = new System.Drawing.Size(88, 31);
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
            this.txtKWH2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlOffPeak.Location = new System.Drawing.Point(205, 355);
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
            this.panel3.Location = new System.Drawing.Point(205, 302);
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
            this.txtKWH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKWH.Location = new System.Drawing.Point(177, 10);
            this.txtKWH.Margin = new System.Windows.Forms.Padding(1);
            this.txtKWH.Multiline = true;
            this.txtKWH.Name = "txtKWH";
            this.txtKWH.Size = new System.Drawing.Size(114, 28);
            this.txtKWH.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIamount);
            this.groupBox1.Controls.Add(this.lblCOamount);
            this.groupBox1.Controls.Add(this.lblRamount);
            this.groupBox1.Controls.Add(this.lblCamount);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lstCustomer);
            this.groupBox1.Location = new System.Drawing.Point(267, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(498, 240);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer List";
            // 
            // lblIamount
            // 
            this.lblIamount.BackColor = System.Drawing.Color.PeachPuff;
            this.lblIamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIamount.Location = new System.Drawing.Point(391, 199);
            this.lblIamount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblIamount.Name = "lblIamount";
            this.lblIamount.Size = new System.Drawing.Size(85, 35);
            this.lblIamount.TabIndex = 10;
            this.lblIamount.Text = " ";
            this.lblIamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCOamount
            // 
            this.lblCOamount.BackColor = System.Drawing.Color.PeachPuff;
            this.lblCOamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCOamount.Location = new System.Drawing.Point(391, 154);
            this.lblCOamount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCOamount.Name = "lblCOamount";
            this.lblCOamount.Size = new System.Drawing.Size(85, 34);
            this.lblCOamount.TabIndex = 9;
            this.lblCOamount.Text = " ";
            this.lblCOamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRamount
            // 
            this.lblRamount.BackColor = System.Drawing.Color.PeachPuff;
            this.lblRamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRamount.Location = new System.Drawing.Point(391, 112);
            this.lblRamount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRamount.Name = "lblRamount";
            this.lblRamount.Size = new System.Drawing.Size(85, 35);
            this.lblRamount.TabIndex = 8;
            this.lblRamount.Text = " ";
            this.lblRamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCamount
            // 
            this.lblCamount.BackColor = System.Drawing.Color.PeachPuff;
            this.lblCamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCamount.Location = new System.Drawing.Point(391, 68);
            this.lblCamount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCamount.Name = "lblCamount";
            this.lblCamount.Size = new System.Drawing.Size(85, 35);
            this.lblCamount.TabIndex = 7;
            this.lblCamount.Text = " ";
            this.lblCamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.PeachPuff;
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Location = new System.Drawing.Point(391, 23);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(85, 35);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = " ";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(222, 209);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 14);
            this.label12.TabIndex = 5;
            this.label12.Text = "Sum Of Industrial Charge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(222, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 14);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sum Of Commercial Charge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(222, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sum Of Residential Charge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sum of Charge Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total no # of Customers";
            // 
            // lstCustomer
            // 
            this.lstCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 14;
            this.lstCustomer.Location = new System.Drawing.Point(15, 23);
            this.lstCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(205, 200);
            this.lstCustomer.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(170, 141);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 37);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "&Add >>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 123);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 14);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(18, 141);
            this.txtName.Margin = new System.Windows.Forms.Padding(1);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 37);
            this.txtName.TabIndex = 23;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(18, 41);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(121, 14);
            this.lblNumber.TabIndex = 24;
            this.lblNumber.Text = "Customer Number:";
            // 
            // txtCNumber
            // 
            this.txtCNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNumber.Location = new System.Drawing.Point(18, 63);
            this.txtCNumber.Margin = new System.Windows.Forms.Padding(1);
            this.txtCNumber.Multiline = true;
            this.txtCNumber.Name = "txtCNumber";
            this.txtCNumber.Size = new System.Drawing.Size(139, 36);
            this.txtCNumber.TabIndex = 25;
            this.txtCNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "Select the Plan:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(788, 472);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlOffPeak);
            this.Controls.Add(this.pnlCalculated);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(783, 461);
            this.Name = "Form1";
            this.Text = "Customer Power Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCalculated.ResumeLayout(false);
            this.pnlCalculated.PerformLayout();
            this.pnlOffPeak.ResumeLayout(false);
            this.pnlOffPeak.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel pnlCalculated;
        private System.Windows.Forms.TextBox txtCalculated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblw2;
        private System.Windows.Forms.TextBox txtKWH2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnlOffPeak;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblw1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtKWH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Label lblIamount;
        private System.Windows.Forms.Label lblCOamount;
        private System.Windows.Forms.Label lblRamount;
        private System.Windows.Forms.Label lblCamount;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtCNumber;
        private System.Windows.Forms.Label label8;
    }
}

