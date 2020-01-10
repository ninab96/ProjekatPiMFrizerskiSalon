namespace WindowsFormsApp1
{
    partial class Pocetni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetni));
            this.btnPristupi = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.inpImePrezime = new System.Windows.Forms.TextBox();
            this.inpBrojTelefona = new System.Windows.Forms.TextBox();
            this.dropDan = new System.Windows.Forms.ComboBox();
            this.dropVreme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbDelatnosti = new System.Windows.Forms.ComboBox();
            this.dropGodina = new System.Windows.Forms.ComboBox();
            this.dropMesec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPristupi
            // 
            this.btnPristupi.Location = new System.Drawing.Point(320, 369);
            this.btnPristupi.Name = "btnPristupi";
            this.btnPristupi.Size = new System.Drawing.Size(87, 23);
            this.btnPristupi.TabIndex = 0;
            this.btnPristupi.Text = "Pristupi sistemu";
            this.btnPristupi.UseVisualStyleBackColor = true;
            this.btnPristupi.Click += new System.EventHandler(this.btnPristupi_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(69, 369);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(80, 20);
            this.txtId.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(100, 149);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.CausesValidation = false;
            this.label2.Image = global::WindowsFormsApp1.Properties.Resources.salonbackground;
            this.label2.Location = new System.Drawing.Point(-518, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1494, 357);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(211, 369);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = 'X';
            this.txtLozinka.Size = new System.Drawing.Size(90, 20);
            this.txtLozinka.TabIndex = 6;
            // 
            // btnZakazi
            // 
            this.btnZakazi.Location = new System.Drawing.Point(239, 168);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(289, 30);
            this.btnZakazi.TabIndex = 9;
            this.btnZakazi.Text = "Zakazi";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // inpImePrezime
            // 
            this.inpImePrezime.Location = new System.Drawing.Point(334, 110);
            this.inpImePrezime.Name = "inpImePrezime";
            this.inpImePrezime.Size = new System.Drawing.Size(194, 20);
            this.inpImePrezime.TabIndex = 10;
            // 
            // inpBrojTelefona
            // 
            this.inpBrojTelefona.Location = new System.Drawing.Point(334, 142);
            this.inpBrojTelefona.Name = "inpBrojTelefona";
            this.inpBrojTelefona.Size = new System.Drawing.Size(194, 20);
            this.inpBrojTelefona.TabIndex = 11;
            // 
            // dropDan
            // 
            this.dropDan.FormattingEnabled = true;
            this.dropDan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dropDan.Location = new System.Drawing.Point(239, 74);
            this.dropDan.Name = "dropDan";
            this.dropDan.Size = new System.Drawing.Size(47, 21);
            this.dropDan.TabIndex = 12;
            this.dropDan.Text = "Dan";
            this.dropDan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dropVreme
            // 
            this.dropVreme.FormattingEnabled = true;
            this.dropVreme.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.dropVreme.Location = new System.Drawing.Point(391, 74);
            this.dropVreme.Name = "dropVreme";
            this.dropVreme.Size = new System.Drawing.Size(62, 21);
            this.dropVreme.TabIndex = 13;
            this.dropVreme.Text = "Vreme";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(242, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ime i Prezime";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(242, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Vas broj telefona";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID Broj";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(155, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lozinka";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(242, 252);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 18;
            // 
            // cmbDelatnosti
            // 
            this.cmbDelatnosti.FormattingEnabled = true;
            this.cmbDelatnosti.Location = new System.Drawing.Point(239, 42);
            this.cmbDelatnosti.Name = "cmbDelatnosti";
            this.cmbDelatnosti.Size = new System.Drawing.Size(289, 21);
            this.cmbDelatnosti.TabIndex = 19;
            this.cmbDelatnosti.Text = "Usluga";
            // 
            // dropGodina
            // 
            this.dropGodina.FormattingEnabled = true;
            this.dropGodina.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.dropGodina.Location = new System.Drawing.Point(459, 74);
            this.dropGodina.Name = "dropGodina";
            this.dropGodina.Size = new System.Drawing.Size(69, 21);
            this.dropGodina.TabIndex = 20;
            this.dropGodina.Text = "Godina";
            // 
            // dropMesec
            // 
            this.dropMesec.FormattingEnabled = true;
            this.dropMesec.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.dropMesec.Location = new System.Drawing.Point(292, 74);
            this.dropMesec.Name = "dropMesec";
            this.dropMesec.Size = new System.Drawing.Size(85, 21);
            this.dropMesec.TabIndex = 21;
            this.dropMesec.Text = "Mesec";
            // 
            // Pocetni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 401);
            this.Controls.Add(this.dropMesec);
            this.Controls.Add(this.dropGodina);
            this.Controls.Add(this.cmbDelatnosti);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropVreme);
            this.Controls.Add(this.dropDan);
            this.Controls.Add(this.inpBrojTelefona);
            this.Controls.Add(this.inpImePrezime);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.btnPristupi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pocetni";
            this.Text = "Frizerski Salon";
            this.Load += new System.EventHandler(this.Pocetni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPristupi;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.TextBox inpImePrezime;
        private System.Windows.Forms.TextBox inpBrojTelefona;
        private System.Windows.Forms.ComboBox dropDan;
        private System.Windows.Forms.ComboBox dropVreme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbDelatnosti;
        private System.Windows.Forms.ComboBox dropGodina;
        private System.Windows.Forms.ComboBox dropMesec;
    }
}

