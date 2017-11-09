namespace Chinarhomes
{
    partial class messages
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
            this.msgpnl = new System.Windows.Forms.Panel();
            this.messagesdataview = new System.Windows.Forms.DataGridView();
            this.mpnl = new System.Windows.Forms.Panel();
            this.msgtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.midlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.sublbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtn = new System.Windows.Forms.Button();
            this.msgpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesdataview)).BeginInit();
            this.mpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgpnl
            // 
            this.msgpnl.Controls.Add(this.messagesdataview);
            this.msgpnl.Controls.Add(this.mpnl);
            this.msgpnl.Location = new System.Drawing.Point(4, 28);
            this.msgpnl.Name = "msgpnl";
            this.msgpnl.Size = new System.Drawing.Size(954, 591);
            this.msgpnl.TabIndex = 32;
            // 
            // messagesdataview
            // 
            this.messagesdataview.AllowUserToAddRows = false;
            this.messagesdataview.AllowUserToDeleteRows = false;
            this.messagesdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.messagesdataview.BackgroundColor = System.Drawing.Color.White;
            this.messagesdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagesdataview.GridColor = System.Drawing.Color.White;
            this.messagesdataview.Location = new System.Drawing.Point(10, 10);
            this.messagesdataview.Name = "messagesdataview";
            this.messagesdataview.ReadOnly = true;
            this.messagesdataview.Size = new System.Drawing.Size(843, 367);
            this.messagesdataview.TabIndex = 1;
            this.messagesdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesdataview_CellClick);
            // 
            // mpnl
            // 
            this.mpnl.Controls.Add(this.rbtn);
            this.mpnl.Controls.Add(this.msgtxt);
            this.mpnl.Controls.Add(this.label2);
            this.mpnl.Controls.Add(this.midlbl);
            this.mpnl.Controls.Add(this.emaillbl);
            this.mpnl.Controls.Add(this.sublbl);
            this.mpnl.Controls.Add(this.label7);
            this.mpnl.Controls.Add(this.label8);
            this.mpnl.Controls.Add(this.label9);
            this.mpnl.Location = new System.Drawing.Point(8, 379);
            this.mpnl.Name = "mpnl";
            this.mpnl.Size = new System.Drawing.Size(845, 204);
            this.mpnl.TabIndex = 30;
            this.mpnl.Visible = false;
            // 
            // msgtxt
            // 
            this.msgtxt.Location = new System.Drawing.Point(253, 29);
            this.msgtxt.Multiline = true;
            this.msgtxt.Name = "msgtxt";
            this.msgtxt.ReadOnly = true;
            this.msgtxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.msgtxt.Size = new System.Drawing.Size(344, 171);
            this.msgtxt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(400, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Message";
            // 
            // midlbl
            // 
            this.midlbl.AutoSize = true;
            this.midlbl.ForeColor = System.Drawing.Color.Black;
            this.midlbl.Location = new System.Drawing.Point(5, 32);
            this.midlbl.Name = "midlbl";
            this.midlbl.Size = new System.Drawing.Size(23, 13);
            this.midlbl.TabIndex = 2;
            this.midlbl.Text = "mid";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.ForeColor = System.Drawing.Color.Black;
            this.emaillbl.Location = new System.Drawing.Point(48, 32);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(31, 13);
            this.emaillbl.TabIndex = 3;
            this.emaillbl.Text = "email";
            // 
            // sublbl
            // 
            this.sublbl.ForeColor = System.Drawing.Color.Black;
            this.sublbl.Location = new System.Drawing.Point(5, 94);
            this.sublbl.Name = "sublbl";
            this.sublbl.Size = new System.Drawing.Size(188, 106);
            this.sublbl.TabIndex = 4;
            this.sublbl.Text = "mrp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(3, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Subject";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(48, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(5, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mid";
            // 
            // rbtn
            // 
            this.rbtn.Location = new System.Drawing.Point(616, 94);
            this.rbtn.Name = "rbtn";
            this.rbtn.Size = new System.Drawing.Size(113, 35);
            this.rbtn.TabIndex = 39;
            this.rbtn.Text = "Send Reply Mail";
            this.rbtn.UseVisualStyleBackColor = false;
            // 
            // messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 629);
            this.Controls.Add(this.msgpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messages";
            this.Text = "messages";
            this.Load += new System.EventHandler(this.messages_Load);
            this.msgpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messagesdataview)).EndInit();
            this.mpnl.ResumeLayout(false);
            this.mpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel msgpnl;
        private System.Windows.Forms.DataGridView messagesdataview;
        private System.Windows.Forms.Panel mpnl;
        private System.Windows.Forms.TextBox msgtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label midlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label sublbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button rbtn;
    }
}