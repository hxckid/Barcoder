namespace DBH
{
    partial class AddForm
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
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.productBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baseBox1 = new System.Windows.Forms.ComboBox();
            this.volumeBox1 = new System.Windows.Forms.TextBox();
            this.bcBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bcBox2 = new System.Windows.Forms.TextBox();
            this.volumeBox2 = new System.Windows.Forms.TextBox();
            this.baseBox2 = new System.Windows.Forms.ComboBox();
            this.bcBox3 = new System.Windows.Forms.TextBox();
            this.volumeBox3 = new System.Windows.Forms.TextBox();
            this.baseBox3 = new System.Windows.Forms.ComboBox();
            this.bcBox4 = new System.Windows.Forms.TextBox();
            this.volumeBox4 = new System.Windows.Forms.TextBox();
            this.baseBox4 = new System.Windows.Forms.ComboBox();
            this.bcBox5 = new System.Windows.Forms.TextBox();
            this.volumeBox5 = new System.Windows.Forms.TextBox();
            this.baseBox5 = new System.Windows.Forms.ComboBox();
            this.bcBox6 = new System.Windows.Forms.TextBox();
            this.volumeBox6 = new System.Windows.Forms.TextBox();
            this.baseBox6 = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brandBox
            // 
            this.brandBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.brandBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.brandBox.FormattingEnabled = true;
            this.brandBox.Items.AddRange(new object[] {
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
            "Teknos",
            "Tikkurila",
            "Vekker",
            "Vincent",
            "Лакра",
            "Текстурол"});
            this.brandBox.Location = new System.Drawing.Point(47, 25);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(176, 26);
            this.brandBox.TabIndex = 0;
            // 
            // productBox
            // 
            this.productBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.productBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.productBox.Location = new System.Drawing.Point(15, 77);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(251, 26);
            this.productBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бренд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название продукта";
            // 
            // baseBox1
            // 
            this.baseBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.baseBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.baseBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.baseBox1.FormattingEnabled = true;
            this.baseBox1.Items.AddRange(new object[] {
            "",
            "A",
            "AP",
            "BC",
            "BW",
            "C",
            "EP",
            "TR",
            "ORO",
            "ARG",
            "BRO",
            "BB",
            "DD",
            "BT",
            "PER",
            "NEU"});
            this.baseBox1.Location = new System.Drawing.Point(15, 137);
            this.baseBox1.Name = "baseBox1";
            this.baseBox1.Size = new System.Drawing.Size(69, 26);
            this.baseBox1.TabIndex = 2;
            // 
            // volumeBox1
            // 
            this.volumeBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.volumeBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.volumeBox1.Location = new System.Drawing.Point(91, 137);
            this.volumeBox1.MaxLength = 5;
            this.volumeBox1.Name = "volumeBox1";
            this.volumeBox1.Size = new System.Drawing.Size(69, 26);
            this.volumeBox1.TabIndex = 3;
            this.volumeBox1.Tag = "";
            this.volumeBox1.Text = " ";
            this.volumeBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bcBox1
            // 
            this.bcBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bcBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.bcBox1.Location = new System.Drawing.Point(166, 138);
            this.bcBox1.MaxLength = 5;
            this.bcBox1.Name = "bcBox1";
            this.bcBox1.Size = new System.Drawing.Size(100, 26);
            this.bcBox1.TabIndex = 4;
            this.bcBox1.Tag = "";
            this.bcBox1.Text = " ";
            this.bcBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "База";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Объем";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Баркод";
            // 
            // bcBox2
            // 
            this.bcBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.bcBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.bcBox2.Location = new System.Drawing.Point(166, 165);
            this.bcBox2.MaxLength = 5;
            this.bcBox2.Name = "bcBox2";
            this.bcBox2.Size = new System.Drawing.Size(100, 26);
            this.bcBox2.TabIndex = 7;
            this.bcBox2.Tag = "";
            this.bcBox2.Text = " ";
            this.bcBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox2
            // 
            this.volumeBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.volumeBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.volumeBox2.Location = new System.Drawing.Point(91, 164);
            this.volumeBox2.MaxLength = 5;
            this.volumeBox2.Name = "volumeBox2";
            this.volumeBox2.Size = new System.Drawing.Size(69, 26);
            this.volumeBox2.TabIndex = 6;
            this.volumeBox2.Tag = "";
            this.volumeBox2.Text = " ";
            this.volumeBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox2
            // 
            this.baseBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.baseBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.baseBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.baseBox2.FormattingEnabled = true;
            this.baseBox2.Items.AddRange(new object[] {
            "A",
            "AP",
            "BC",
            "BW",
            "C",
            "EP",
            "TR",
            "ORO",
            "ARG",
            "BRO",
            "BB",
            "DD",
            "BT",
            "PER",
            "NEU"});
            this.baseBox2.Location = new System.Drawing.Point(15, 164);
            this.baseBox2.Name = "baseBox2";
            this.baseBox2.Size = new System.Drawing.Size(69, 26);
            this.baseBox2.TabIndex = 5;
            // 
            // bcBox3
            // 
            this.bcBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.bcBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.bcBox3.Location = new System.Drawing.Point(166, 192);
            this.bcBox3.MaxLength = 5;
            this.bcBox3.Name = "bcBox3";
            this.bcBox3.Size = new System.Drawing.Size(100, 26);
            this.bcBox3.TabIndex = 10;
            this.bcBox3.Tag = "";
            this.bcBox3.Text = " ";
            this.bcBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox3
            // 
            this.volumeBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.volumeBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.volumeBox3.Location = new System.Drawing.Point(91, 191);
            this.volumeBox3.MaxLength = 5;
            this.volumeBox3.Name = "volumeBox3";
            this.volumeBox3.Size = new System.Drawing.Size(69, 26);
            this.volumeBox3.TabIndex = 9;
            this.volumeBox3.Tag = "";
            this.volumeBox3.Text = " ";
            this.volumeBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox3
            // 
            this.baseBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.baseBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.baseBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.baseBox3.FormattingEnabled = true;
            this.baseBox3.Items.AddRange(new object[] {
            "A",
            "AP",
            "BC",
            "BW",
            "C",
            "EP",
            "TR",
            "ORO",
            "ARG",
            "BRO",
            "BB",
            "DD",
            "BT",
            "PER",
            "NEU"});
            this.baseBox3.Location = new System.Drawing.Point(15, 191);
            this.baseBox3.Name = "baseBox3";
            this.baseBox3.Size = new System.Drawing.Size(69, 26);
            this.baseBox3.TabIndex = 8;
            // 
            // bcBox4
            // 
            this.bcBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.bcBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.bcBox4.Location = new System.Drawing.Point(165, 218);
            this.bcBox4.MaxLength = 5;
            this.bcBox4.Name = "bcBox4";
            this.bcBox4.Size = new System.Drawing.Size(100, 26);
            this.bcBox4.TabIndex = 13;
            this.bcBox4.Tag = "";
            this.bcBox4.Text = " ";
            this.bcBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox4
            // 
            this.volumeBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.volumeBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.volumeBox4.Location = new System.Drawing.Point(90, 217);
            this.volumeBox4.MaxLength = 5;
            this.volumeBox4.Name = "volumeBox4";
            this.volumeBox4.Size = new System.Drawing.Size(69, 26);
            this.volumeBox4.TabIndex = 12;
            this.volumeBox4.Tag = "";
            this.volumeBox4.Text = " ";
            this.volumeBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox4
            // 
            this.baseBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.baseBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.baseBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.baseBox4.FormattingEnabled = true;
            this.baseBox4.Items.AddRange(new object[] {
            "A",
            "AP",
            "BC",
            "BW",
            "C",
            "EP",
            "TR",
            "ORO",
            "ARG",
            "BRO",
            "BB",
            "DD",
            "BT",
            "PER",
            "NEU"});
            this.baseBox4.Location = new System.Drawing.Point(14, 217);
            this.baseBox4.Name = "baseBox4";
            this.baseBox4.Size = new System.Drawing.Size(69, 26);
            this.baseBox4.TabIndex = 11;
            // 
            // bcBox5
            // 
            this.bcBox5.BackColor = System.Drawing.Color.DodgerBlue;
            this.bcBox5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox5.ForeColor = System.Drawing.SystemColors.Menu;
            this.bcBox5.Location = new System.Drawing.Point(165, 245);
            this.bcBox5.MaxLength = 5;
            this.bcBox5.Name = "bcBox5";
            this.bcBox5.Size = new System.Drawing.Size(100, 26);
            this.bcBox5.TabIndex = 16;
            this.bcBox5.Tag = "";
            this.bcBox5.Text = " ";
            this.bcBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox5
            // 
            this.volumeBox5.BackColor = System.Drawing.Color.DodgerBlue;
            this.volumeBox5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox5.ForeColor = System.Drawing.SystemColors.Menu;
            this.volumeBox5.Location = new System.Drawing.Point(90, 244);
            this.volumeBox5.MaxLength = 5;
            this.volumeBox5.Name = "volumeBox5";
            this.volumeBox5.Size = new System.Drawing.Size(69, 26);
            this.volumeBox5.TabIndex = 15;
            this.volumeBox5.Tag = "";
            this.volumeBox5.Text = " ";
            this.volumeBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox5
            // 
            this.baseBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.baseBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox5.BackColor = System.Drawing.Color.DodgerBlue;
            this.baseBox5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox5.ForeColor = System.Drawing.SystemColors.Menu;
            this.baseBox5.FormattingEnabled = true;
            this.baseBox5.Items.AddRange(new object[] {
            "A",
            "AP",
            "BC",
            "BW",
            "C",
            "EP",
            "TR",
            "ORO",
            "ARG",
            "BRO",
            "BB",
            "DD",
            "BT",
            "PER",
            "NEU"});
            this.baseBox5.Location = new System.Drawing.Point(14, 244);
            this.baseBox5.Name = "baseBox5";
            this.baseBox5.Size = new System.Drawing.Size(69, 26);
            this.baseBox5.TabIndex = 14;
            // 
            // bcBox6
            // 
            this.bcBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.bcBox6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox6.ForeColor = System.Drawing.SystemColors.Menu;
            this.bcBox6.Location = new System.Drawing.Point(165, 272);
            this.bcBox6.MaxLength = 5;
            this.bcBox6.Name = "bcBox6";
            this.bcBox6.Size = new System.Drawing.Size(100, 26);
            this.bcBox6.TabIndex = 19;
            this.bcBox6.Tag = "";
            this.bcBox6.Text = " ";
            this.bcBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox6
            // 
            this.volumeBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.volumeBox6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox6.ForeColor = System.Drawing.SystemColors.Menu;
            this.volumeBox6.Location = new System.Drawing.Point(90, 271);
            this.volumeBox6.MaxLength = 5;
            this.volumeBox6.Name = "volumeBox6";
            this.volumeBox6.Size = new System.Drawing.Size(69, 26);
            this.volumeBox6.TabIndex = 18;
            this.volumeBox6.Tag = "";
            this.volumeBox6.Text = " ";
            this.volumeBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox6
            // 
            this.baseBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.baseBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.baseBox6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox6.ForeColor = System.Drawing.SystemColors.Menu;
            this.baseBox6.FormattingEnabled = true;
            this.baseBox6.Items.AddRange(new object[] {
            "A",
            "AP",
            "BC",
            "BW",
            "C",
            "EP",
            "TR",
            "ORO",
            "ARG",
            "BRO",
            "BB",
            "DD",
            "BT",
            "PER",
            "NEU"});
            this.baseBox6.Location = new System.Drawing.Point(14, 271);
            this.baseBox6.Name = "baseBox6";
            this.baseBox6.Size = new System.Drawing.Size(69, 26);
            this.baseBox6.TabIndex = 17;
            // 
            // saveBtn
            // 
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Location = new System.Drawing.Point(14, 308);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(146, 23);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelBtn.Location = new System.Drawing.Point(167, 308);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(99, 23);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(278, 343);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.bcBox6);
            this.Controls.Add(this.volumeBox6);
            this.Controls.Add(this.baseBox6);
            this.Controls.Add(this.bcBox5);
            this.Controls.Add(this.volumeBox5);
            this.Controls.Add(this.baseBox5);
            this.Controls.Add(this.bcBox4);
            this.Controls.Add(this.volumeBox4);
            this.Controls.Add(this.baseBox4);
            this.Controls.Add(this.bcBox3);
            this.Controls.Add(this.volumeBox3);
            this.Controls.Add(this.baseBox3);
            this.Controls.Add(this.bcBox2);
            this.Controls.Add(this.volumeBox2);
            this.Controls.Add(this.baseBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bcBox1);
            this.Controls.Add(this.volumeBox1);
            this.Controls.Add(this.baseBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.brandBox);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "AddForm";
            this.Text = "Database Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox brandBox;
        public System.Windows.Forms.TextBox productBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox baseBox1;
        public System.Windows.Forms.TextBox volumeBox1;
        public System.Windows.Forms.TextBox bcBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox bcBox2;
        public System.Windows.Forms.TextBox volumeBox2;
        public System.Windows.Forms.ComboBox baseBox2;
        public System.Windows.Forms.TextBox bcBox3;
        public System.Windows.Forms.TextBox volumeBox3;
        public System.Windows.Forms.ComboBox baseBox3;
        public System.Windows.Forms.TextBox bcBox4;
        public System.Windows.Forms.TextBox volumeBox4;
        public System.Windows.Forms.ComboBox baseBox4;
        public System.Windows.Forms.TextBox bcBox5;
        public System.Windows.Forms.TextBox volumeBox5;
        public System.Windows.Forms.ComboBox baseBox5;
        public System.Windows.Forms.TextBox bcBox6;
        public System.Windows.Forms.TextBox volumeBox6;
        public System.Windows.Forms.ComboBox baseBox6;
        public System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}