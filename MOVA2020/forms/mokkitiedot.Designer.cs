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
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.lblVaraukset = new System.Windows.Forms.Label();
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblPaikkakunta = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbPaikkakunta = new System.Windows.Forms.TextBox();
            this.lblHinta = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.nmrHenkilomaara = new System.Windows.Forms.NumericUpDown();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.rtbVarustelu = new System.Windows.Forms.RichTextBox();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.rtbKuvaus = new System.Windows.Forms.RichTextBox();
            this.lblToimintaalue = new System.Windows.Forms.Label();
            this.tbToimintaalue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHenkilomaara)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(351, 30);
            this.dgvVaraukset.MultiSelect = false;
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.RowHeadersVisible = false;
            this.dgvVaraukset.Size = new System.Drawing.Size(437, 408);
            this.dgvVaraukset.TabIndex = 2;
            // 
            // lblVaraukset
            // 
            this.lblVaraukset.AutoSize = true;
            this.lblVaraukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVaraukset.Location = new System.Drawing.Point(348, 9);
            this.lblVaraukset.Name = "lblVaraukset";
            this.lblVaraukset.Size = new System.Drawing.Size(72, 17);
            this.lblVaraukset.TabIndex = 3;
            this.lblVaraukset.Text = "Varaukset";
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNimi.Location = new System.Drawing.Point(9, 9);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(74, 17);
            this.lblNimi.TabIndex = 4;
            this.lblNimi.Text = "Mökin nimi";
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOsoite.Location = new System.Drawing.Point(9, 102);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(75, 17);
            this.lblOsoite.TabIndex = 5;
            this.lblOsoite.Text = "Katuosoite";
            // 
            // lblPaikkakunta
            // 
            this.lblPaikkakunta.AutoSize = true;
            this.lblPaikkakunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaikkakunta.Location = new System.Drawing.Point(9, 149);
            this.lblPaikkakunta.Name = "lblPaikkakunta";
            this.lblPaikkakunta.Size = new System.Drawing.Size(85, 17);
            this.lblPaikkakunta.TabIndex = 6;
            this.lblPaikkakunta.Text = "Paikkakunta";
            // 
            // tbNimi
            // 
            this.tbNimi.Enabled = false;
            this.tbNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNimi.Location = new System.Drawing.Point(12, 30);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(144, 23);
            this.tbNimi.TabIndex = 7;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Enabled = false;
            this.tbKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbKatuosoite.Location = new System.Drawing.Point(12, 126);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(144, 23);
            this.tbKatuosoite.TabIndex = 8;
            // 
            // tbPaikkakunta
            // 
            this.tbPaikkakunta.Enabled = false;
            this.tbPaikkakunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPaikkakunta.Location = new System.Drawing.Point(12, 170);
            this.tbPaikkakunta.Name = "tbPaikkakunta";
            this.tbPaikkakunta.Size = new System.Drawing.Size(144, 23);
            this.tbPaikkakunta.TabIndex = 9;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHinta.Location = new System.Drawing.Point(192, 9);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(79, 17);
            this.lblHinta.TabIndex = 10;
            this.lblHinta.Text = "Hinta/päivä";
            // 
            // tbHinta
            // 
            this.tbHinta.Enabled = false;
            this.tbHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbHinta.Location = new System.Drawing.Point(195, 29);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 23);
            this.tbHinta.TabIndex = 11;
            // 
            // nmrHenkilomaara
            // 
            this.nmrHenkilomaara.Enabled = false;
            this.nmrHenkilomaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nmrHenkilomaara.Location = new System.Drawing.Point(12, 76);
            this.nmrHenkilomaara.Name = "nmrHenkilomaara";
            this.nmrHenkilomaara.Size = new System.Drawing.Size(144, 23);
            this.nmrHenkilomaara.TabIndex = 12;
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHenkilomaara.Location = new System.Drawing.Point(9, 56);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(95, 17);
            this.lblHenkilomaara.TabIndex = 13;
            this.lblHenkilomaara.Text = "Henkilömäärä";
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Enabled = false;
            this.tbPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPostinumero.Location = new System.Drawing.Point(195, 126);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(100, 23);
            this.tbPostinumero.TabIndex = 14;
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPostinumero.Location = new System.Drawing.Point(195, 102);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(87, 17);
            this.lblPostinumero.TabIndex = 15;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVarustelu.Location = new System.Drawing.Point(9, 196);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(68, 17);
            this.lblVarustelu.TabIndex = 16;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // rtbVarustelu
            // 
            this.rtbVarustelu.Enabled = false;
            this.rtbVarustelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbVarustelu.Location = new System.Drawing.Point(12, 217);
            this.rtbVarustelu.Name = "rtbVarustelu";
            this.rtbVarustelu.Size = new System.Drawing.Size(272, 58);
            this.rtbVarustelu.TabIndex = 17;
            this.rtbVarustelu.Text = "";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKuvaus.Location = new System.Drawing.Point(12, 288);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(55, 17);
            this.lblKuvaus.TabIndex = 18;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // rtbKuvaus
            // 
            this.rtbKuvaus.Enabled = false;
            this.rtbKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbKuvaus.Location = new System.Drawing.Point(12, 305);
            this.rtbKuvaus.Name = "rtbKuvaus";
            this.rtbKuvaus.Size = new System.Drawing.Size(272, 133);
            this.rtbKuvaus.TabIndex = 19;
            this.rtbKuvaus.Text = "";
            // 
            // lblToimintaalue
            // 
            this.lblToimintaalue.AutoSize = true;
            this.lblToimintaalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblToimintaalue.Location = new System.Drawing.Point(192, 56);
            this.lblToimintaalue.Name = "lblToimintaalue";
            this.lblToimintaalue.Size = new System.Drawing.Size(94, 17);
            this.lblToimintaalue.TabIndex = 20;
            this.lblToimintaalue.Text = "Toiminta-alue";
            // 
            // tbToimintaalue
            // 
            this.tbToimintaalue.Enabled = false;
            this.tbToimintaalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbToimintaalue.Location = new System.Drawing.Point(195, 76);
            this.tbToimintaalue.Name = "tbToimintaalue";
            this.tbToimintaalue.Size = new System.Drawing.Size(100, 23);
            this.tbToimintaalue.TabIndex = 21;
            // 
            // mokkitiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbToimintaalue);
            this.Controls.Add(this.lblToimintaalue);
            this.Controls.Add(this.rtbKuvaus);
            this.Controls.Add(this.lblKuvaus);
            this.Controls.Add(this.rtbVarustelu);
            this.Controls.Add(this.lblVarustelu);
            this.Controls.Add(this.lblPostinumero);
            this.Controls.Add(this.tbPostinumero);
            this.Controls.Add(this.lblHenkilomaara);
            this.Controls.Add(this.nmrHenkilomaara);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.lblHinta);
            this.Controls.Add(this.tbPaikkakunta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.lblPaikkakunta);
            this.Controls.Add(this.lblOsoite);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.lblVaraukset);
            this.Controls.Add(this.dgvVaraukset);
            this.Name = "mokkitiedot";
            this.Text = "Mökin tiedot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHenkilomaara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Label lblVaraukset;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblPaikkakunta;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbPaikkakunta;
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.NumericUpDown nmrHenkilomaara;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.RichTextBox rtbVarustelu;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.RichTextBox rtbKuvaus;
        private System.Windows.Forms.Label lblToimintaalue;
        private System.Windows.Forms.TextBox tbToimintaalue;
    }
}