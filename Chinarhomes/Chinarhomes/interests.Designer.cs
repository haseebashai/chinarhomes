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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpnl = new System.Windows.Forms.Panel();
            this.mailbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iflowpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.conlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.loadinglbl = new System.Windows.Forms.Label();
            this.proploading = new System.Windows.Forms.PictureBox();
            this.formlbl = new System.Windows.Forms.Label();
            this.titlelbl = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.ipnl.SuspendLayout();
            this.dpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proploading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // custlist
            // 
            this.custlist.FormattingEnabled = true;
            this.custlist.Location = new System.Drawing.Point(19, 24);
            this.custlist.Name = "custlist";
            this.custlist.Size = new System.Drawing.Size(303, 550);
            this.custlist.TabIndex = 0;
            this.custlist.SelectedIndexChanged += new System.EventHandler(this.custlist_SelectedIndexChanged);
            // 
            // ipnl
            // 
            this.ipnl.Controls.Add(this.label9);
            this.ipnl.Controls.Add(this.label8);
            this.ipnl.Controls.Add(this.dpnl);
            this.ipnl.Controls.Add(this.custlist);
            this.ipnl.Controls.Add(this.loadinglbl);
            this.ipnl.Controls.Add(this.proploading);
            this.ipnl.Location = new System.Drawing.Point(1, 27);
            this.ipnl.Name = "ipnl";
            this.ipnl.Size = new System.Drawing.Size(1145, 603);
            this.ipnl.TabIndex = 1;
            this.ipnl.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(75, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(16, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "ID";
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
            this.dpnl.Location = new System.Drawing.Point(360, 24);
            this.dpnl.Name = "dpnl";
            this.dpnl.Size = new System.Drawing.Size(782, 563);
            this.dpnl.TabIndex = 1;
            this.dpnl.Visible = false;
            // 
            // mailbtn
            // 
            this.mailbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mailbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.mailbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.mailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailbtn.Location = new System.Drawing.Point(251, 528);
            this.mailbtn.Name = "mailbtn";
            this.mailbtn.Size = new System.Drawing.Size(148, 33);
            this.mailbtn.TabIndex = 37;
            this.mailbtn.Text = "Send Mail";
            this.mailbtn.UseVisualStyleBackColor = true;
            this.mailbtn.Click += new System.EventHandler(this.mailbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Or send a Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Call customer on:";
            // 
            // iflowpnl
            // 
            this.iflowpnl.Location = new System.Drawing.Point(126, 99);
            this.iflowpnl.Name = "iflowpnl";
            this.iflowpnl.Size = new System.Drawing.Size(630, 384);
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
            this.emaillbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.emaillbl.Location = new System.Drawing.Point(25, 47);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(58, 25);
            this.emaillbl.TabIndex = 2;
            this.emaillbl.Text = "email";
            // 
            // conlbl
            // 
            this.conlbl.AutoSize = true;
            this.conlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.conlbl.Location = new System.Drawing.Point(246, 497);
            this.conlbl.Name = "conlbl";
            this.conlbl.Size = new System.Drawing.Size(75, 25);
            this.conlbl.TabIndex = 1;
            this.conlbl.Text = "contact";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.namelbl.Location = new System.Drawing.Point(28, 15);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(61, 25);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "name";
            // 
            // loadinglbl
            // 
            this.loadinglbl.AutoSize = true;
            this.loadinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglbl.ForeColor = System.Drawing.Color.Silver;
            this.loadinglbl.Location = new System.Drawing.Point(510, 254);
            this.loadinglbl.Name = "loadinglbl";
            this.loadinglbl.Size = new System.Drawing.Size(117, 25);
            this.loadinglbl.TabIndex = 47;
            this.loadinglbl.Text = "Loading List";
            this.loadinglbl.Visible = false;
            // 
            // proploading
            // 
            this.proploading.Image = global::Chinarhomes.Properties.Resources.loading1;
            this.proploading.Location = new System.Drawing.Point(569, 170);
            this.proploading.Name = "proploading";
            this.proploading.Size = new System.Drawing.Size(214, 178);
            this.proploading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proploading.TabIndex = 48;
            this.proploading.TabStop = false;
            this.proploading.Visible = false;
            // 
            // formlbl
            // 
            this.formlbl.AutoSize = true;
            this.formlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.formlbl.Location = new System.Drawing.Point(0, 1);
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(119, 20);
            this.formlbl.TabIndex = 45;
            this.formlbl.Text = "Gathering Data";
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titlelbl.Location = new System.Drawing.Point(219, 4);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(382, 20);
            this.titlelbl.TabIndex = 47;
            this.titlelbl.Text = "Customers who have shown interest in the properties";
            this.titlelbl.Visible = false;
            // 
            // loading
            // 
            this.loading.Image = global::Chinarhomes.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(117, -4);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(31, 32);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 46;
            this.loading.TabStop = false;
            // 
            // interests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 639);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.ipnl);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.formlbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "interests";
            this.Text = "interests";
            this.ipnl.ResumeLayout(false);
            this.ipnl.PerformLayout();
            this.dpnl.ResumeLayout(false);
            this.dpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proploading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Label formlbl;
        private System.Windows.Forms.Label loadinglbl;
        private System.Windows.Forms.PictureBox proploading;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}