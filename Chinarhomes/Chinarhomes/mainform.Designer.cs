namespace Chinarhomes
{
    partial class mainform
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
            this.cntpnl = new System.Windows.Forms.Panel();
            this.navpnl = new System.Windows.Forms.Panel();
            this.navtxt = new System.Windows.Forms.Label();
            this.signoutlbl = new System.Windows.Forms.Label();
            this.signinlbl = new System.Windows.Forms.Label();
            this.propbtn = new System.Windows.Forms.Button();
            this.navpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntpnl
            // 
            this.cntpnl.BackColor = System.Drawing.Color.White;
            this.cntpnl.Location = new System.Drawing.Point(171, 0);
            this.cntpnl.Name = "cntpnl";
            this.cntpnl.Size = new System.Drawing.Size(1179, 705);
            this.cntpnl.TabIndex = 15;
            // 
            // navpnl
            // 
            this.navpnl.BackColor = System.Drawing.Color.White;
            this.navpnl.Controls.Add(this.propbtn);
            this.navpnl.Controls.Add(this.navtxt);
            this.navpnl.Controls.Add(this.signoutlbl);
            this.navpnl.Controls.Add(this.signinlbl);
            this.navpnl.Location = new System.Drawing.Point(0, 0);
            this.navpnl.Name = "navpnl";
            this.navpnl.Size = new System.Drawing.Size(170, 705);
            this.navpnl.TabIndex = 13;
            // 
            // navtxt
            // 
            this.navtxt.AutoSize = true;
            this.navtxt.BackColor = System.Drawing.Color.Transparent;
            this.navtxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navtxt.ForeColor = System.Drawing.Color.Black;
            this.navtxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navtxt.Location = new System.Drawing.Point(50, 1);
            this.navtxt.Name = "navtxt";
            this.navtxt.Size = new System.Drawing.Size(72, 20);
            this.navtxt.TabIndex = 0;
            this.navtxt.Text = "     Home";
            // 
            // signoutlbl
            // 
            this.signoutlbl.AutoSize = true;
            this.signoutlbl.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signoutlbl.Location = new System.Drawing.Point(134, 613);
            this.signoutlbl.Name = "signoutlbl";
            this.signoutlbl.Size = new System.Drawing.Size(55, 16);
            this.signoutlbl.TabIndex = 16;
            this.signoutlbl.Text = "SIGN OUT";
            this.signoutlbl.Visible = false;
            // 
            // signinlbl
            // 
            this.signinlbl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinlbl.Location = new System.Drawing.Point(-3, 590);
            this.signinlbl.Name = "signinlbl";
            this.signinlbl.Size = new System.Drawing.Size(192, 25);
            this.signinlbl.TabIndex = 9;
            this.signinlbl.Text = "Welcome, admin";
            this.signinlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signinlbl.Visible = false;
            // 
            // propbtn
            // 
            this.propbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.propbtn.FlatAppearance.BorderSize = 0;
            this.propbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.propbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.propbtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propbtn.Image = global::Chinarhomes.Properties.Resources.chinarhomes_cion;
            this.propbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.propbtn.Location = new System.Drawing.Point(10, 54);
            this.propbtn.Name = "propbtn";
            this.propbtn.Size = new System.Drawing.Size(120, 32);
            this.propbtn.TabIndex = 17;
            this.propbtn.Text = "Properties";
            this.propbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.propbtn.UseVisualStyleBackColor = true;
            this.propbtn.Click += new System.EventHandler(this.propbtn_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 705);
            this.Controls.Add(this.cntpnl);
            this.Controls.Add(this.navpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Text = "Chinarhomes Homepage";
            this.navpnl.ResumeLayout(false);
            this.navpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel cntpnl;
        private System.Windows.Forms.Panel navpnl;
        private System.Windows.Forms.Label signoutlbl;
        private System.Windows.Forms.Label signinlbl;
        private System.Windows.Forms.Label navtxt;
        private System.Windows.Forms.Button propbtn;
    }
}