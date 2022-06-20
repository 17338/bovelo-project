
namespace Bovelo
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.TheMainMenu = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Options = new System.Windows.Forms.Label();
            this.CyclistImagePanel = new System.Windows.Forms.Panel();
            this.Cyclist1ImagePanel = new System.Windows.Forms.Panel();
            this.BoveloLogoPanel = new System.Windows.Forms.Panel();
            this.Stock = new System.Windows.Forms.Label();
            this.UserSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Planning = new System.Windows.Forms.Label();
            this.Catalog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheMainMenu
            // 
            this.TheMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TheMainMenu.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheMainMenu.ForeColor = System.Drawing.Color.White;
            this.TheMainMenu.Location = new System.Drawing.Point(585, 14);
            this.TheMainMenu.Name = "TheMainMenu";
            this.TheMainMenu.Size = new System.Drawing.Size(191, 46);
            this.TheMainMenu.TabIndex = 3;
            this.TheMainMenu.Text = "Main menu";
            this.TheMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1340, 8);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.TheMainMenu);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 83);
            this.panel1.TabIndex = 20;
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Options.Location = new System.Drawing.Point(222, 131);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(933, 44);
            this.Options.TabIndex = 26;
            this.Options.Text = "You can select one of the options below :";
            this.Options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CyclistImagePanel
            // 
            this.CyclistImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CyclistImagePanel.BackgroundImage = global::bov.Properties.Resources.cyclist;
            this.CyclistImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CyclistImagePanel.Location = new System.Drawing.Point(1079, 502);
            this.CyclistImagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CyclistImagePanel.Name = "CyclistImagePanel";
            this.CyclistImagePanel.Size = new System.Drawing.Size(306, 205);
            this.CyclistImagePanel.TabIndex = 31;
            // 
            // Cyclist1ImagePanel
            // 
            this.Cyclist1ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cyclist1ImagePanel.BackgroundImage = global::bov.Properties.Resources.cyclist1;
            this.Cyclist1ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cyclist1ImagePanel.Location = new System.Drawing.Point(0, 502);
            this.Cyclist1ImagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cyclist1ImagePanel.Name = "Cyclist1ImagePanel";
            this.Cyclist1ImagePanel.Size = new System.Drawing.Size(240, 185);
            this.Cyclist1ImagePanel.TabIndex = 30;
            // 
            // BoveloLogoPanel
            // 
            this.BoveloLogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoveloLogoPanel.BackgroundImage")));
            this.BoveloLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoveloLogoPanel.Location = new System.Drawing.Point(16, 124);
            this.BoveloLogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoveloLogoPanel.Name = "BoveloLogoPanel";
            this.BoveloLogoPanel.Size = new System.Drawing.Size(263, 154);
            this.BoveloLogoPanel.TabIndex = 32;
            // 
            // Stock
            // 
            this.Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Stock.Location = new System.Drawing.Point(587, 518);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(223, 42);
            this.Stock.TabIndex = 43;
            this.Stock.Text = "STOCK";
            this.Stock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // UserSettings
            // 
            this.UserSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserSettings.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSettings.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserSettings.Location = new System.Drawing.Point(546, 582);
            this.UserSettings.Name = "UserSettings";
            this.UserSettings.Size = new System.Drawing.Size(324, 40);
            this.UserSettings.TabIndex = 41;
            this.UserSettings.Text = "USER SETTINGS";
            this.UserSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserSettings.Click += new System.EventHandler(this.UserSettings_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(513, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 42);
            this.label1.TabIndex = 45;
            this.label1.Text = "ORDER PARTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(567, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 42);
            this.label2.TabIndex = 44;
            this.label2.Text = "PLANNING WORKER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Planning
            // 
            this.Planning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Planning.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Planning.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Planning.Location = new System.Drawing.Point(557, 291);
            this.Planning.Name = "Planning";
            this.Planning.Size = new System.Drawing.Size(300, 42);
            this.Planning.TabIndex = 42;
            this.Planning.Text = "PLANNING MANAGER";
            this.Planning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Planning.Click += new System.EventHandler(this.Planning_Click);
            // 
            // Catalog
            // 
            this.Catalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Catalog.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalog.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Catalog.Location = new System.Drawing.Point(587, 225);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(270, 42);
            this.Catalog.TabIndex = 40;
            this.Catalog.Text = "CATALOG";
            this.Catalog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Catalog.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 677);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.UserSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Planning);
            this.Controls.Add(this.Catalog);
            this.Controls.Add(this.BoveloLogoPanel);
            this.Controls.Add(this.CyclistImagePanel);
            this.Controls.Add(this.Cyclist1ImagePanel);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TheMainMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Options;
        private System.Windows.Forms.Panel Cyclist1ImagePanel;
        private System.Windows.Forms.Panel CyclistImagePanel;
        private System.Windows.Forms.Panel BoveloLogoPanel;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label UserSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Planning;
        private System.Windows.Forms.Label Catalog;
    }
}