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
            this.components = new System.ComponentModel.Container();
            this.lvUtilizatori = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuAplicatie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.meniulAplicatiei = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new ProiectPaw.MyDBDataSet();
            this.utilizatoriTableAdapter = new ProiectPaw.MyDBDataSetTableAdapters.UtilizatoriTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNastere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuAplicatie.SuspendLayout();
            this.meniulAplicatiei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
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
            this.lvUtilizatori.ContextMenuStrip = this.contextMenuAplicatie;
            this.lvUtilizatori.FullRowSelect = true;
            this.lvUtilizatori.HideSelection = false;
            this.lvUtilizatori.Location = new System.Drawing.Point(348, 152);
            this.lvUtilizatori.Margin = new System.Windows.Forms.Padding(4);
            this.lvUtilizatori.MultiSelect = false;
            this.lvUtilizatori.Name = "lvUtilizatori";
            this.lvUtilizatori.Size = new System.Drawing.Size(960, 370);
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
            // contextMenuAplicatie
            // 
            this.contextMenuAplicatie.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuAplicatie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.modificaToolStripMenuItem1,
            this.stergeToolStripMenuItem1});
            this.contextMenuAplicatie.Name = "contextMenuAplicatie";
            this.contextMenuAplicatie.Size = new System.Drawing.Size(154, 100);
            this.contextMenuAplicatie.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuAplicatie_Opening);
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(153, 32);
            this.adaugaToolStripMenuItem1.Text = "Adauga";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // modificaToolStripMenuItem1
            // 
            this.modificaToolStripMenuItem1.Name = "modificaToolStripMenuItem1";
            this.modificaToolStripMenuItem1.Size = new System.Drawing.Size(153, 32);
            this.modificaToolStripMenuItem1.Text = "Modifica";
            this.modificaToolStripMenuItem1.Click += new System.EventHandler(this.modificaToolStripMenuItem1_Click);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(153, 32);
            this.stergeToolStripMenuItem1.Text = "Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
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
            this.meniulAplicatiei.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.meniulAplicatiei.Size = new System.Drawing.Size(4238, 54);
            this.meniulAplicatiei.TabIndex = 1;
            this.meniulAplicatiei.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareBinarToolStripMenuItem,
            this.restaurareBinarToolStripMenuItem,
            this.salvareXMLToolStripMenuItem,
            this.restaurareXMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(77, 50);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.salvareBinarToolStripMenuItem.Text = "Salvare binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare binar";
            this.restaurareBinarToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinarToolStripMenuItem_Click);
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.salvareXMLToolStripMenuItem.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click);
            // 
            // restaurareXMLToolStripMenuItem
            // 
            this.restaurareXMLToolStripMenuItem.Name = "restaurareXMLToolStripMenuItem";
            this.restaurareXMLToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.restaurareXMLToolStripMenuItem.Text = "Restaurare XML";
            this.restaurareXMLToolStripMenuItem.Click += new System.EventHandler(this.restaurareXMLToolStripMenuItem_Click);
            // 
            // utilizatoriToolStripMenuItem
            // 
            this.utilizatoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(102, 50);
            this.utilizatoriToolStripMenuItem.Text = "Utilizatori";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.adaugaToolStripMenuItem.Text = "adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.modificaToolStripMenuItem.Text = "modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.stergeToolStripMenuItem.Text = "sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // despreAplicatieToolStripMenuItem
            // 
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(153, 50);
            this.despreAplicatieToolStripMenuItem.Text = "Despre aplicatie";
            // 
            // tbSelectedUtilizator
            // 
            this.tbSelectedUtilizator.Location = new System.Drawing.Point(348, 596);
            this.tbSelectedUtilizator.Margin = new System.Windows.Forms.Padding(4);
            this.tbSelectedUtilizator.Name = "tbSelectedUtilizator";
            this.tbSelectedUtilizator.Size = new System.Drawing.Size(960, 29);
            this.tbSelectedUtilizator.TabIndex = 2;
            // 
            // lvGrupuri
            // 
            this.lvGrupuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGrupuri,
            this.chDrepturi});
            this.lvGrupuri.HideSelection = false;
            this.lvGrupuri.Location = new System.Drawing.Point(1475, 152);
            this.lvGrupuri.Margin = new System.Windows.Forms.Padding(4);
            this.lvGrupuri.Name = "lvGrupuri";
            this.lvGrupuri.Size = new System.Drawing.Size(378, 254);
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
            this.tvGrupuri.Location = new System.Drawing.Point(162, 640);
            this.tvGrupuri.Margin = new System.Windows.Forms.Padding(4);
            this.tvGrupuri.Name = "tvGrupuri";
            this.tvGrupuri.Size = new System.Drawing.Size(807, 246);
            this.tvGrupuri.TabIndex = 4;
            this.tvGrupuri.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvGrupuri_DragDrop);
            this.tvGrupuri.DragOver += new System.Windows.Forms.DragEventHandler(this.tvGrupuri_DragOver);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nume,
            this.email,
            this.password,
            this.cnp,
            this.dataNastere});
            this.dataGridView1.DataSource = this.utilizatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1045, 674);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1534, 212);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(1045, 948);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(402, 139);
            this.btnSalveaza.TabIndex = 6;
            this.btnSalveaza.Text = "salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 175;
            // 
            // nume
            // 
            this.nume.DataPropertyName = "nume";
            this.nume.HeaderText = "nume";
            this.nume.MinimumWidth = 9;
            this.nume.Name = "nume";
            this.nume.Width = 175;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 9;
            this.email.Name = "email";
            this.email.Width = 175;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 9;
            this.password.Name = "password";
            this.password.Width = 175;
            // 
            // cnp
            // 
            this.cnp.DataPropertyName = "cnp";
            this.cnp.HeaderText = "cnp";
            this.cnp.MinimumWidth = 9;
            this.cnp.Name = "cnp";
            this.cnp.Width = 175;
            // 
            // dataNastere
            // 
            this.dataNastere.DataPropertyName = "data_nastere";
            this.dataNastere.HeaderText = "data_nastere";
            this.dataNastere.MinimumWidth = 9;
            this.dataNastere.Name = "dataNastere";
            this.dataNastere.Width = 175;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2825, 1229);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tvGrupuri);
            this.Controls.Add(this.lvGrupuri);
            this.Controls.Add(this.tbSelectedUtilizator);
            this.Controls.Add(this.lvUtilizatori);
            this.Controls.Add(this.meniulAplicatiei);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuAplicatie.ResumeLayout(false);
            this.meniulAplicatiei.ResumeLayout(false);
            this.meniulAplicatiei.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinarToolStripMenuItem;
        private System.Windows.Forms.TreeView tvGrupuri;
        private System.Windows.Forms.ContextMenuStrip contextMenuAplicatie;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareXMLToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private MyDBDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNastere;
    }
}

