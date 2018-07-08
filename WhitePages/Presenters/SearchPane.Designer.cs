namespace WhitePages.Presenters
{
    partial class SearchPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPane));
            this.tsSearch = new System.Windows.Forms.ToolStrip();
            this.tsbShowSearchPane = new System.Windows.Forms.ToolStripButton();
            this.pSearch = new System.Windows.Forms.Panel();
            this.tsSearchCommand = new System.Windows.Forms.ToolStrip();
            this.tsbSearchRun = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClear = new System.Windows.Forms.ToolStripButton();
            this.cbSubsearch = new System.Windows.Forms.CheckBox();
            this.pAddress2 = new System.Windows.Forms.Panel();
            this.gbAddressExt = new System.Windows.Forms.GroupBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.Panel();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.pPhoneNumber = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.pBirthDate = new System.Windows.Forms.Panel();
            this.gbBirthDate = new System.Windows.Forms.GroupBox();
            this.cbBirthDate = new System.Windows.Forms.CheckBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.pGivenName = new System.Windows.Forms.Panel();
            this.gbGivenName = new System.Windows.Forms.GroupBox();
            this.tbGivenName = new System.Windows.Forms.TextBox();
            this.pFirstName = new System.Windows.Forms.Panel();
            this.gbFirstName = new System.Windows.Forms.GroupBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pSurName = new System.Windows.Forms.Panel();
            this.gbSurName = new System.Windows.Forms.GroupBox();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lHeader = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tsSearch.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.tsSearchCommand.SuspendLayout();
            this.pAddress2.SuspendLayout();
            this.gbAddressExt.SuspendLayout();
            this.pAddress.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.pPhoneNumber.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pBirthDate.SuspendLayout();
            this.gbBirthDate.SuspendLayout();
            this.pGivenName.SuspendLayout();
            this.gbGivenName.SuspendLayout();
            this.pFirstName.SuspendLayout();
            this.gbFirstName.SuspendLayout();
            this.pSurName.SuspendLayout();
            this.gbSurName.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSearch
            // 
            this.tsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbShowSearchPane});
            this.tsSearch.Location = new System.Drawing.Point(219, 0);
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(24, 509);
            this.tsSearch.TabIndex = 0;
            this.tsSearch.Text = "toolStrip1";
            // 
            // tsbShowSearchPane
            // 
            this.tsbShowSearchPane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowSearchPane.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowSearchPane.Image")));
            this.tsbShowSearchPane.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowSearchPane.Name = "tsbShowSearchPane";
            this.tsbShowSearchPane.Size = new System.Drawing.Size(21, 20);
            this.tsbShowSearchPane.Text = "Поиск";
            this.tsbShowSearchPane.ToolTipText = "Показать/скрыть панель поиска";
            this.tsbShowSearchPane.Click += new System.EventHandler(this.tsbShowSearchPane_Click);
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.tsSearchCommand);
            this.pSearch.Controls.Add(this.cbSubsearch);
            this.pSearch.Controls.Add(this.pAddress2);
            this.pSearch.Controls.Add(this.pAddress);
            this.pSearch.Controls.Add(this.pPhoneNumber);
            this.pSearch.Controls.Add(this.pBirthDate);
            this.pSearch.Controls.Add(this.pGivenName);
            this.pSearch.Controls.Add(this.pFirstName);
            this.pSearch.Controls.Add(this.pSurName);
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Controls.Add(this.pHeader);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pSearch.Size = new System.Drawing.Size(219, 509);
            this.pSearch.TabIndex = 1;
            this.pSearch.Visible = false;
            this.pSearch.VisibleChanged += new System.EventHandler(this.pSearch_VisibleChanged);
            // 
            // tsSearchCommand
            // 
            this.tsSearchCommand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSearchCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearchRun,
            this.tsbSearchClear});
            this.tsSearchCommand.Location = new System.Drawing.Point(4, 433);
            this.tsSearchCommand.Name = "tsSearchCommand";
            this.tsSearchCommand.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.tsSearchCommand.Size = new System.Drawing.Size(211, 25);
            this.tsSearchCommand.TabIndex = 8;
            this.tsSearchCommand.Text = "toolStrip1";
            // 
            // tsbSearchRun
            // 
            this.tsbSearchRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchRun.Enabled = false;
            this.tsbSearchRun.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchRun.Image")));
            this.tsbSearchRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchRun.Name = "tsbSearchRun";
            this.tsbSearchRun.Size = new System.Drawing.Size(23, 22);
            this.tsbSearchRun.Text = "Искать";
            this.tsbSearchRun.ToolTipText = "Выполнить поиск спо указанным условиям";
            this.tsbSearchRun.Click += new System.EventHandler(this.tsbSearchRun_Click);
            // 
            // tsbSearchClear
            // 
            this.tsbSearchClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchClear.Enabled = false;
            this.tsbSearchClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchClear.Image")));
            this.tsbSearchClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchClear.Name = "tsbSearchClear";
            this.tsbSearchClear.Size = new System.Drawing.Size(23, 22);
            this.tsbSearchClear.Text = "Очистить";
            this.tsbSearchClear.ToolTipText = "Очистить условия поиска";
            this.tsbSearchClear.Click += new System.EventHandler(this.tsbSearchClear_Click);
            // 
            // cbSubsearch
            // 
            this.cbSubsearch.AutoSize = true;
            this.cbSubsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSubsearch.Location = new System.Drawing.Point(4, 401);
            this.cbSubsearch.Name = "cbSubsearch";
            this.cbSubsearch.Padding = new System.Windows.Forms.Padding(10, 5, 0, 10);
            this.cbSubsearch.Size = new System.Drawing.Size(211, 32);
            this.cbSubsearch.TabIndex = 9;
            this.cbSubsearch.Text = "Искать в найденном";
            this.toolTip1.SetToolTip(this.cbSubsearch, "Поиск выполняется только в уже отображаемых записях");
            this.cbSubsearch.UseVisualStyleBackColor = true;
            this.cbSubsearch.CheckedChanged += new System.EventHandler(this.cbSubsearch_CheckedChanged);
            // 
            // pAddress2
            // 
            this.pAddress2.Controls.Add(this.gbAddressExt);
            this.pAddress2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAddress2.Location = new System.Drawing.Point(4, 350);
            this.pAddress2.Name = "pAddress2";
            this.pAddress2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pAddress2.Size = new System.Drawing.Size(211, 51);
            this.pAddress2.TabIndex = 7;
            // 
            // gbAddressExt
            // 
            this.gbAddressExt.Controls.Add(this.tbAddress2);
            this.gbAddressExt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddressExt.Location = new System.Drawing.Point(0, 5);
            this.gbAddressExt.Name = "gbAddressExt";
            this.gbAddressExt.Size = new System.Drawing.Size(211, 46);
            this.gbAddressExt.TabIndex = 4;
            this.gbAddressExt.TabStop = false;
            this.gbAddressExt.Text = "В доп.адресе (дом, кв-ра)";
            // 
            // tbAddress2
            // 
            this.tbAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress2.Location = new System.Drawing.Point(7, 19);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(198, 22);
            this.tbAddress2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbAddress2, "Введите искомую строку для поиска в дополнительном поле адреса (номер дома или кв" +
        "артиры)");
            this.tbAddress2.TextChanged += new System.EventHandler(this.tbSurName_TextChanged);
            // 
            // pAddress
            // 
            this.pAddress.Controls.Add(this.gbAddress);
            this.pAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAddress.Location = new System.Drawing.Point(4, 299);
            this.pAddress.Name = "pAddress";
            this.pAddress.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pAddress.Size = new System.Drawing.Size(211, 51);
            this.pAddress.TabIndex = 6;
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.tbAddress);
            this.gbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddress.Location = new System.Drawing.Point(0, 5);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(211, 46);
            this.gbAddress.TabIndex = 4;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "В адресе (до улицы вкл.)";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(7, 19);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(198, 22);
            this.tbAddress.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbAddress, "Введите часть или название города/области/района,населенного пункта или улицы пол" +
        "ностью, начиная с начала");
            this.tbAddress.TextChanged += new System.EventHandler(this.tbSurName_TextChanged);
            // 
            // pPhoneNumber
            // 
            this.pPhoneNumber.Controls.Add(this.groupBox4);
            this.pPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPhoneNumber.Location = new System.Drawing.Point(4, 248);
            this.pPhoneNumber.Name = "pPhoneNumber";
            this.pPhoneNumber.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pPhoneNumber.Size = new System.Drawing.Size(211, 51);
            this.pPhoneNumber.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mtbPhoneNumber);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 46);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "По номеру телефона";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(7, 19);
            this.mtbPhoneNumber.Mask = "(999) 000-00-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(206, 22);
            this.mtbPhoneNumber.TabIndex = 4;
            this.mtbPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.mtbPhoneNumber, "Введите часть или номер полностью, начиная слева");
            this.mtbPhoneNumber.TextChanged += new System.EventHandler(this.tbSurName_TextChanged);
            // 
            // pBirthDate
            // 
            this.pBirthDate.Controls.Add(this.gbBirthDate);
            this.pBirthDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBirthDate.Location = new System.Drawing.Point(4, 197);
            this.pBirthDate.Name = "pBirthDate";
            this.pBirthDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pBirthDate.Size = new System.Drawing.Size(211, 51);
            this.pBirthDate.TabIndex = 4;
            // 
            // gbBirthDate
            // 
            this.gbBirthDate.Controls.Add(this.cbBirthDate);
            this.gbBirthDate.Controls.Add(this.dtpBirthDate);
            this.gbBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBirthDate.Location = new System.Drawing.Point(0, 5);
            this.gbBirthDate.Name = "gbBirthDate";
            this.gbBirthDate.Size = new System.Drawing.Size(211, 46);
            this.gbBirthDate.TabIndex = 4;
            this.gbBirthDate.TabStop = false;
            // 
            // cbBirthDate
            // 
            this.cbBirthDate.AutoSize = true;
            this.cbBirthDate.Location = new System.Drawing.Point(10, 0);
            this.cbBirthDate.Name = "cbBirthDate";
            this.cbBirthDate.Size = new System.Drawing.Size(125, 17);
            this.cbBirthDate.TabIndex = 0;
            this.cbBirthDate.Text = "По дате рождения";
            this.cbBirthDate.UseVisualStyleBackColor = true;
            this.cbBirthDate.CheckedChanged += new System.EventHandler(this.cbBirthDate_CheckedChanged);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Enabled = false;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(10, 18);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(203, 22);
            this.dtpBirthDate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dtpBirthDate, "Введите дату рождения");
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // pGivenName
            // 
            this.pGivenName.Controls.Add(this.gbGivenName);
            this.pGivenName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGivenName.Location = new System.Drawing.Point(4, 146);
            this.pGivenName.Name = "pGivenName";
            this.pGivenName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pGivenName.Size = new System.Drawing.Size(211, 51);
            this.pGivenName.TabIndex = 3;
            // 
            // gbGivenName
            // 
            this.gbGivenName.Controls.Add(this.tbGivenName);
            this.gbGivenName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGivenName.Location = new System.Drawing.Point(0, 5);
            this.gbGivenName.Name = "gbGivenName";
            this.gbGivenName.Size = new System.Drawing.Size(211, 46);
            this.gbGivenName.TabIndex = 4;
            this.gbGivenName.TabStop = false;
            this.gbGivenName.Text = "В отчестве";
            // 
            // tbGivenName
            // 
            this.tbGivenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGivenName.Location = new System.Drawing.Point(7, 19);
            this.tbGivenName.Name = "tbGivenName";
            this.tbGivenName.Size = new System.Drawing.Size(198, 22);
            this.tbGivenName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbGivenName, "Введите часть или отчество полностью, начиная с начала");
            this.tbGivenName.TextChanged += new System.EventHandler(this.tbSurName_TextChanged);
            // 
            // pFirstName
            // 
            this.pFirstName.Controls.Add(this.gbFirstName);
            this.pFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFirstName.Location = new System.Drawing.Point(4, 95);
            this.pFirstName.Name = "pFirstName";
            this.pFirstName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pFirstName.Size = new System.Drawing.Size(211, 51);
            this.pFirstName.TabIndex = 2;
            // 
            // gbFirstName
            // 
            this.gbFirstName.Controls.Add(this.tbFirstName);
            this.gbFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFirstName.Location = new System.Drawing.Point(0, 5);
            this.gbFirstName.Name = "gbFirstName";
            this.gbFirstName.Size = new System.Drawing.Size(211, 46);
            this.gbFirstName.TabIndex = 4;
            this.gbFirstName.TabStop = false;
            this.gbFirstName.Text = "В имени";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(7, 19);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(198, 22);
            this.tbFirstName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbFirstName, "Введите часть или имя полностью, начиная с начала");
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbSurName_TextChanged);
            // 
            // pSurName
            // 
            this.pSurName.Controls.Add(this.gbSurName);
            this.pSurName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSurName.Location = new System.Drawing.Point(4, 44);
            this.pSurName.Name = "pSurName";
            this.pSurName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pSurName.Size = new System.Drawing.Size(211, 51);
            this.pSurName.TabIndex = 1;
            // 
            // gbSurName
            // 
            this.gbSurName.Controls.Add(this.tbSurName);
            this.gbSurName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSurName.Location = new System.Drawing.Point(0, 5);
            this.gbSurName.Name = "gbSurName";
            this.gbSurName.Size = new System.Drawing.Size(211, 46);
            this.gbSurName.TabIndex = 0;
            this.gbSurName.TabStop = false;
            this.gbSurName.Text = "В фамилии";
            // 
            // tbSurName
            // 
            this.tbSurName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSurName.Location = new System.Drawing.Point(7, 19);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(198, 22);
            this.tbSurName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbSurName, "Введите часть или фамилию полностью, начиная с начала");
            this.tbSurName.TextChanged += new System.EventHandler(this.tbSurName_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Искать в:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pHeader.Controls.Add(this.lHeader);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(4, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(211, 21);
            this.pHeader.TabIndex = 0;
            // 
            // lHeader
            // 
            this.lHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lHeader.Location = new System.Drawing.Point(0, 0);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(211, 21);
            this.lHeader.TabIndex = 0;
            this.lHeader.Text = "Поиск";
            this.lHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.pSearch);
            this.Controls.Add(this.tsSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SearchPane";
            this.Size = new System.Drawing.Size(243, 509);
            this.tsSearch.ResumeLayout(false);
            this.tsSearch.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.tsSearchCommand.ResumeLayout(false);
            this.tsSearchCommand.PerformLayout();
            this.pAddress2.ResumeLayout(false);
            this.gbAddressExt.ResumeLayout(false);
            this.gbAddressExt.PerformLayout();
            this.pAddress.ResumeLayout(false);
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.pPhoneNumber.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pBirthDate.ResumeLayout(false);
            this.gbBirthDate.ResumeLayout(false);
            this.gbBirthDate.PerformLayout();
            this.pGivenName.ResumeLayout(false);
            this.gbGivenName.ResumeLayout(false);
            this.gbGivenName.PerformLayout();
            this.pFirstName.ResumeLayout(false);
            this.gbFirstName.ResumeLayout(false);
            this.gbFirstName.PerformLayout();
            this.pSurName.ResumeLayout(false);
            this.gbSurName.ResumeLayout(false);
            this.gbSurName.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSearch;
        private System.Windows.Forms.ToolStripButton tsbShowSearchPane;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.Panel pPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pBirthDate;
        private System.Windows.Forms.GroupBox gbBirthDate;
        private System.Windows.Forms.Panel pGivenName;
        private System.Windows.Forms.GroupBox gbGivenName;
        private System.Windows.Forms.TextBox tbGivenName;
        private System.Windows.Forms.Panel pFirstName;
        private System.Windows.Forms.GroupBox gbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Panel pSurName;
        private System.Windows.Forms.GroupBox gbSurName;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pAddress;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ToolStrip tsSearchCommand;
        private System.Windows.Forms.ToolStripButton tsbSearchRun;
        private System.Windows.Forms.ToolStripButton tsbSearchClear;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.CheckBox cbBirthDate;
        private System.Windows.Forms.Panel pAddress2;
        private System.Windows.Forms.GroupBox gbAddressExt;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbSubsearch;
    }
}
