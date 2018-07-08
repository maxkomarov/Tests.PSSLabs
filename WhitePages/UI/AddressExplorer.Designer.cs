namespace WhitePages.UI
{
    partial class AddressExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressExplorer));
            this.explorer = new WhitePages.Presenters.AddressExplorer();
            this.SuspendLayout();
            // 
            // explorer
            // 
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.Location = new System.Drawing.Point(0, 0);
            this.explorer.Margin = new System.Windows.Forms.Padding(0);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(896, 532);
            this.explorer.TabIndex = 1;
            // 
            // AddressExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 532);
            this.Controls.Add(this.explorer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddressExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник адресов";
            this.ResumeLayout(false);

        }

        #endregion

        private Presenters.AddressExplorer explorer;
    }
}