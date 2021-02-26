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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcoder));
            this.brandsBox = new System.Windows.Forms.ComboBox();
            this.productsBox = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.dataBtn1 = new System.Windows.Forms.Button();
            this.dataBtn2 = new System.Windows.Forms.Button();
            this.dataBtn3 = new System.Windows.Forms.Button();
            this.dataBtn4 = new System.Windows.Forms.Button();
            this.dataBtn5 = new System.Windows.Forms.Button();
            this.dataBtn6 = new System.Windows.Forms.Button();
            this.dataBtn7 = new System.Windows.Forms.Button();
            this.dataBtn8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brandsBox
            // 
            this.brandsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            "Rossetti",
            "TEKC",
            "Tikkurila",
            "Vekker",
            "Dufa",
            "Лакра",
            "Текстурол"});
            this.brandsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandsBox.BackColor = System.Drawing.Color.SteelBlue;
            this.brandsBox.DisplayMember = "Brand";
            this.brandsBox.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandsBox.ForeColor = System.Drawing.Color.Black;
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
            this.brandsBox.Location = new System.Drawing.Point(10, 10);
            this.brandsBox.MaxDropDownItems = 100;
            this.brandsBox.Name = "brandsBox";
            this.brandsBox.Size = new System.Drawing.Size(190, 27);
            this.brandsBox.Sorted = true;
            this.brandsBox.TabIndex = 0;
            this.brandsBox.SelectedIndexChanged += new System.EventHandler(this.brandsBox_SelectedIndexChanged);
            // 
            // productsBox
            // 
            this.productsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productsBox.BackColor = System.Drawing.Color.SteelBlue;
            this.productsBox.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsBox.ForeColor = System.Drawing.Color.Black;
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(10, 50);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(190, 27);
            this.productsBox.Sorted = true;
            this.productsBox.TabIndex = 1;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.productsBox_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.Window;
            this.label.Location = new System.Drawing.Point(0, 422);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.label.Size = new System.Drawing.Size(189, 38);
            this.label.TabIndex = 3;
            this.label.Text = "Выберите марку";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // dataBtn1
            // 
            this.dataBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn1.Location = new System.Drawing.Point(10, 100);
            this.dataBtn1.Name = "dataBtn1";
            this.dataBtn1.Size = new System.Drawing.Size(190, 40);
            this.dataBtn1.TabIndex = 3;
            this.dataBtn1.UseVisualStyleBackColor = true;
            this.dataBtn1.Click += new System.EventHandler(this.dataBtn1_Click);
            // 
            // dataBtn2
            // 
            this.dataBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn2.Location = new System.Drawing.Point(10, 140);
            this.dataBtn2.Name = "dataBtn2";
            this.dataBtn2.Size = new System.Drawing.Size(190, 40);
            this.dataBtn2.TabIndex = 4;
            this.dataBtn2.UseVisualStyleBackColor = true;
            this.dataBtn2.Click += new System.EventHandler(this.dataBtn2_Click);
            // 
            // dataBtn3
            // 
            this.dataBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn3.Location = new System.Drawing.Point(10, 180);
            this.dataBtn3.Name = "dataBtn3";
            this.dataBtn3.Size = new System.Drawing.Size(190, 40);
            this.dataBtn3.TabIndex = 5;
            this.dataBtn3.UseVisualStyleBackColor = true;
            this.dataBtn3.Click += new System.EventHandler(this.dataBtn3_Click);
            // 
            // dataBtn4
            // 
            this.dataBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn4.Location = new System.Drawing.Point(10, 220);
            this.dataBtn4.Name = "dataBtn4";
            this.dataBtn4.Size = new System.Drawing.Size(190, 40);
            this.dataBtn4.TabIndex = 6;
            this.dataBtn4.UseVisualStyleBackColor = true;
            this.dataBtn4.Click += new System.EventHandler(this.dataBtn4_Click);
            // 
            // dataBtn5
            // 
            this.dataBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn5.Location = new System.Drawing.Point(10, 260);
            this.dataBtn5.Name = "dataBtn5";
            this.dataBtn5.Size = new System.Drawing.Size(190, 40);
            this.dataBtn5.TabIndex = 7;
            this.dataBtn5.UseVisualStyleBackColor = true;
            this.dataBtn5.Click += new System.EventHandler(this.dataBtn5_Click);
            // 
            // dataBtn6
            // 
            this.dataBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn6.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn6.Location = new System.Drawing.Point(10, 300);
            this.dataBtn6.Name = "dataBtn6";
            this.dataBtn6.Size = new System.Drawing.Size(190, 40);
            this.dataBtn6.TabIndex = 8;
            this.dataBtn6.UseVisualStyleBackColor = true;
            this.dataBtn6.Click += new System.EventHandler(this.dataBtn6_Click);
            // 
            // dataBtn7
            // 
            this.dataBtn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn7.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn7.Location = new System.Drawing.Point(10, 340);
            this.dataBtn7.Name = "dataBtn7";
            this.dataBtn7.Size = new System.Drawing.Size(190, 40);
            this.dataBtn7.TabIndex = 9;
            this.dataBtn7.UseVisualStyleBackColor = true;
            this.dataBtn7.Click += new System.EventHandler(this.dataBtn7_Click);
            // 
            // dataBtn8
            // 
            this.dataBtn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn8.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn8.Location = new System.Drawing.Point(10, 380);
            this.dataBtn8.Name = "dataBtn8";
            this.dataBtn8.Size = new System.Drawing.Size(190, 40);
            this.dataBtn8.TabIndex = 10;
            this.dataBtn8.UseVisualStyleBackColor = true;
            this.dataBtn8.Click += new System.EventHandler(this.dataBtn8_Click);
            // 
            // Barcoder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(213, 460);
            this.Controls.Add(this.dataBtn8);
            this.Controls.Add(this.dataBtn7);
            this.Controls.Add(this.dataBtn6);
            this.Controls.Add(this.dataBtn5);
            this.Controls.Add(this.dataBtn4);
            this.Controls.Add(this.dataBtn3);
            this.Controls.Add(this.dataBtn2);
            this.Controls.Add(this.dataBtn1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.brandsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcoder";
            this.ShowIcon = false;
            this.Text = "Barcoder PRO";
            this.Load += new System.EventHandler(this.Barcoder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brandsBox;
        private System.Windows.Forms.ComboBox productsBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button dataBtn1;
        private System.Windows.Forms.Button dataBtn2;
        private System.Windows.Forms.Button dataBtn3;
        private System.Windows.Forms.Button dataBtn4;
        private System.Windows.Forms.Button dataBtn5;
        private System.Windows.Forms.Button dataBtn6;
        private System.Windows.Forms.Button dataBtn7;
        private System.Windows.Forms.Button dataBtn8;
    }
}

