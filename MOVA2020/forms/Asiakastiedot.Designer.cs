namespace MOVA2020.forms
{
    partial class Asiakastiedot
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
            this.btnLisaaVaraus = new System.Windows.Forms.Button();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblPaikkakunta = new System.Windows.Forms.Label();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblPuhnro = new System.Windows.Forms.Label();
            this.lblSahkoposti = new System.Windows.Forms.Label();
            this.btnPoistaVaraus = new System.Windows.Forms.Button();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbPaikkakunta = new System.Windows.Forms.TextBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbPuhnro = new System.Windows.Forms.TextBox();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.btnMuokkaaVarausta = new System.Windows.Forms.Button();
            this.btnVaraustiedot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.AllowUserToAddRows = false;
            this.dgvVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(386, 12);
            this.dgvVaraukset.MultiSelect = false;
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.ReadOnly = true;
            this.dgvVaraukset.RowHeadersVisible = false;
            this.dgvVaraukset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVaraukset.Size = new System.Drawing.Size(608, 426);
            this.dgvVaraukset.TabIndex = 0;
            this.dgvVaraukset.Click += new System.EventHandler(this.dgvVaraukset_Click);
            // 
            // btnLisaaVaraus
            // 
            this.btnLisaaVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaaVaraus.Location = new System.Drawing.Point(235, 409);
            this.btnLisaaVaraus.Name = "btnLisaaVaraus";
            this.btnLisaaVaraus.Size = new System.Drawing.Size(145, 29);
            this.btnLisaaVaraus.TabIndex = 1;
            this.btnLisaaVaraus.Text = "Lisää Varaus";
            this.btnLisaaVaraus.UseVisualStyleBackColor = true;
            this.btnLisaaVaraus.Click += new System.EventHandler(this.btnLisaaVaraus_Click);
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEtunimi.Location = new System.Drawing.Point(13, 12);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(54, 17);
            this.lblEtunimi.TabIndex = 2;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSukunimi.Location = new System.Drawing.Point(14, 55);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(65, 17);
            this.lblSukunimi.TabIndex = 3;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKatuosoite.Location = new System.Drawing.Point(13, 154);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(75, 17);
            this.lblKatuosoite.TabIndex = 4;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblPaikkakunta
            // 
            this.lblPaikkakunta.AutoSize = true;
            this.lblPaikkakunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaikkakunta.Location = new System.Drawing.Point(12, 202);
            this.lblPaikkakunta.Name = "lblPaikkakunta";
            this.lblPaikkakunta.Size = new System.Drawing.Size(85, 17);
            this.lblPaikkakunta.TabIndex = 5;
            this.lblPaikkakunta.Text = "Paikkakunta";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPostinumero.Location = new System.Drawing.Point(134, 202);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(87, 17);
            this.lblPostinumero.TabIndex = 6;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // lblPuhnro
            // 
            this.lblPuhnro.AutoSize = true;
            this.lblPuhnro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPuhnro.Location = new System.Drawing.Point(12, 281);
            this.lblPuhnro.Name = "lblPuhnro";
            this.lblPuhnro.Size = new System.Drawing.Size(103, 17);
            this.lblPuhnro.TabIndex = 7;
            this.lblPuhnro.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            this.lblSahkoposti.AutoSize = true;
            this.lblSahkoposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSahkoposti.Location = new System.Drawing.Point(11, 328);
            this.lblSahkoposti.Name = "lblSahkoposti";
            this.lblSahkoposti.Size = new System.Drawing.Size(78, 17);
            this.lblSahkoposti.TabIndex = 8;
            this.lblSahkoposti.Text = "Sähköposti";
            // 
            // btnPoistaVaraus
            // 
            this.btnPoistaVaraus.Enabled = false;
            this.btnPoistaVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoistaVaraus.Location = new System.Drawing.Point(6, 409);
            this.btnPoistaVaraus.Name = "btnPoistaVaraus";
            this.btnPoistaVaraus.Size = new System.Drawing.Size(154, 29);
            this.btnPoistaVaraus.TabIndex = 9;
            this.btnPoistaVaraus.Text = "Poista Varaus";
            this.btnPoistaVaraus.UseVisualStyleBackColor = true;
            this.btnPoistaVaraus.Click += new System.EventHandler(this.btnPoistaVaraus_Click);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Enabled = false;
            this.tbSukunimi.Location = new System.Drawing.Point(16, 32);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(222, 20);
            this.tbSukunimi.TabIndex = 10;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Enabled = false;
            this.tbEtunimi.Location = new System.Drawing.Point(17, 75);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(221, 20);
            this.tbEtunimi.TabIndex = 11;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Enabled = false;
            this.tbKatuosoite.Location = new System.Drawing.Point(16, 179);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(221, 20);
            this.tbKatuosoite.TabIndex = 12;
            // 
            // tbPaikkakunta
            // 
            this.tbPaikkakunta.Enabled = false;
            this.tbPaikkakunta.Location = new System.Drawing.Point(16, 222);
            this.tbPaikkakunta.Name = "tbPaikkakunta";
            this.tbPaikkakunta.Size = new System.Drawing.Size(100, 20);
            this.tbPaikkakunta.TabIndex = 13;
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Enabled = false;
            this.tbPostinumero.Location = new System.Drawing.Point(137, 222);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(100, 20);
            this.tbPostinumero.TabIndex = 14;
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Enabled = false;
            this.tbPuhnro.Location = new System.Drawing.Point(15, 302);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(222, 20);
            this.tbPuhnro.TabIndex = 15;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Enabled = false;
            this.tbSahkoposti.Location = new System.Drawing.Point(15, 348);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(222, 20);
            this.tbSahkoposti.TabIndex = 16;
            // 
            // btnMuokkaaVarausta
            // 
            this.btnMuokkaaVarausta.Enabled = false;
            this.btnMuokkaaVarausta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMuokkaaVarausta.Location = new System.Drawing.Point(6, 374);
            this.btnMuokkaaVarausta.Name = "btnMuokkaaVarausta";
            this.btnMuokkaaVarausta.Size = new System.Drawing.Size(154, 29);
            this.btnMuokkaaVarausta.TabIndex = 17;
            this.btnMuokkaaVarausta.Text = "Muokkaa Varausta";
            this.btnMuokkaaVarausta.UseVisualStyleBackColor = true;
            this.btnMuokkaaVarausta.Click += new System.EventHandler(this.btnMuokkaaVarausta_Click);
            // 
            // btnVaraustiedot
            // 
            this.btnVaraustiedot.Enabled = false;
            this.btnVaraustiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVaraustiedot.Location = new System.Drawing.Point(235, 374);
            this.btnVaraustiedot.Name = "btnVaraustiedot";
            this.btnVaraustiedot.Size = new System.Drawing.Size(145, 29);
            this.btnVaraustiedot.TabIndex = 18;
            this.btnVaraustiedot.Text = "Varauksen tiedot";
            this.btnVaraustiedot.UseVisualStyleBackColor = true;
            this.btnVaraustiedot.Click += new System.EventHandler(this.btnVaraustiedot_Click);
            // 
            // Asiakastiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.btnVaraustiedot);
            this.Controls.Add(this.btnMuokkaaVarausta);
            this.Controls.Add(this.tbSahkoposti);
            this.Controls.Add(this.tbPuhnro);
            this.Controls.Add(this.tbPostinumero);
            this.Controls.Add(this.tbPaikkakunta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.btnPoistaVaraus);
            this.Controls.Add(this.lblSahkoposti);
            this.Controls.Add(this.lblPuhnro);
            this.Controls.Add(this.lblPostinumero);
            this.Controls.Add(this.lblPaikkakunta);
            this.Controls.Add(this.lblKatuosoite);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.btnLisaaVaraus);
            this.Controls.Add(this.dgvVaraukset);
            this.Name = "Asiakastiedot";
            this.Text = "Asiakastiedot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Button btnLisaaVaraus;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblPaikkakunta;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.Label lblPuhnro;
        private System.Windows.Forms.Label lblSahkoposti;
        private System.Windows.Forms.Button btnPoistaVaraus;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbPaikkakunta;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbPuhnro;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.Button btnMuokkaaVarausta;
        private System.Windows.Forms.Button btnVaraustiedot;
    }
}