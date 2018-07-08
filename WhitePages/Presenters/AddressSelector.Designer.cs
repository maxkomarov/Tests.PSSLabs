namespace WhitePages.Presenters
{
    partial class AddressSelector
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
            this.lvAddresses = new System.Windows.Forms.ListView();
            this.chZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsSearch = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbZipCode = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchByZip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbAddress = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchByAddress = new System.Windows.Forms.ToolStripButton();
            this.pSearch = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addressExplorer = new WhitePages.Presenters.AddressExplorer();
            this.tsSearch.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAddresses
            // 
            this.lvAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chZipCode,
            this.chAddress});
            this.lvAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAddresses.FullRowSelect = true;
            this.lvAddresses.GridLines = true;
            this.lvAddresses.Location = new System.Drawing.Point(0, 25);
            this.lvAddresses.MultiSelect = false;
            this.lvAddresses.Name = "lvAddresses";
            this.lvAddresses.Size = new System.Drawing.Size(631, 265);
            this.lvAddresses.TabIndex = 1;
            this.lvAddresses.UseCompatibleStateImageBehavior = false;
            this.lvAddresses.View = System.Windows.Forms.View.Details;
            this.lvAddresses.SelectedIndexChanged += new System.EventHandler(this.lvAddresses_SelectedIndexChanged);
            this.lvAddresses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAddresses_MouseDoubleClick);
            // 
            // chZipCode
            // 
            this.chZipCode.Text = "Индекс";
            this.chZipCode.Width = 100;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Адрес";
            this.chAddress.Width = 800;
            // 
            // tsSearch
            // 
            this.tsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbZipCode,
            this.tsbSearchByZip,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbAddress,
            this.tsbSearchByAddress});
            this.tsSearch.Location = new System.Drawing.Point(0, 0);
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(631, 25);
            this.tsSearch.TabIndex = 2;
            this.tsSearch.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel2.Text = "Поиск";
            // 
            // tbZipCode
            // 
            this.tbZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(100, 25);
            this.tbZipCode.TextChanged += new System.EventHandler(this.tsbZip_TextChanged);
            // 
            // tsbSearchByZip
            // 
            this.tsbSearchByZip.Enabled = false;
            this.tsbSearchByZip.Image = global::WhitePages.Properties.Resources.zoom_icon_16;
            this.tsbSearchByZip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchByZip.Name = "tsbSearchByZip";
            this.tsbSearchByZip.Size = new System.Drawing.Size(88, 22);
            this.tsbSearchByZip.Text = "по индексу";
            this.tsbSearchByZip.Click += new System.EventHandler(this.tsbSearchByZip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel1.Text = "или";
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 25);
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tsbSearchByAddress
            // 
            this.tsbSearchByAddress.Enabled = false;
            this.tsbSearchByAddress.Image = global::WhitePages.Properties.Resources.zoom_icon_16;
            this.tsbSearchByAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchByAddress.Name = "tsbSearchByAddress";
            this.tsbSearchByAddress.Size = new System.Drawing.Size(115, 22);
            this.tsbSearchByAddress.Text = "по части адреса";
            this.tsbSearchByAddress.Click += new System.EventHandler(this.tsbSearchByAddress_Click);
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.lvAddresses);
            this.pSearch.Controls.Add(this.tsSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(3, 3);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(631, 290);
            this.pSearch.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 322);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addressExplorer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проводник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addressExplorer
            // 
            this.addressExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressExplorer.Location = new System.Drawing.Point(3, 3);
            this.addressExplorer.Margin = new System.Windows.Forms.Padding(0);
            this.addressExplorer.Name = "addressExplorer";
            this.addressExplorer.Size = new System.Drawing.Size(631, 290);
            this.addressExplorer.TabIndex = 0;
            // 
            // AddressSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 322);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddressSelector";
            this.Text = "Выберите адрес";
            this.tsSearch.ResumeLayout(false);
            this.tsSearch.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvAddresses;
        private System.Windows.Forms.ColumnHeader chZipCode;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ToolStrip tsSearch;
        private System.Windows.Forms.ToolStripTextBox tbZipCode;
        private System.Windows.Forms.ToolStripButton tsbSearchByZip;
        private System.Windows.Forms.ToolStripTextBox tbAddress;
        private System.Windows.Forms.ToolStripButton tsbSearchByAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AddressExplorer addressExplorer;
    }
}