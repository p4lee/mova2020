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
            this.btnMokintiedot = new System.Windows.Forms.Button();
            this.btnAsiakkaantiedot = new System.Windows.Forms.Button();
            this.tbAsiakasnimi = new System.Windows.Forms.TextBox();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.lblMokkinimi = new System.Windows.Forms.Label();
            this.lblAsiakasnimi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVaraus.Location = new System.Drawing.Point(32, 305);
            this.lblVaraus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(62, 20);
            this.lblVaraus.TabIndex = 4;
            this.lblVaraus.Text = "Varaus";
            // 
            // calVaraus
            // 
            this.calVaraus.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.calVaraus.Enabled = false;
            this.calVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calVaraus.Location = new System.Drawing.Point(36, 332);
            this.calVaraus.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calVaraus.MaxSelectionCount = 999999;
            this.calVaraus.Name = "calVaraus";
            this.calVaraus.ShowToday = false;
            this.calVaraus.ShowTodayCircle = false;
            this.calVaraus.ShowWeekNumbers = true;
            this.calVaraus.TabIndex = 6;
            this.calVaraus.TitleBackColor = System.Drawing.Color.Yellow;
            this.calVaraus.TrailingForeColor = System.Drawing.Color.Yellow;
            // 
            // lblVarattupvm
            // 
            this.lblVarattupvm.AutoSize = true;
            this.lblVarattupvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVarattupvm.Location = new System.Drawing.Point(32, 270);
            this.lblVarattupvm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVarattupvm.Name = "lblVarattupvm";
            this.lblVarattupvm.Size = new System.Drawing.Size(156, 20);
            this.lblVarattupvm.TabIndex = 6;
            this.lblVarattupvm.Text = "Varattu Päivämäärä";
            // 
            // dtpVarattupvm
            // 
            this.dtpVarattupvm.Enabled = false;
            this.dtpVarattupvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpVarattupvm.Location = new System.Drawing.Point(249, 270);
            this.dtpVarattupvm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVarattupvm.Name = "dtpVarattupvm";
            this.dtpVarattupvm.Size = new System.Drawing.Size(317, 26);
            this.dtpVarattupvm.TabIndex = 5;
            // 
            // btnMokintiedot
            // 
            this.btnMokintiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMokintiedot.Location = new System.Drawing.Point(265, 89);
            this.btnMokintiedot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMokintiedot.Name = "btnMokintiedot";
            this.btnMokintiedot.Size = new System.Drawing.Size(188, 39);
            this.btnMokintiedot.TabIndex = 4;
            this.btnMokintiedot.Text = "Mökin tiedot";
            this.btnMokintiedot.UseVisualStyleBackColor = true;
            this.btnMokintiedot.Click += new System.EventHandler(this.btnMokintiedot_Click);
            // 
            // btnAsiakkaantiedot
            // 
            this.btnAsiakkaantiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAsiakkaantiedot.Location = new System.Drawing.Point(265, 23);
            this.btnAsiakkaantiedot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsiakkaantiedot.Name = "btnAsiakkaantiedot";
            this.btnAsiakkaantiedot.Size = new System.Drawing.Size(188, 39);
            this.btnAsiakkaantiedot.TabIndex = 2;
            this.btnAsiakkaantiedot.Text = "Asiakkaan tiedot";
            this.btnAsiakkaantiedot.UseVisualStyleBackColor = true;
            this.btnAsiakkaantiedot.Click += new System.EventHandler(this.btnAsiakkaantiedot_Click);
            // 
            // tbAsiakasnimi
            // 
            this.tbAsiakasnimi.Enabled = false;
            this.tbAsiakasnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAsiakasnimi.Location = new System.Drawing.Point(16, 31);
            this.tbAsiakasnimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAsiakasnimi.Name = "tbAsiakasnimi";
            this.tbAsiakasnimi.Size = new System.Drawing.Size(179, 26);
            this.tbAsiakasnimi.TabIndex = 1;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Enabled = false;
            this.tbMokkinimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokkinimi.Location = new System.Drawing.Point(16, 96);
            this.tbMokkinimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(179, 26);
            this.tbMokkinimi.TabIndex = 3;
            // 
            // lblMokkinimi
            // 
            this.lblMokkinimi.AutoSize = true;
            this.lblMokkinimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkinimi.Location = new System.Drawing.Point(16, 76);
            this.lblMokkinimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMokkinimi.Name = "lblMokkinimi";
            this.lblMokkinimi.Size = new System.Drawing.Size(89, 20);
            this.lblMokkinimi.TabIndex = 12;
            this.lblMokkinimi.Text = "Mökin nimi";
            // 
            // lblAsiakasnimi
            // 
            this.lblAsiakasnimi.AutoSize = true;
            this.lblAsiakasnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakasnimi.Location = new System.Drawing.Point(16, 11);
            this.lblAsiakasnimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsiakasnimi.Name = "lblAsiakasnimi";
            this.lblAsiakasnimi.Size = new System.Drawing.Size(121, 20);
            this.lblAsiakasnimi.TabIndex = 13;
            this.lblAsiakasnimi.Text = "Asiakkaan nimi";
            // 
            // Varauksentiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblAsiakasnimi);
            this.Controls.Add(this.lblMokkinimi);
            this.Controls.Add(this.tbMokkinimi);
            this.Controls.Add(this.tbAsiakasnimi);
            this.Controls.Add(this.btnAsiakkaantiedot);
            this.Controls.Add(this.btnMokintiedot);
            this.Controls.Add(this.dtpVarattupvm);
            this.Controls.Add(this.lblVarattupvm);
            this.Controls.Add(this.calVaraus);
            this.Controls.Add(this.lblVaraus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Varauksentiedot";
            this.Text = "Varauksentiedot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.MonthCalendar calVaraus;
        private System.Windows.Forms.Label lblVarattupvm;
        private System.Windows.Forms.DateTimePicker dtpVarattupvm;
        private System.Windows.Forms.Button btnMokintiedot;
        private System.Windows.Forms.Button btnAsiakkaantiedot;
        private System.Windows.Forms.TextBox tbAsiakasnimi;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.Label lblMokkinimi;
        private System.Windows.Forms.Label lblAsiakasnimi;
    }
}