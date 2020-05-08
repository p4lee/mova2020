namespace MOVA2020.forms
{
    partial class Laskutus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laskutus));
            this.printpreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnVarmenna = new System.Windows.Forms.Button();
            this.btlaheta = new System.Windows.Forms.Button();
            this.btnVaraustiedot = new System.Windows.Forms.Button();
            this.bttulosta = new System.Windows.Forms.Button();
            this.lblpvm = new System.Windows.Forms.Label();
            this.lblErapvm = new System.Windows.Forms.Label();
            this.lbllaskunum = new System.Windows.Forms.Label();
            this.TBnum = new System.Windows.Forms.TextBox();
            this.TBlisatiedot = new System.Windows.Forms.TextBox();
            this.TBpvm = new System.Windows.Forms.TextBox();
            this.TBAsiakas = new System.Windows.Forms.TextBox();
            this.TBerapvm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TByht = new System.Windows.Forms.TextBox();
            this.lbllasku = new System.Windows.Forms.Label();
            this.lblyht = new System.Windows.Forms.Label();
            this.lbllaskuttaja = new System.Windows.Forms.Label();
            this.TBLaskutus = new System.Windows.Forms.TextBox();
            this.panelLasku = new System.Windows.Forms.Panel();
            this.panelLasku.SuspendLayout();
            this.SuspendLayout();
            // 
            // printpreview
            // 
            this.printpreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printpreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printpreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printpreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printpreview.Document = this.printDocument;
            this.printpreview.Enabled = true;
            this.printpreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printpreview.Icon")));
            this.printpreview.Name = "pvdprinting";
            this.printpreview.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnVarmenna
            // 
            this.btnVarmenna.Enabled = false;
            this.btnVarmenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVarmenna.Location = new System.Drawing.Point(577, 142);
            this.btnVarmenna.Name = "btnVarmenna";
            this.btnVarmenna.Size = new System.Drawing.Size(189, 37);
            this.btnVarmenna.TabIndex = 4;
            this.btnVarmenna.Text = "Maksun varmennus";
            this.btnVarmenna.UseVisualStyleBackColor = true;
            this.btnVarmenna.Click += new System.EventHandler(this.btnVarmenna_Click);
            // 
            // btlaheta
            // 
            this.btlaheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btlaheta.Location = new System.Drawing.Point(577, 104);
            this.btlaheta.Name = "btlaheta";
            this.btlaheta.Size = new System.Drawing.Size(189, 32);
            this.btlaheta.TabIndex = 3;
            this.btlaheta.Text = "Lähetä lasku";
            this.btlaheta.UseVisualStyleBackColor = true;
            this.btlaheta.Click += new System.EventHandler(this.btlaheta_Click);
            // 
            // btnVaraustiedot
            // 
            this.btnVaraustiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVaraustiedot.Location = new System.Drawing.Point(577, 26);
            this.btnVaraustiedot.Name = "btnVaraustiedot";
            this.btnVaraustiedot.Size = new System.Drawing.Size(189, 32);
            this.btnVaraustiedot.TabIndex = 1;
            this.btnVaraustiedot.Text = "Varauksen tiedot";
            this.btnVaraustiedot.UseVisualStyleBackColor = true;
            this.btnVaraustiedot.Click += new System.EventHandler(this.btnVaraustiedot_Click);
            // 
            // bttulosta
            // 
            this.bttulosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttulosta.Location = new System.Drawing.Point(577, 67);
            this.bttulosta.Name = "bttulosta";
            this.bttulosta.Size = new System.Drawing.Size(189, 32);
            this.bttulosta.TabIndex = 2;
            this.bttulosta.Text = "Tulosta lasku";
            this.bttulosta.UseVisualStyleBackColor = true;
            this.bttulosta.Click += new System.EventHandler(this.bttulosta_Click);
            // 
            // lblpvm
            // 
            this.lblpvm.AutoSize = true;
            this.lblpvm.Location = new System.Drawing.Point(230, 62);
            this.lblpvm.Name = "lblpvm";
            this.lblpvm.Size = new System.Drawing.Size(99, 20);
            this.lblpvm.TabIndex = 81;
            this.lblpvm.Text = "Laskun pvm";
            // 
            // lblErapvm
            // 
            this.lblErapvm.AutoSize = true;
            this.lblErapvm.Location = new System.Drawing.Point(230, 85);
            this.lblErapvm.Name = "lblErapvm";
            this.lblErapvm.Size = new System.Drawing.Size(74, 20);
            this.lblErapvm.TabIndex = 82;
            this.lblErapvm.Text = "Eräpäivä";
            // 
            // lbllaskunum
            // 
            this.lbllaskunum.AutoSize = true;
            this.lbllaskunum.Location = new System.Drawing.Point(230, 39);
            this.lbllaskunum.Name = "lbllaskunum";
            this.lbllaskunum.Size = new System.Drawing.Size(124, 20);
            this.lbllaskunum.TabIndex = 80;
            this.lbllaskunum.Text = "Laskun numero";
            // 
            // TBnum
            // 
            this.TBnum.Location = new System.Drawing.Point(359, 36);
            this.TBnum.Name = "TBnum";
            this.TBnum.Size = new System.Drawing.Size(117, 26);
            this.TBnum.TabIndex = 83;
            // 
            // TBlisatiedot
            // 
            this.TBlisatiedot.Location = new System.Drawing.Point(7, 150);
            this.TBlisatiedot.Multiline = true;
            this.TBlisatiedot.Name = "TBlisatiedot";
            this.TBlisatiedot.Size = new System.Drawing.Size(470, 262);
            this.TBlisatiedot.TabIndex = 79;
            // 
            // TBpvm
            // 
            this.TBpvm.Location = new System.Drawing.Point(359, 62);
            this.TBpvm.Name = "TBpvm";
            this.TBpvm.Size = new System.Drawing.Size(117, 26);
            this.TBpvm.TabIndex = 84;
            // 
            // TBAsiakas
            // 
            this.TBAsiakas.Location = new System.Drawing.Point(7, 59);
            this.TBAsiakas.Multiline = true;
            this.TBAsiakas.Name = "TBAsiakas";
            this.TBAsiakas.Size = new System.Drawing.Size(213, 72);
            this.TBAsiakas.TabIndex = 78;
            // 
            // TBerapvm
            // 
            this.TBerapvm.Location = new System.Drawing.Point(359, 88);
            this.TBerapvm.Name = "TBerapvm";
            this.TBerapvm.Size = new System.Drawing.Size(117, 26);
            this.TBerapvm.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Siilokatu 1, 90700 OULU";
            // 
            // TByht
            // 
            this.TByht.BackColor = System.Drawing.Color.White;
            this.TByht.Location = new System.Drawing.Point(410, 656);
            this.TByht.Name = "TByht";
            this.TByht.ReadOnly = true;
            this.TByht.Size = new System.Drawing.Size(67, 26);
            this.TByht.TabIndex = 87;
            // 
            // lbllasku
            // 
            this.lbllasku.AutoSize = true;
            this.lbllasku.Location = new System.Drawing.Point(230, 7);
            this.lbllasku.Name = "lbllasku";
            this.lbllasku.Size = new System.Drawing.Size(64, 20);
            this.lbllasku.TabIndex = 75;
            this.lbllasku.Text = "LASKU";
            // 
            // lblyht
            // 
            this.lblyht.AutoSize = true;
            this.lblyht.Location = new System.Drawing.Point(336, 659);
            this.lblyht.Name = "lblyht";
            this.lblyht.Size = new System.Drawing.Size(78, 20);
            this.lblyht.TabIndex = 86;
            this.lblyht.Text = "Yhteensä";
            // 
            // lbllaskuttaja
            // 
            this.lbllaskuttaja.AutoSize = true;
            this.lbllaskuttaja.Location = new System.Drawing.Point(3, 7);
            this.lbllaskuttaja.Name = "lbllaskuttaja";
            this.lbllaskuttaja.Size = new System.Drawing.Size(156, 20);
            this.lbllaskuttaja.TabIndex = 76;
            this.lbllaskuttaja.Text = "Village Newbies OY";
            // 
            // TBLaskutus
            // 
            this.TBLaskutus.Location = new System.Drawing.Point(6, 418);
            this.TBLaskutus.Multiline = true;
            this.TBLaskutus.Name = "TBLaskutus";
            this.TBLaskutus.Size = new System.Drawing.Size(470, 228);
            this.TBLaskutus.TabIndex = 88;
            // 
            // panelLasku
            // 
            this.panelLasku.Controls.Add(this.TBLaskutus);
            this.panelLasku.Controls.Add(this.lbllaskuttaja);
            this.panelLasku.Controls.Add(this.lblyht);
            this.panelLasku.Controls.Add(this.lbllasku);
            this.panelLasku.Controls.Add(this.TByht);
            this.panelLasku.Controls.Add(this.label1);
            this.panelLasku.Controls.Add(this.TBerapvm);
            this.panelLasku.Controls.Add(this.TBAsiakas);
            this.panelLasku.Controls.Add(this.TBpvm);
            this.panelLasku.Controls.Add(this.TBlisatiedot);
            this.panelLasku.Controls.Add(this.TBnum);
            this.panelLasku.Controls.Add(this.lbllaskunum);
            this.panelLasku.Controls.Add(this.lblErapvm);
            this.panelLasku.Controls.Add(this.lblpvm);
            this.panelLasku.Location = new System.Drawing.Point(5, 2);
            this.panelLasku.Name = "panelLasku";
            this.panelLasku.Size = new System.Drawing.Size(487, 710);
            this.panelLasku.TabIndex = 74;
            // 
            // Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 726);
            this.Controls.Add(this.btnVarmenna);
            this.Controls.Add(this.btlaheta);
            this.Controls.Add(this.btnVaraustiedot);
            this.Controls.Add(this.bttulosta);
            this.Controls.Add(this.panelLasku);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(550, 650);
            this.Name = "Laskutus";
            this.Text = "Lasku";
            this.panelLasku.ResumeLayout(false);
            this.panelLasku.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printpreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnVarmenna;
        private System.Windows.Forms.Button btlaheta;
        private System.Windows.Forms.Button btnVaraustiedot;
        private System.Windows.Forms.Button bttulosta;
        private System.Windows.Forms.Label lblpvm;
        private System.Windows.Forms.Label lblErapvm;
        private System.Windows.Forms.Label lbllaskunum;
        private System.Windows.Forms.TextBox TBnum;
        private System.Windows.Forms.TextBox TBlisatiedot;
        private System.Windows.Forms.TextBox TBpvm;
        public System.Windows.Forms.TextBox TBAsiakas;
        private System.Windows.Forms.TextBox TBerapvm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TByht;
        private System.Windows.Forms.Label lbllasku;
        private System.Windows.Forms.Label lblyht;
        private System.Windows.Forms.Label lbllaskuttaja;
        private System.Windows.Forms.TextBox TBLaskutus;
        private System.Windows.Forms.Panel panelLasku;
    }
}