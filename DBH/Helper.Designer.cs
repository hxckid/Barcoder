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
            this.brandsBox = new System.Windows.Forms.ComboBox();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.barcoderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barcoderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 401);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(177, 402);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Удалить";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // brandsBox
            // 
            this.brandsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.brandsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandsBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.brandsBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandsBox.ForeColor = System.Drawing.SystemColors.Window;
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
            this.brandsBox.Size = new System.Drawing.Size(239, 27);
            this.brandsBox.TabIndex = 1;
            this.brandsBox.SelectedIndexChanged += new System.EventHandler(this.brandsBox_SelectedIndexChanged);
            // 
            // productsBox
            // 
            this.productsBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.productsBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsBox.ForeColor = System.Drawing.SystemColors.Window;
            this.productsBox.FormattingEnabled = true;
            this.productsBox.ItemHeight = 19;
            this.productsBox.Location = new System.Drawing.Point(13, 41);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(239, 346);
            this.productsBox.TabIndex = 2;
            this.productsBox.DoubleClick += new System.EventHandler(this.editBtn_Click);
            // 
            // barcoderBindingSource1
            // 
            this.barcoderBindingSource1.DataSource = typeof(Barcoder.Barcoder);
            // 
            // barcoderBindingSource
            // 
            this.barcoderBindingSource.DataSource = typeof(Barcoder.Barcoder);
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(268, 437);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.brandsBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Helper";
            this.Text = "Database Helper";
            this.Activated += new System.EventHandler(this.brandsBox_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ComboBox brandsBox;
        private System.Windows.Forms.BindingSource barcoderBindingSource1;
        private System.Windows.Forms.ListBox productsBox;
        private System.Windows.Forms.BindingSource barcoderBindingSource;
    }
}

