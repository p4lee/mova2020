namespace MOVA2020.forms
{
    partial class Varauksenlisays
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
            this.DTPvarauspv = new System.Windows.Forms.DateTimePicker();
            this.lblvarauspv = new System.Windows.Forms.Label();
            this.lblVaraus = new System.Windows.Forms.Label();
            this.btvaraus = new System.Windows.Forms.Button();
            this.lblmokki = new System.Windows.Forms.Label();
            this.CBMokki = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBAsiakas = new System.Windows.Forms.ComboBox();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.CLBpalvelut = new System.Windows.Forms.CheckedListBox();
            this.DTPVarausalku = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPVarausloppu = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DTPvarauspv
            // 
            this.DTPvarauspv.Enabled = false;
            this.DTPvarauspv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPvarauspv.Location = new System.Drawing.Point(133, 245);
            this.DTPvarauspv.Name = "DTPvarauspv";
            this.DTPvarauspv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTPvarauspv.Size = new System.Drawing.Size(112, 26);
            this.DTPvarauspv.TabIndex = 0;
            // 
            // lblvarauspv
            // 
            this.lblvarauspv.AutoSize = true;
            this.lblvarauspv.Location = new System.Drawing.Point(12, 251);
            this.lblvarauspv.Name = "lblvarauspv";
            this.lblvarauspv.Size = new System.Drawing.Size(101, 20);
            this.lblvarauspv.TabIndex = 1;
            this.lblvarauspv.Text = "Varauspäivä";
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Location = new System.Drawing.Point(12, 297);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(106, 20);
            this.lblVaraus.TabIndex = 3;
            this.lblVaraus.Text = "Varaus alkaa";
            // 
            // btvaraus
            // 
            this.btvaraus.AutoSize = true;
            this.btvaraus.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btvaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btvaraus.Location = new System.Drawing.Point(16, 390);
            this.btvaraus.Name = "btvaraus";
            this.btvaraus.Size = new System.Drawing.Size(444, 41);
            this.btvaraus.TabIndex = 4;
            this.btvaraus.Text = "Tee varaus";
            this.btvaraus.UseVisualStyleBackColor = true;
            this.btvaraus.Click += new System.EventHandler(this.btvaraus_Click);
            // 
            // lblmokki
            // 
            this.lblmokki.AutoSize = true;
            this.lblmokki.Location = new System.Drawing.Point(12, 74);
            this.lblmokki.Name = "lblmokki";
            this.lblmokki.Size = new System.Drawing.Size(52, 20);
            this.lblmokki.TabIndex = 5;
            this.lblmokki.Text = "Mökki";
            // 
            // CBMokki
            // 
            this.CBMokki.FormattingEnabled = true;
            this.CBMokki.Location = new System.Drawing.Point(133, 71);
            this.CBMokki.Name = "CBMokki";
            this.CBMokki.Size = new System.Drawing.Size(323, 28);
            this.CBMokki.Sorted = true;
            this.CBMokki.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Asiakas";
            // 
            // CBAsiakas
            // 
            this.CBAsiakas.FormattingEnabled = true;
            this.CBAsiakas.Location = new System.Drawing.Point(133, 24);
            this.CBAsiakas.Name = "CBAsiakas";
            this.CBAsiakas.Size = new System.Drawing.Size(323, 28);
            this.CBAsiakas.TabIndex = 8;
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.Location = new System.Drawing.Point(16, 163);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(68, 20);
            this.lblPalvelut.TabIndex = 9;
            this.lblPalvelut.Text = "Palvelut";
            // 
            // CLBpalvelut
            // 
            this.CLBpalvelut.FormattingEnabled = true;
            this.CLBpalvelut.Location = new System.Drawing.Point(133, 119);
            this.CLBpalvelut.Name = "CLBpalvelut";
            this.CLBpalvelut.Size = new System.Drawing.Size(323, 109);
            this.CLBpalvelut.TabIndex = 10;
            // 
            // DTPVarausalku
            // 
            this.DTPVarausalku.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVarausalku.Location = new System.Drawing.Point(133, 291);
            this.DTPVarausalku.Name = "DTPVarausalku";
            this.DTPVarausalku.Size = new System.Drawing.Size(112, 26);
            this.DTPVarausalku.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Varaus loppuu";
            // 
            // DTPVarausloppu
            // 
            this.DTPVarausloppu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVarausloppu.Location = new System.Drawing.Point(134, 337);
            this.DTPVarausloppu.Name = "DTPVarausloppu";
            this.DTPVarausloppu.Size = new System.Drawing.Size(112, 26);
            this.DTPVarausloppu.TabIndex = 13;
            // 
            // Varauksenlisays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 453);
            this.Controls.Add(this.DTPVarausloppu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPVarausalku);
            this.Controls.Add(this.CLBpalvelut);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.CBAsiakas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBMokki);
            this.Controls.Add(this.lblmokki);
            this.Controls.Add(this.btvaraus);
            this.Controls.Add(this.lblVaraus);
            this.Controls.Add(this.lblvarauspv);
            this.Controls.Add(this.DTPvarauspv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Varauksenlisays";
            this.Text = "Varauksen lisäys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPvarauspv;
        private System.Windows.Forms.Label lblvarauspv;
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.Button btvaraus;
        private System.Windows.Forms.Label lblmokki;
        private System.Windows.Forms.ComboBox CBMokki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBAsiakas;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.CheckedListBox CLBpalvelut;
        private System.Windows.Forms.DateTimePicker DTPVarausalku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPVarausloppu;
    }
}