namespace MOVA2020.forms
{
    partial class Varausmuokkaus
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
            this.btmuokkaa = new System.Windows.Forms.Button();
            this.lblvaraus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblmokki = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CLBPalvelut = new System.Windows.Forms.CheckedListBox();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmuokkaa
            // 
            this.btmuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btmuokkaa.Location = new System.Drawing.Point(5, 487);
            this.btmuokkaa.Margin = new System.Windows.Forms.Padding(4);
            this.btmuokkaa.Name = "btmuokkaa";
            this.btmuokkaa.Size = new System.Drawing.Size(444, 70);
            this.btmuokkaa.TabIndex = 0;
            this.btmuokkaa.Text = "Muokkaa varausta";
            this.btmuokkaa.UseVisualStyleBackColor = true;
            // 
            // lblvaraus
            // 
            this.lblvaraus.AutoSize = true;
            this.lblvaraus.Location = new System.Drawing.Point(12, 32);
            this.lblvaraus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvaraus.Name = "lblvaraus";
            this.lblvaraus.Size = new System.Drawing.Size(62, 20);
            this.lblvaraus.TabIndex = 1;
            this.lblvaraus.Text = "Varaus";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(5, 267);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // lblmokki
            // 
            this.lblmokki.AutoSize = true;
            this.lblmokki.Location = new System.Drawing.Point(12, 80);
            this.lblmokki.Name = "lblmokki";
            this.lblmokki.Size = new System.Drawing.Size(52, 20);
            this.lblmokki.TabIndex = 4;
            this.lblmokki.Text = "Mökki";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(345, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // CLBPalvelut
            // 
            this.CLBPalvelut.FormattingEnabled = true;
            this.CLBPalvelut.Location = new System.Drawing.Point(86, 130);
            this.CLBPalvelut.Name = "CLBPalvelut";
            this.CLBPalvelut.Size = new System.Drawing.Size(345, 109);
            this.CLBPalvelut.Sorted = true;
            this.CLBPalvelut.TabIndex = 12;
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.Location = new System.Drawing.Point(12, 172);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(68, 20);
            this.lblPalvelut.TabIndex = 11;
            this.lblPalvelut.Text = "Palvelut";
            // 
            // Varausmuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 570);
            this.Controls.Add(this.CLBPalvelut);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblmokki);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblvaraus);
            this.Controls.Add(this.btmuokkaa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Varausmuokkaus";
            this.Text = "Varauksen muokkaus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmuokkaa;
        private System.Windows.Forms.Label lblvaraus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblmokki;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckedListBox CLBPalvelut;
        private System.Windows.Forms.Label lblPalvelut;
    }
}