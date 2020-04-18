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
            this.SuspendLayout();
            // 
            // btmuokkaa
            // 
            this.btmuokkaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btmuokkaa.Location = new System.Drawing.Point(12, 502);
            this.btmuokkaa.Name = "btmuokkaa";
            this.btmuokkaa.Size = new System.Drawing.Size(427, 56);
            this.btmuokkaa.TabIndex = 0;
            this.btmuokkaa.Text = "Muokkaa varausta";
            this.btmuokkaa.UseVisualStyleBackColor = true;
            // 
            // Varausmuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 568);
            this.Controls.Add(this.btmuokkaa);
            this.Name = "Varausmuokkaus";
            this.Text = "Varauksen muokkaus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmuokkaa;
    }
}