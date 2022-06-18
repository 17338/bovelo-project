
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 30);
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
            this.CyclistImagePanel.Location = new System.Drawing.Point(992, 427);
            this.CyclistImagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CyclistImagePanel.Name = "CyclistImagePanel";
            this.CyclistImagePanel.Size = new System.Drawing.Size(393, 279);
            this.CyclistImagePanel.TabIndex = 31;
            // 
            // Cyclist1ImagePanel
            // 
            this.Cyclist1ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cyclist1ImagePanel.BackgroundImage = global::bov.Properties.Resources.cyclist1;
            this.Cyclist1ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cyclist1ImagePanel.Location = new System.Drawing.Point(0, 427);
            this.Cyclist1ImagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cyclist1ImagePanel.Name = "Cyclist1ImagePanel";
            this.Cyclist1ImagePanel.Size = new System.Drawing.Size(355, 259);
            this.Cyclist1ImagePanel.TabIndex = 30;
            // 
            // BoveloLogoPanel
            // 
            this.BoveloLogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoveloLogoPanel.BackgroundImage")));
            this.BoveloLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoveloLogoPanel.Location = new System.Drawing.Point(16, 131);
            this.BoveloLogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoveloLogoPanel.Name = "BoveloLogoPanel";
            this.BoveloLogoPanel.Size = new System.Drawing.Size(263, 154);
            this.BoveloLogoPanel.TabIndex = 32;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1377, 30);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Catalog";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Planning Worker";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Planning Manager";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Stock";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Order Parts";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "User Setting";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 677);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoveloLogoPanel);
            this.Controls.Add(this.CyclistImagePanel);
            this.Controls.Add(this.Cyclist1ImagePanel);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TheMainMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Options;
        private System.Windows.Forms.Panel Cyclist1ImagePanel;
        private System.Windows.Forms.Panel CyclistImagePanel;
        private System.Windows.Forms.Panel BoveloLogoPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}