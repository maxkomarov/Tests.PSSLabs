namespace WhitePages.Presenters
{
    partial class AddressExplorer
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressExplorer));
            this.lvAddresses = new System.Windows.Forms.ListView();
            this.chZip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilAddresses = new System.Windows.Forms.ImageList(this.components);
            this.tvAddresses = new System.Windows.Forms.TreeView();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.addressPane = new WhitePages.Presenters.AddressPane();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.newAddressBar1 = new WhitePages.Presenters.NewAddressBar();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAddresses
            // 
            this.lvAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chZip,
            this.chAddress,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAddresses.FullRowSelect = true;
            this.lvAddresses.GridLines = true;
            this.lvAddresses.Location = new System.Drawing.Point(200, 25);
            this.lvAddresses.MultiSelect = false;
            this.lvAddresses.Name = "lvAddresses";
            this.lvAddresses.Size = new System.Drawing.Size(125, 222);
            this.lvAddresses.SmallImageList = this.ilAddresses;
            this.lvAddresses.TabIndex = 0;
            this.lvAddresses.UseCompatibleStateImageBehavior = false;
            this.lvAddresses.View = System.Windows.Forms.View.Details;
            this.lvAddresses.SelectedIndexChanged += new System.EventHandler(this.lvAddresses_SelectedIndexChanged);
            this.lvAddresses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAddresses_MouseDoubleClick);
            // 
            // chZip
            // 
            this.chZip.Text = "Индекс";
            this.chZip.Width = 80;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Объект адреса";
            this.chAddress.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Начальный индекс";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Конечный индекс";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "От дома";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "До дома";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Сторона улицы";
            this.columnHeader7.Width = 100;
            // 
            // ilAddresses
            // 
            this.ilAddresses.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAddresses.ImageStream")));
            this.ilAddresses.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAddresses.Images.SetKeyName(0, "mail_icon&16.png");
            this.ilAddresses.Images.SetKeyName(1, "home_icon&16.png");
            // 
            // tvAddresses
            // 
            this.tvAddresses.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvAddresses.ImageIndex = 0;
            this.tvAddresses.ImageList = this.ilAddresses;
            this.tvAddresses.Location = new System.Drawing.Point(0, 25);
            this.tvAddresses.Name = "tvAddresses";
            this.tvAddresses.SelectedImageIndex = 0;
            this.tvAddresses.Size = new System.Drawing.Size(200, 222);
            this.tvAddresses.TabIndex = 0;
            this.tvAddresses.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAddresses_AfterSelect);
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCopy,
            this.tsbPaste,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbDelete});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(571, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Enabled = false;
            this.tsbCopy.Image = global::WhitePages.Properties.Resources.clipboard_copy_icon_16;
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbCopy.Text = "Копировать ";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = global::WhitePages.Properties.Resources.clipboard_past_icon_16;
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbPaste.Text = "Вставить";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::WhitePages.Properties.Resources.doc_empty_icon_16;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "Создать...";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = global::WhitePages.Properties.Resources.delete_icon_16;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Удалить";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(325, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 222);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // addressPane
            // 
            this.addressPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.addressPane.Location = new System.Drawing.Point(328, 25);
            this.addressPane.Margin = new System.Windows.Forms.Padding(0);
            this.addressPane.MinimumSize = new System.Drawing.Size(243, 284);
            this.addressPane.Name = "addressPane";
            this.addressPane.Size = new System.Drawing.Size(243, 291);
            this.addressPane.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(200, 25);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 222);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // newAddressBar1
            // 
            this.newAddressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newAddressBar1.Location = new System.Drawing.Point(0, 247);
            this.newAddressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.newAddressBar1.MinimumSize = new System.Drawing.Size(0, 69);
            this.newAddressBar1.Name = "newAddressBar1";
            this.newAddressBar1.Size = new System.Drawing.Size(328, 69);
            this.newAddressBar1.TabIndex = 5;
            // 
            // AddressExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.lvAddresses);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tvAddresses);
            this.Controls.Add(this.newAddressBar1);
            this.Controls.Add(this.addressPane);
            this.Controls.Add(this.tsMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddressExplorer";
            this.Size = new System.Drawing.Size(571, 316);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvAddresses;
        private System.Windows.Forms.TreeView tvAddresses;
        private System.Windows.Forms.ImageList ilAddresses;
        private System.Windows.Forms.ColumnHeader chZip;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Splitter splitter1;
        private AddressPane addressPane;
        private System.Windows.Forms.Splitter splitter2;
        private NewAddressBar newAddressBar1;
    }
}
