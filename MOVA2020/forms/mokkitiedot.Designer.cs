namespace MOVA2020.forms
{
    partial class mokkitiedot
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
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.lblVaraukset = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(548, 25);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.Size = new System.Drawing.Size(240, 413);
            this.dgvPalvelut.TabIndex = 0;
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.Location = new System.Drawing.Point(545, 9);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(45, 13);
            this.lblPalvelut.TabIndex = 1;
            this.lblPalvelut.Text = "Palvelut";
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(302, 25);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(240, 413);
            this.dgvVaraukset.TabIndex = 2;
            // 
            // lblVaraukset
            // 
            this.lblVaraukset.AutoSize = true;
            this.lblVaraukset.Location = new System.Drawing.Point(299, 9);
            this.lblVaraukset.Name = "lblVaraukset";
            this.lblVaraukset.Size = new System.Drawing.Size(55, 13);
            this.lblVaraukset.TabIndex = 3;
            this.lblVaraukset.Text = "Varaukset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // mokkitiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVaraukset);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.dgvPalvelut);
            this.Name = "mokkitiedot";
            this.Text = "mokintiedot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Label lblVaraukset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}