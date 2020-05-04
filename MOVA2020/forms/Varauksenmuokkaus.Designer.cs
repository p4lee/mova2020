namespace MOVA2020.forms
{
    partial class Varauksenmuokkaus
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
            this.btvaraus = new System.Windows.Forms.Button();
            this.lblmokki = new System.Windows.Forms.Label();
            this.CBMokki = new System.Windows.Forms.ComboBox();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.lbVarauksenPalvelut = new System.Windows.Forms.ListBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.cbPalvelut = new System.Windows.Forms.ComboBox();
            this.nmrLukumaara = new System.Windows.Forms.NumericUpDown();
            this.lblLukumäärä = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbToimintaalueet = new System.Windows.Forms.ComboBox();
            this.lblToimintaalue = new System.Windows.Forms.Label();
            this.calVaraus = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLukumaara)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Location = new System.Drawing.Point(13, 222);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(91, 17);
            this.lblVaraus.TabIndex = 3;
            this.lblVaraus.Text = "Varaus alkaa";
            // 
            // btvaraus
            // 
            this.btvaraus.AutoSize = true;
            this.btvaraus.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btvaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btvaraus.Location = new System.Drawing.Point(7, 451);
            this.btvaraus.Name = "btvaraus";
            this.btvaraus.Size = new System.Drawing.Size(939, 41);
            this.btvaraus.TabIndex = 4;
            this.btvaraus.Text = "Tee varaus";
            this.btvaraus.UseVisualStyleBackColor = true;
            this.btvaraus.Click += new System.EventHandler(this.btvaraus_Click);
            // 
            // lblmokki
            // 
            this.lblmokki.AutoSize = true;
            this.lblmokki.Location = new System.Drawing.Point(241, 9);
            this.lblmokki.Name = "lblmokki";
            this.lblmokki.Size = new System.Drawing.Size(44, 17);
            this.lblmokki.TabIndex = 5;
            this.lblmokki.Text = "Mökki";
            // 
            // CBMokki
            // 
            this.CBMokki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMokki.FormattingEnabled = true;
            this.CBMokki.Location = new System.Drawing.Point(244, 29);
            this.CBMokki.Name = "CBMokki";
            this.CBMokki.Size = new System.Drawing.Size(230, 24);
            this.CBMokki.Sorted = true;
            this.CBMokki.TabIndex = 6;
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.Location = new System.Drawing.Point(552, 9);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(58, 17);
            this.lblPalvelut.TabIndex = 9;
            this.lblPalvelut.Text = "Palvelut";
            // 
            // lbVarauksenPalvelut
            // 
            this.lbVarauksenPalvelut.FormattingEnabled = true;
            this.lbVarauksenPalvelut.ItemHeight = 16;
            this.lbVarauksenPalvelut.Location = new System.Drawing.Point(478, 29);
            this.lbVarauksenPalvelut.Name = "lbVarauksenPalvelut";
            this.lbVarauksenPalvelut.Size = new System.Drawing.Size(468, 372);
            this.lbVarauksenPalvelut.TabIndex = 14;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaa.Location = new System.Drawing.Point(244, 114);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(106, 70);
            this.btnLisaa.TabIndex = 15;
            this.btnLisaa.Text = "+";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoista.Location = new System.Drawing.Point(356, 114);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(110, 70);
            this.btnPoista.TabIndex = 16;
            this.btnPoista.Text = "-";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // cbPalvelut
            // 
            this.cbPalvelut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalvelut.FormattingEnabled = true;
            this.cbPalvelut.Location = new System.Drawing.Point(7, 162);
            this.cbPalvelut.Name = "cbPalvelut";
            this.cbPalvelut.Size = new System.Drawing.Size(230, 24);
            this.cbPalvelut.TabIndex = 17;
            // 
            // nmrLukumaara
            // 
            this.nmrLukumaara.Location = new System.Drawing.Point(7, 116);
            this.nmrLukumaara.Name = "nmrLukumaara";
            this.nmrLukumaara.Size = new System.Drawing.Size(230, 23);
            this.nmrLukumaara.TabIndex = 18;
            // 
            // lblLukumäärä
            // 
            this.lblLukumäärä.AutoSize = true;
            this.lblLukumäärä.Location = new System.Drawing.Point(4, 96);
            this.lblLukumäärä.Name = "lblLukumäärä";
            this.lblLukumäärä.Size = new System.Drawing.Size(79, 17);
            this.lblLukumäärä.TabIndex = 19;
            this.lblLukumäärä.Text = "Lukumäärä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Palvelu";
            // 
            // cbToimintaalueet
            // 
            this.cbToimintaalueet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToimintaalueet.FormattingEnabled = true;
            this.cbToimintaalueet.Location = new System.Drawing.Point(8, 29);
            this.cbToimintaalueet.Name = "cbToimintaalueet";
            this.cbToimintaalueet.Size = new System.Drawing.Size(229, 24);
            this.cbToimintaalueet.TabIndex = 21;
            this.cbToimintaalueet.SelectedIndexChanged += new System.EventHandler(this.cbToimintaalueet_SelectedIndexChanged);
            // 
            // lblToimintaalue
            // 
            this.lblToimintaalue.AutoSize = true;
            this.lblToimintaalue.Location = new System.Drawing.Point(5, 9);
            this.lblToimintaalue.Name = "lblToimintaalue";
            this.lblToimintaalue.Size = new System.Drawing.Size(94, 17);
            this.lblToimintaalue.TabIndex = 22;
            this.lblToimintaalue.Text = "Toiminta-alue";
            // 
            // calVaraus
            // 
            this.calVaraus.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calVaraus.Location = new System.Drawing.Point(8, 243);
            this.calVaraus.MaxSelectionCount = 365;
            this.calVaraus.MinDate = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.calVaraus.Name = "calVaraus";
            this.calVaraus.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(244, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "Mökin tiedot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMokintiedot_Click);
            // 
            // Varauksenmuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calVaraus);
            this.Controls.Add(this.lblToimintaalue);
            this.Controls.Add(this.cbToimintaalueet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLukumäärä);
            this.Controls.Add(this.nmrLukumaara);
            this.Controls.Add(this.cbPalvelut);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.lbVarauksenPalvelut);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.CBMokki);
            this.Controls.Add(this.lblmokki);
            this.Controls.Add(this.btvaraus);
            this.Controls.Add(this.lblVaraus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(974, 543);
            this.Name = "Varauksenmuokkaus";
            this.Text = "Varauksen lisäys";
            ((System.ComponentModel.ISupportInitialize)(this.nmrLukumaara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.Button btvaraus;
        private System.Windows.Forms.Label lblmokki;
        private System.Windows.Forms.ComboBox CBMokki;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.ListBox lbVarauksenPalvelut;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.ComboBox cbPalvelut;
        private System.Windows.Forms.NumericUpDown nmrLukumaara;
        private System.Windows.Forms.Label lblLukumäärä;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbToimintaalueet;
        private System.Windows.Forms.Label lblToimintaalue;
        private System.Windows.Forms.MonthCalendar calVaraus;
        private System.Windows.Forms.Button button1;
    }
}