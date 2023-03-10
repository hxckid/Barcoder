using System.Drawing;

namespace Barcoder
{
    public enum AppMode { Maxidom = 5, Petrovich = 6 }

    partial class Barcoder
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcoder));
            this.brandsBox = new System.Windows.Forms.ComboBox();
            this.productsBox = new System.Windows.Forms.ComboBox();
            this.copiedLabel = new System.Windows.Forms.Label();
            this.dataBtn1 = new System.Windows.Forms.Button();
            this.dataBtn2 = new System.Windows.Forms.Button();
            this.dataBtn3 = new System.Windows.Forms.Button();
            this.dataBtn4 = new System.Windows.Forms.Button();
            this.dataBtn5 = new System.Windows.Forms.Button();
            this.dataBtn6 = new System.Windows.Forms.Button();
            this.dataBtn7 = new System.Windows.Forms.Button();
            this.dataBtn8 = new System.Windows.Forms.Button();
            this.switchModeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brandsBox
            // 
            this.brandsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandsBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brandsBox.DisplayMember = "Brand";
            this.brandsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandsBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandsBox.ForeColor = System.Drawing.Color.Black;
            this.brandsBox.FormattingEnabled = true;
            this.brandsBox.ItemHeight = 24;
            this.brandsBox.Location = new System.Drawing.Point(10, 10);
            this.brandsBox.MaxDropDownItems = 10;
            this.brandsBox.Name = "brandsBox";
            this.brandsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brandsBox.Size = new System.Drawing.Size(256, 32);
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
            this.productsBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsBox.ForeColor = System.Drawing.Color.Black;
            this.productsBox.FormattingEnabled = true;
            this.productsBox.ItemHeight = 24;
            this.productsBox.Location = new System.Drawing.Point(10, 50);
            this.productsBox.MaxDropDownItems = 10;
            this.productsBox.Name = "productsBox";
            this.productsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productsBox.Size = new System.Drawing.Size(256, 32);
            this.productsBox.Sorted = true;
            this.productsBox.TabIndex = 1;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.productsBox_SelectedIndexChanged);
            // 
            // copiedLabel
            // 
            this.copiedLabel.AutoSize = true;
            this.copiedLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.copiedLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copiedLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.copiedLabel.Location = new System.Drawing.Point(0, 433);
            this.copiedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.copiedLabel.Name = "copiedLabel";
            this.copiedLabel.Padding = new System.Windows.Forms.Padding(55, 0, 0, 5);
            this.copiedLabel.Size = new System.Drawing.Size(55, 29);
            this.copiedLabel.TabIndex = 3;
            this.copiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataBtn1
            // 
            this.dataBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn1.Location = new System.Drawing.Point(10, 90);
            this.dataBtn1.Name = "dataBtn1";
            this.dataBtn1.Size = new System.Drawing.Size(256, 41);
            this.dataBtn1.TabIndex = 3;
            this.dataBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn1.UseVisualStyleBackColor = true;
            this.dataBtn1.Click += new System.EventHandler(this.dataBtn1_Click);
            // 
            // dataBtn2
            // 
            this.dataBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn2.Location = new System.Drawing.Point(10, 130);
            this.dataBtn2.Name = "dataBtn2";
            this.dataBtn2.Size = new System.Drawing.Size(256, 41);
            this.dataBtn2.TabIndex = 4;
            this.dataBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn2.UseVisualStyleBackColor = true;
            this.dataBtn2.Click += new System.EventHandler(this.dataBtn2_Click);
            // 
            // dataBtn3
            // 
            this.dataBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn3.Location = new System.Drawing.Point(10, 170);
            this.dataBtn3.Name = "dataBtn3";
            this.dataBtn3.Size = new System.Drawing.Size(256, 41);
            this.dataBtn3.TabIndex = 5;
            this.dataBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn3.UseVisualStyleBackColor = true;
            this.dataBtn3.Click += new System.EventHandler(this.dataBtn3_Click);
            // 
            // dataBtn4
            // 
            this.dataBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn4.Location = new System.Drawing.Point(10, 210);
            this.dataBtn4.Name = "dataBtn4";
            this.dataBtn4.Size = new System.Drawing.Size(256, 41);
            this.dataBtn4.TabIndex = 6;
            this.dataBtn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn4.UseVisualStyleBackColor = true;
            this.dataBtn4.Click += new System.EventHandler(this.dataBtn4_Click);
            // 
            // dataBtn5
            // 
            this.dataBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn5.Location = new System.Drawing.Point(10, 250);
            this.dataBtn5.Name = "dataBtn5";
            this.dataBtn5.Size = new System.Drawing.Size(256, 41);
            this.dataBtn5.TabIndex = 7;
            this.dataBtn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn5.UseVisualStyleBackColor = true;
            this.dataBtn5.Click += new System.EventHandler(this.dataBtn5_Click);
            // 
            // dataBtn6
            // 
            this.dataBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn6.Location = new System.Drawing.Point(10, 290);
            this.dataBtn6.Name = "dataBtn6";
            this.dataBtn6.Size = new System.Drawing.Size(256, 41);
            this.dataBtn6.TabIndex = 8;
            this.dataBtn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn6.UseVisualStyleBackColor = true;
            this.dataBtn6.Click += new System.EventHandler(this.dataBtn6_Click);
            // 
            // dataBtn7
            // 
            this.dataBtn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn7.Location = new System.Drawing.Point(10, 330);
            this.dataBtn7.Name = "dataBtn7";
            this.dataBtn7.Size = new System.Drawing.Size(256, 41);
            this.dataBtn7.TabIndex = 9;
            this.dataBtn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn7.UseVisualStyleBackColor = true;
            this.dataBtn7.Click += new System.EventHandler(this.dataBtn7_Click);
            // 
            // dataBtn8
            // 
            this.dataBtn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBtn8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBtn8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataBtn8.Location = new System.Drawing.Point(10, 370);
            this.dataBtn8.Name = "dataBtn8";
            this.dataBtn8.Size = new System.Drawing.Size(256, 41);
            this.dataBtn8.TabIndex = 10;
            this.dataBtn8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBtn8.UseVisualStyleBackColor = true;
            this.dataBtn8.Click += new System.EventHandler(this.dataBtn8_Click);
            // 
            // switchModeLabel
            // 
            this.switchModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.switchModeLabel.AutoSize = true;
            this.switchModeLabel.Location = new System.Drawing.Point(1, 449);
            this.switchModeLabel.Name = "switchModeLabel";
            this.switchModeLabel.Size = new System.Drawing.Size(10, 13);
            this.switchModeLabel.TabIndex = 11;
            this.switchModeLabel.Text = ".";
            // 
            // Barcoder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(275, 462);
            this.Controls.Add(this.switchModeLabel);
            this.Controls.Add(this.dataBtn8);
            this.Controls.Add(this.dataBtn7);
            this.Controls.Add(this.dataBtn6);
            this.Controls.Add(this.dataBtn5);
            this.Controls.Add(this.dataBtn4);
            this.Controls.Add(this.dataBtn3);
            this.Controls.Add(this.dataBtn2);
            this.Controls.Add(this.dataBtn1);
            this.Controls.Add(this.copiedLabel);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.brandsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcoder";
            this.ShowIcon = false;
            this.Text = "Bcoder PRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brandsBox;
        private System.Windows.Forms.ComboBox productsBox;
        private System.Windows.Forms.Label copiedLabel;
        private System.Windows.Forms.Button dataBtn1;
        private System.Windows.Forms.Button dataBtn2;
        private System.Windows.Forms.Button dataBtn3;
        private System.Windows.Forms.Button dataBtn4;
        private System.Windows.Forms.Button dataBtn5;
        private System.Windows.Forms.Button dataBtn6;
        private System.Windows.Forms.Button dataBtn7;
        private System.Windows.Forms.Button dataBtn8;
        private System.Windows.Forms.Label switchModeLabel;
    }
}

