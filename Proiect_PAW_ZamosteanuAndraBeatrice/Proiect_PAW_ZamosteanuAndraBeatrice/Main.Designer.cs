namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seeOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOperation = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.lvAcc = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Iban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detinator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Moneda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataDeschiderii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deschis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Proiect_PAW_ZamosteanuAndraBeatrice.Database1DataSet();
            this.conturiTableAdapter = new Proiect_PAW_ZamosteanuAndraBeatrice.Database1DataSetTableAdapters.ConturiTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.printToolStripMenuItem,
            this.seeOperationsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(954, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.addAccountToolStripMenuItem.Text = "Adauga Cont";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.AddAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem1});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.PrintToolStripMenuItem1_Click);
            // 
            // seeOperationsToolStripMenuItem
            // 
            this.seeOperationsToolStripMenuItem.Name = "seeOperationsToolStripMenuItem";
            this.seeOperationsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.seeOperationsToolStripMenuItem.Text = "Vezi operatii";
            this.seeOperationsToolStripMenuItem.Click += new System.EventHandler(this.SeeOperationsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btOperation);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.lvAcc);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conturi";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btOperation
            // 
            this.btOperation.Location = new System.Drawing.Point(547, 336);
            this.btOperation.Name = "btOperation";
            this.btOperation.Size = new System.Drawing.Size(137, 29);
            this.btOperation.TabIndex = 3;
            this.btOperation.Text = "Adauga Operatie";
            this.btOperation.UseVisualStyleBackColor = true;
            this.btOperation.Click += new System.EventHandler(this.BtOperation_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(278, 336);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(146, 29);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "&Stergere Cont";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(78, 336);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(111, 29);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Edit Cont";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // lvAcc
            // 
            this.lvAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAcc.BackColor = System.Drawing.Color.White;
            this.lvAcc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Iban,
            this.Detinator,
            this.Moneda,
            this.DataDeschiderii,
            this.Suma,
            this.Deschis});
            this.lvAcc.FullRowSelect = true;
            this.lvAcc.GridLines = true;
            this.lvAcc.HideSelection = false;
            this.lvAcc.Location = new System.Drawing.Point(25, 37);
            this.lvAcc.MultiSelect = false;
            this.lvAcc.Name = "lvAcc";
            this.lvAcc.Size = new System.Drawing.Size(768, 293);
            this.lvAcc.TabIndex = 0;
            this.lvAcc.Tag = "";
            this.lvAcc.UseCompatibleStateImageBehavior = false;
            this.lvAcc.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Tag = "id";
            this.Id.Text = "Id";
            // 
            // Iban
            // 
            this.Iban.Text = "Iban";
            this.Iban.Width = 111;
            // 
            // Detinator
            // 
            this.Detinator.Text = "Detinator";
            this.Detinator.Width = 113;
            // 
            // Moneda
            // 
            this.Moneda.Text = "Moneda";
            this.Moneda.Width = 92;
            // 
            // DataDeschiderii
            // 
            this.DataDeschiderii.Text = "Data deschiderii";
            this.DataDeschiderii.Width = 70;
            // 
            // Suma
            // 
            this.Suma.Text = "Suma";
            this.Suma.Width = 137;
            // 
            // Deschis
            // 
            this.Deschis.Text = "Deschis";
            // 
            // conturiBindingSource
            // 
            this.conturiBindingSource.DataMember = "Conturi";
            this.conturiBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conturiTableAdapter
            // 
            this.conturiTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOperation;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ColumnHeader Iban;
        private System.Windows.Forms.ColumnHeader Detinator;
        private System.Windows.Forms.ColumnHeader Moneda;
        private System.Windows.Forms.ColumnHeader DataDeschiderii;
        private System.Windows.Forms.ColumnHeader Suma;
        public System.Windows.Forms.ListView lvAcc;
        private System.Windows.Forms.ColumnHeader Id;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource conturiBindingSource;
        private Database1DataSetTableAdapters.ConturiTableAdapter conturiTableAdapter;
        private System.Windows.Forms.ColumnHeader Deschis;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem seeOperationsToolStripMenuItem;
    }
}