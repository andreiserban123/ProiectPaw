﻿namespace ProiectPaw {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lvUtilizatori = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meniulAplicatiei = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSelectedUtilizator = new System.Windows.Forms.TextBox();
            this.lvGrupuri = new System.Windows.Forms.ListView();
            this.chGrupuri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDrepturi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvGrupuri = new System.Windows.Forms.TreeView();
            this.meniulAplicatiei.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvUtilizatori
            // 
            this.lvUtilizatori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chCNP,
            this.chEmail,
            this.chPassword,
            this.chData});
            this.lvUtilizatori.FullRowSelect = true;
            this.lvUtilizatori.HideSelection = false;
            this.lvUtilizatori.Location = new System.Drawing.Point(285, 127);
            this.lvUtilizatori.Name = "lvUtilizatori";
            this.lvUtilizatori.Size = new System.Drawing.Size(786, 309);
            this.lvUtilizatori.TabIndex = 0;
            this.lvUtilizatori.UseCompatibleStateImageBehavior = false;
            this.lvUtilizatori.View = System.Windows.Forms.View.Details;
            this.lvUtilizatori.SelectedIndexChanged += new System.EventHandler(this.lvUtilizatori_SelectedIndexChanged);
            this.lvUtilizatori.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvUtilizatori_MouseDown);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 120;
            // 
            // chCNP
            // 
            this.chCNP.Text = "CNP";
            this.chCNP.Width = 120;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 120;
            // 
            // chPassword
            // 
            this.chPassword.Text = "Password";
            this.chPassword.Width = 120;
            // 
            // chData
            // 
            this.chData.Text = "DataNastere";
            this.chData.Width = 150;
            // 
            // meniulAplicatiei
            // 
            this.meniulAplicatiei.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.meniulAplicatiei.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.meniulAplicatiei.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.utilizatoriToolStripMenuItem,
            this.despreAplicatieToolStripMenuItem});
            this.meniulAplicatiei.Location = new System.Drawing.Point(0, 0);
            this.meniulAplicatiei.Name = "meniulAplicatiei";
            this.meniulAplicatiei.Size = new System.Drawing.Size(1675, 42);
            this.meniulAplicatiei.TabIndex = 1;
            this.meniulAplicatiei.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.restaurareBinarToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(89, 34);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.adaugaToolStripMenuItem1.Text = "Salvare binar";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare binar";
            this.restaurareBinarToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinarToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // utilizatoriToolStripMenuItem
            // 
            this.utilizatoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(119, 34);
            this.utilizatoriToolStripMenuItem.Text = "Utilizatori";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(211, 40);
            this.adaugaToolStripMenuItem.Text = "adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(211, 40);
            this.modificaToolStripMenuItem.Text = "modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(211, 40);
            this.stergeToolStripMenuItem.Text = "sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // despreAplicatieToolStripMenuItem
            // 
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.despreAplicatieToolStripMenuItem.Text = "Despre aplicatie";
            // 
            // tbSelectedUtilizator
            // 
            this.tbSelectedUtilizator.Location = new System.Drawing.Point(285, 497);
            this.tbSelectedUtilizator.Name = "tbSelectedUtilizator";
            this.tbSelectedUtilizator.Size = new System.Drawing.Size(786, 26);
            this.tbSelectedUtilizator.TabIndex = 2;
            // 
            // lvGrupuri
            // 
            this.lvGrupuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGrupuri,
            this.chDrepturi});
            this.lvGrupuri.HideSelection = false;
            this.lvGrupuri.Location = new System.Drawing.Point(1207, 127);
            this.lvGrupuri.Name = "lvGrupuri";
            this.lvGrupuri.Size = new System.Drawing.Size(310, 213);
            this.lvGrupuri.TabIndex = 3;
            this.lvGrupuri.UseCompatibleStateImageBehavior = false;
            this.lvGrupuri.View = System.Windows.Forms.View.Details;
            // 
            // chGrupuri
            // 
            this.chGrupuri.Text = "Grup";
            this.chGrupuri.Width = 100;
            // 
            // chDrepturi
            // 
            this.chDrepturi.Text = "Drepturi";
            this.chDrepturi.Width = 100;
            // 
            // tvGrupuri
            // 
            this.tvGrupuri.AllowDrop = true;
            this.tvGrupuri.LabelEdit = true;
            this.tvGrupuri.Location = new System.Drawing.Point(285, 553);
            this.tvGrupuri.Name = "tvGrupuri";
            this.tvGrupuri.Size = new System.Drawing.Size(480, 206);
            this.tvGrupuri.TabIndex = 4;
            this.tvGrupuri.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvGrupuri_DragDrop);
            this.tvGrupuri.DragOver += new System.Windows.Forms.DragEventHandler(this.tvGrupuri_DragOver);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 785);
            this.Controls.Add(this.tvGrupuri);
            this.Controls.Add(this.lvGrupuri);
            this.Controls.Add(this.tbSelectedUtilizator);
            this.Controls.Add(this.lvUtilizatori);
            this.Controls.Add(this.meniulAplicatiei);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.meniulAplicatiei.ResumeLayout(false);
            this.meniulAplicatiei.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUtilizatori;
        private System.Windows.Forms.MenuStrip meniulAplicatiei;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreAplicatieToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSelectedUtilizator;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chCNP;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chPassword;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ListView lvGrupuri;
        private System.Windows.Forms.ColumnHeader chGrupuri;
        private System.Windows.Forms.ColumnHeader chDrepturi;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TreeView tvGrupuri;
    }
}

