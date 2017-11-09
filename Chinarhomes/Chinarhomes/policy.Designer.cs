namespace Chinarhomes
{
    partial class policy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bpnl = new System.Windows.Forms.Panel();
            this.termbtn = new System.Windows.Forms.Button();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.faqbtn = new System.Windows.Forms.Button();
            this.ppnl = new System.Windows.Forms.Panel();
            this.addnewbtn = new System.Windows.Forms.Button();
            this.epnl = new System.Windows.Forms.Panel();
            this.updbtn = new System.Windows.Forms.Button();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.headtxt = new System.Windows.Forms.TextBox();
            this.policydataview = new System.Windows.Forms.DataGridView();
            this.formlbl = new System.Windows.Forms.Label();
            this.loadinglbl = new System.Windows.Forms.Label();
            this.loadingpic = new System.Windows.Forms.PictureBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.bpnl.SuspendLayout();
            this.ppnl.SuspendLayout();
            this.epnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policydataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingpic)).BeginInit();
            this.SuspendLayout();
            // 
            // bpnl
            // 
            this.bpnl.Controls.Add(this.termbtn);
            this.bpnl.Controls.Add(this.aboutbtn);
            this.bpnl.Controls.Add(this.faqbtn);
            this.bpnl.Location = new System.Drawing.Point(7, 26);
            this.bpnl.Name = "bpnl";
            this.bpnl.Size = new System.Drawing.Size(425, 51);
            this.bpnl.TabIndex = 22;
            // 
            // termbtn
            // 
            this.termbtn.Location = new System.Drawing.Point(3, 8);
            this.termbtn.Name = "termbtn";
            this.termbtn.Size = new System.Drawing.Size(113, 35);
            this.termbtn.TabIndex = 41;
            this.termbtn.Text = "Terms";
            this.termbtn.UseVisualStyleBackColor = false;
            this.termbtn.Click += new System.EventHandler(this.termsbtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Location = new System.Drawing.Point(241, 8);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(113, 35);
            this.aboutbtn.TabIndex = 40;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = false;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // faqbtn
            // 
            this.faqbtn.Location = new System.Drawing.Point(122, 8);
            this.faqbtn.Name = "faqbtn";
            this.faqbtn.Size = new System.Drawing.Size(113, 35);
            this.faqbtn.TabIndex = 39;
            this.faqbtn.Text = "FAQ";
            this.faqbtn.UseVisualStyleBackColor = false;
            this.faqbtn.Click += new System.EventHandler(this.faqbtn_Click);
            // 
            // ppnl
            // 
            this.ppnl.Controls.Add(this.addnewbtn);
            this.ppnl.Controls.Add(this.epnl);
            this.ppnl.Controls.Add(this.policydataview);
            this.ppnl.Location = new System.Drawing.Point(7, 83);
            this.ppnl.Name = "ppnl";
            this.ppnl.Size = new System.Drawing.Size(1158, 581);
            this.ppnl.TabIndex = 24;
            // 
            // addnewbtn
            // 
            this.addnewbtn.Location = new System.Drawing.Point(991, 292);
            this.addnewbtn.Name = "addnewbtn";
            this.addnewbtn.Size = new System.Drawing.Size(157, 49);
            this.addnewbtn.TabIndex = 44;
            this.addnewbtn.Text = "Add new clause";
            this.addnewbtn.UseVisualStyleBackColor = false;
            this.addnewbtn.Click += new System.EventHandler(this.addnewbtn_Click);
            // 
            // epnl
            // 
            this.epnl.BackColor = System.Drawing.Color.Transparent;
            this.epnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epnl.Controls.Add(this.addbtn);
            this.epnl.Controls.Add(this.updbtn);
            this.epnl.Controls.Add(this.desctxt);
            this.epnl.Controls.Add(this.headtxt);
            this.epnl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.epnl.Location = new System.Drawing.Point(7, 288);
            this.epnl.Name = "epnl";
            this.epnl.Size = new System.Drawing.Size(560, 290);
            this.epnl.TabIndex = 43;
            // 
            // updbtn
            // 
            this.updbtn.Location = new System.Drawing.Point(390, 251);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(113, 35);
            this.updbtn.TabIndex = 45;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(7, 96);
            this.desctxt.Multiline = true;
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(377, 190);
            this.desctxt.TabIndex = 44;
            this.desctxt.Text = "description";
            this.desctxt.Enter += new System.EventHandler(this.desctxt_Enter);
            this.desctxt.Leave += new System.EventHandler(this.desctxt_Leave);
            // 
            // headtxt
            // 
            this.headtxt.Location = new System.Drawing.Point(5, 4);
            this.headtxt.Multiline = true;
            this.headtxt.Name = "headtxt";
            this.headtxt.Size = new System.Drawing.Size(379, 86);
            this.headtxt.TabIndex = 43;
            this.headtxt.Text = "heading";
            this.headtxt.Enter += new System.EventHandler(this.headtxt_Enter);
            this.headtxt.Leave += new System.EventHandler(this.headtxt_Leave);
            // 
            // policydataview
            // 
            this.policydataview.AllowUserToAddRows = false;
            this.policydataview.AllowUserToDeleteRows = false;
            this.policydataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.policydataview.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.policydataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.policydataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.policydataview.Location = new System.Drawing.Point(7, 5);
            this.policydataview.MultiSelect = false;
            this.policydataview.Name = "policydataview";
            this.policydataview.ReadOnly = true;
            this.policydataview.Size = new System.Drawing.Size(1141, 277);
            this.policydataview.TabIndex = 12;
            this.policydataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.policydataview_CellClick);
            // 
            // formlbl
            // 
            this.formlbl.AutoSize = true;
            this.formlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.formlbl.Location = new System.Drawing.Point(2, 0);
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(79, 25);
            this.formlbl.TabIndex = 23;
            this.formlbl.Text = "Policies";
            // 
            // loadinglbl
            // 
            this.loadinglbl.AutoSize = true;
            this.loadinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglbl.ForeColor = System.Drawing.Color.Black;
            this.loadinglbl.Location = new System.Drawing.Point(100, 193);
            this.loadinglbl.Name = "loadinglbl";
            this.loadinglbl.Size = new System.Drawing.Size(140, 25);
            this.loadinglbl.TabIndex = 25;
            this.loadinglbl.Text = "Gathering data";
            this.loadinglbl.Visible = false;
            // 
            // loadingpic
            // 
            this.loadingpic.Location = new System.Drawing.Point(100, 111);
            this.loadingpic.Name = "loadingpic";
            this.loadingpic.Size = new System.Drawing.Size(140, 86);
            this.loadingpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingpic.TabIndex = 26;
            this.loadingpic.TabStop = false;
            this.loadingpic.Visible = false;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(390, 131);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(113, 35);
            this.addbtn.TabIndex = 46;
            this.addbtn.Text = "Add new";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Visible = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // policy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 665);
            this.Controls.Add(this.bpnl);
            this.Controls.Add(this.ppnl);
            this.Controls.Add(this.formlbl);
            this.Controls.Add(this.loadingpic);
            this.Controls.Add(this.loadinglbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "policy";
            this.Text = "policy";
            this.Load += new System.EventHandler(this.policy_Load);
            this.bpnl.ResumeLayout(false);
            this.ppnl.ResumeLayout(false);
            this.epnl.ResumeLayout(false);
            this.epnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policydataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel bpnl;
        private System.Windows.Forms.Panel ppnl;
        private System.Windows.Forms.Label formlbl;
        private System.Windows.Forms.PictureBox loadingpic;
        private System.Windows.Forms.Label loadinglbl;
        private System.Windows.Forms.Button termbtn;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button faqbtn;
        private System.Windows.Forms.DataGridView policydataview;
        private System.Windows.Forms.Button addnewbtn;
        private System.Windows.Forms.Panel epnl;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.TextBox headtxt;
        private System.Windows.Forms.Button addbtn;
    }
}