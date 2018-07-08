namespace WhitePages.Presenters
{
    partial class PersonPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonPane));
            this.cbSurName = new System.Windows.Forms.ComboBox();
            this.cbFirstName = new System.Windows.Forms.ComboBox();
            this.cbGivenName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.lGivenName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddressExt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.mtbZipCode = new System.Windows.Forms.MaskedTextBox();
            this.pDetails = new System.Windows.Forms.Panel();
            this.mtbBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddressToSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGenerate = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tsDetails = new System.Windows.Forms.ToolStrip();
            this.tsbShowData = new System.Windows.Forms.ToolStripButton();
            this.tsbAutoShow = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tsTools.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tsDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSurName
            // 
            this.cbSurName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSurName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSurName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSurName.DropDownWidth = 120;
            this.cbSurName.FormattingEnabled = true;
            this.cbSurName.Location = new System.Drawing.Point(4, 45);
            this.cbSurName.Name = "cbSurName";
            this.cbSurName.Size = new System.Drawing.Size(357, 21);
            this.cbSurName.TabIndex = 1;
            this.cbSurName.Tag = "@surName";
            // 
            // cbFirstName
            // 
            this.cbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbFirstName.DropDownWidth = 120;
            this.cbFirstName.FormattingEnabled = true;
            this.cbFirstName.Location = new System.Drawing.Point(4, 84);
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Size = new System.Drawing.Size(357, 21);
            this.cbFirstName.TabIndex = 3;
            this.cbFirstName.Tag = "@firstName";
            // 
            // cbGivenName
            // 
            this.cbGivenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGivenName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGivenName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbGivenName.DropDownWidth = 120;
            this.cbGivenName.FormattingEnabled = true;
            this.cbGivenName.Location = new System.Drawing.Point(4, 126);
            this.cbGivenName.Name = "cbGivenName";
            this.cbGivenName.Size = new System.Drawing.Size(357, 21);
            this.cbGivenName.TabIndex = 5;
            this.cbGivenName.Tag = "@givenName";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "&Дата рождения:";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbPhoneNumber.BeepOnError = true;
            this.mtbPhoneNumber.Location = new System.Drawing.Point(4, 168);
            this.mtbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mtbPhoneNumber.Mask = "(999) 000-00-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(357, 22);
            this.mtbPhoneNumber.TabIndex = 7;
            this.mtbPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lPhone
            // 
            this.lPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(4, 151);
            this.lPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(56, 13);
            this.lPhone.TabIndex = 6;
            this.lPhone.Text = "&Телефон:";
            // 
            // lGivenName
            // 
            this.lGivenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lGivenName.AutoSize = true;
            this.lGivenName.Location = new System.Drawing.Point(4, 109);
            this.lGivenName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGivenName.Name = "lGivenName";
            this.lGivenName.Size = new System.Drawing.Size(60, 13);
            this.lGivenName.TabIndex = 4;
            this.lGivenName.Text = "&Отчество:";
            // 
            // lFirstName
            // 
            this.lFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(4, 68);
            this.lFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(32, 13);
            this.lFirstName.TabIndex = 2;
            this.lFirstName.Text = "&Имя:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Фамилия:";
            // 
            // tbAddressExt
            // 
            this.tbAddressExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddressExt.Location = new System.Drawing.Point(4, 340);
            this.tbAddressExt.Name = "tbAddressExt";
            this.tbAddressExt.Size = new System.Drawing.Size(357, 22);
            this.tbAddressExt.TabIndex = 13;
            this.tbAddressExt.Tag = "@address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&По идексу (все 6 цифр):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "&Дом, квартира:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "&Почтовый адрес:";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddress.Location = new System.Drawing.Point(4, 250);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(357, 65);
            this.tbAddress.TabIndex = 11;
            // 
            // mtbZipCode
            // 
            this.mtbZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbZipCode.Location = new System.Drawing.Point(6, 34);
            this.mtbZipCode.Mask = "000000";
            this.mtbZipCode.Name = "mtbZipCode";
            this.mtbZipCode.Size = new System.Drawing.Size(345, 22);
            this.mtbZipCode.TabIndex = 1;
            this.mtbZipCode.TextChanged += new System.EventHandler(this.mtbZipCode_TextChanged);
            // 
            // pDetails
            // 
            this.pDetails.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pDetails.Controls.Add(this.mtbBirthDate);
            this.pDetails.Controls.Add(this.groupBox1);
            this.pDetails.Controls.Add(this.tsTools);
            this.pDetails.Controls.Add(this.label3);
            this.pDetails.Controls.Add(this.panel2);
            this.pDetails.Controls.Add(this.cbGivenName);
            this.pDetails.Controls.Add(this.label4);
            this.pDetails.Controls.Add(this.tbAddress);
            this.pDetails.Controls.Add(this.cbFirstName);
            this.pDetails.Controls.Add(this.tbAddressExt);
            this.pDetails.Controls.Add(this.label5);
            this.pDetails.Controls.Add(this.cbSurName);
            this.pDetails.Controls.Add(this.label1);
            this.pDetails.Controls.Add(this.lPhone);
            this.pDetails.Controls.Add(this.mtbPhoneNumber);
            this.pDetails.Controls.Add(this.lGivenName);
            this.pDetails.Controls.Add(this.lFirstName);
            this.pDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetails.Location = new System.Drawing.Point(24, 0);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(365, 528);
            this.pDetails.TabIndex = 18;
            this.pDetails.VisibleChanged += new System.EventHandler(this.pDetails_VisibleChanged);
            // 
            // mtbBirthDate
            // 
            this.mtbBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbBirthDate.Culture = new System.Globalization.CultureInfo("");
            this.mtbBirthDate.Location = new System.Drawing.Point(4, 208);
            this.mtbBirthDate.Mask = "00.00.0000";
            this.mtbBirthDate.Name = "mtbBirthDate";
            this.mtbBirthDate.Size = new System.Drawing.Size(357, 22);
            this.mtbBirthDate.TabIndex = 9;
            this.mtbBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbAddressToSearch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtbZipCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 106);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подбор адреса";
            // 
            // tbAddressToSearch
            // 
            this.tbAddressToSearch.AcceptsReturn = true;
            this.tbAddressToSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddressToSearch.Location = new System.Drawing.Point(6, 75);
            this.tbAddressToSearch.Name = "tbAddressToSearch";
            this.tbAddressToSearch.Size = new System.Drawing.Size(345, 22);
            this.tbAddressToSearch.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbAddressToSearch, "Введите искомую часть адреса. Это может быть ");
            this.tbAddressToSearch.DoubleClick += new System.EventHandler(this.tbAddressToSearch_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "&По части адреса:";
            // 
            // tsTools
            // 
            this.tsTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsTools.AutoSize = false;
            this.tsTools.Dock = System.Windows.Forms.DockStyle.None;
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbDelete,
            this.tsbSave,
            this.toolStripSeparator6,
            this.tsbGenerate});
            this.tsTools.Location = new System.Drawing.Point(4, 477);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(357, 25);
            this.tsTools.TabIndex = 15;
            this.tsTools.Text = "toolStrip3";
            // 
            // tsbNew
            // 
            this.tsbNew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Enabled = false;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "Создать";
            this.tsbNew.ToolTipText = "Создать новую запись";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Удалить";
            this.tsbDelete.ToolTipText = "Удалить текущую записи";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "&Сохранить";
            this.tsbSave.ToolTipText = "Сохранить изменения в текущей записи";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbGenerate
            // 
            this.tsbGenerate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGenerate.Enabled = false;
            this.tsbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerate.Image")));
            this.tsbGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerate.Name = "tsbGenerate";
            this.tsbGenerate.Size = new System.Drawing.Size(23, 22);
            this.tsbGenerate.Text = "&Генерировать";
            this.tsbGenerate.ToolTipText = "Заполнить случайными значениями";
            this.tsbGenerate.Click += new System.EventHandler(this.tsbGenerate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 21);
            this.panel2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Данные";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsDetails
            // 
            this.tsDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsDetails.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbShowData,
            this.tsbAutoShow});
            this.tsDetails.Location = new System.Drawing.Point(0, 0);
            this.tsDetails.Name = "tsDetails";
            this.tsDetails.Size = new System.Drawing.Size(24, 528);
            this.tsDetails.TabIndex = 20;
            this.tsDetails.Text = "toolStrip1";
            // 
            // tsbShowData
            // 
            this.tsbShowData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowData.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowData.Image")));
            this.tsbShowData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowData.Name = "tsbShowData";
            this.tsbShowData.Size = new System.Drawing.Size(29, 20);
            this.tsbShowData.Text = "Показать/скрыть";
            this.tsbShowData.ToolTipText = "Отобразить/скрыть панель данных";
            this.tsbShowData.Click += new System.EventHandler(this.tsbShowData_Click);
            // 
            // tsbAutoShow
            // 
            this.tsbAutoShow.Checked = true;
            this.tsbAutoShow.CheckOnClick = true;
            this.tsbAutoShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbAutoShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAutoShow.Image = global::WhitePages.Properties.Resources.expand_icon_16;
            this.tsbAutoShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAutoShow.Name = "tsbAutoShow";
            this.tsbAutoShow.Size = new System.Drawing.Size(29, 20);
            this.tsbAutoShow.Text = "Автопоказ";
            this.tsbAutoShow.ToolTipText = "Автоматически показывать при выборе записи в списке";
            // 
            // PersonPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pDetails);
            this.Controls.Add(this.tsDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "PersonPane";
            this.Size = new System.Drawing.Size(389, 528);
            this.pDetails.ResumeLayout(false);
            this.pDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tsDetails.ResumeLayout(false);
            this.tsDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.ComboBox cbSurName;
        private System.Windows.Forms.ComboBox cbFirstName;
        private System.Windows.Forms.ComboBox cbGivenName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lGivenName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddressExt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.MaskedTextBox mtbZipCode;
        private System.Windows.Forms.Panel pDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip tsDetails;
        private System.Windows.Forms.ToolStripButton tsbShowData;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbGenerate;
        private System.Windows.Forms.ToolStripButton tsbAutoShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAddressToSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox mtbBirthDate;
    }
}
