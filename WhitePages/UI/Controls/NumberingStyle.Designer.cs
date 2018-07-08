namespace WhitePages.UI.Controls
{
    partial class NumberingStyle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSideEven = new System.Windows.Forms.RadioButton();
            this.rbSideOdd = new System.Windows.Forms.RadioButton();
            this.rbSideAny = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSideEven);
            this.groupBox1.Controls.Add(this.rbSideOdd);
            this.groupBox1.Controls.Add(this.rbSideAny);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сторона улицы";
            // 
            // rbSideEven
            // 
            this.rbSideEven.AutoSize = true;
            this.rbSideEven.Location = new System.Drawing.Point(83, 67);
            this.rbSideEven.Name = "rbSideEven";
            this.rbSideEven.Size = new System.Drawing.Size(62, 17);
            this.rbSideEven.TabIndex = 2;
            this.rbSideEven.Text = "Четная";
            this.rbSideEven.UseVisualStyleBackColor = true;
            // 
            // rbSideOdd
            // 
            this.rbSideOdd.AutoSize = true;
            this.rbSideOdd.Location = new System.Drawing.Point(83, 44);
            this.rbSideOdd.Name = "rbSideOdd";
            this.rbSideOdd.Size = new System.Drawing.Size(73, 17);
            this.rbSideOdd.TabIndex = 1;
            this.rbSideOdd.Text = "Нечетная";
            this.rbSideOdd.UseVisualStyleBackColor = true;
            // 
            // rbSideAny
            // 
            this.rbSideAny.AutoSize = true;
            this.rbSideAny.Checked = true;
            this.rbSideAny.Location = new System.Drawing.Point(83, 21);
            this.rbSideAny.Name = "rbSideAny";
            this.rbSideAny.Size = new System.Drawing.Size(59, 17);
            this.rbSideAny.TabIndex = 0;
            this.rbSideAny.TabStop = true;
            this.rbSideAny.Text = "Любая";
            this.rbSideAny.UseVisualStyleBackColor = true;
            // 
            // StreetSideNumberingStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "StreetSideNumberingStyle";
            this.Size = new System.Drawing.Size(200, 94);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSideEven;
        private System.Windows.Forms.RadioButton rbSideOdd;
        private System.Windows.Forms.RadioButton rbSideAny;
    }
}
