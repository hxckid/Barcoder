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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.brandsBox = new System.Windows.Forms.ComboBox();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.barcoderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barcoderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcoderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addBtn.Location = new System.Drawing.Point(17, 400);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 25);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.removeBtn.Location = new System.Drawing.Point(190, 400);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(80, 25);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Удалить";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // brandsBox
            // 
            this.brandsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.brandsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandsBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.brandsBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandsBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.brandsBox.FormattingEnabled = true;
            this.brandsBox.Items.AddRange(new object[] {
            "Aura",
            "Dufa",
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
            "Лакра",
            "Текстурол"});
            this.brandsBox.Location = new System.Drawing.Point(15, 10);
            this.brandsBox.MaxDropDownItems = 100;
            this.brandsBox.Name = "brandsBox";
            this.brandsBox.Size = new System.Drawing.Size(255, 27);
            this.brandsBox.Sorted = true;
            this.brandsBox.TabIndex = 1;
            this.brandsBox.SelectedIndexChanged += new System.EventHandler(this.brandsBox_SelectedIndexChanged);
            // 
            // productsBox
            // 
            this.productsBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.productsBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productsBox.FormattingEnabled = true;
            this.productsBox.ItemHeight = 19;
            this.productsBox.Location = new System.Drawing.Point(15, 45);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(255, 346);
            this.productsBox.Sorted = true;
            this.productsBox.TabIndex = 2;
            this.productsBox.DoubleClick += new System.EventHandler(this.editBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.editBtn.Location = new System.Drawing.Point(104, 400);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(80, 25);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
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
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(282, 437);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.brandsBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Helper";
            this.Text = "Database Helper";
            this.TopMost = true;
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
        private System.Windows.Forms.Button editBtn;
    }
}

