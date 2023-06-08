namespace DBH
{
    partial class AddForm
    {
        public static string[] bases = {
            "A","AP","ARG",
            "BB","BC","BRO","BT","BW",
            "C",
            "D","DD",
            "EC","EP",
            "KA","KC","KTA",
            "MRA","MRC",
            "NEU",
            "ORO",
            "PER",
            "TR",
            "VC","VVA",
            "Б1","Б3",
            "Гл",
            "Мат",
            "П/м","П/гл"};
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
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
            this.baseBox7 = new System.Windows.Forms.ComboBox();
            this.volumeBox7 = new System.Windows.Forms.TextBox();
            this.bcBox7 = new System.Windows.Forms.TextBox();
            this.baseBox8 = new System.Windows.Forms.ComboBox();
            this.volumeBox8 = new System.Windows.Forms.TextBox();
            this.bcBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brandBox
            // 
            this.brandBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.brandBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.brandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.brandBox.FormattingEnabled = true;
            this.brandBox.Items.AddRange(DBH.Helper.brands.ToArray());
            this.brandBox.Location = new System.Drawing.Point(74, 31);
            this.brandBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(176, 32);
            this.brandBox.Sorted = true;
            this.brandBox.TabIndex = 0;
            // 
            // productBox
            // 
            this.productBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.productBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productBox.Location = new System.Drawing.Point(15, 95);
            this.productBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(293, 29);
            this.productBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бренд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название продукта";
            // 
            // baseBox1
            // 
            this.baseBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox1.FormattingEnabled = true;
            this.baseBox1.Items.AddRange(DBH.AddForm.bases); 
            this.baseBox1.Location = new System.Drawing.Point(14, 169);
            this.baseBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox1.Name = "baseBox1";
            this.baseBox1.Size = new System.Drawing.Size(95, 28);
            this.baseBox1.Sorted = true;
            this.baseBox1.TabIndex = 2;
            // 
            // volumeBox1
            // 
            this.volumeBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox1.Location = new System.Drawing.Point(113, 169);
            this.volumeBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox1.MaxLength = 0;
            this.volumeBox1.Name = "volumeBox1";
            this.volumeBox1.Size = new System.Drawing.Size(91, 26);
            this.volumeBox1.TabIndex = 3;
            this.volumeBox1.Tag = "";
            this.volumeBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bcBox1
            // 
            this.bcBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox1.Location = new System.Drawing.Point(208, 169);
            this.bcBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox1.MaxLength = 0;
            this.bcBox1.Name = "bcBox1";
            this.bcBox1.Size = new System.Drawing.Size(100, 26);
            this.bcBox1.TabIndex = 4;
            this.bcBox1.Tag = "";
            this.bcBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "База";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(125, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Объем";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(226, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Баркод";
            // 
            // bcBox2
            // 
            this.bcBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox2.Location = new System.Drawing.Point(208, 202);
            this.bcBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox2.MaxLength = 0;
            this.bcBox2.Name = "bcBox2";
            this.bcBox2.Size = new System.Drawing.Size(100, 26);
            this.bcBox2.TabIndex = 7;
            this.bcBox2.Tag = "";
            this.bcBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox2
            // 
            this.volumeBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox2.Location = new System.Drawing.Point(113, 202);
            this.volumeBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox2.MaxLength = 0;
            this.volumeBox2.Name = "volumeBox2";
            this.volumeBox2.Size = new System.Drawing.Size(91, 26);
            this.volumeBox2.TabIndex = 6;
            this.volumeBox2.Tag = "";
            this.volumeBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox2
            // 
            this.baseBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox2.FormattingEnabled = true;
            this.baseBox2.Items.AddRange(DBH.AddForm.bases);
            this.baseBox2.Location = new System.Drawing.Point(14, 202);
            this.baseBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox2.Name = "baseBox2";
            this.baseBox2.Size = new System.Drawing.Size(95, 28);
            this.baseBox2.Sorted = true;
            this.baseBox2.TabIndex = 5;
            // 
            // bcBox3
            // 
            this.bcBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox3.Location = new System.Drawing.Point(208, 235);
            this.bcBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox3.MaxLength = 0;
            this.bcBox3.Name = "bcBox3";
            this.bcBox3.Size = new System.Drawing.Size(100, 26);
            this.bcBox3.TabIndex = 10;
            this.bcBox3.Tag = "";
            this.bcBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox3
            // 
            this.volumeBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox3.Location = new System.Drawing.Point(113, 235);
            this.volumeBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox3.MaxLength = 0;
            this.volumeBox3.Name = "volumeBox3";
            this.volumeBox3.Size = new System.Drawing.Size(91, 26);
            this.volumeBox3.TabIndex = 9;
            this.volumeBox3.Tag = "";
            this.volumeBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox3
            // 
            this.baseBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox3.FormattingEnabled = true;
            this.baseBox3.Items.AddRange(DBH.AddForm.bases);
            this.baseBox3.Location = new System.Drawing.Point(14, 235);
            this.baseBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox3.Name = "baseBox3";
            this.baseBox3.Size = new System.Drawing.Size(95, 28);
            this.baseBox3.Sorted = true;
            this.baseBox3.TabIndex = 8;
            // 
            // bcBox4
            // 
            this.bcBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox4.Location = new System.Drawing.Point(208, 268);
            this.bcBox4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox4.MaxLength = 0;
            this.bcBox4.Name = "bcBox4";
            this.bcBox4.Size = new System.Drawing.Size(100, 26);
            this.bcBox4.TabIndex = 13;
            this.bcBox4.Tag = "";
            this.bcBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox4
            // 
            this.volumeBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox4.Location = new System.Drawing.Point(113, 268);
            this.volumeBox4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox4.MaxLength = 0;
            this.volumeBox4.Name = "volumeBox4";
            this.volumeBox4.Size = new System.Drawing.Size(91, 26);
            this.volumeBox4.TabIndex = 12;
            this.volumeBox4.Tag = "";
            this.volumeBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox4
            // 
            this.baseBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox4.FormattingEnabled = true;
            this.baseBox4.Items.AddRange(DBH.AddForm.bases);
            this.baseBox4.Location = new System.Drawing.Point(14, 268);
            this.baseBox4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox4.Name = "baseBox4";
            this.baseBox4.Size = new System.Drawing.Size(95, 28);
            this.baseBox4.Sorted = true;
            this.baseBox4.TabIndex = 11;
            // 
            // bcBox5
            // 
            this.bcBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox5.Location = new System.Drawing.Point(208, 302);
            this.bcBox5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox5.MaxLength = 0;
            this.bcBox5.Name = "bcBox5";
            this.bcBox5.Size = new System.Drawing.Size(100, 26);
            this.bcBox5.TabIndex = 16;
            this.bcBox5.Tag = "";
            this.bcBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox5
            // 
            this.volumeBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox5.Location = new System.Drawing.Point(113, 302);
            this.volumeBox5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox5.MaxLength = 0;
            this.volumeBox5.Name = "volumeBox5";
            this.volumeBox5.Size = new System.Drawing.Size(91, 26);
            this.volumeBox5.TabIndex = 15;
            this.volumeBox5.Tag = "";
            this.volumeBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox5
            // 
            this.baseBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox5.FormattingEnabled = true;
            this.baseBox5.Items.AddRange(DBH.AddForm.bases);
            this.baseBox5.Location = new System.Drawing.Point(14, 302);
            this.baseBox5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox5.Name = "baseBox5";
            this.baseBox5.Size = new System.Drawing.Size(95, 28);
            this.baseBox5.Sorted = true;
            this.baseBox5.TabIndex = 14;
            // 
            // bcBox6
            // 
            this.bcBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox6.Location = new System.Drawing.Point(208, 335);
            this.bcBox6.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox6.MaxLength = 0;
            this.bcBox6.Name = "bcBox6";
            this.bcBox6.Size = new System.Drawing.Size(100, 26);
            this.bcBox6.TabIndex = 19;
            this.bcBox6.Tag = "";
            this.bcBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeBox6
            // 
            this.volumeBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox6.Location = new System.Drawing.Point(113, 335);
            this.volumeBox6.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox6.MaxLength = 0;
            this.volumeBox6.Name = "volumeBox6";
            this.volumeBox6.Size = new System.Drawing.Size(91, 26);
            this.volumeBox6.TabIndex = 18;
            this.volumeBox6.Tag = "";
            this.volumeBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox6
            // 
            this.baseBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox6.FormattingEnabled = true;
            this.baseBox6.Items.AddRange(DBH.AddForm.bases);
            this.baseBox6.Location = new System.Drawing.Point(14, 335);
            this.baseBox6.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox6.Name = "baseBox6";
            this.baseBox6.Size = new System.Drawing.Size(95, 28);
            this.baseBox6.Sorted = true;
            this.baseBox6.TabIndex = 17;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Location = new System.Drawing.Point(11, 454);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(146, 28);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelBtn.Location = new System.Drawing.Point(161, 454);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(147, 28);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // baseBox7
            // 
            this.baseBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox7.FormattingEnabled = true;
            this.baseBox7.Items.AddRange(DBH.AddForm.bases);
            this.baseBox7.Location = new System.Drawing.Point(14, 368);
            this.baseBox7.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox7.Name = "baseBox7";
            this.baseBox7.Size = new System.Drawing.Size(95, 28);
            this.baseBox7.Sorted = true;
            this.baseBox7.TabIndex = 20;
            // 
            // volumeBox7
            // 
            this.volumeBox7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox7.Location = new System.Drawing.Point(113, 368);
            this.volumeBox7.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox7.MaxLength = 0;
            this.volumeBox7.Name = "volumeBox7";
            this.volumeBox7.Size = new System.Drawing.Size(91, 26);
            this.volumeBox7.TabIndex = 21;
            this.volumeBox7.Tag = "";
            this.volumeBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bcBox7
            // 
            this.bcBox7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox7.Location = new System.Drawing.Point(208, 368);
            this.bcBox7.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox7.MaxLength = 0;
            this.bcBox7.Name = "bcBox7";
            this.bcBox7.Size = new System.Drawing.Size(100, 26);
            this.bcBox7.TabIndex = 22;
            this.bcBox7.Tag = "";
            this.bcBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baseBox8
            // 
            this.baseBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.baseBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.baseBox8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.baseBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baseBox8.FormattingEnabled = true;
            this.baseBox8.Items.AddRange(DBH.AddForm.bases);
            this.baseBox8.Location = new System.Drawing.Point(14, 401);
            this.baseBox8.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.baseBox8.Name = "baseBox8";
            this.baseBox8.Size = new System.Drawing.Size(95, 28);
            this.baseBox8.Sorted = true;
            this.baseBox8.TabIndex = 23;
            // 
            // volumeBox8
            // 
            this.volumeBox8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volumeBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.volumeBox8.Location = new System.Drawing.Point(113, 401);
            this.volumeBox8.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.volumeBox8.MaxLength = 0;
            this.volumeBox8.Name = "volumeBox8";
            this.volumeBox8.Size = new System.Drawing.Size(91, 26);
            this.volumeBox8.TabIndex = 24;
            this.volumeBox8.Tag = "";
            this.volumeBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bcBox8
            // 
            this.bcBox8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bcBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bcBox8.Location = new System.Drawing.Point(208, 401);
            this.bcBox8.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcBox8.MaxLength = 0;
            this.bcBox8.Name = "bcBox8";
            this.bcBox8.Size = new System.Drawing.Size(100, 26);
            this.bcBox8.TabIndex = 25;
            this.bcBox8.Tag = "";
            this.bcBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(319, 495);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.bcBox8);
            this.Controls.Add(this.bcBox7);
            this.Controls.Add(this.volumeBox8);
            this.Controls.Add(this.bcBox6);
            this.Controls.Add(this.volumeBox7);
            this.Controls.Add(this.baseBox8);
            this.Controls.Add(this.volumeBox6);
            this.Controls.Add(this.baseBox7);
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
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "AddForm";
            this.Text = "Database Helper";
            this.TopMost = true;
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
        public System.Windows.Forms.ComboBox baseBox7;
        public System.Windows.Forms.TextBox volumeBox7;
        public System.Windows.Forms.TextBox bcBox7;
        public System.Windows.Forms.ComboBox baseBox8;
        public System.Windows.Forms.TextBox volumeBox8;
        public System.Windows.Forms.TextBox bcBox8;
    }
}