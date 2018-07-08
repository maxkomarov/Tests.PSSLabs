namespace WhitePages.Presenters
{
    partial class NewAddressBar
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsCommand = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(3, 27);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(495, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pHeader.Controls.Add(this.label1);
            this.pHeader.Controls.Add(this.pictureBox1);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pHeader.Size = new System.Drawing.Size(525, 21);
            this.pHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WhitePages.Properties.Resources.doc_empty_icon_161;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск/Новый адрес";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsCommand
            // 
            this.tsCommand.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsCommand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSearch});
            this.tsCommand.Location = new System.Drawing.Point(501, 21);
            this.tsCommand.Name = "tsCommand";
            this.tsCommand.Size = new System.Drawing.Size(24, 50);
            this.tsCommand.TabIndex = 3;
            this.tsCommand.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::WhitePages.Properties.Resources.doc_empty_icon_16;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(29, 20);
            this.tsbNew.Text = "Создать адрес";
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::WhitePages.Properties.Resources.zoom_icon_16;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(29, 20);
            this.tsbSearch.Text = "Найти";
            // 
            // NewAddressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsCommand);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.tbAddress);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NewAddressBar";
            this.Size = new System.Drawing.Size(525, 71);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsCommand.ResumeLayout(false);
            this.tsCommand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsCommand;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSearch;
    }
}
