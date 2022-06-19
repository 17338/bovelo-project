
namespace bov.Stock
{
    partial class Stock
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
            this.PartName = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.MaskedTextBox();
            this.ColorInput = new System.Windows.Forms.MaskedTextBox();
            this.Color = new System.Windows.Forms.Label();
            this.SizeInput = new System.Windows.Forms.MaskedTextBox();
            this.Size = new System.Windows.Forms.Label();
            this.QuantityInput = new System.Windows.Forms.MaskedTextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.LocationInput = new System.Windows.Forms.MaskedTextBox();
            this.Location = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.MaskedTextBox();
            this.StockView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StockView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartName
            // 
            this.PartName.AutoSize = true;
            this.PartName.Location = new System.Drawing.Point(128, 128);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(59, 20);
            this.PartName.TabIndex = 0;
            this.PartName.Text = "Name :";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(202, 124);
            this.NameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 26);
            this.NameInput.TabIndex = 1;
            // 
            // ColorInput
            // 
            this.ColorInput.Location = new System.Drawing.Point(202, 215);
            this.ColorInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorInput.Name = "ColorInput";
            this.ColorInput.Size = new System.Drawing.Size(100, 26);
            this.ColorInput.TabIndex = 3;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(128, 218);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(54, 20);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color :";
            // 
            // SizeInput
            // 
            this.SizeInput.Location = new System.Drawing.Point(202, 319);
            this.SizeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SizeInput.Name = "SizeInput";
            this.SizeInput.Size = new System.Drawing.Size(100, 26);
            this.SizeInput.TabIndex = 5;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(128, 322);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(48, 20);
            this.Size.TabIndex = 4;
            this.Size.Text = "Size :";
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(202, 429);
            this.QuantityInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(100, 26);
            this.QuantityInput.TabIndex = 7;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(128, 432);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(76, 20);
            this.Quantity.TabIndex = 6;
            this.Quantity.Text = "Quantity :";
            // 
            // LocationInput
            // 
            this.LocationInput.Location = new System.Drawing.Point(202, 532);
            this.LocationInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocationInput.Name = "LocationInput";
            this.LocationInput.Size = new System.Drawing.Size(100, 26);
            this.LocationInput.TabIndex = 9;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(128, 536);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(78, 20);
            this.Location.TabIndex = 8;
            this.Location.Text = "Location :";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(27, 578);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(96, 35);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(144, 580);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 32);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(255, 580);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(94, 32);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1116, 98);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 32);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(620, 100);
            this.SearchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(455, 26);
            this.SearchInput.TabIndex = 14;
            // 
            // StockView
            // 
            this.StockView.AllowUserToAddRows = false;
            this.StockView.AllowUserToDeleteRows = false;
            this.StockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockView.Location = new System.Drawing.Point(493, 192);
            this.StockView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StockView.Name = "StockView";
            this.StockView.ReadOnly = true;
            this.StockView.RowHeadersWidth = 62;
            this.StockView.RowTemplate.Height = 28;
            this.StockView.Size = new System.Drawing.Size(979, 461);
            this.StockView.TabIndex = 15;
            this.StockView.DoubleClick += new System.EventHandler(this.StockView_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(819, 678);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "5. White";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(671, 678);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "3. Green";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 678);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "4. Black";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "2. Blue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "1. Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 678);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Color:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(607, 744);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "2. 28\'\'";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 744);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "1. 26\'\'";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 744);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Size:";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 805);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StockView);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LocationInput);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.SizeInput);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.ColorInput);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.PartName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Stock";
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartName;
        private System.Windows.Forms.MaskedTextBox NameInput;
        private System.Windows.Forms.MaskedTextBox ColorInput;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.MaskedTextBox SizeInput;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.MaskedTextBox QuantityInput;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.MaskedTextBox LocationInput;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.MaskedTextBox SearchInput;
        private System.Windows.Forms.DataGridView StockView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
    }
}