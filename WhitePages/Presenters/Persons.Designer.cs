namespace WhitePages.Presenters
{
    partial class Persons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persons));
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDataDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDataGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.tsmain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbMainPaste = new System.Windows.Forms.ToolStripButton();
            this.sLeft = new System.Windows.Forms.Splitter();
            this.sRight = new System.Windows.Forms.Splitter();
            this.pMain = new System.Windows.Forms.Panel();
            this.personsPane = new WhitePages.Presenters.PersonsPane();
            this.searchPane = new WhitePages.Presenters.SearchPane();
            this.personPane = new WhitePages.Presenters.PersonPane();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddressExplorer = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tsmain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImport
            // 
            this.ofdImport.FileName = "openFileDialog1";
            this.ofdImport.Filter = "Книга Microsoft Excel | *.xls | Книга Microsoft Excel 2003 | *.xlsx | Текстовый ф" +
    "айл с разделителями - запятыми |*.csv";
            this.ofdImport.Title = "Импорт данных их файла";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiView,
            this.tsmiData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileImport,
            this.tsmiFileExport});
            this.tsmiFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "&Файл";
            // 
            // tsmiFileImport
            // 
            this.tsmiFileImport.Enabled = false;
            this.tsmiFileImport.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFileImport.Image")));
            this.tsmiFileImport.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiFileImport.MergeIndex = 0;
            this.tsmiFileImport.Name = "tsmiFileImport";
            this.tsmiFileImport.Size = new System.Drawing.Size(128, 22);
            this.tsmiFileImport.Text = "&Импорт...";
            this.tsmiFileImport.ToolTipText = "Импортировать данные из файла";
            // 
            // tsmiFileExport
            // 
            this.tsmiFileExport.Enabled = false;
            this.tsmiFileExport.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFileExport.Image")));
            this.tsmiFileExport.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiFileExport.MergeIndex = 0;
            this.tsmiFileExport.Name = "tsmiFileExport";
            this.tsmiFileExport.Size = new System.Drawing.Size(128, 22);
            this.tsmiFileExport.Text = "&Экспорт...";
            this.tsmiFileExport.ToolTipText = "Экспортировать данные в файл";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditCopy,
            this.tsmiEditPaste,
            this.toolStripSeparator4,
            this.tsmiEditSelectAll});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(59, 20);
            this.tsmiEdit.Text = "&Правка";
            this.tsmiEdit.Visible = false;
            // 
            // tsmiEditCopy
            // 
            this.tsmiEditCopy.Enabled = false;
            this.tsmiEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditCopy.Image")));
            this.tsmiEditCopy.Name = "tsmiEditCopy";
            this.tsmiEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiEditCopy.Size = new System.Drawing.Size(190, 22);
            this.tsmiEditCopy.Text = "&Копировать";
            this.tsmiEditCopy.ToolTipText = "Копировать выделенные записи в буфер обмена";
            // 
            // tsmiEditPaste
            // 
            this.tsmiEditPaste.Enabled = false;
            this.tsmiEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditPaste.Image")));
            this.tsmiEditPaste.Name = "tsmiEditPaste";
            this.tsmiEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiEditPaste.Size = new System.Drawing.Size(190, 22);
            this.tsmiEditPaste.Text = "&Вставить";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmiEditSelectAll
            // 
            this.tsmiEditSelectAll.Enabled = false;
            this.tsmiEditSelectAll.Name = "tsmiEditSelectAll";
            this.tsmiEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiEditSelectAll.Size = new System.Drawing.Size(190, 22);
            this.tsmiEditSelectAll.Text = "Выделить в&се";
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewRefresh});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(39, 20);
            this.tsmiView.Text = "&Вид";
            this.tsmiView.Visible = false;
            // 
            // tsmiViewRefresh
            // 
            this.tsmiViewRefresh.Enabled = false;
            this.tsmiViewRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewRefresh.Image")));
            this.tsmiViewRefresh.Name = "tsmiViewRefresh";
            this.tsmiViewRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiViewRefresh.Size = new System.Drawing.Size(147, 22);
            this.tsmiViewRefresh.Text = "&Обновить";
            this.tsmiViewRefresh.ToolTipText = "Загрузить данные из базы данных заново (результаты поиска, если выполнялся, будут" +
    " сброшены)";
            // 
            // tsmiData
            // 
            this.tsmiData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDataDelete,
            this.toolStripSeparator8,
            this.tsmiDataGenerate});
            this.tsmiData.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.tsmiData.Name = "tsmiData";
            this.tsmiData.Size = new System.Drawing.Size(62, 20);
            this.tsmiData.Text = "&Данные";
            this.tsmiData.Visible = false;
            // 
            // tsmiDataDelete
            // 
            this.tsmiDataDelete.Enabled = false;
            this.tsmiDataDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDataDelete.Image")));
            this.tsmiDataDelete.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiDataDelete.MergeIndex = 0;
            this.tsmiDataDelete.Name = "tsmiDataDelete";
            this.tsmiDataDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmiDataDelete.Size = new System.Drawing.Size(169, 22);
            this.tsmiDataDelete.Text = "&Удалить";
            this.tsmiDataDelete.ToolTipText = "Удалить выделенные записи";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator8.MergeIndex = 0;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(166, 6);
            // 
            // tsmiDataGenerate
            // 
            this.tsmiDataGenerate.Name = "tsmiDataGenerate";
            this.tsmiDataGenerate.Size = new System.Drawing.Size(169, 22);
            this.tsmiDataGenerate.Text = "&Генерировать";
            this.tsmiDataGenerate.ToolTipText = "Гереировать случайные данные";
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "txt";
            this.sfdExport.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            this.sfdExport.Title = "Экспорт данных";
            // 
            // tsmain
            // 
            this.tsmain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsbImport,
            this.tsbExport,
            this.tsbMainPaste,
            this.toolStripSeparator1,
            this.tsbAddressExplorer});
            this.tsmain.Location = new System.Drawing.Point(0, 0);
            this.tsmain.Name = "tsmain";
            this.tsmain.Size = new System.Drawing.Size(786, 25);
            this.tsmain.TabIndex = 10;
            this.tsmain.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Enabled = false;
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(23, 22);
            this.tsbImport.Text = "Импорт...";
            this.tsbImport.ToolTipText = "Импортировать данные из файла";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Enabled = false;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "Экспорт";
            this.tsbExport.ToolTipText = "Экспортировать данные в файл";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbMainPaste
            // 
            this.tsbMainPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMainPaste.Image = global::WhitePages.Properties.Resources.clipboard_past_icon_16;
            this.tsbMainPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMainPaste.Name = "tsbMainPaste";
            this.tsbMainPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbMainPaste.Text = "Вставить";
            this.tsbMainPaste.ToolTipText = "Попытаться вставить данные из буфера обмена";
            this.tsbMainPaste.Click += new System.EventHandler(this.tsbMainPaste_Click);
            // 
            // sLeft
            // 
            this.sLeft.Location = new System.Drawing.Point(200, 0);
            this.sLeft.Name = "sLeft";
            this.sLeft.Size = new System.Drawing.Size(3, 451);
            this.sLeft.TabIndex = 5;
            this.sLeft.TabStop = false;
            // 
            // sRight
            // 
            this.sRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.sRight.Location = new System.Drawing.Point(683, 0);
            this.sRight.Name = "sRight";
            this.sRight.Size = new System.Drawing.Size(3, 451);
            this.sRight.TabIndex = 6;
            this.sRight.TabStop = false;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.personsPane);
            this.pMain.Controls.Add(this.sRight);
            this.pMain.Controls.Add(this.sLeft);
            this.pMain.Controls.Add(this.searchPane);
            this.pMain.Controls.Add(this.personPane);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 25);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(786, 451);
            this.pMain.TabIndex = 9;
            // 
            // personsPane
            // 
            this.personsPane.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.personsPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personsPane.Location = new System.Drawing.Point(203, 0);
            this.personsPane.Name = "personsPane";
            this.personsPane.Size = new System.Drawing.Size(480, 451);
            this.personsPane.TabIndex = 7;
            this.personsPane.PersonsListSelectionChanged += new WhitePages.Presenters.PersonsPane.PersonsListEventHandler(this.Persons_SelectedPersonsListChanged);
            this.personsPane.PersonsDeletionRequested += new WhitePages.Presenters.PersonsPane.PersonsListEventHandler(this.Persons_PersonsDeletionRequested);
            this.personsPane.PersonsRefreshRequested += new WhitePages.Presenters.PersonsPane.PersonsListEventHandler(this.Persons_PersonsRefreshRequested);
            this.personsPane.PersonsPasteRequested += new WhitePages.Presenters.PersonsPane.PersonsListEventHandler(this.Persons_PersonsPasteRequested);
            this.personsPane.PersonsDragDropped += new WhitePages.Presenters.PersonsPane.PersonsListEventHandler(this.Persons_PersonsDragDropped);
            // 
            // searchPane
            // 
            this.searchPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchPane.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPane.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPane.Location = new System.Drawing.Point(686, 0);
            this.searchPane.Name = "searchPane";
            this.searchPane.SearchEnabled = false;
            this.searchPane.Size = new System.Drawing.Size(100, 451);
            this.searchPane.TabIndex = 4;
            // 
            // personPane
            // 
            this.personPane.Dock = System.Windows.Forms.DockStyle.Left;
            this.personPane.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personPane.Location = new System.Drawing.Point(0, 0);
            this.personPane.Name = "personPane";
            this.personPane.Size = new System.Drawing.Size(200, 451);
            this.personPane.TabIndex = 2;
            this.personPane.DeleteRequested += new WhitePages.Presenters.PersonPane.PersonEditingEventHandler(this.personPane_DeleteRequested);
            this.personPane.UpdateRequested += new WhitePages.Presenters.PersonPane.PersonEditingEventHandler(this.personPane_UpdateRequested);
            this.personPane.AddressRequested += new WhitePages.Presenters.PersonPane.PersonEditingEventHandler(this.personPane_AddressRequested);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddressExplorer
            // 
            this.tsbAddressExplorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddressExplorer.Image = global::WhitePages.Properties.Resources.mail_icon_16;
            this.tsbAddressExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddressExplorer.Name = "tsbAddressExplorer";
            this.tsbAddressExplorer.Size = new System.Drawing.Size(23, 22);
            this.tsbAddressExplorer.Text = "Справочник адресов";
            this.tsbAddressExplorer.Click += new System.EventHandler(this.tsbAddressExplorer_Click);
            // 
            // Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.tsmain);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Persons";
            this.Size = new System.Drawing.Size(786, 476);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsmain.ResumeLayout(false);
            this.tsmain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmiData;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSelectAll;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataGenerate;
        private System.Windows.Forms.ToolStrip tsmain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private PersonPane personPane;
        private SearchPane searchPane;
        private System.Windows.Forms.Splitter sLeft;
        private System.Windows.Forms.Splitter sRight;
        private System.Windows.Forms.Panel pMain;
        private PersonsPane personsPane;
        private System.Windows.Forms.ToolStripButton tsbMainPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddressExplorer;
    }
}
