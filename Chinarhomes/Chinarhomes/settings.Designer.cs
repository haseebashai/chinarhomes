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
            this.addtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spnl = new System.Windows.Forms.Panel();
            this.loadinglbl = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.spnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Email";
            // 
            // pwdtxt
            // 
            this.pwdtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pwdtxt.Location = new System.Drawing.Point(17, 184);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(169, 20);
            this.pwdtxt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Change Password";
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(239, 29);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(232, 20);
            this.mailtxt.TabIndex = 2;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(239, 106);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(169, 20);
            this.contacttxt.TabIndex = 4;
            this.contacttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttxt_KeyPress);
            this.contacttxt.Leave += new System.EventHandler(this.contacttxt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Contact";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(17, 29);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(169, 20);
            this.nametxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Name";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(434, 302);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 38);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Update";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cpwdtxt
            // 
            this.cpwdtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cpwdtxt.Location = new System.Drawing.Point(239, 184);
            this.cpwdtxt.Name = "cpwdtxt";
            this.cpwdtxt.PasswordChar = '*';
            this.cpwdtxt.Size = new System.Drawing.Size(169, 20);
            this.cpwdtxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Confirm Password";
            // 
            // errorlbl
            // 
            this.errorlbl.AutoSize = true;
            this.errorlbl.ForeColor = System.Drawing.Color.Red;
            this.errorlbl.Location = new System.Drawing.Point(236, 207);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.Size = new System.Drawing.Size(137, 13);
            this.errorlbl.TabIndex = 119;
            this.errorlbl.Text = "Please match the password";
            this.errorlbl.Visible = false;
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(17, 106);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(169, 20);
            this.addtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Address";
            // 
            // spnl
            // 
            this.spnl.Controls.Add(this.label6);
            this.spnl.Controls.Add(this.addtxt);
            this.spnl.Controls.Add(this.nametxt);
            this.spnl.Controls.Add(this.label3);
            this.spnl.Controls.Add(this.label7);
            this.spnl.Controls.Add(this.errorlbl);
            this.spnl.Controls.Add(this.contacttxt);
            this.spnl.Controls.Add(this.cpwdtxt);
            this.spnl.Controls.Add(this.mailtxt);
            this.spnl.Controls.Add(this.label2);
            this.spnl.Controls.Add(this.label9);
            this.spnl.Controls.Add(this.addbtn);
            this.spnl.Controls.Add(this.pwdtxt);
            this.spnl.Controls.Add(this.label11);
            this.spnl.Location = new System.Drawing.Point(58, 35);
            this.spnl.Name = "spnl";
            this.spnl.Size = new System.Drawing.Size(531, 346);
            this.spnl.TabIndex = 122;
            this.spnl.Visible = false;
            // 
            // loadinglbl
            // 
            this.loadinglbl.AutoSize = true;
            this.loadinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglbl.ForeColor = System.Drawing.Color.DarkGray;
            this.loadinglbl.Location = new System.Drawing.Point(185, 167);
            this.loadinglbl.Name = "loadinglbl";
            this.loadinglbl.Size = new System.Drawing.Size(82, 25);
            this.loadinglbl.TabIndex = 123;
            this.loadinglbl.Text = "Loading";
            this.loadinglbl.Visible = false;
            // 
            // loading
            // 
            this.loading.Image = global::Chinarhomes.Properties.Resources.loading1;
            this.loading.Location = new System.Drawing.Point(157, 55);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(333, 231);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 124;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 407);
            this.Controls.Add(this.spnl);
            this.Controls.Add(this.loadinglbl);
            this.Controls.Add(this.loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.Text = "settings";
            this.spnl.ResumeLayout(false);
            this.spnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel spnl;
        private System.Windows.Forms.Label loadinglbl;
        private System.Windows.Forms.PictureBox loading;
    }
}