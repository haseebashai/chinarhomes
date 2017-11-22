namespace Chinarhomes
{
    partial class mail
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
            this.pwdpnl = new System.Windows.Forms.Panel();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mailbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totxt = new System.Windows.Forms.TextBox();
            this.subtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.frombox = new System.Windows.Forms.ComboBox();
            this.bodytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.pwdpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pwdpnl);
            this.panel4.Controls.Add(this.mailbtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.totxt);
            this.panel4.Controls.Add(this.subtxt);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.frombox);
            this.panel4.Controls.Add(this.bodytxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 471);
            this.panel4.TabIndex = 72;
            // 
            // pwdpnl
            // 
            this.pwdpnl.Controls.Add(this.pwdtxt);
            this.pwdpnl.Controls.Add(this.label1);
            this.pwdpnl.Location = new System.Drawing.Point(446, 364);
            this.pwdpnl.Name = "pwdpnl";
            this.pwdpnl.Size = new System.Drawing.Size(163, 58);
            this.pwdpnl.TabIndex = 72;
            this.pwdpnl.Visible = false;
            // 
            // pwdtxt
            // 
            this.pwdtxt.Location = new System.Drawing.Point(3, 27);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(149, 20);
            this.pwdtxt.TabIndex = 5;
            this.pwdtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwdtxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Enter Password";
            // 
            // mailbtn
            // 
            this.mailbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mailbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.mailbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.mailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailbtn.Location = new System.Drawing.Point(450, 424);
            this.mailbtn.Name = "mailbtn";
            this.mailbtn.Size = new System.Drawing.Size(149, 33);
            this.mailbtn.TabIndex = 6;
            this.mailbtn.Text = "Send Mail";
            this.mailbtn.UseVisualStyleBackColor = true;
            this.mailbtn.Visible = false;
            this.mailbtn.Click += new System.EventHandler(this.mailbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "To";
            // 
            // totxt
            // 
            this.totxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.totxt.Location = new System.Drawing.Point(12, 29);
            this.totxt.Name = "totxt";
            this.totxt.Size = new System.Drawing.Size(587, 20);
            this.totxt.TabIndex = 1;
            // 
            // subtxt
            // 
            this.subtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.subtxt.Location = new System.Drawing.Point(12, 83);
            this.subtxt.Name = "subtxt";
            this.subtxt.Size = new System.Drawing.Size(587, 20);
            this.subtxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(146, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Send From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Subject";
            // 
            // frombox
            // 
            this.frombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frombox.FormattingEnabled = true;
            this.frombox.Location = new System.Drawing.Point(229, 391);
            this.frombox.Name = "frombox";
            this.frombox.Size = new System.Drawing.Size(185, 21);
            this.frombox.TabIndex = 4;
            this.frombox.SelectedIndexChanged += new System.EventHandler(this.frombox_SelectedIndexChanged);
            // 
            // bodytxt
            // 
            this.bodytxt.Location = new System.Drawing.Point(12, 139);
            this.bodytxt.Multiline = true;
            this.bodytxt.Name = "bodytxt";
            this.bodytxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bodytxt.Size = new System.Drawing.Size(587, 219);
            this.bodytxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Body";
            // 
            // mail
            // 
            this.AcceptButton = this.mailbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 486);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mail";
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.mail_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pwdpnl.ResumeLayout(false);
            this.pwdpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totxt;
        private System.Windows.Forms.TextBox subtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox frombox;
        private System.Windows.Forms.TextBox bodytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mailbtn;
        private System.Windows.Forms.Panel pwdpnl;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.Label label1;
    }
}