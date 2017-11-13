namespace Chinarhomes
{
    partial class interests
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
            this.custlist = new System.Windows.Forms.ListBox();
            this.ipnl = new System.Windows.Forms.Panel();
            this.dpnl = new System.Windows.Forms.Panel();
            this.iflowpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.conlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mailbtn = new System.Windows.Forms.Button();
            this.ipnl.SuspendLayout();
            this.dpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // custlist
            // 
            this.custlist.FormattingEnabled = true;
            this.custlist.Location = new System.Drawing.Point(19, 37);
            this.custlist.Name = "custlist";
            this.custlist.Size = new System.Drawing.Size(303, 498);
            this.custlist.TabIndex = 0;
            this.custlist.SelectedIndexChanged += new System.EventHandler(this.custlist_SelectedIndexChanged);
            // 
            // ipnl
            // 
            this.ipnl.Controls.Add(this.dpnl);
            this.ipnl.Controls.Add(this.custlist);
            this.ipnl.Location = new System.Drawing.Point(4, 3);
            this.ipnl.Name = "ipnl";
            this.ipnl.Size = new System.Drawing.Size(1145, 603);
            this.ipnl.TabIndex = 1;
            // 
            // dpnl
            // 
            this.dpnl.Controls.Add(this.mailbtn);
            this.dpnl.Controls.Add(this.label3);
            this.dpnl.Controls.Add(this.label2);
            this.dpnl.Controls.Add(this.iflowpnl);
            this.dpnl.Controls.Add(this.label1);
            this.dpnl.Controls.Add(this.emaillbl);
            this.dpnl.Controls.Add(this.conlbl);
            this.dpnl.Controls.Add(this.namelbl);
            this.dpnl.Location = new System.Drawing.Point(356, 22);
            this.dpnl.Name = "dpnl";
            this.dpnl.Size = new System.Drawing.Size(782, 556);
            this.dpnl.TabIndex = 1;
            this.dpnl.Visible = false;
            // 
            // iflowpnl
            // 
            this.iflowpnl.Location = new System.Drawing.Point(126, 126);
            this.iflowpnl.Name = "iflowpnl";
            this.iflowpnl.Size = new System.Drawing.Size(630, 287);
            this.iflowpnl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interested in:";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(28, 47);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(58, 25);
            this.emaillbl.TabIndex = 2;
            this.emaillbl.Text = "email";
            // 
            // conlbl
            // 
            this.conlbl.AutoSize = true;
            this.conlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.conlbl.Location = new System.Drawing.Point(663, 466);
            this.conlbl.Name = "conlbl";
            this.conlbl.Size = new System.Drawing.Size(62, 20);
            this.conlbl.TabIndex = 1;
            this.conlbl.Text = "contact";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(28, 15);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(61, 25);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Call customer on:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Or send a Mail:";
            // 
            // mailbtn
            // 
            this.mailbtn.Location = new System.Drawing.Point(667, 497);
            this.mailbtn.Name = "mailbtn";
            this.mailbtn.Size = new System.Drawing.Size(89, 21);
            this.mailbtn.TabIndex = 37;
            this.mailbtn.Text = "Send Mail";
            this.mailbtn.UseVisualStyleBackColor = true;
            // 
            // interests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 608);
            this.Controls.Add(this.ipnl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "interests";
            this.Text = "interests";
            this.Load += new System.EventHandler(this.interests_Load);
            this.ipnl.ResumeLayout(false);
            this.dpnl.ResumeLayout(false);
            this.dpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox custlist;
        private System.Windows.Forms.Panel ipnl;
        private System.Windows.Forms.Panel dpnl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.FlowLayoutPanel iflowpnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label conlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mailbtn;
    }
}