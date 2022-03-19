
namespace Bovelo
{
    partial class LoginErrorMsg
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
            this.LoginError = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginErrorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginError
            // 
            this.LoginError.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginError.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginError.Location = new System.Drawing.Point(104, 51);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(448, 138);
            this.LoginError.TabIndex = 1;
            this.LoginError.Text = "PLEASE, CHECK YOUR USERNAME AND YOUR PASSWORD";
            this.LoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 329);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(656, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 329);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 26);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 26);
            this.panel1.TabIndex = 6;
            // 
            // LoginErrorBtn
            // 
            this.LoginErrorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.LoginErrorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginErrorBtn.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginErrorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginErrorBtn.Location = new System.Drawing.Point(246, 221);
            this.LoginErrorBtn.Name = "LoginErrorBtn";
            this.LoginErrorBtn.Size = new System.Drawing.Size(159, 70);
            this.LoginErrorBtn.TabIndex = 10;
            this.LoginErrorBtn.Text = "OKAY";
            this.LoginErrorBtn.UseVisualStyleBackColor = false;
            this.LoginErrorBtn.Click += new System.EventHandler(this.LoginErrorBtn_Click);
            // 
            // LoginErrorMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 381);
            this.Controls.Add(this.LoginErrorBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginErrorMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginMessageBox";
            this.Load += new System.EventHandler(this.LoginErrorMsg_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoginError;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginErrorBtn;
    }
}