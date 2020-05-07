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
            this.productsBox = new System.Windows.Forms.ComboBox();
            this.dataBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brandsBox
            // 
            this.brandsBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Aura",
            "Dulux",
            "Eskaro",
            "Finncolor",
            "Hammerite",
            "Holzer",
            "Marshall",
            "Parade",
            "Pinotex",
            "Rosetti",
            "TEKC",
            "Tikkurila",
            "Vekker",
            "Vincent",
            "Лакра",
            "Текстурол"});
            this.brandsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.brandsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandsBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.brandsBox.DisplayMember = "Brand";
            this.brandsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandsBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.brandsBox.FormattingEnabled = true;
            this.brandsBox.Items.AddRange(new object[] {
            "Aura",
            "Dulux",
            "Eskaro",
            "Finncolor",
            "Hammerite",
            "Holzer",
            "Marshall",
            "Parade",
            "Pinotex",
            "Rossetti",
            "TEKC",
            "Tikkurila",
            "Vekker",
            "Vincent",
            "Лакра",
            "Текстурол"});
            this.brandsBox.Location = new System.Drawing.Point(10, 10);
            this.brandsBox.MaxDropDownItems = 100;
            this.brandsBox.Name = "brandsBox";
            this.brandsBox.Size = new System.Drawing.Size(175, 28);
            this.brandsBox.Sorted = true;
            this.brandsBox.TabIndex = 0;
            this.brandsBox.SelectedIndexChanged += new System.EventHandler(this.brandsBox_SelectedIndexChanged);
            // 
            // productsBox
            // 
            this.productsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productsBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.productsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(10, 50);
            this.productsBox.MaxDropDownItems = 100;
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(175, 28);
            this.productsBox.Sorted = true;
            this.productsBox.TabIndex = 1;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.productsBox_SelectedIndexChanged);
            // 
            // dataBox
            // 
            this.dataBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.dataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.dataBox.FormattingEnabled = true;
            this.dataBox.ItemHeight = 20;
            this.dataBox.Location = new System.Drawing.Point(10, 90);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(175, 144);
            this.dataBox.TabIndex = 2;
            this.dataBox.SelectedIndexChanged += new System.EventHandler(this.dataBox_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label.Location = new System.Drawing.Point(10, 240);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 3;
            // 
            // Barcoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(199, 261);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.brandsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Barcoder";
            this.Text = "Gestori Barcoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brandsBox;
        private System.Windows.Forms.ComboBox productsBox;
        private System.Windows.Forms.ListBox dataBox;
        private System.Windows.Forms.Label label;
    }
}

