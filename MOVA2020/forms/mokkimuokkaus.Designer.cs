namespace MOVA2020.forms
{
    partial class mokkimuokkaus
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
            this.components = new System.ComponentModel.Container();
            this.cbToimialue = new System.Windows.Forms.ComboBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbMokkiNimi = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.lblPostinro = new System.Windows.Forms.Label();
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.rtbKuvaus = new System.Windows.Forms.RichTextBox();
            this.lblToimialueet = new System.Windows.Forms.Label();
            this.nmbHenkilomaara = new System.Windows.Forms.NumericUpDown();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbVarustelu = new System.Windows.Forms.RichTextBox();
            this.btnMokinLisays = new System.Windows.Forms.Button();
            this.lbMokkiHinta = new System.Windows.Forms.Label();
            this.tbMokkiHinta = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmbHenkilomaara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbToimialue
            // 
            this.cbToimialue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbToimialue.FormattingEnabled = true;
            this.cbToimialue.Location = new System.Drawing.Point(14, 31);
            this.cbToimialue.Name = "cbToimialue";
            this.cbToimialue.Size = new System.Drawing.Size(263, 24);
            this.cbToimialue.TabIndex = 0;
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostinumero.Location = new System.Drawing.Point(14, 128);
            this.tbPostinumero.MaxLength = 5;
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(263, 22);
            this.tbPostinumero.TabIndex = 2;
            this.tbPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinumero_KeyPress);
            // 
            // tbMokkiNimi
            // 
            this.tbMokkiNimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMokkiNimi.Location = new System.Drawing.Point(15, 80);
            this.tbMokkiNimi.Name = "tbMokkiNimi";
            this.tbMokkiNimi.Size = new System.Drawing.Size(262, 22);
            this.tbMokkiNimi.TabIndex = 1;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKatuosoite.Location = new System.Drawing.Point(14, 176);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(263, 22);
            this.tbKatuosoite.TabIndex = 3;
            // 
            // lblPostinro
            // 
            this.lblPostinro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostinro.Location = new System.Drawing.Point(10, 105);
            this.lblPostinro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(103, 20);
            this.lblPostinro.TabIndex = 5;
            this.lblPostinro.Text = "Postinumero";
            // 
            // lblNimi
            // 
            this.lblNimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNimi.AutoSize = true;
            this.lblNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNimi.Location = new System.Drawing.Point(10, 58);
            this.lblNimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(43, 20);
            this.lblNimi.TabIndex = 6;
            this.lblNimi.Text = "Nimi";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatuosoite.Location = new System.Drawing.Point(10, 153);
            this.lblKatuosoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(88, 20);
            this.lblKatuosoite.TabIndex = 7;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuvaus.Location = new System.Drawing.Point(13, 406);
            this.lblKuvaus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(64, 20);
            this.lblKuvaus.TabIndex = 8;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // rtbKuvaus
            // 
            this.rtbKuvaus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbKuvaus.Location = new System.Drawing.Point(15, 429);
            this.rtbKuvaus.Name = "rtbKuvaus";
            this.rtbKuvaus.Size = new System.Drawing.Size(262, 126);
            this.rtbKuvaus.TabIndex = 7;
            this.rtbKuvaus.Text = "";
            // 
            // lblToimialueet
            // 
            this.lblToimialueet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToimialueet.AutoSize = true;
            this.lblToimialueet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToimialueet.Location = new System.Drawing.Point(10, 9);
            this.lblToimialueet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToimialueet.Name = "lblToimialueet";
            this.lblToimialueet.Size = new System.Drawing.Size(81, 20);
            this.lblToimialueet.TabIndex = 10;
            this.lblToimialueet.Text = "Toimialue";
            // 
            // nmbHenkilomaara
            // 
            this.nmbHenkilomaara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmbHenkilomaara.Location = new System.Drawing.Point(13, 276);
            this.nmbHenkilomaara.Margin = new System.Windows.Forms.Padding(4);
            this.nmbHenkilomaara.Name = "nmbHenkilomaara";
            this.nmbHenkilomaara.Size = new System.Drawing.Size(264, 22);
            this.nmbHenkilomaara.TabIndex = 5;
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHenkilomaara.Location = new System.Drawing.Point(11, 252);
            this.lblHenkilomaara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(112, 20);
            this.lblHenkilomaara.TabIndex = 12;
            this.lblHenkilomaara.Text = "Henkilömäärä";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Varustelu";
            // 
            // rtbVarustelu
            // 
            this.rtbVarustelu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbVarustelu.Location = new System.Drawing.Point(14, 325);
            this.rtbVarustelu.Name = "rtbVarustelu";
            this.rtbVarustelu.Size = new System.Drawing.Size(263, 78);
            this.rtbVarustelu.TabIndex = 6;
            this.rtbVarustelu.Text = "";
            // 
            // btnMokinLisays
            // 
            this.btnMokinLisays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMokinLisays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokinLisays.Location = new System.Drawing.Point(14, 561);
            this.btnMokinLisays.Name = "btnMokinLisays";
            this.btnMokinLisays.Size = new System.Drawing.Size(263, 37);
            this.btnMokinLisays.TabIndex = 8;
            this.btnMokinLisays.UseVisualStyleBackColor = true;
            this.btnMokinLisays.Click += new System.EventHandler(this.btnMokinLisays_Click);
            // 
            // lbMokkiHinta
            // 
            this.lbMokkiHinta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMokkiHinta.AutoSize = true;
            this.lbMokkiHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMokkiHinta.Location = new System.Drawing.Point(13, 201);
            this.lbMokkiHinta.Name = "lbMokkiHinta";
            this.lbMokkiHinta.Size = new System.Drawing.Size(73, 20);
            this.lbMokkiHinta.TabIndex = 16;
            this.lbMokkiHinta.Text = "Hinta/Yö";
            // 
            // tbMokkiHinta
            // 
            this.tbMokkiHinta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMokkiHinta.Location = new System.Drawing.Point(14, 224);
            this.tbMokkiHinta.Name = "tbMokkiHinta";
            this.tbMokkiHinta.Size = new System.Drawing.Size(263, 22);
            this.tbMokkiHinta.TabIndex = 4;
            this.tbMokkiHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMokkiHinta_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mokkimuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 610);
            this.Controls.Add(this.tbMokkiHinta);
            this.Controls.Add(this.lbMokkiHinta);
            this.Controls.Add(this.btnMokinLisays);
            this.Controls.Add(this.rtbVarustelu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHenkilomaara);
            this.Controls.Add(this.nmbHenkilomaara);
            this.Controls.Add(this.lblToimialueet);
            this.Controls.Add(this.rtbKuvaus);
            this.Controls.Add(this.lblKuvaus);
            this.Controls.Add(this.lblKatuosoite);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.lblPostinro);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokkiNimi);
            this.Controls.Add(this.tbPostinumero);
            this.Controls.Add(this.cbToimialue);
            this.MinimumSize = new System.Drawing.Size(322, 657);
            this.Name = "mokkimuokkaus";
            ((System.ComponentModel.ISupportInitialize)(this.nmbHenkilomaara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbToimialue;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbMokkiNimi;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.Label lblPostinro;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.RichTextBox rtbKuvaus;
        private System.Windows.Forms.Label lblToimialueet;
        private System.Windows.Forms.NumericUpDown nmbHenkilomaara;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbVarustelu;
        private System.Windows.Forms.Button btnMokinLisays;
        private System.Windows.Forms.Label lbMokkiHinta;
        private System.Windows.Forms.TextBox tbMokkiHinta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}