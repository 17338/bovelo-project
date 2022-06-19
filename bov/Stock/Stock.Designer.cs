
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDInput = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartName
            // 
            this.PartName.AutoSize = true;
            this.PartName.Location = new System.Drawing.Point(114, 102);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(53, 17);
            this.PartName.TabIndex = 0;
            this.PartName.Text = "Name :";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(180, 99);
            this.NameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(89, 22);
            this.NameInput.TabIndex = 1;
            // 
            // ColorInput
            // 
            this.ColorInput.Location = new System.Drawing.Point(180, 172);
            this.ColorInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorInput.Name = "ColorInput";
            this.ColorInput.Size = new System.Drawing.Size(89, 22);
            this.ColorInput.TabIndex = 3;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(114, 174);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(49, 17);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color :";
            // 
            // SizeInput
            // 
            this.SizeInput.Location = new System.Drawing.Point(180, 255);
            this.SizeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SizeInput.Name = "SizeInput";
            this.SizeInput.Size = new System.Drawing.Size(89, 22);
            this.SizeInput.TabIndex = 5;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(114, 258);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(43, 17);
            this.Size.TabIndex = 4;
            this.Size.Text = "Size :";
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(180, 343);
            this.QuantityInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(89, 22);
            this.QuantityInput.TabIndex = 7;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(114, 346);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(69, 17);
            this.Quantity.TabIndex = 6;
            this.Quantity.Text = "Quantity :";
            // 
            // LocationInput
            // 
            this.LocationInput.Location = new System.Drawing.Point(180, 426);
            this.LocationInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocationInput.Name = "LocationInput";
            this.LocationInput.Size = new System.Drawing.Size(89, 22);
            this.LocationInput.TabIndex = 9;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(114, 429);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(70, 17);
            this.Location.TabIndex = 8;
            this.Location.Text = "Location :";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(24, 462);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(85, 28);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(128, 464);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(84, 26);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(227, 464);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(84, 26);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(992, 78);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(84, 26);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(551, 80);
            this.SearchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(405, 22);
            this.SearchInput.TabIndex = 14;
            // 
            // StockView
            // 
            this.StockView.AllowUserToAddRows = false;
            this.StockView.AllowUserToDeleteRows = false;
            this.StockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockView.Location = new System.Drawing.Point(438, 154);
            this.StockView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StockView.Name = "StockView";
            this.StockView.ReadOnly = true;
            this.StockView.RowHeadersWidth = 62;
            this.StockView.RowTemplate.Height = 28;
            this.StockView.Size = new System.Drawing.Size(870, 369);
            this.StockView.TabIndex = 15;
            this.StockView.DoubleClick += new System.EventHandler(this.StockView_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID :";
            // 
            // IDInput
            // 
            this.IDInput.Location = new System.Drawing.Point(180, 22);
            this.IDInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDInput.Name = "IDInput";
            this.IDInput.Size = new System.Drawing.Size(89, 22);
            this.IDInput.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDInput);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox IDInput;
        private System.Windows.Forms.Button button1;
    }
}