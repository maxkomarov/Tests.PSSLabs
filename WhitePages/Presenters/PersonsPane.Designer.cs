namespace WhitePages.Presenters
{
    partial class PersonsPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonsPane));
            this.tsmain = new System.Windows.Forms.ToolStrip();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsPager = new System.Windows.Forms.ToolStrip();
            this.tsbGoFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbGoPrev = new System.Windows.Forms.ToolStripButton();
            this.tslWindowSizeBefore = new System.Windows.Forms.ToolStripLabel();
            this.tscbWindowSize = new System.Windows.Forms.ToolStripComboBox();
            this.tslWindowSizeAfter = new System.Windows.Forms.ToolStripLabel();
            this.tslPagerPosition = new System.Windows.Forms.ToolStripLabel();
            this.tsbGoNext = new System.Windows.Forms.ToolStripButton();
            this.tsbGoLast = new System.Windows.Forms.ToolStripButton();
            this.tspbLoading = new System.Windows.Forms.ToolStripProgressBar();
            this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ilPersons = new System.Windows.Forms.ImageList(this.components);
            this.tLoading = new System.Windows.Forms.Timer(this.components);
            this.lvPersons = new WhitePages.UI.Controls.ListViewExtended();
            this.chSurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsmain.SuspendLayout();
            this.tsPager.SuspendLayout();
            this.cmsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmain
            // 
            this.tsmain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsmain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCopy,
            this.toolStripSeparator1,
            this.tsbDelete2,
            this.toolStripSeparator5,
            this.tsbRefresh});
            this.tsmain.Location = new System.Drawing.Point(0, 0);
            this.tsmain.Name = "tsmain";
            this.tsmain.Size = new System.Drawing.Size(32, 370);
            this.tsmain.TabIndex = 5;
            this.tsmain.Text = "toolStrip1";
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Enabled = false;
            this.tsbCopy.Image = global::WhitePages.Properties.Resources.clipboard_copy_icon_16;
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(29, 20);
            this.tsbCopy.Text = "Копировать";
            this.tsbCopy.ToolTipText = "Копировать выделленые записи в буфер обмена";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(29, 6);
            // 
            // tsbDelete2
            // 
            this.tsbDelete2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete2.Enabled = false;
            this.tsbDelete2.Image = global::WhitePages.Properties.Resources.delete_icon_16;
            this.tsbDelete2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete2.Name = "tsbDelete2";
            this.tsbDelete2.Size = new System.Drawing.Size(29, 20);
            this.tsbDelete2.Text = "Удалить";
            this.tsbDelete2.ToolTipText = "Удалить выделенные записи";
            this.tsbDelete2.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(29, 6);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Enabled = false;
            this.tsbRefresh.Image = global::WhitePages.Properties.Resources.refresh_icon_16;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(29, 20);
            this.tsbRefresh.Text = "Обновить";
            this.tsbRefresh.ToolTipText = "Загрузить данные";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsPager
            // 
            this.tsPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsPager.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGoFirst,
            this.tsbGoPrev,
            this.tslWindowSizeBefore,
            this.tscbWindowSize,
            this.tslWindowSizeAfter,
            this.tslPagerPosition,
            this.tsbGoNext,
            this.tsbGoLast,
            this.tspbLoading});
            this.tsPager.Location = new System.Drawing.Point(32, 345);
            this.tsPager.Name = "tsPager";
            this.tsPager.Size = new System.Drawing.Size(737, 25);
            this.tsPager.TabIndex = 7;
            this.tsPager.Text = "toolStrip2";
            // 
            // tsbGoFirst
            // 
            this.tsbGoFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbGoFirst.Image")));
            this.tsbGoFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoFirst.Name = "tsbGoFirst";
            this.tsbGoFirst.Size = new System.Drawing.Size(23, 22);
            this.tsbGoFirst.Text = "К первой";
            this.tsbGoFirst.ToolTipText = "Перейти к первой записи";
            this.tsbGoFirst.Click += new System.EventHandler(this.tsbGoFirst_Click);
            // 
            // tsbGoPrev
            // 
            this.tsbGoPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbGoPrev.Image")));
            this.tsbGoPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoPrev.Name = "tsbGoPrev";
            this.tsbGoPrev.Size = new System.Drawing.Size(23, 22);
            this.tsbGoPrev.Text = "Предыдущая";
            this.tsbGoPrev.ToolTipText = "Перейти на предыдущую страницу";
            this.tsbGoPrev.Click += new System.EventHandler(this.tsbGoPrev_Click);
            // 
            // tslWindowSizeBefore
            // 
            this.tslWindowSizeBefore.Name = "tslWindowSizeBefore";
            this.tslWindowSizeBefore.Size = new System.Drawing.Size(94, 22);
            this.tslWindowSizeBefore.Text = "Отображать по:";
            // 
            // tscbWindowSize
            // 
            this.tscbWindowSize.AutoSize = false;
            this.tscbWindowSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbWindowSize.DropDownWidth = 25;
            this.tscbWindowSize.Items.AddRange(new object[] {
            "10",
            "100",
            "200",
            "25",
            "300",
            "50"});
            this.tscbWindowSize.Name = "tscbWindowSize";
            this.tscbWindowSize.Size = new System.Drawing.Size(40, 23);
            this.tscbWindowSize.Sorted = true;
            this.tscbWindowSize.SelectedIndexChanged += new System.EventHandler(this.tscbWindowSize_SelectedIndexChanged);
            // 
            // tslWindowSizeAfter
            // 
            this.tslWindowSizeAfter.Name = "tslWindowSizeAfter";
            this.tslWindowSizeAfter.Size = new System.Drawing.Size(153, 22);
            this.tslWindowSizeAfter.Text = " записей. Текущая позиия:";
            // 
            // tslPagerPosition
            // 
            this.tslPagerPosition.Name = "tslPagerPosition";
            this.tslPagerPosition.Size = new System.Drawing.Size(24, 22);
            this.tslPagerPosition.Text = "0/0";
            // 
            // tsbGoNext
            // 
            this.tsbGoNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbGoNext.Image")));
            this.tsbGoNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoNext.Name = "tsbGoNext";
            this.tsbGoNext.Size = new System.Drawing.Size(23, 22);
            this.tsbGoNext.Text = "Следующая";
            this.tsbGoNext.ToolTipText = "Перейти на следующую страницу";
            this.tsbGoNext.Click += new System.EventHandler(this.tsbGoNext_Click);
            // 
            // tsbGoLast
            // 
            this.tsbGoLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbGoLast.Image")));
            this.tsbGoLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoLast.Name = "tsbGoLast";
            this.tsbGoLast.Size = new System.Drawing.Size(23, 22);
            this.tsbGoLast.Text = "Последняя";
            this.tsbGoLast.ToolTipText = "Перейти к последней странице";
            this.tsbGoLast.Click += new System.EventHandler(this.tsbGoLast_Click);
            // 
            // tspbLoading
            // 
            this.tspbLoading.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspbLoading.Name = "tspbLoading";
            this.tspbLoading.Size = new System.Drawing.Size(200, 22);
            this.tspbLoading.Visible = false;
            // 
            // cmsList
            // 
            this.cmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy,
            this.tsmiPaste,
            this.toolStripSeparator2,
            this.tsmiSelectAll,
            this.toolStripSeparator4,
            this.tsmiDelete,
            this.toolStripSeparator6,
            this.tsmiRefresh});
            this.cmsList.Name = "cmsList";
            this.cmsList.Size = new System.Drawing.Size(191, 132);
            this.cmsList.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPersons_Opening);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Enabled = false;
            this.tsmiCopy.Image = global::WhitePages.Properties.Resources.clipboard_copy_icon_16;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(190, 22);
            this.tsmiCopy.Text = "&Копировать";
            this.tsmiCopy.ToolTipText = "Копировать выделенные записи в буфер обмена";
            this.tsmiCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Enabled = false;
            this.tsmiPaste.Image = global::WhitePages.Properties.Resources.clipboard_past_icon_16;
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(190, 22);
            this.tsmiPaste.Text = "&Вставить";
            this.tsmiPaste.ToolTipText = "Пытаться импортировать данные из буфера обмена";
            this.tsmiPaste.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Enabled = false;
            this.tsmiSelectAll.Image = global::WhitePages.Properties.Resources.checkmark_icon_16;
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(190, 22);
            this.tsmiSelectAll.Text = "Выделить в&се";
            this.tsmiSelectAll.ToolTipText = "Выделить все загруженные записи";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Enabled = false;
            this.tsmiDelete.Image = global::WhitePages.Properties.Resources.delete_icon_16;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmiDelete.Size = new System.Drawing.Size(190, 22);
            this.tsmiDelete.Text = "У&далить";
            this.tsmiDelete.ToolTipText = "Удалить выделенные записи";
            this.tsmiDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Enabled = false;
            this.tsmiRefresh.Image = global::WhitePages.Properties.Resources.refresh_icon_16;
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiRefresh.Size = new System.Drawing.Size(190, 22);
            this.tsmiRefresh.Text = "&Обновить";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // ilPersons
            // 
            this.ilPersons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPersons.ImageStream")));
            this.ilPersons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPersons.Images.SetKeyName(0, "user_icon&16-32.png");
            // 
            // lvPersons
            // 
            this.lvPersons.AllowColumnReorder = true;
            this.lvPersons.AllowDrop = true;
            this.lvPersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSurName,
            this.chPhoneNumber,
            this.chBirthDate,
            this.chAddress});
            this.lvPersons.ContextMenuStrip = this.cmsList;
            this.lvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPersons.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvPersons.FullRowSelect = true;
            this.lvPersons.GridLines = true;
            this.lvPersons.HideSelection = false;
            this.lvPersons.Location = new System.Drawing.Point(32, 0);
            this.lvPersons.Name = "lvPersons";
            this.lvPersons.Size = new System.Drawing.Size(737, 345);
            this.lvPersons.SmallImageList = this.ilPersons;
            this.lvPersons.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPersons.TabIndex = 8;
            this.lvPersons.UseCompatibleStateImageBehavior = false;
            this.lvPersons.View = System.Windows.Forms.View.Details;
            this.lvPersons.SelectedIndexChanged += new System.EventHandler(this.lvPersons_SelectedIndexChanged);
            this.lvPersons.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvPersons_DragDrop);
            this.lvPersons.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvPersons_DragEnter);
            this.lvPersons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPersons_MouseDoubleClick);
            this.lvPersons.Resize += new System.EventHandler(this.lvPersons_Resize);
            // 
            // chSurName
            // 
            this.chSurName.Text = "Фамилия";
            this.chSurName.Width = 250;
            // 
            // chPhoneNumber
            // 
            this.chPhoneNumber.Text = "Телефон";
            this.chPhoneNumber.Width = 112;
            // 
            // chBirthDate
            // 
            this.chBirthDate.Text = "Дата рождения";
            this.chBirthDate.Width = 100;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Адрес";
            this.chAddress.Width = 500;
            // 
            // PersonsPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPersons);
            this.Controls.Add(this.tsPager);
            this.Controls.Add(this.tsmain);
            this.Name = "PersonsPane";
            this.Size = new System.Drawing.Size(769, 370);
            this.tsmain.ResumeLayout(false);
            this.tsmain.PerformLayout();
            this.tsPager.ResumeLayout(false);
            this.tsPager.PerformLayout();
            this.cmsList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsmain;
        private System.Windows.Forms.ToolStrip tsPager;
        private System.Windows.Forms.ToolStripButton tsbGoFirst;
        private System.Windows.Forms.ToolStripButton tsbGoPrev;
        private System.Windows.Forms.ToolStripLabel tslWindowSizeBefore;
        private System.Windows.Forms.ToolStripComboBox tscbWindowSize;
        private System.Windows.Forms.ToolStripLabel tslWindowSizeAfter;
        private System.Windows.Forms.ToolStripLabel tslPagerPosition;
        private System.Windows.Forms.ToolStripButton tsbGoNext;
        private System.Windows.Forms.ToolStripButton tsbGoLast;
        private UI.Controls.ListViewExtended lvPersons;
        private System.Windows.Forms.ColumnHeader chSurName;
        private System.Windows.Forms.ColumnHeader chPhoneNumber;
        private System.Windows.Forms.ColumnHeader chBirthDate;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ImageList ilPersons;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDelete2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ContextMenuStrip cmsList;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripProgressBar tspbLoading;
        private System.Windows.Forms.Timer tLoading;
    }
}
