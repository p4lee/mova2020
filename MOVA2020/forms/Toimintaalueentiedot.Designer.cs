namespace MOVA2020.forms
{
    partial class Toimintaalueentiedot
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
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.lblMokit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.lblNimi = new System.Windows.Forms.Label();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.btnMuokkaaPalvelu = new System.Windows.Forms.Button();
            this.btnLisaaPalvelu = new System.Windows.Forms.Button();
            this.btnVaihdanimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMokit
            // 
            this.dgvMokit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(220, 34);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.ReadOnly = true;
            this.dgvMokit.RowHeadersVisible = false;
            this.dgvMokit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMokit.Size = new System.Drawing.Size(568, 196);
            this.dgvMokit.TabIndex = 0;
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(220, 253);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.ReadOnly = true;
            this.dgvPalvelut.RowHeadersVisible = false;
            this.dgvPalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalvelut.Size = new System.Drawing.Size(568, 185);
            this.dgvPalvelut.TabIndex = 1;
            this.dgvPalvelut.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPalvelut_ColumnHeaderMouseClick);
            this.dgvPalvelut.Click += new System.EventHandler(this.dgvPalvelut_Click);
            // 
            // lblMokit
            // 
            this.lblMokit.AutoSize = true;
            this.lblMokit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMokit.Location = new System.Drawing.Point(217, 14);
            this.lblMokit.Name = "lblMokit";
            this.lblMokit.Size = new System.Drawing.Size(41, 17);
            this.lblMokit.TabIndex = 2;
            this.lblMokit.Text = "Mökit";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(217, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Palvelut";
            // 
            // tbNimi
            // 
            this.tbNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNimi.Location = new System.Drawing.Point(12, 28);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(152, 23);
            this.tbNimi.TabIndex = 4;
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNimi.Location = new System.Drawing.Point(9, 9);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(139, 17);
            this.lblNimi.TabIndex = 5;
            this.lblNimi.Text = "Toiminta-alueen nimi";
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(11, 408);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(152, 30);
            this.btnPoistaPalvelu.TabIndex = 6;
            this.btnPoistaPalvelu.Text = "Poista palvelu";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.btnPoistaPalvelu_Click);
            // 
            // btnMuokkaaPalvelu
            // 
            this.btnMuokkaaPalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMuokkaaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMuokkaaPalvelu.Location = new System.Drawing.Point(11, 372);
            this.btnMuokkaaPalvelu.Name = "btnMuokkaaPalvelu";
            this.btnMuokkaaPalvelu.Size = new System.Drawing.Size(152, 30);
            this.btnMuokkaaPalvelu.TabIndex = 7;
            this.btnMuokkaaPalvelu.Text = "Muokkaa palvelua";
            this.btnMuokkaaPalvelu.UseVisualStyleBackColor = true;
            this.btnMuokkaaPalvelu.Click += new System.EventHandler(this.btnMuokkaaPalvelu_Click);
            // 
            // btnLisaaPalvelu
            // 
            this.btnLisaaPalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaaPalvelu.Location = new System.Drawing.Point(12, 336);
            this.btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            this.btnLisaaPalvelu.Size = new System.Drawing.Size(152, 30);
            this.btnLisaaPalvelu.TabIndex = 8;
            this.btnLisaaPalvelu.Text = "Lisää palvelu";
            this.btnLisaaPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaPalvelu.Click += new System.EventHandler(this.btnLisaaPalvelu_Click);
            // 
            // btnVaihdanimi
            // 
            this.btnVaihdanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVaihdanimi.Location = new System.Drawing.Point(12, 55);
            this.btnVaihdanimi.Name = "btnVaihdanimi";
            this.btnVaihdanimi.Size = new System.Drawing.Size(152, 31);
            this.btnVaihdanimi.TabIndex = 9;
            this.btnVaihdanimi.Text = "Vaihda nimi";
            this.btnVaihdanimi.UseVisualStyleBackColor = true;
            this.btnVaihdanimi.Click += new System.EventHandler(this.btnVaihdanimi_Click);
            // 
            // Toimintaalueentiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVaihdanimi);
            this.Controls.Add(this.btnLisaaPalvelu);
            this.Controls.Add(this.btnMuokkaaPalvelu);
            this.Controls.Add(this.btnPoistaPalvelu);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMokit);
            this.Controls.Add(this.dgvPalvelut);
            this.Controls.Add(this.dgvMokit);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Toimintaalueentiedot";
            this.Text = "Toimintaalueentiedot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.Label lblMokit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.Button btnMuokkaaPalvelu;
        private System.Windows.Forms.Button btnLisaaPalvelu;
        private System.Windows.Forms.Button btnVaihdanimi;
    }
}