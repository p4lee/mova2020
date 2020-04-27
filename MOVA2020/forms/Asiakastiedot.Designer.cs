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
            this.dgvVaraukset.Location = new System.Drawing.Point(268, 12);
            this.dgvVaraukset.MultiSelect = false;
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.ReadOnly = true;
            this.dgvVaraukset.RowHeadersVisible = false;
            this.dgvVaraukset.Size = new System.Drawing.Size(520, 426);
            this.dgvVaraukset.TabIndex = 0;
            this.dgvVaraukset.Click += new System.EventHandler(this.dgvVaraukset_Click);
            // 
            // btnLisaaVaraus
            // 
            this.btnLisaaVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaaVaraus.Location = new System.Drawing.Point(137, 409);
            this.btnLisaaVaraus.Name = "btnLisaaVaraus";
            this.btnLisaaVaraus.Size = new System.Drawing.Size(125, 29);
            this.btnLisaaVaraus.TabIndex = 1;
            this.btnLisaaVaraus.Text = "Lisää Varaus";
            this.btnLisaaVaraus.UseVisualStyleBackColor = true;
            this.btnLisaaVaraus.Click += new System.EventHandler(this.btnLisaaVaraus_Click);
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEtunimi.Location = new System.Drawing.Point(13, 13);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(46, 17);
            this.lblEtunimi.TabIndex = 2;
            this.lblEtunimi.Text = "label1";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSukunimi.Location = new System.Drawing.Point(153, 13);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(46, 17);
            this.lblSukunimi.TabIndex = 3;
            this.lblSukunimi.Text = "label2";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKatuosoite.Location = new System.Drawing.Point(13, 73);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(46, 17);
            this.lblKatuosoite.TabIndex = 4;
            this.lblKatuosoite.Text = "label3";
            // 
            // lblPaikkakunta
            // 
            this.lblPaikkakunta.AutoSize = true;
            this.lblPaikkakunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaikkakunta.Location = new System.Drawing.Point(153, 73);
            this.lblPaikkakunta.Name = "lblPaikkakunta";
            this.lblPaikkakunta.Size = new System.Drawing.Size(46, 17);
            this.lblPaikkakunta.TabIndex = 5;
            this.lblPaikkakunta.Text = "label4";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPostinumero.Location = new System.Drawing.Point(13, 101);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(46, 17);
            this.lblPostinumero.TabIndex = 6;
            this.lblPostinumero.Text = "label5";
            // 
            // lblPuhnro
            // 
            this.lblPuhnro.AutoSize = true;
            this.lblPuhnro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPuhnro.Location = new System.Drawing.Point(13, 183);
            this.lblPuhnro.Name = "lblPuhnro";
            this.lblPuhnro.Size = new System.Drawing.Size(46, 17);
            this.lblPuhnro.TabIndex = 7;
            this.lblPuhnro.Text = "label6";
            // 
            // lblSahkoposti
            // 
            this.lblSahkoposti.AutoSize = true;
            this.lblSahkoposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSahkoposti.Location = new System.Drawing.Point(13, 213);
            this.lblSahkoposti.Name = "lblSahkoposti";
            this.lblSahkoposti.Size = new System.Drawing.Size(46, 17);
            this.lblSahkoposti.TabIndex = 8;
            this.lblSahkoposti.Text = "label7";
            // 
            // btnPoistaVaraus
            // 
            this.btnPoistaVaraus.Enabled = false;
            this.btnPoistaVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoistaVaraus.Location = new System.Drawing.Point(6, 409);
            this.btnPoistaVaraus.Name = "btnPoistaVaraus";
            this.btnPoistaVaraus.Size = new System.Drawing.Size(125, 29);
            this.btnPoistaVaraus.TabIndex = 9;
            this.btnPoistaVaraus.Text = "Poista Varaus";
            this.btnPoistaVaraus.UseVisualStyleBackColor = true;
            // 
            // Asiakastiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}