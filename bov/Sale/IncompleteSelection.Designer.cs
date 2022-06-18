
namespace bov.Sale
{
    partial class IncompleteSelection
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
            this.IncompleteSelectionTxt = new System.Windows.Forms.Label();
            this.IncompleteSelectionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 328);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(651, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 328);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 27);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 27);
            this.panel1.TabIndex = 10;
            // 
            // IncompleteSelectionTxt
            // 
            this.IncompleteSelectionTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncompleteSelectionTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IncompleteSelectionTxt.Location = new System.Drawing.Point(85, 64);
            this.IncompleteSelectionTxt.Name = "IncompleteSelectionTxt";
            this.IncompleteSelectionTxt.Size = new System.Drawing.Size(483, 115);
            this.IncompleteSelectionTxt.TabIndex = 14;
            this.IncompleteSelectionTxt.Text = "MAKE SURE TO SELECT A COLOR, A SIZE AND A QUANTITY PLEASE";
            this.IncompleteSelectionTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IncompleteSelectionBtn
            // 
            this.IncompleteSelectionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IncompleteSelectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.IncompleteSelectionBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncompleteSelectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncompleteSelectionBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncompleteSelectionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IncompleteSelectionBtn.Location = new System.Drawing.Point(239, 220);
            this.IncompleteSelectionBtn.Name = "IncompleteSelectionBtn";
            this.IncompleteSelectionBtn.Size = new System.Drawing.Size(169, 68);
            this.IncompleteSelectionBtn.TabIndex = 15;
            this.IncompleteSelectionBtn.Text = "OKAY";
            this.IncompleteSelectionBtn.UseVisualStyleBackColor = false;
            this.IncompleteSelectionBtn.Click += new System.EventHandler(this.IncompleteSelectionBtn_Click);
            // 
            // IncompleteSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 382);
            this.Controls.Add(this.IncompleteSelectionBtn);
            this.Controls.Add(this.IncompleteSelectionTxt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncompleteSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncompleteSelection";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IncompleteSelectionTxt;
        private System.Windows.Forms.Button IncompleteSelectionBtn;
    }
}