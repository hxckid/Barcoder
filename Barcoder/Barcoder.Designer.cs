namespace Barcoder
{
    partial class Barcoder
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.brandsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // brandsBox
            // 
            this.brandsBox.FormattingEnabled = true;
            this.brandsBox.Location = new System.Drawing.Point(12, 13);
            this.brandsBox.Name = "brandsBox";
            this.brandsBox.Size = new System.Drawing.Size(175, 21);
            this.brandsBox.TabIndex = 0;
            this.brandsBox.SelectedIndexChanged += new System.EventHandler(this.brandsBox_SelectedIndexChanged);
            // 
            // Barcoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 450);
            this.Controls.Add(this.brandsBox);
            this.Name = "Barcoder";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox brandsBox;
    }
}

