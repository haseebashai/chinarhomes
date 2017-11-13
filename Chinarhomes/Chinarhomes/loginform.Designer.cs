namespace Chinarhomes
{
    partial class loginform
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pwdlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.forgotbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chinarhomes.Properties.Resources.chinarhomes;
            this.pictureBox1.Location = new System.Drawing.Point(330, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdlbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pwdlbl.Location = new System.Drawing.Point(632, 317);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(54, 16);
            this.pwdlbl.TabIndex = 19;
            this.pwdlbl.Text = "Password";
            this.pwdlbl.Visible = false;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.namelbl.Location = new System.Drawing.Point(632, 256);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(57, 16);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Username";
            this.namelbl.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Coral;
            this.error.Location = new System.Drawing.Point(632, 362);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(123, 13);
            this.error.TabIndex = 17;
            this.error.Text = "Username does not exist";
            this.error.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(681, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // usernametxt
            // 
            this.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.usernametxt.Location = new System.Drawing.Point(635, 277);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(246, 16);
            this.usernametxt.TabIndex = 21;
            this.usernametxt.Text = "Username";
            this.usernametxt.Enter += new System.EventHandler(this.usrtxt_Enter);
            this.usernametxt.Leave += new System.EventHandler(this.usernametxt_Leave);
            // 
            // pwdtxt
            // 
            this.pwdtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxt.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pwdtxt.Location = new System.Drawing.Point(635, 336);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(246, 16);
            this.pwdtxt.TabIndex = 22;
            this.pwdtxt.Text = "Password";
            this.pwdtxt.Enter += new System.EventHandler(this.pwdtxt_Enter);
            this.pwdtxt.Leave += new System.EventHandler(this.pwdtxt_Leave);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(789, 392);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(96, 35);
            this.loginbtn.TabIndex = 23;
            this.loginbtn.Text = "&LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // forgotbtn
            // 
            this.forgotbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.forgotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotbtn.Location = new System.Drawing.Point(635, 403);
            this.forgotbtn.Name = "forgotbtn";
            this.forgotbtn.Size = new System.Drawing.Size(104, 23);
            this.forgotbtn.TabIndex = 24;
            this.forgotbtn.Text = "&Forgot Password?";
            this.forgotbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(632, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "_________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(632, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "_________________________________________";
            // 
            // loading
            // 
            this.loading.Image = global::Chinarhomes.Properties.Resources.pageload;
            this.loading.Location = new System.Drawing.Point(614, 337);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(309, 141);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 27;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // loginform
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 683);
            this.Controls.Add(this.forgotbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pwdlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button forgotbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox loading;
    }
}