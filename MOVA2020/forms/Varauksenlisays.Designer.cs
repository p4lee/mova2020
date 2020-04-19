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
            this.MCVaraus = new System.Windows.Forms.MonthCalendar();
            this.lblVaraus = new System.Windows.Forms.Label();
            this.btvaraus = new System.Windows.Forms.Button();
            this.lblmokki = new System.Windows.Forms.Label();
            this.CBMokki = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBAsiakas = new System.Windows.Forms.ComboBox();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // DTPvarauspv
            // 
            this.DTPvarauspv.Enabled = false;
            this.DTPvarauspv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPvarauspv.Location = new System.Drawing.Point(133, 245);
            this.DTPvarauspv.Name = "DTPvarauspv";
            this.DTPvarauspv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTPvarauspv.Size = new System.Drawing.Size(135, 26);
            this.DTPvarauspv.TabIndex = 0;
            // 
            // lblvarauspv
            // 
            this.lblvarauspv.AutoSize = true;
            this.lblvarauspv.Location = new System.Drawing.Point(12, 248);
            this.lblvarauspv.Name = "lblvarauspv";
            this.lblvarauspv.Size = new System.Drawing.Size(101, 20);
            this.lblvarauspv.TabIndex = 1;
            this.lblvarauspv.Text = "Varauspäivä";
            // 
            // MCVaraus
            // 
            this.MCVaraus.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.MCVaraus.Location = new System.Drawing.Point(11, 343);
            this.MCVaraus.MaxSelectionCount = 30;
            this.MCVaraus.Name = "MCVaraus";
            this.MCVaraus.ShowWeekNumbers = true;
            this.MCVaraus.TabIndex = 2;
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Location = new System.Drawing.Point(176, 300);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(125, 20);
            this.lblVaraus.TabIndex = 3;
            this.lblVaraus.Text = "Varauskalenteri";
            // 
            // btvaraus
            // 
            this.btvaraus.AutoSize = true;
            this.btvaraus.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btvaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btvaraus.Location = new System.Drawing.Point(16, 562);
            this.btvaraus.Name = "btvaraus";
            this.btvaraus.Size = new System.Drawing.Size(444, 41);
            this.btvaraus.TabIndex = 4;
            this.btvaraus.Text = "Tee varaus";
            this.btvaraus.UseVisualStyleBackColor = true;
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
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(133, 119);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(323, 109);
            this.checkedListBox1.TabIndex = 10;
            // 
            // Varauksenlisays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 615);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.CBAsiakas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBMokki);
            this.Controls.Add(this.lblmokki);
            this.Controls.Add(this.btvaraus);
            this.Controls.Add(this.lblVaraus);
            this.Controls.Add(this.MCVaraus);
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
        private System.Windows.Forms.MonthCalendar MCVaraus;
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.Button btvaraus;
        private System.Windows.Forms.Label lblmokki;
        private System.Windows.Forms.ComboBox CBMokki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBAsiakas;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}