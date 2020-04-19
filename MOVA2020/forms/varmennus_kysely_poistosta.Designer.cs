namespace MOVA2020.forms
{
    partial class varmennus_kysely_poistosta
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
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnKylla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPeruuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeruuta.Location = new System.Drawing.Point(12, 127);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(103, 30);
            this.btnPeruuta.TabIndex = 2;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnKylla
            // 
            this.btnKylla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKylla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKylla.Location = new System.Drawing.Point(217, 127);
            this.btnKylla.Name = "btnKylla";
            this.btnKylla.Size = new System.Drawing.Size(103, 30);
            this.btnKylla.TabIndex = 3;
            this.btnKylla.Text = "Kyllä";
            this.btnKylla.UseVisualStyleBackColor = true;
            this.btnKylla.Click += new System.EventHandler(this.btnKylla_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(46, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 53);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Oletko varma, että haluat poistaa kohteen?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varmennus_kysely_poistosta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 169);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKylla);
            this.Controls.Add(this.btnPeruuta);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 216);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 216);
            this.Name = "varmennus_kysely_poistosta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poista kohde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnKylla;
        private System.Windows.Forms.TextBox textBox1;
    }
}