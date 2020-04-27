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
            this.btnMokinTiedot = new System.Windows.Forms.Button();
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
            this.btnPoistaAsiakas = new System.Windows.Forms.Button();
            this.btnMuokkaaAsiakas = new System.Windows.Forms.Button();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnLaskutus = new System.Windows.Forms.Button();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.btnMuokkaaPalvelua = new System.Windows.Forms.Button();
            this.btnLisaaPalvelu = new System.Windows.Forms.Button();
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
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnMokinTiedot);
            this.tabPage1.Controls.Add(this.btnPoistaMokki);
            this.tabPage1.Controls.Add(this.btnMuokkaaMokki);
            this.tabPage1.Controls.Add(this.btnLisaaMokki);
            this.tabPage1.Controls.Add(this.dgvMokit);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mökit";
            // 
            // btnMokinTiedot
            // 
            this.btnMokinTiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMokinTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokinTiedot.Location = new System.Drawing.Point(23, 431);
            this.btnMokinTiedot.Name = "btnMokinTiedot";
            this.btnMokinTiedot.Size = new System.Drawing.Size(269, 32);
            this.btnMokinTiedot.TabIndex = 4;
            this.btnMokinTiedot.Text = "Mökin Tiedot";
            this.btnMokinTiedot.UseVisualStyleBackColor = true;
            this.btnMokinTiedot.Click += new System.EventHandler(this.btnMokinTiedot_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Enabled = false;
            this.btnPoistaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaMokki.Location = new System.Drawing.Point(17, 126);
            this.btnPoistaMokki.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(202, 26);
            this.btnPoistaMokki.TabIndex = 3;
            this.btnPoistaMokki.Text = "Poista Mökki";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // btnMuokkaaMokki
            // 
            this.btnMuokkaaMokki.Enabled = false;
            this.btnMuokkaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuokkaaMokki.Location = new System.Drawing.Point(17, 76);
            this.btnMuokkaaMokki.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuokkaaMokki.Name = "btnMuokkaaMokki";
            this.btnMuokkaaMokki.Size = new System.Drawing.Size(202, 27);
            this.btnMuokkaaMokki.TabIndex = 2;
            this.btnMuokkaaMokki.Text = "Muokkaa Mökkiä";
            this.btnMuokkaaMokki.UseVisualStyleBackColor = true;
            this.btnMuokkaaMokki.Click += new System.EventHandler(this.btnMuokkaaMokki_Click);
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaMokki.Location = new System.Drawing.Point(17, 27);
            this.btnLisaaMokki.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(202, 26);
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
            this.dgvMokit.Location = new System.Drawing.Point(323, 1);
            this.dgvMokit.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMokit.MultiSelect = false;
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.ReadOnly = true;
            this.dgvMokit.RowHeadersVisible = false;
            this.dgvMokit.RowHeadersWidth = 51;
            this.dgvMokit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMokit.Size = new System.Drawing.Size(890, 553);
            this.dgvMokit.TabIndex = 0;
            this.dgvMokit.Click += new System.EventHandler(this.dgvMokit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLisaatoimintaalue);
            this.tabPage2.Controls.Add(this.tbLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.lblLisaaToimintaalueNimi);
            this.tabPage2.Controls.Add(this.dgvToimintaalueet);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Toimialueet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLisaatoimintaalue
            // 
            this.btnLisaatoimintaalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaatoimintaalue.Location = new System.Drawing.Point(6, 52);
            this.btnLisaatoimintaalue.Margin = new System.Windows.Forms.Padding(4);
            this.btnLisaatoimintaalue.Name = "btnLisaatoimintaalue";
            this.btnLisaatoimintaalue.Size = new System.Drawing.Size(84, 29);
            this.btnLisaatoimintaalue.TabIndex = 4;
            this.btnLisaatoimintaalue.Text = "Lisää toiminta-alue";
            this.btnLisaatoimintaalue.UseVisualStyleBackColor = true;
            this.btnLisaatoimintaalue.Click += new System.EventHandler(this.btnLisaatoimintaalue_Click);
            // 
            // tbLisaaToimintaalueNimi
            // 
            this.tbLisaaToimintaalueNimi.Location = new System.Drawing.Point(6, 23);
            this.tbLisaaToimintaalueNimi.Margin = new System.Windows.Forms.Padding(4);
            this.tbLisaaToimintaalueNimi.Name = "tbLisaaToimintaalueNimi";
            this.tbLisaaToimintaalueNimi.Size = new System.Drawing.Size(111, 26);
            this.tbLisaaToimintaalueNimi.TabIndex = 3;
            // 
            // lblLisaaToimintaalueNimi
            // 
            this.lblLisaaToimintaalueNimi.AutoSize = true;
            this.lblLisaaToimintaalueNimi.Location = new System.Drawing.Point(6, 3);
            this.lblLisaaToimintaalueNimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLisaaToimintaalueNimi.Name = "lblLisaaToimintaalueNimi";
            this.lblLisaaToimintaalueNimi.Size = new System.Drawing.Size(43, 20);
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
            this.dgvToimintaalueet.Location = new System.Drawing.Point(411, 6);
            this.dgvToimintaalueet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvToimintaalueet.MultiSelect = false;
            this.dgvToimintaalueet.Name = "dgvToimintaalueet";
            this.dgvToimintaalueet.ReadOnly = true;
            this.dgvToimintaalueet.RowHeadersVisible = false;
            this.dgvToimintaalueet.RowHeadersWidth = 51;
            this.dgvToimintaalueet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvToimintaalueet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToimintaalueet.ShowCellErrors = false;
            this.dgvToimintaalueet.ShowCellToolTips = false;
            this.dgvToimintaalueet.ShowEditingIcon = false;
            this.dgvToimintaalueet.ShowRowErrors = false;
            this.dgvToimintaalueet.Size = new System.Drawing.Size(597, 444);
            this.dgvToimintaalueet.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvVaraukset);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1213, 554);
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
            this.dgvVaraukset.Location = new System.Drawing.Point(411, 6);
            this.dgvVaraukset.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVaraukset.MultiSelect = false;
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.ReadOnly = true;
            this.dgvVaraukset.RowHeadersVisible = false;
            this.dgvVaraukset.RowHeadersWidth = 51;
            this.dgvVaraukset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVaraukset.Size = new System.Drawing.Size(597, 444);
            this.dgvVaraukset.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnPoistaAsiakas);
            this.tabPage4.Controls.Add(this.btnMuokkaaAsiakas);
            this.tabPage4.Controls.Add(this.btnLisaaAsiakas);
            this.tabPage4.Controls.Add(this.dgvAsiakkaat);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1213, 554);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asiakkaat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnPoistaAsiakas
            // 
            this.btnPoistaAsiakas.Enabled = false;
            this.btnPoistaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoistaAsiakas.Location = new System.Drawing.Point(5, 415);
            this.btnPoistaAsiakas.Name = "btnPoistaAsiakas";
            this.btnPoistaAsiakas.Size = new System.Drawing.Size(166, 31);
            this.btnPoistaAsiakas.TabIndex = 3;
            this.btnPoistaAsiakas.Text = "Poista asiakas";
            this.btnPoistaAsiakas.UseVisualStyleBackColor = true;
            this.btnPoistaAsiakas.Click += new System.EventHandler(this.btnPoistaAsiakas_Click);
            // 
            // btnMuokkaaAsiakas
            // 
            this.btnMuokkaaAsiakas.Enabled = false;
            this.btnMuokkaaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMuokkaaAsiakas.Location = new System.Drawing.Point(5, 358);
            this.btnMuokkaaAsiakas.Name = "btnMuokkaaAsiakas";
            this.btnMuokkaaAsiakas.Size = new System.Drawing.Size(166, 30);
            this.btnMuokkaaAsiakas.TabIndex = 2;
            this.btnMuokkaaAsiakas.Text = "Muokkaa asiakasta";
            this.btnMuokkaaAsiakas.UseVisualStyleBackColor = true;
            this.btnMuokkaaAsiakas.Click += new System.EventHandler(this.btnMuokkaaAsiakas_Click);
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(5, 298);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(166, 28);
            this.btnLisaaAsiakas.TabIndex = 1;
            this.btnLisaaAsiakas.Text = "Lisää asiakas";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaAsiakas.Click += new System.EventHandler(this.btnLisaaAsiakas_Click);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToAddRows = false;
            this.dgvAsiakkaat.AllowUserToDeleteRows = false;
            this.dgvAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsiakkaat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(411, 6);
            this.dgvAsiakkaat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAsiakkaat.MultiSelect = false;
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.ReadOnly = true;
            this.dgvAsiakkaat.RowHeadersVisible = false;
            this.dgvAsiakkaat.RowHeadersWidth = 51;
            this.dgvAsiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(597, 444);
            this.dgvAsiakkaat.TabIndex = 0;
            this.dgvAsiakkaat.Click += new System.EventHandler(this.dgvAsiakkaat_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnLaskutus);
            this.tabPage5.Controls.Add(this.dgvLaskut);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1213, 554);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Laskut";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnLaskutus
            // 
            this.btnLaskutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLaskutus.Location = new System.Drawing.Point(4, 418);
            this.btnLaskutus.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaskutus.Name = "btnLaskutus";
            this.btnLaskutus.Size = new System.Drawing.Size(87, 26);
            this.btnLaskutus.TabIndex = 1;
            this.btnLaskutus.Text = "Laskutus";
            this.btnLaskutus.UseVisualStyleBackColor = true;
            this.btnLaskutus.Click += new System.EventHandler(this.btnLaskutus_Click);
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
            this.dgvLaskut.Location = new System.Drawing.Point(308, 5);
            this.dgvLaskut.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLaskut.MultiSelect = false;
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.ReadOnly = true;
            this.dgvLaskut.RowHeadersVisible = false;
            this.dgvLaskut.RowHeadersWidth = 51;
            this.dgvLaskut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaskut.Size = new System.Drawing.Size(597, 444);
            this.dgvLaskut.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnPoistaPalvelu);
            this.tabPage6.Controls.Add(this.btnMuokkaaPalvelua);
            this.tabPage6.Controls.Add(this.btnLisaaPalvelu);
            this.tabPage6.Controls.Add(this.dgvPalvelut);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1213, 554);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Palvelut";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.Enabled = false;
            this.btnPoistaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(6, 75);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(164, 26);
            this.btnPoistaPalvelu.TabIndex = 3;
            this.btnPoistaPalvelu.Text = "Poista Palvelu";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.btnPoistaPalvelu_Click);
            // 
            // btnMuokkaaPalvelua
            // 
            this.btnMuokkaaPalvelua.Enabled = false;
            this.btnMuokkaaPalvelua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMuokkaaPalvelua.Location = new System.Drawing.Point(6, 40);
            this.btnMuokkaaPalvelua.Name = "btnMuokkaaPalvelua";
            this.btnMuokkaaPalvelua.Size = new System.Drawing.Size(164, 29);
            this.btnMuokkaaPalvelua.TabIndex = 2;
            this.btnMuokkaaPalvelua.Text = "Muokkaa Palvelua";
            this.btnMuokkaaPalvelua.UseVisualStyleBackColor = true;
            this.btnMuokkaaPalvelua.Click += new System.EventHandler(this.btnMuokkaaPalvelua_Click);
            // 
            // btnLisaaPalvelu
            // 
            this.btnLisaaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLisaaPalvelu.Location = new System.Drawing.Point(6, 5);
            this.btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            this.btnLisaaPalvelu.Size = new System.Drawing.Size(165, 29);
            this.btnLisaaPalvelu.TabIndex = 1;
            this.btnLisaaPalvelu.Text = "Lisää palvelu";
            this.btnLisaaPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaPalvelu.Click += new System.EventHandler(this.btnLisaaPalvelu_Click);
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
            this.dgvPalvelut.Location = new System.Drawing.Point(176, 5);
            this.dgvPalvelut.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPalvelut.MultiSelect = false;
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.ReadOnly = true;
            this.dgvPalvelut.RowHeadersVisible = false;
            this.dgvPalvelut.RowHeadersWidth = 51;
            this.dgvPalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalvelut.Size = new System.Drawing.Size(729, 444);
            this.dgvPalvelut.TabIndex = 0;
            this.dgvPalvelut.Click += new System.EventHandler(this.dgvPalvelut_Click);
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 496);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Button btnMokinTiedot;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnLaskutus;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.Button btnMuokkaaPalvelua;
        private System.Windows.Forms.Button btnLisaaPalvelu;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.Button btnPoistaAsiakas;
        private System.Windows.Forms.Button btnMuokkaaAsiakas;
        private System.Windows.Forms.Button btnLisaaAsiakas;
    }
}

