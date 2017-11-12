namespace Chinarhomes
{
    partial class settings
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
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.cpwdtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(90, 158);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(169, 20);
            this.usertxt.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Email";
            // 
            // pwdtxt
            // 
            this.pwdtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pwdtxt.Location = new System.Drawing.Point(90, 232);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(169, 20);
            this.pwdtxt.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Change Password";
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(312, 88);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(232, 20);
            this.mailtxt.TabIndex = 107;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(312, 158);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(169, 20);
            this.contacttxt.TabIndex = 106;
            this.contacttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Contact";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(90, 88);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(169, 20);
            this.nametxt.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Name";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(504, 361);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 38);
            this.addbtn.TabIndex = 115;
            this.addbtn.Text = "Update";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cpwdtxt
            // 
            this.cpwdtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cpwdtxt.Location = new System.Drawing.Point(312, 232);
            this.cpwdtxt.Name = "cpwdtxt";
            this.cpwdtxt.PasswordChar = '*';
            this.cpwdtxt.Size = new System.Drawing.Size(169, 20);
            this.cpwdtxt.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Confirm Password";
            // 
            // errorlbl
            // 
            this.errorlbl.AutoSize = true;
            this.errorlbl.ForeColor = System.Drawing.Color.Red;
            this.errorlbl.Location = new System.Drawing.Point(309, 255);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.Size = new System.Drawing.Size(150, 13);
            this.errorlbl.TabIndex = 119;
            this.errorlbl.Text = "Please enter correct password";
            this.errorlbl.Visible = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 407);
            this.Controls.Add(this.errorlbl);
            this.Controls.Add(this.cpwdtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox cpwdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorlbl;
    }
}