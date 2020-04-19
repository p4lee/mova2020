namespace MOVA2020
{
    partial class Primary
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.btnMuokkaaMokki = new System.Windows.Forms.Button();
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLisaatoimintaalue = new System.Windows.Forms.Button();
            this.tbLisaaToimintaalueNimi = new System.Windows.Forms.TextBox();
            this.lblLisaaToimintaalueNimi = new System.Windows.Forms.Label();
            this.dgvToimintaalueet = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.btnMokinTiedotJaPalvelut = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaalueet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1221, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnMokinTiedotJaPalvelut);
            this.tabPage1.Controls.Add(this.btnPoistaMokki);
            this.tabPage1.Controls.Add(this.btnMuokkaaMokki);
            this.tabPage1.Controls.Add(this.btnLisaaMokki);
            this.tabPage1.Controls.Add(this.dgvMokit);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökit";
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaMokki.Location = new System.Drawing.Point(23, 155);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(269, 32);
            this.btnPoistaMokki.TabIndex = 3;
            this.btnPoistaMokki.Text = "Poista Mökki";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // btnMuokkaaMokki
            // 
            this.btnMuokkaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuokkaaMokki.Location = new System.Drawing.Point(23, 93);
            this.btnMuokkaaMokki.Name = "btnMuokkaaMokki";
            this.btnMuokkaaMokki.Size = new System.Drawing.Size(269, 33);
            this.btnMuokkaaMokki.TabIndex = 2;
            this.btnMuokkaaMokki.Text = "Muokkaa Mökkiä";
            this.btnMuokkaaMokki.UseVisualStyleBackColor = true;
            this.btnMuokkaaMokki.Click += new System.EventHandler(this.btnMuokkaaMokki_Click);
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaMokki.Location = new System.Drawing.Point(23, 33);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(269, 32);
            this.btnLisaaMokki.TabIndex = 1;
            this.btnLisaaMokki.Text = "Lisää Mökki";
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaaMokki_Click);
            // 
            // dgvMokit
            // 

            this.dgvMokit.AllowUserToAddRows = false;
            this.dgvMokit.AllowUserToDeleteRows = false;
            this.dgvMokit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMokit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMokit.Location = new System.Drawing.Point(411, 6);
            this.dgvMokit.MultiSelect = false;
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.RowHeadersVisible = false;
            this.dgvMokit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMokit.Size = new System.Drawing.Size(796, 546);
            this.dgvMokit.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLisaatoimintaalue);
            this.tabPage2.Controls.Add(this.tbLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.lblLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.dgvToimintaalueet);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toimialueet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLisaatoimintaalue
            // 
            this.btnLisaatoimintaalue.Margin = new System.Windows.Forms.Padding(4);

            this.btnLisaatoimintaalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaatoimintaalue.Location = new System.Drawing.Point(6, 52);
            this.btnLisaatoimintaalue.Name = "btnLisaatoimintaalue";
            this.btnLisaatoimintaalue.Size = new System.Drawing.Size(111, 28);
            this.btnLisaatoimintaalue.TabIndex = 4;
            this.btnLisaatoimintaalue.Text = "Lisää toiminta-alue";
            this.btnLisaatoimintaalue.UseVisualStyleBackColor = true;
            this.btnLisaatoimintaalue.Click += new System.EventHandler(this.btnLisaatoimintaalue_Click);
            // 
            // tbLisaaToimintaalueNimi
            // 

            this.tbLisaaToimintaalueNimi.Margin = new System.Windows.Forms.Padding(4);

            this.tbLisaaToimintaalueNimi.Location = new System.Drawing.Point(6, 23);
            this.tbLisaaToimintaalueNimi.Name = "tbLisaaToimintaalueNimi";
            this.tbLisaaToimintaalueNimi.Size = new System.Drawing.Size(111, 23);
            this.tbLisaaToimintaalueNimi.TabIndex = 3;
            // 
            // lblLisaaToimintaalueNimi
            // 
            this.lblLisaaToimintaalueNimi.AutoSize = true;
            this.lblLisaaToimintaalueNimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLisaaToimintaalueNimi.Location = new System.Drawing.Point(6, 3);
            this.lblLisaaToimintaalueNimi.Name = "lblLisaaToimintaalueNimi";
            this.lblLisaaToimintaalueNimi.Size = new System.Drawing.Size(35, 17);
            this.lblLisaaToimintaalueNimi.TabIndex = 2;
            this.lblLisaaToimintaalueNimi.Text = "Nimi";
            // 
            // dgvToimintaalueet
            // 
            this.dgvToimintaalueet.AllowUserToAddRows = false;
            this.dgvToimintaalueet.AllowUserToDeleteRows = false;
            this.dgvToimintaalueet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToimintaalueet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToimintaalueet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvToimintaalueet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimintaalueet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvToimintaalueet.Location = new System.Drawing.Point(411, 6);
            this.dgvToimintaalueet.MultiSelect = false;
            this.dgvToimintaalueet.Name = "dgvToimintaalueet";
            this.dgvToimintaalueet.RowHeadersVisible = false;
            this.dgvToimintaalueet.RowHeadersWidth = 51;
            this.dgvToimintaalueet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvToimintaalueet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToimintaalueet.ShowCellErrors = false;
            this.dgvToimintaalueet.ShowCellToolTips = false;
            this.dgvToimintaalueet.ShowEditingIcon = false;
            this.dgvToimintaalueet.ShowRowErrors = false;
            this.dgvToimintaalueet.Size = new System.Drawing.Size(796, 546);
            this.dgvToimintaalueet.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvVaraukset);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1213, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Varaukset";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.AllowUserToAddRows = false;
            this.dgvVaraukset.AllowUserToDeleteRows = false;
            this.dgvVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaraukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVaraukset.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVaraukset.Location = new System.Drawing.Point(411, 6);
            this.dgvVaraukset.MultiSelect = false;
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.RowHeadersVisible = false;
            this.dgvVaraukset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVaraukset.Size = new System.Drawing.Size(796, 546);
            this.dgvVaraukset.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvAsiakkaat);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1213, 558);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asiakkaat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btPoista
            // 
            this.dgvAsiakkaat.AllowUserToAddRows = false;
            this.dgvAsiakkaat.AllowUserToDeleteRows = false;
            this.dgvAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsiakkaat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Margin = new System.Windows.Forms.Padding(4);

            this.btnMokinTiedotJaPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokinTiedotJaPalvelut.Location = new System.Drawing.Point(23, 418);
            this.btnMokinTiedotJaPalvelut.Name = "btnMokinTiedotJaPalvelut";
            this.btnMokinTiedotJaPalvelut.Size = new System.Drawing.Size(269, 32);
            this.btnMokinTiedotJaPalvelut.TabIndex = 4;
            this.btnMokinTiedotJaPalvelut.Text = "Mökin Tiedot ja Palvelut";
            this.btnMokinTiedotJaPalvelut.UseVisualStyleBackColor = true;
            this.btnMokinTiedotJaPalvelut.Click += new System.EventHandler(this.btnMokinTiedotJaPalvelut_Click);
            this.dgvAsiakkaat.Location = new System.Drawing.Point(411, 6);
            this.dgvAsiakkaat.MultiSelect = false;
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.RowHeadersVisible = false;
            this.dgvAsiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(796, 546);
            this.dgvAsiakkaat.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.dgvLaskut);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1213, 558);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Laskut";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(6, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.AllowUserToAddRows = false;
            this.dgvLaskut.AllowUserToDeleteRows = false;
            this.dgvLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaskut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLaskut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(411, 6);
            this.dgvLaskut.MultiSelect = false;
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.RowHeadersVisible = false;
            this.dgvLaskut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaskut.Size = new System.Drawing.Size(796, 546);
            this.dgvLaskut.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvPalvelut);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1213, 558);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Palvelut";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.AllowUserToAddRows = false;
            this.dgvPalvelut.AllowUserToDeleteRows = false;
            this.dgvPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPalvelut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(411, 6);
            this.dgvPalvelut.MultiSelect = false;
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.RowHeadersVisible = false;
            this.dgvPalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalvelut.Size = new System.Drawing.Size(796, 546);
            this.dgvPalvelut.TabIndex = 0;
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 611);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Primary";
            this.Text = "MOVA2020";
            this.Load += new System.EventHandler(this.Primary_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaalueet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.DataGridView dgvToimintaalueet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.Button btnLisaatoimintaalue;
        private System.Windows.Forms.TextBox tbLisaaToimintaalueNimi;
        private System.Windows.Forms.Label lblLisaaToimintaalueNimi;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Button btnMuokkaaMokki;
        private System.Windows.Forms.Button btnLisaaMokki;
        private System.Windows.Forms.Button btnMokinTiedotJaPalvelut;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvPalvelut;
    }
}

