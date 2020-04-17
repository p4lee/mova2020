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
            this.SuspendLayout();
            // 
            // DTPvarauspv
            // 
            this.DTPvarauspv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPvarauspv.Location = new System.Drawing.Point(133, 299);
            this.DTPvarauspv.Name = "DTPvarauspv";
            this.DTPvarauspv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTPvarauspv.Size = new System.Drawing.Size(135, 26);
            this.DTPvarauspv.TabIndex = 0;
            // 
            // lblvarauspv
            // 
            this.lblvarauspv.AutoSize = true;
            this.lblvarauspv.Location = new System.Drawing.Point(12, 299);
            this.lblvarauspv.Name = "lblvarauspv";
            this.lblvarauspv.Size = new System.Drawing.Size(101, 20);
            this.lblvarauspv.TabIndex = 1;
            this.lblvarauspv.Text = "Varauspäivä";
            // 
            // MCVaraus
            // 
            this.MCVaraus.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.MCVaraus.Location = new System.Drawing.Point(12, 377);
            this.MCVaraus.MaxSelectionCount = 30;
            this.MCVaraus.Name = "MCVaraus";
            this.MCVaraus.ShowWeekNumbers = true;
            this.MCVaraus.TabIndex = 2;
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Location = new System.Drawing.Point(182, 348);
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
            this.btvaraus.Location = new System.Drawing.Point(12, 614);
            this.btvaraus.Name = "btvaraus";
            this.btvaraus.Size = new System.Drawing.Size(444, 41);
            this.btvaraus.TabIndex = 4;
            this.btvaraus.Text = "Tee varaus";
            this.btvaraus.UseVisualStyleBackColor = true;
            // 
            // lblmokki
            // 
            this.lblmokki.AutoSize = true;
            this.lblmokki.Location = new System.Drawing.Point(13, 17);
            this.lblmokki.Name = "lblmokki";
            this.lblmokki.Size = new System.Drawing.Size(52, 20);
            this.lblmokki.TabIndex = 5;
            this.lblmokki.Text = "Mökki";
            // 
            // CBMokki
            // 
            this.CBMokki.FormattingEnabled = true;
            this.CBMokki.Location = new System.Drawing.Point(71, 14);
            this.CBMokki.Name = "CBMokki";
            this.CBMokki.Size = new System.Drawing.Size(323, 28);
            this.CBMokki.Sorted = true;
            this.CBMokki.TabIndex = 6;
            // 
            // Varauksenlisays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 667);
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
    }
}