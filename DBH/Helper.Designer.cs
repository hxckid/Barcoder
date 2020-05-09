namespace DBH
{
    partial class Helper
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
            this.components = new System.ComponentModel.Container();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.brandsBox = new System.Windows.Forms.ComboBox();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.barcoderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barcoderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 401);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(95, 401);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Удалить";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(177, 401);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // brandsBox
            // 
            this.brandsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.brandsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.brandsBox.Location = new System.Drawing.Point(13, 13);
            this.brandsBox.MaxDropDownItems = 100;
            this.brandsBox.Name = "brandsBox";
            this.brandsBox.Size = new System.Drawing.Size(193, 21);
            this.brandsBox.TabIndex = 4;
            this.brandsBox.SelectedIndexChanged += new System.EventHandler(this.brandsBox_SelectedIndexChanged);
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(13, 41);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(239, 355);
            this.productsBox.TabIndex = 5;
            // 
            // barcoderBindingSource1
            // 
            this.barcoderBindingSource1.DataSource = typeof(Barcoder.Barcoder);
            // 
            // barcoderBindingSource
            // 
            this.barcoderBindingSource.DataSource = typeof(Barcoder.Barcoder);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(213, 13);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(39, 23);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Upd";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 437);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.brandsBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Helper";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ComboBox brandsBox;
        private System.Windows.Forms.BindingSource barcoderBindingSource1;
        private System.Windows.Forms.ListBox productsBox;
        private System.Windows.Forms.BindingSource barcoderBindingSource;
        private System.Windows.Forms.Button updateBtn;
    }
}

