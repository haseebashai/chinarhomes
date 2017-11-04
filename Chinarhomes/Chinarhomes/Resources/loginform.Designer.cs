namespace Chinarhomes.Resources
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
            this.pwdlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
           
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdlbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pwdlbl.Location = new System.Drawing.Point(292, 339);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(58, 18);
            this.pwdlbl.TabIndex = 19;
            this.pwdlbl.Text = "Password";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.namelbl.Location = new System.Drawing.Point(292, 283);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(38, 18);
            this.namelbl.TabIndex = 18;
            this.namelbl.Text = "Name";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Coral;
            this.error.Location = new System.Drawing.Point(420, 365);
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
            this.label1.Location = new System.Drawing.Point(341, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN TO YOUR ACCOUNT.";
            // 
            // loginbtn
            // 
           
            // 
            // forgotbtn
            // 
           
            // 
            // pwdtxt
            // 
           
            // 
            // usernametxt
            // 
           
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chinarhomes.Properties.Resources.chinarhomes;
            this.pictureBox1.Location = new System.Drawing.Point(334, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
           
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pwdlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label1;
       
    }
}