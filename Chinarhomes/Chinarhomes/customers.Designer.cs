namespace Chinarhomes
{
    partial class customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cpnl = new System.Windows.Forms.Panel();
            this.countlbl = new System.Windows.Forms.Label();
            this.ppnl = new System.Windows.Forms.Panel();
            this.wflow = new System.Windows.Forms.FlowLayoutPanel();
            this.iflow = new System.Windows.Forms.FlowLayoutPanel();
            this.ilbl = new System.Windows.Forms.Label();
            this.wlbl = new System.Windows.Forms.Label();
            this.dpnl = new System.Windows.Forms.Panel();
            this.mailbtn = new System.Windows.Forms.Button();
            this.emaillbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.contactlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.customerdataview = new System.Windows.Forms.DataGridView();
            this.loadinglbl = new System.Windows.Forms.Label();
            this.proploading = new System.Windows.Forms.PictureBox();
            this.loadbtn = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.PictureBox();
            this.formlbl = new System.Windows.Forms.Label();
            this.cpnl.SuspendLayout();
            this.ppnl.SuspendLayout();
            this.dpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerdataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proploading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // cpnl
            // 
            this.cpnl.Controls.Add(this.countlbl);
            this.cpnl.Controls.Add(this.ppnl);
            this.cpnl.Controls.Add(this.dpnl);
            this.cpnl.Controls.Add(this.label2);
            this.cpnl.Controls.Add(this.usertxt);
            this.cpnl.Controls.Add(this.label1);
            this.cpnl.Controls.Add(this.emailtxt);
            this.cpnl.Controls.Add(this.customerdataview);
            this.cpnl.Controls.Add(this.loadinglbl);
            this.cpnl.Controls.Add(this.proploading);
            this.cpnl.Controls.Add(this.loadbtn);
            this.cpnl.Location = new System.Drawing.Point(1, 6);
            this.cpnl.Name = "cpnl";
            this.cpnl.Size = new System.Drawing.Size(1161, 663);
            this.cpnl.TabIndex = 12;
            this.cpnl.Visible = false;
            // 
            // countlbl
            // 
            this.countlbl.AutoSize = true;
            this.countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlbl.ForeColor = System.Drawing.Color.Blue;
            this.countlbl.Location = new System.Drawing.Point(3, 638);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(176, 16);
            this.countlbl.TabIndex = 40;
            this.countlbl.Text = "Total Registered Customers";
            // 
            // ppnl
            // 
            this.ppnl.Controls.Add(this.wflow);
            this.ppnl.Controls.Add(this.iflow);
            this.ppnl.Controls.Add(this.ilbl);
            this.ppnl.Controls.Add(this.wlbl);
            this.ppnl.Location = new System.Drawing.Point(649, 51);
            this.ppnl.Name = "ppnl";
            this.ppnl.Size = new System.Drawing.Size(515, 436);
            this.ppnl.TabIndex = 42;
            this.ppnl.Visible = false;
            // 
            // wflow
            // 
            this.wflow.Location = new System.Drawing.Point(11, 243);
            this.wflow.Name = "wflow";
            this.wflow.Size = new System.Drawing.Size(226, 168);
            this.wflow.TabIndex = 41;
            // 
            // iflow
            // 
            this.iflow.Location = new System.Drawing.Point(11, 39);
            this.iflow.Name = "iflow";
            this.iflow.Size = new System.Drawing.Size(226, 168);
            this.iflow.TabIndex = 40;
            // 
            // ilbl
            // 
            this.ilbl.AutoSize = true;
            this.ilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ilbl.Location = new System.Drawing.Point(8, 10);
            this.ilbl.Name = "ilbl";
            this.ilbl.Size = new System.Drawing.Size(86, 17);
            this.ilbl.TabIndex = 39;
            this.ilbl.Text = "Interested in";
            // 
            // wlbl
            // 
            this.wlbl.AutoSize = true;
            this.wlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wlbl.Location = new System.Drawing.Point(8, 215);
            this.wlbl.Name = "wlbl";
            this.wlbl.Size = new System.Drawing.Size(93, 17);
            this.wlbl.TabIndex = 29;
            this.wlbl.Text = "Wishlist Items";
            // 
            // dpnl
            // 
            this.dpnl.Controls.Add(this.mailbtn);
            this.dpnl.Controls.Add(this.emaillbl);
            this.dpnl.Controls.Add(this.namelbl);
            this.dpnl.Controls.Add(this.contactlbl);
            this.dpnl.Controls.Add(this.panel1);
            this.dpnl.Location = new System.Drawing.Point(649, 493);
            this.dpnl.Name = "dpnl";
            this.dpnl.Size = new System.Drawing.Size(500, 116);
            this.dpnl.TabIndex = 41;
            this.dpnl.Visible = false;
            // 
            // mailbtn
            // 
            this.mailbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.mailbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.mailbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.mailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailbtn.Location = new System.Drawing.Point(266, 28);
            this.mailbtn.Name = "mailbtn";
            this.mailbtn.Size = new System.Drawing.Size(209, 56);
            this.mailbtn.TabIndex = 4;
            this.mailbtn.Text = "Send Mail";
            this.mailbtn.UseVisualStyleBackColor = true;
            this.mailbtn.Click += new System.EventHandler(this.mailbtn_Click);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.Color.White;
            this.emaillbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.emaillbl.Location = new System.Drawing.Point(8, 54);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(0, 13);
            this.emaillbl.TabIndex = 32;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.White;
            this.namelbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.namelbl.Location = new System.Drawing.Point(8, 28);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(0, 13);
            this.namelbl.TabIndex = 33;
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.BackColor = System.Drawing.Color.White;
            this.contactlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.contactlbl.Location = new System.Drawing.Point(8, 80);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(0, 13);
            this.contactlbl.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(210, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 100);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filter by Username";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(388, 24);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(178, 20);
            this.usertxt.TabIndex = 3;
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            this.usertxt.VisibleChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filter by Email";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(92, 25);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(178, 20);
            this.emailtxt.TabIndex = 2;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // customerdataview
            // 
            this.customerdataview.AllowUserToAddRows = false;
            this.customerdataview.AllowUserToDeleteRows = false;
            this.customerdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerdataview.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerdataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerdataview.GridColor = System.Drawing.Color.White;
            this.customerdataview.Location = new System.Drawing.Point(3, 51);
            this.customerdataview.Name = "customerdataview";
            this.customerdataview.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerdataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerdataview.Size = new System.Drawing.Size(637, 577);
            this.customerdataview.TabIndex = 1;
            this.customerdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerdataview_CellClick);
            this.customerdataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerdataview_CellClick);
            // 
            // loadinglbl
            // 
            this.loadinglbl.AutoSize = true;
            this.loadinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglbl.ForeColor = System.Drawing.Color.Gray;
            this.loadinglbl.Location = new System.Drawing.Point(730, 266);
            this.loadinglbl.Name = "loadinglbl";
            this.loadinglbl.Size = new System.Drawing.Size(146, 25);
            this.loadinglbl.TabIndex = 47;
            this.loadinglbl.Text = "Loading Details";
            this.loadinglbl.Visible = false;
            // 
            // proploading
            // 
            this.proploading.Image = global::Chinarhomes.Properties.Resources.loading1;
            this.proploading.Location = new System.Drawing.Point(809, 182);
            this.proploading.Name = "proploading";
            this.proploading.Size = new System.Drawing.Size(214, 178);
            this.proploading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proploading.TabIndex = 48;
            this.proploading.TabStop = false;
            this.proploading.Visible = false;
            // 
            // loadbtn
            // 
            this.loadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.loadbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.loadbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbtn.Location = new System.Drawing.Point(791, 264);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(162, 35);
            this.loadbtn.TabIndex = 49;
            this.loadbtn.Text = "Load Details";
            this.loadbtn.UseVisualStyleBackColor = false;
            this.loadbtn.Visible = false;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // loading
            // 
            this.loading.Image = global::Chinarhomes.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(115, -4);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(31, 32);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 49;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // formlbl
            // 
            this.formlbl.AutoSize = true;
            this.formlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.formlbl.Location = new System.Drawing.Point(0, 1);
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(119, 20);
            this.formlbl.TabIndex = 48;
            this.formlbl.Text = "Gathering Data";
            this.formlbl.Visible = false;
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 665);
            this.Controls.Add(this.cpnl);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.formlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customers";
            this.Text = "customers";
            this.cpnl.ResumeLayout(false);
            this.cpnl.PerformLayout();
            this.ppnl.ResumeLayout(false);
            this.ppnl.PerformLayout();
            this.dpnl.ResumeLayout(false);
            this.dpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerdataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proploading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cpnl;
        private System.Windows.Forms.Label countlbl;
        private System.Windows.Forms.Panel ppnl;
        private System.Windows.Forms.Label ilbl;
        private System.Windows.Forms.Label wlbl;
        private System.Windows.Forms.Panel dpnl;
        private System.Windows.Forms.Button mailbtn;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.DataGridView customerdataview;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Label formlbl;
        private System.Windows.Forms.Label loadinglbl;
        private System.Windows.Forms.PictureBox proploading;
        public System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.FlowLayoutPanel wflow;
        private System.Windows.Forms.FlowLayoutPanel iflow;
    }
}