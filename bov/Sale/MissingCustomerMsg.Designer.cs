
namespace bov
{
    partial class MissingCustomerMsg
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerMissing = new System.Windows.Forms.Label();
            this.MissingCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 326);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(652, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 326);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 27);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 27);
            this.panel1.TabIndex = 10;
            // 
            // CustomerMissing
            // 
            this.CustomerMissing.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerMissing.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CustomerMissing.Location = new System.Drawing.Point(106, 95);
            this.CustomerMissing.Name = "CustomerMissing";
            this.CustomerMissing.Size = new System.Drawing.Size(457, 43);
            this.CustomerMissing.TabIndex = 14;
            this.CustomerMissing.Text = "YOU FORGOT TO PUT A CUSTOMER";
            // 
            // MissingCustomerBtn
            // 
            this.MissingCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MissingCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.MissingCustomerBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MissingCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissingCustomerBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingCustomerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MissingCustomerBtn.Location = new System.Drawing.Point(241, 192);
            this.MissingCustomerBtn.Name = "MissingCustomerBtn";
            this.MissingCustomerBtn.Size = new System.Drawing.Size(169, 79);
            this.MissingCustomerBtn.TabIndex = 15;
            this.MissingCustomerBtn.Text = "OKAY";
            this.MissingCustomerBtn.UseVisualStyleBackColor = false;
            this.MissingCustomerBtn.Click += new System.EventHandler(this.submitPurchase_Click);
            // 
            // MissingCustomerMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 380);
            this.Controls.Add(this.MissingCustomerBtn);
            this.Controls.Add(this.CustomerMissing);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MissingCustomerMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMissingMsg";
            this.Load += new System.EventHandler(this.CustomerMissingMsg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CustomerMissing;
        private System.Windows.Forms.Button MissingCustomerBtn;
    }
}