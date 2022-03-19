namespace bov
{
    partial class Cart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteThisOrderLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EstimativeDeliveryDate = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.EstimativeDeliveryDateDisplay = new System.Windows.Forms.TextBox();
            this.TotalCostDisplay = new System.Windows.Forms.TextBox();
            this.IndicationForCustomer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastnameInput = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.TVA = new System.Windows.Forms.Label();
            this.FirstnameInput = new System.Windows.Forms.TextBox();
            this.AdressInput = new System.Windows.Forms.TextBox();
            this.TVAInput = new System.Windows.Forms.TextBox();
            this.YourShoppingCart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoveloLogoPanel = new System.Windows.Forms.Panel();
            this.MountainImagePanel = new System.Windows.Forms.Panel();
            this.BackToTheCatalogBtn = new bov.classes.RoundButton();
            this.SubmitPurchaseBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteThisOrderLineToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 36);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // deleteThisOrderLineToolStripMenuItem
            // 
            this.deleteThisOrderLineToolStripMenuItem.Name = "deleteThisOrderLineToolStripMenuItem";
            this.deleteThisOrderLineToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.deleteThisOrderLineToolStripMenuItem.Text = "Delete this order line";
            // 
            // EstimativeDeliveryDate
            // 
            this.EstimativeDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EstimativeDeliveryDate.Location = new System.Drawing.Point(187, 648);
            this.EstimativeDeliveryDate.Name = "EstimativeDeliveryDate";
            this.EstimativeDeliveryDate.Size = new System.Drawing.Size(185, 30);
            this.EstimativeDeliveryDate.TabIndex = 5;
            this.EstimativeDeliveryDate.Text = "estimative delivery date :";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalPrice.Location = new System.Drawing.Point(281, 690);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(91, 27);
            this.TotalPrice.TabIndex = 6;
            this.TotalPrice.Text = "total price :";
            // 
            // EstimativeDeliveryDateDisplay
            // 
            this.EstimativeDeliveryDateDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstimativeDeliveryDateDisplay.BackColor = System.Drawing.Color.White;
            this.EstimativeDeliveryDateDisplay.Location = new System.Drawing.Point(383, 645);
            this.EstimativeDeliveryDateDisplay.Name = "EstimativeDeliveryDateDisplay";
            this.EstimativeDeliveryDateDisplay.ReadOnly = true;
            this.EstimativeDeliveryDateDisplay.Size = new System.Drawing.Size(141, 26);
            this.EstimativeDeliveryDateDisplay.TabIndex = 7;
            // 
            // TotalCostDisplay
            // 
            this.TotalCostDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalCostDisplay.BackColor = System.Drawing.Color.White;
            this.TotalCostDisplay.Location = new System.Drawing.Point(383, 687);
            this.TotalCostDisplay.Name = "TotalCostDisplay";
            this.TotalCostDisplay.ReadOnly = true;
            this.TotalCostDisplay.Size = new System.Drawing.Size(141, 26);
            this.TotalCostDisplay.TabIndex = 8;
            // 
            // IndicationForCustomer
            // 
            this.IndicationForCustomer.AutoSize = true;
            this.IndicationForCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndicationForCustomer.Location = new System.Drawing.Point(382, 127);
            this.IndicationForCustomer.Name = "IndicationForCustomer";
            this.IndicationForCustomer.Size = new System.Drawing.Size(418, 22);
            this.IndicationForCustomer.TabIndex = 14;
            this.IndicationForCustomer.Text = "Right click on the order line that you want to delete ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(859, 462);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LastnameInput
            // 
            this.LastnameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LastnameInput.Location = new System.Drawing.Point(1415, 450);
            this.LastnameInput.Name = "LastnameInput";
            this.LastnameInput.Size = new System.Drawing.Size(100, 26);
            this.LastnameInput.TabIndex = 5;
            // 
            // Lastname
            // 
            this.Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(1321, 450);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(88, 20);
            this.Lastname.TabIndex = 7;
            this.Lastname.Text = "Lastname :";
            // 
            // Firstname
            // 
            this.Firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(1321, 500);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(88, 20);
            this.Firstname.TabIndex = 8;
            this.Firstname.Text = "Firstname :";
            // 
            // Adress
            // 
            this.Adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(1342, 600);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(67, 20);
            this.Adress.TabIndex = 9;
            this.Adress.Text = "Adress :";
            // 
            // TVA
            // 
            this.TVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TVA.AutoSize = true;
            this.TVA.Location = new System.Drawing.Point(1361, 553);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(48, 20);
            this.TVA.TabIndex = 10;
            this.TVA.Text = "TVA :";
            // 
            // FirstnameInput
            // 
            this.FirstnameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstnameInput.Location = new System.Drawing.Point(1415, 500);
            this.FirstnameInput.Name = "FirstnameInput";
            this.FirstnameInput.Size = new System.Drawing.Size(100, 26);
            this.FirstnameInput.TabIndex = 11;
            // 
            // AdressInput
            // 
            this.AdressInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressInput.Location = new System.Drawing.Point(1415, 597);
            this.AdressInput.Name = "AdressInput";
            this.AdressInput.Size = new System.Drawing.Size(100, 26);
            this.AdressInput.TabIndex = 12;
            // 
            // TVAInput
            // 
            this.TVAInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TVAInput.Location = new System.Drawing.Point(1415, 550);
            this.TVAInput.Name = "TVAInput";
            this.TVAInput.Size = new System.Drawing.Size(100, 26);
            this.TVAInput.TabIndex = 13;
            // 
            // YourShoppingCart
            // 
            this.YourShoppingCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.YourShoppingCart.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourShoppingCart.ForeColor = System.Drawing.Color.White;
            this.YourShoppingCart.Location = new System.Drawing.Point(620, 9);
            this.YourShoppingCart.Name = "YourShoppingCart";
            this.YourShoppingCart.Size = new System.Drawing.Size(392, 81);
            this.YourShoppingCart.TabIndex = 15;
            this.YourShoppingCart.Text = "Your shopping cart";
            this.YourShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.BackToTheCatalogBtn);
            this.panel1.Controls.Add(this.YourShoppingCart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1570, 98);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(193, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1332, 10);
            this.panel2.TabIndex = 15;
            // 
            // BoveloLogoPanel
            // 
            this.BoveloLogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoveloLogoPanel.BackgroundImage")));
            this.BoveloLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoveloLogoPanel.Location = new System.Drawing.Point(30, 127);
            this.BoveloLogoPanel.Name = "BoveloLogoPanel";
            this.BoveloLogoPanel.Size = new System.Drawing.Size(296, 192);
            this.BoveloLogoPanel.TabIndex = 16;
            // 
            // MountainImagePanel
            // 
            this.MountainImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MountainImagePanel.BackgroundImage = global::bov.Properties.Resources.mountain;
            this.MountainImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MountainImagePanel.Location = new System.Drawing.Point(579, 499);
            this.MountainImagePanel.Name = "MountainImagePanel";
            this.MountainImagePanel.Size = new System.Drawing.Size(663, 433);
            this.MountainImagePanel.TabIndex = 17;
            // 
            // BackToTheCatalogBtn
            // 
            this.BackToTheCatalogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.BackToTheCatalogBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.BackToTheCatalogBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BackToTheCatalogBtn.BorderRadius = 20;
            this.BackToTheCatalogBtn.BorderSize = 0;
            this.BackToTheCatalogBtn.FlatAppearance.BorderSize = 0;
            this.BackToTheCatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToTheCatalogBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToTheCatalogBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackToTheCatalogBtn.Location = new System.Drawing.Point(12, 9);
            this.BackToTheCatalogBtn.Name = "BackToTheCatalogBtn";
            this.BackToTheCatalogBtn.Size = new System.Drawing.Size(163, 81);
            this.BackToTheCatalogBtn.TabIndex = 18;
            this.BackToTheCatalogBtn.Text = "Back to the catalog";
            this.BackToTheCatalogBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackToTheCatalogBtn.UseVisualStyleBackColor = false;
            this.BackToTheCatalogBtn.Click += new System.EventHandler(this.BackToTheCatalogBtn_Click);
            // 
            // SubmitPurchaseBtn
            // 
            this.SubmitPurchaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitPurchaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.SubmitPurchaseBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SubmitPurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitPurchaseBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitPurchaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubmitPurchaseBtn.Location = new System.Drawing.Point(1346, 690);
            this.SubmitPurchaseBtn.Name = "SubmitPurchaseBtn";
            this.SubmitPurchaseBtn.Size = new System.Drawing.Size(179, 86);
            this.SubmitPurchaseBtn.TabIndex = 18;
            this.SubmitPurchaseBtn.Text = "Confirm the order";
            this.SubmitPurchaseBtn.UseVisualStyleBackColor = false;
            this.SubmitPurchaseBtn.Click += new System.EventHandler(this.SubmitPurchaseBtn_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1570, 813);
            this.Controls.Add(this.SubmitPurchaseBtn);
            this.Controls.Add(this.BoveloLogoPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IndicationForCustomer);
            this.Controls.Add(this.TotalCostDisplay);
            this.Controls.Add(this.EstimativeDeliveryDateDisplay);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.EstimativeDeliveryDate);
            this.Controls.Add(this.TVAInput);
            this.Controls.Add(this.AdressInput);
            this.Controls.Add(this.FirstnameInput);
            this.Controls.Add(this.TVA);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.LastnameInput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MountainImagePanel);
            this.Name = "Cart";
            this.Text = "Cart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cart_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteThisOrderLineToolStripMenuItem;

        private System.Windows.Forms.Label EstimativeDeliveryDate;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.TextBox EstimativeDeliveryDateDisplay;
        private System.Windows.Forms.TextBox TotalCostDisplay;
        private System.Windows.Forms.Label IndicationForCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox LastnameInput;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label TVA;
        private System.Windows.Forms.TextBox FirstnameInput;
        private System.Windows.Forms.TextBox AdressInput;
        private System.Windows.Forms.TextBox TVAInput;
        private System.Windows.Forms.Label YourShoppingCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel BoveloLogoPanel;
        private System.Windows.Forms.Panel MountainImagePanel;
        private classes.RoundButton BackToTheCatalogBtn;
        private System.Windows.Forms.Button SubmitPurchaseBtn;
    }
}