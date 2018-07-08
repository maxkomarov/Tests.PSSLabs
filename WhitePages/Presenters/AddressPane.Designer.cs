namespace WhitePages.Presenters
{
    partial class AddressPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressPane));
            this.ttAddress = new System.Windows.Forms.ToolTip(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbZipCodeBase = new System.Windows.Forms.MaskedTextBox();
            this.mtbZipCodeEnd = new System.Windows.Forms.MaskedTextBox();
            this.mtbBuildingNumberingStart = new System.Windows.Forms.MaskedTextBox();
            this.mtbBuildingNumberingEnd = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbParentName = new System.Windows.Forms.TextBox();
            this.pDetails = new System.Windows.Forms.Panel();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsDetails = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.numberingStyle = new WhitePages.UI.Controls.NumberingStyle();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbShowData = new System.Windows.Forms.ToolStripButton();
            this.tsbAutoShow = new System.Windows.Forms.ToolStripButton();
            this.pDetails.SuspendLayout();
            this.tsTools.SuspendLayout();
            this.tsDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(6, 109);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 50);
            this.tbName.TabIndex = 3;
            // 
            // mtbZipCodeBase
            // 
            this.mtbZipCodeBase.Location = new System.Drawing.Point(121, 166);
            this.mtbZipCodeBase.Mask = "000000";
            this.mtbZipCodeBase.Name = "mtbZipCodeBase";
            this.mtbZipCodeBase.Size = new System.Drawing.Size(93, 20);
            this.mtbZipCodeBase.TabIndex = 5;
            // 
            // mtbZipCodeEnd
            // 
            this.mtbZipCodeEnd.Location = new System.Drawing.Point(121, 192);
            this.mtbZipCodeEnd.Mask = "000000";
            this.mtbZipCodeEnd.Name = "mtbZipCodeEnd";
            this.mtbZipCodeEnd.Size = new System.Drawing.Size(93, 20);
            this.mtbZipCodeEnd.TabIndex = 7;
            // 
            // mtbBuildingNumberingStart
            // 
            this.mtbBuildingNumberingStart.Location = new System.Drawing.Point(121, 218);
            this.mtbBuildingNumberingStart.Mask = "000";
            this.mtbBuildingNumberingStart.Name = "mtbBuildingNumberingStart";
            this.mtbBuildingNumberingStart.Size = new System.Drawing.Size(93, 20);
            this.mtbBuildingNumberingStart.TabIndex = 9;
            // 
            // mtbBuildingNumberingEnd
            // 
            this.mtbBuildingNumberingEnd.Location = new System.Drawing.Point(121, 244);
            this.mtbBuildingNumberingEnd.Mask = "000";
            this.mtbBuildingNumberingEnd.Name = "mtbBuildingNumberingEnd";
            this.mtbBuildingNumberingEnd.Size = new System.Drawing.Size(93, 20);
            this.mtbBuildingNumberingEnd.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Tag = "mtbBuildingNumberingStart";
            this.label3.Text = "Индексы от:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Tag = "mtbBuildingNumberingStart";
            this.label4.Text = "Индексы до:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Tag = "mtbBuildingNumberingStart";
            this.label5.Text = "Номера домов от:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 10;
            this.label6.Tag = "mtbBuildingNumberingStart";
            this.label6.Text = "Номера домов до:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Вышестоящий адрес";
            // 
            // tbParentName
            // 
            this.tbParentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParentName.Location = new System.Drawing.Point(6, 41);
            this.tbParentName.Multiline = true;
            this.tbParentName.Name = "tbParentName";
            this.tbParentName.ReadOnly = true;
            this.tbParentName.Size = new System.Drawing.Size(208, 50);
            this.tbParentName.TabIndex = 1;
            // 
            // pDetails
            // 
            this.pDetails.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pDetails.Controls.Add(this.label1);
            this.pDetails.Controls.Add(this.tsTools);
            this.pDetails.Controls.Add(this.label7);
            this.pDetails.Controls.Add(this.tbName);
            this.pDetails.Controls.Add(this.tbParentName);
            this.pDetails.Controls.Add(this.mtbZipCodeBase);
            this.pDetails.Controls.Add(this.mtbZipCodeEnd);
            this.pDetails.Controls.Add(this.label6);
            this.pDetails.Controls.Add(this.mtbBuildingNumberingStart);
            this.pDetails.Controls.Add(this.label5);
            this.pDetails.Controls.Add(this.mtbBuildingNumberingEnd);
            this.pDetails.Controls.Add(this.label4);
            this.pDetails.Controls.Add(this.label2);
            this.pDetails.Controls.Add(this.label3);
            this.pDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetails.Location = new System.Drawing.Point(0, 0);
            this.pDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(219, 464);
            this.pDetails.TabIndex = 0;
            this.pDetails.VisibleChanged += new System.EventHandler(this.pDetails_VisibleChanged);
            // 
            // tsTools
            // 
            this.tsTools.AutoSize = false;
            this.tsTools.Dock = System.Windows.Forms.DockStyle.None;
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbDelete,
            this.tsbSave});
            this.tsTools.Location = new System.Drawing.Point(3, 366);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(211, 25);
            this.tsTools.TabIndex = 16;
            this.tsTools.Text = "toolStrip3";
            // 
            // tsDetails
            // 
            this.tsDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsDetails.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbShowData,
            this.tsbAutoShow});
            this.tsDetails.Location = new System.Drawing.Point(219, 0);
            this.tsDetails.Name = "tsDetails";
            this.tsDetails.Size = new System.Drawing.Size(24, 464);
            this.tsDetails.TabIndex = 19;
            this.tsDetails.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Адрес";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberingStyle
            // 
            this.numberingStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numberingStyle.Location = new System.Drawing.Point(6, 270);
            this.numberingStyle.Name = "numberingStyle";
            this.numberingStyle.Size = new System.Drawing.Size(208, 93);
            this.numberingStyle.TabIndex = 20;
            this.numberingStyle.Value = WhitePages.Model.Address.NumberingEnum.Odd;
            // 
            // tsbNew
            // 
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
            // tsbShowData
            // 
            this.tsbShowData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowData.Image = global::WhitePages.Properties.Resources.mail_icon_16;
            this.tsbShowData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowData.Name = "tsbShowData";
            this.tsbShowData.Size = new System.Drawing.Size(21, 20);
            this.tsbShowData.Text = "Отобразить/скрыть";
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
            this.tsbAutoShow.Size = new System.Drawing.Size(21, 20);
            this.tsbAutoShow.Text = "Автопоказ";
            this.tsbAutoShow.ToolTipText = "Автоматически показывать при выборе записи в списке";
            // 
            // AddressPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numberingStyle);
            this.Controls.Add(this.pDetails);
            this.Controls.Add(this.tsDetails);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddressPane";
            this.Size = new System.Drawing.Size(243, 464);
            this.pDetails.ResumeLayout(false);
            this.pDetails.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.tsDetails.ResumeLayout(false);
            this.tsDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox mtbZipCodeBase;
        private System.Windows.Forms.MaskedTextBox mtbZipCodeEnd;
        private System.Windows.Forms.MaskedTextBox mtbBuildingNumberingStart;
        private System.Windows.Forms.MaskedTextBox mtbBuildingNumberingEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbParentName;
        private System.Windows.Forms.Panel pDetails;
        private System.Windows.Forms.ToolStrip tsDetails;
        private System.Windows.Forms.ToolStripButton tsbShowData;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbAutoShow;
        private System.Windows.Forms.Label label1;
        private UI.Controls.NumberingStyle numberingStyle;
    }
}
