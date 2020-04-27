namespace MOVA2020.forms
{
    partial class Varauksentiedot
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
            this.lblVaraus = new System.Windows.Forms.Label();
            this.calVaraus = new System.Windows.Forms.MonthCalendar();
            this.lblVarattupvm = new System.Windows.Forms.Label();
            this.dtpVarattupvm = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAsiakasPostinumero = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblAsiakasOsoite = new System.Windows.Forms.Label();
            this.lblAsiakasPaikkakunta = new System.Windows.Forms.Label();
            this.lblPuhelinnumero = new System.Windows.Forms.Label();
            this.lblSahkoposti = new System.Windows.Forms.Label();
            this.lblToimintaalue = new System.Windows.Forms.Label();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblMokkiPaikkakunta = new System.Windows.Forms.Label();
            this.lblMokkiOsoite = new System.Windows.Forms.Label();
            this.lblMokkiPostinro = new System.Windows.Forms.Label();
            this.lblHinta = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.rtbKuvaus = new System.Windows.Forms.RichTextBox();
            this.rtbVarustelu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbToimintaalue = new System.Windows.Forms.TextBox();
            this.tbMokkiPostinro = new System.Windows.Forms.TextBox();
            this.tbMokkiOsoite = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.nmrHenkilomaara = new System.Windows.Forms.NumericUpDown();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.tbMokkiPaikkakunta = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbAsiakasosoite = new System.Windows.Forms.TextBox();
            this.tbAsiakaspostinro = new System.Windows.Forms.TextBox();
            this.tbAsiakasPaikkakunta = new System.Windows.Forms.TextBox();
            this.tbPuhnro = new System.Windows.Forms.TextBox();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHenkilomaara)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVaraus.Location = new System.Drawing.Point(24, 248);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(53, 17);
            this.lblVaraus.TabIndex = 4;
            this.lblVaraus.Text = "Varaus";
            // 
            // calVaraus
            // 
            this.calVaraus.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.calVaraus.Enabled = false;
            this.calVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calVaraus.Location = new System.Drawing.Point(27, 270);
            this.calVaraus.MaxSelectionCount = 999999;
            this.calVaraus.Name = "calVaraus";
            this.calVaraus.ShowWeekNumbers = true;
            this.calVaraus.TabIndex = 5;
            this.calVaraus.TitleBackColor = System.Drawing.Color.Yellow;
            this.calVaraus.TrailingForeColor = System.Drawing.Color.Yellow;
            // 
            // lblVarattupvm
            // 
            this.lblVarattupvm.AutoSize = true;
            this.lblVarattupvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVarattupvm.Location = new System.Drawing.Point(24, 219);
            this.lblVarattupvm.Name = "lblVarattupvm";
            this.lblVarattupvm.Size = new System.Drawing.Size(133, 17);
            this.lblVarattupvm.TabIndex = 6;
            this.lblVarattupvm.Text = "Varattu Päivämäärä";
            // 
            // dtpVarattupvm
            // 
            this.dtpVarattupvm.Enabled = false;
            this.dtpVarattupvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpVarattupvm.Location = new System.Drawing.Point(187, 219);
            this.dtpVarattupvm.Name = "dtpVarattupvm";
            this.dtpVarattupvm.Size = new System.Drawing.Size(239, 23);
            this.dtpVarattupvm.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 191);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbSahkoposti);
            this.tabPage1.Controls.Add(this.tbPuhnro);
            this.tabPage1.Controls.Add(this.tbAsiakasPaikkakunta);
            this.tabPage1.Controls.Add(this.tbAsiakaspostinro);
            this.tabPage1.Controls.Add(this.tbAsiakasosoite);
            this.tabPage1.Controls.Add(this.tbSukunimi);
            this.tabPage1.Controls.Add(this.tbEtunimi);
            this.tabPage1.Controls.Add(this.lblSahkoposti);
            this.tabPage1.Controls.Add(this.lblPuhelinnumero);
            this.tabPage1.Controls.Add(this.lblAsiakasPaikkakunta);
            this.tabPage1.Controls.Add(this.lblAsiakasOsoite);
            this.tabPage1.Controls.Add(this.lblSukunimi);
            this.tabPage1.Controls.Add(this.lblAsiakasPostinumero);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asiakkaan tiedot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbMokkiPaikkakunta);
            this.tabPage2.Controls.Add(this.tbMokkinimi);
            this.tabPage2.Controls.Add(this.nmrHenkilomaara);
            this.tabPage2.Controls.Add(this.tbHinta);
            this.tabPage2.Controls.Add(this.tbMokkiOsoite);
            this.tabPage2.Controls.Add(this.tbMokkiPostinro);
            this.tabPage2.Controls.Add(this.tbToimintaalue);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.rtbVarustelu);
            this.tabPage2.Controls.Add(this.rtbKuvaus);
            this.tabPage2.Controls.Add(this.lblVarustelu);
            this.tabPage2.Controls.Add(this.lblKuvaus);
            this.tabPage2.Controls.Add(this.lblHinta);
            this.tabPage2.Controls.Add(this.lblMokkiPaikkakunta);
            this.tabPage2.Controls.Add(this.lblMokkiOsoite);
            this.tabPage2.Controls.Add(this.lblMokkiPostinro);
            this.tabPage2.Controls.Add(this.lblMokkinimi);
            this.tabPage2.Controls.Add(this.lblToimintaalue);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mökin tiedot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Etunimi";
            // 
            // lblAsiakasPostinumero
            // 
            this.lblAsiakasPostinumero.AutoSize = true;
            this.lblAsiakasPostinumero.Location = new System.Drawing.Point(181, 63);
            this.lblAsiakasPostinumero.Name = "lblAsiakasPostinumero";
            this.lblAsiakasPostinumero.Size = new System.Drawing.Size(87, 17);
            this.lblAsiakasPostinumero.TabIndex = 1;
            this.lblAsiakasPostinumero.Text = "Postinumero";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(181, 16);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(65, 17);
            this.lblSukunimi.TabIndex = 2;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblAsiakasOsoite
            // 
            this.lblAsiakasOsoite.AutoSize = true;
            this.lblAsiakasOsoite.Location = new System.Drawing.Point(11, 63);
            this.lblAsiakasOsoite.Name = "lblAsiakasOsoite";
            this.lblAsiakasOsoite.Size = new System.Drawing.Size(49, 17);
            this.lblAsiakasOsoite.TabIndex = 3;
            this.lblAsiakasOsoite.Text = "Osoite";
            // 
            // lblAsiakasPaikkakunta
            // 
            this.lblAsiakasPaikkakunta.AutoSize = true;
            this.lblAsiakasPaikkakunta.Location = new System.Drawing.Point(11, 110);
            this.lblAsiakasPaikkakunta.Name = "lblAsiakasPaikkakunta";
            this.lblAsiakasPaikkakunta.Size = new System.Drawing.Size(85, 17);
            this.lblAsiakasPaikkakunta.TabIndex = 4;
            this.lblAsiakasPaikkakunta.Text = "Paikkakunta";
            // 
            // lblPuhelinnumero
            // 
            this.lblPuhelinnumero.AutoSize = true;
            this.lblPuhelinnumero.Location = new System.Drawing.Point(339, 16);
            this.lblPuhelinnumero.Name = "lblPuhelinnumero";
            this.lblPuhelinnumero.Size = new System.Drawing.Size(103, 17);
            this.lblPuhelinnumero.TabIndex = 5;
            this.lblPuhelinnumero.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            this.lblSahkoposti.AutoSize = true;
            this.lblSahkoposti.Location = new System.Drawing.Point(519, 16);
            this.lblSahkoposti.Name = "lblSahkoposti";
            this.lblSahkoposti.Size = new System.Drawing.Size(78, 17);
            this.lblSahkoposti.TabIndex = 6;
            this.lblSahkoposti.Text = "Sähköposti";
            // 
            // lblToimintaalue
            // 
            this.lblToimintaalue.AutoSize = true;
            this.lblToimintaalue.Location = new System.Drawing.Point(287, 7);
            this.lblToimintaalue.Name = "lblToimintaalue";
            this.lblToimintaalue.Size = new System.Drawing.Size(89, 17);
            this.lblToimintaalue.TabIndex = 0;
            this.lblToimintaalue.Text = "Toimintaalue";
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Location = new System.Drawing.Point(8, 7);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(73, 17);
            this.lblMokkinimi.TabIndex = 1;
            this.lblMokkinimi.Text = "Mökki nimi";
            // 
            // lblMokkiPaikkakunta
            // 
            this.lblMokkiPaikkakunta.AutoSize = true;
            this.lblMokkiPaikkakunta.Location = new System.Drawing.Point(8, 99);
            this.lblMokkiPaikkakunta.Name = "lblMokkiPaikkakunta";
            this.lblMokkiPaikkakunta.Size = new System.Drawing.Size(85, 17);
            this.lblMokkiPaikkakunta.TabIndex = 7;
            this.lblMokkiPaikkakunta.Text = "Paikkakunta";
            // 
            // lblMokkiOsoite
            // 
            this.lblMokkiOsoite.AutoSize = true;
            this.lblMokkiOsoite.Location = new System.Drawing.Point(128, 7);
            this.lblMokkiOsoite.Name = "lblMokkiOsoite";
            this.lblMokkiOsoite.Size = new System.Drawing.Size(49, 17);
            this.lblMokkiOsoite.TabIndex = 6;
            this.lblMokkiOsoite.Text = "Osoite";
            // 
            // lblMokkiPostinro
            // 
            this.lblMokkiPostinro.AutoSize = true;
            this.lblMokkiPostinro.Location = new System.Drawing.Point(8, 53);
            this.lblMokkiPostinro.Name = "lblMokkiPostinro";
            this.lblMokkiPostinro.Size = new System.Drawing.Size(87, 17);
            this.lblMokkiPostinro.TabIndex = 5;
            this.lblMokkiPostinro.Text = "Postinumero";
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(642, 7);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(41, 17);
            this.lblHinta.TabIndex = 8;
            this.lblHinta.Text = "Hinta";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(521, 60);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(55, 17);
            this.lblKuvaus.TabIndex = 9;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(287, 60);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(68, 17);
            this.lblVarustelu.TabIndex = 10;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // rtbKuvaus
            // 
            this.rtbKuvaus.Enabled = false;
            this.rtbKuvaus.Location = new System.Drawing.Point(524, 80);
            this.rtbKuvaus.Name = "rtbKuvaus";
            this.rtbKuvaus.Size = new System.Drawing.Size(238, 57);
            this.rtbKuvaus.TabIndex = 11;
            this.rtbKuvaus.Text = "";
            // 
            // rtbVarustelu
            // 
            this.rtbVarustelu.Enabled = false;
            this.rtbVarustelu.Location = new System.Drawing.Point(290, 80);
            this.rtbVarustelu.Name = "rtbVarustelu";
            this.rtbVarustelu.Size = new System.Drawing.Size(228, 57);
            this.rtbVarustelu.TabIndex = 12;
            this.rtbVarustelu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Henkilömäärä";
            // 
            // tbToimintaalue
            // 
            this.tbToimintaalue.Enabled = false;
            this.tbToimintaalue.Location = new System.Drawing.Point(290, 27);
            this.tbToimintaalue.Name = "tbToimintaalue";
            this.tbToimintaalue.Size = new System.Drawing.Size(228, 23);
            this.tbToimintaalue.TabIndex = 14;
            // 
            // tbMokkiPostinro
            // 
            this.tbMokkiPostinro.Enabled = false;
            this.tbMokkiPostinro.Location = new System.Drawing.Point(11, 73);
            this.tbMokkiPostinro.Name = "tbMokkiPostinro";
            this.tbMokkiPostinro.Size = new System.Drawing.Size(100, 23);
            this.tbMokkiPostinro.TabIndex = 15;
            // 
            // tbMokkiOsoite
            // 
            this.tbMokkiOsoite.Enabled = false;
            this.tbMokkiOsoite.Location = new System.Drawing.Point(131, 28);
            this.tbMokkiOsoite.Name = "tbMokkiOsoite";
            this.tbMokkiOsoite.Size = new System.Drawing.Size(108, 23);
            this.tbMokkiOsoite.TabIndex = 16;
            // 
            // tbHinta
            // 
            this.tbHinta.Enabled = false;
            this.tbHinta.Location = new System.Drawing.Point(645, 28);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(65, 23);
            this.tbHinta.TabIndex = 17;
            // 
            // nmrHenkilomaara
            // 
            this.nmrHenkilomaara.Enabled = false;
            this.nmrHenkilomaara.Location = new System.Drawing.Point(524, 28);
            this.nmrHenkilomaara.Name = "nmrHenkilomaara";
            this.nmrHenkilomaara.Size = new System.Drawing.Size(92, 23);
            this.nmrHenkilomaara.TabIndex = 18;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Enabled = false;
            this.tbMokkinimi.Location = new System.Drawing.Point(11, 27);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(100, 23);
            this.tbMokkinimi.TabIndex = 19;
            // 
            // tbMokkiPaikkakunta
            // 
            this.tbMokkiPaikkakunta.Enabled = false;
            this.tbMokkiPaikkakunta.Location = new System.Drawing.Point(11, 120);
            this.tbMokkiPaikkakunta.Name = "tbMokkiPaikkakunta";
            this.tbMokkiPaikkakunta.Size = new System.Drawing.Size(100, 23);
            this.tbMokkiPaikkakunta.TabIndex = 20;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Enabled = false;
            this.tbEtunimi.Location = new System.Drawing.Point(14, 37);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(100, 23);
            this.tbEtunimi.TabIndex = 7;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Enabled = false;
            this.tbSukunimi.Location = new System.Drawing.Point(184, 37);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 23);
            this.tbSukunimi.TabIndex = 8;
            // 
            // tbAsiakasosoite
            // 
            this.tbAsiakasosoite.Enabled = false;
            this.tbAsiakasosoite.Location = new System.Drawing.Point(14, 84);
            this.tbAsiakasosoite.Name = "tbAsiakasosoite";
            this.tbAsiakasosoite.Size = new System.Drawing.Size(100, 23);
            this.tbAsiakasosoite.TabIndex = 9;
            // 
            // tbAsiakaspostinro
            // 
            this.tbAsiakaspostinro.Enabled = false;
            this.tbAsiakaspostinro.Location = new System.Drawing.Point(184, 83);
            this.tbAsiakaspostinro.Name = "tbAsiakaspostinro";
            this.tbAsiakaspostinro.Size = new System.Drawing.Size(100, 23);
            this.tbAsiakaspostinro.TabIndex = 10;
            // 
            // tbAsiakasPaikkakunta
            // 
            this.tbAsiakasPaikkakunta.Enabled = false;
            this.tbAsiakasPaikkakunta.Location = new System.Drawing.Point(14, 131);
            this.tbAsiakasPaikkakunta.Name = "tbAsiakasPaikkakunta";
            this.tbAsiakasPaikkakunta.Size = new System.Drawing.Size(100, 23);
            this.tbAsiakasPaikkakunta.TabIndex = 11;
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Enabled = false;
            this.tbPuhnro.Location = new System.Drawing.Point(342, 37);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(100, 23);
            this.tbPuhnro.TabIndex = 12;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Enabled = false;
            this.tbSahkoposti.Location = new System.Drawing.Point(522, 36);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(100, 23);
            this.tbSahkoposti.TabIndex = 13;
            // 
            // Varauksentiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtpVarattupvm);
            this.Controls.Add(this.lblVarattupvm);
            this.Controls.Add(this.calVaraus);
            this.Controls.Add(this.lblVaraus);
            this.Name = "Varauksentiedot";
            this.Text = "Varauksentiedot";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHenkilomaara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.MonthCalendar calVaraus;
        private System.Windows.Forms.Label lblVarattupvm;
        private System.Windows.Forms.DateTimePicker dtpVarattupvm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSahkoposti;
        private System.Windows.Forms.Label lblPuhelinnumero;
        private System.Windows.Forms.Label lblAsiakasPaikkakunta;
        private System.Windows.Forms.Label lblAsiakasOsoite;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblAsiakasPostinumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMokkiPaikkakunta;
        private System.Windows.Forms.Label lblMokkiOsoite;
        private System.Windows.Forms.Label lblMokkiPostinro;
        private System.Windows.Forms.Label lblMokkinimi;
        private System.Windows.Forms.Label lblToimintaalue;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.TextBox tbPuhnro;
        private System.Windows.Forms.TextBox tbAsiakasPaikkakunta;
        private System.Windows.Forms.TextBox tbAsiakaspostinro;
        private System.Windows.Forms.TextBox tbAsiakasosoite;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbMokkiPaikkakunta;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.NumericUpDown nmrHenkilomaara;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbMokkiOsoite;
        private System.Windows.Forms.TextBox tbMokkiPostinro;
        private System.Windows.Forms.TextBox tbToimintaalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbVarustelu;
        private System.Windows.Forms.RichTextBox rtbKuvaus;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.Label lblHinta;
    }
}