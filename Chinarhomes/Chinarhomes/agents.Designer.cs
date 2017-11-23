namespace Chinarhomes
{
    partial class agents
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
            this.agentdataview = new System.Windows.Forms.DataGridView();
            this.dpnl = new System.Windows.Forms.Panel();
            this.errlbl = new System.Windows.Forms.Label();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addnewbtn = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.canbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.ano = new System.Windows.Forms.CheckBox();
            this.ayes = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.apnl = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.PictureBox();
            this.formlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentdataview)).BeginInit();
            this.dpnl.SuspendLayout();
            this.apnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // agentdataview
            // 
            this.agentdataview.AllowUserToAddRows = false;
            this.agentdataview.AllowUserToDeleteRows = false;
            this.agentdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agentdataview.BackgroundColor = System.Drawing.Color.White;
            this.agentdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentdataview.GridColor = System.Drawing.Color.White;
            this.agentdataview.Location = new System.Drawing.Point(10, 38);
            this.agentdataview.Name = "agentdataview";
            this.agentdataview.ReadOnly = true;
            this.agentdataview.Size = new System.Drawing.Size(1143, 260);
            this.agentdataview.TabIndex = 3;
            this.agentdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.agentdataview_CellClick);
            // 
            // dpnl
            // 
            this.dpnl.Controls.Add(this.errlbl);
            this.dpnl.Controls.Add(this.addtxt);
            this.dpnl.Controls.Add(this.label3);
            this.dpnl.Controls.Add(this.label2);
            this.dpnl.Controls.Add(this.addnewbtn);
            this.dpnl.Controls.Add(this.usertxt);
            this.dpnl.Controls.Add(this.label1);
            this.dpnl.Controls.Add(this.canbtn);
            this.dpnl.Controls.Add(this.addbtn);
            this.dpnl.Controls.Add(this.genderbox);
            this.dpnl.Controls.Add(this.ano);
            this.dpnl.Controls.Add(this.ayes);
            this.dpnl.Controls.Add(this.label12);
            this.dpnl.Controls.Add(this.label11);
            this.dpnl.Controls.Add(this.pwdtxt);
            this.dpnl.Controls.Add(this.label9);
            this.dpnl.Controls.Add(this.label10);
            this.dpnl.Controls.Add(this.mailtxt);
            this.dpnl.Controls.Add(this.contacttxt);
            this.dpnl.Controls.Add(this.label7);
            this.dpnl.Controls.Add(this.nametxt);
            this.dpnl.Controls.Add(this.label6);
            this.dpnl.Location = new System.Drawing.Point(3, 302);
            this.dpnl.Name = "dpnl";
            this.dpnl.Size = new System.Drawing.Size(1162, 352);
            this.dpnl.TabIndex = 4;
            // 
            // errlbl
            // 
            this.errlbl.AutoSize = true;
            this.errlbl.ForeColor = System.Drawing.Color.Red;
            this.errlbl.Location = new System.Drawing.Point(74, 143);
            this.errlbl.Name = "errlbl";
            this.errlbl.Size = new System.Drawing.Size(121, 13);
            this.errlbl.TabIndex = 106;
            this.errlbl.Text = "Username already exists";
            this.errlbl.Visible = false;
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(244, 185);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(232, 20);
            this.addtxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Add New Agent";
            // 
            // addnewbtn
            // 
            this.addnewbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addnewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnewbtn.Location = new System.Drawing.Point(529, 307);
            this.addnewbtn.Name = "addnewbtn";
            this.addnewbtn.Size = new System.Drawing.Size(161, 38);
            this.addnewbtn.TabIndex = 103;
            this.addnewbtn.Text = "Add New Agent";
            this.addnewbtn.UseVisualStyleBackColor = false;
            this.addnewbtn.Visible = false;
            this.addnewbtn.Click += new System.EventHandler(this.addnewbtn_Click);
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(22, 120);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(169, 20);
            this.usertxt.TabIndex = 3;
            this.usertxt.Leave += new System.EventHandler(this.usertxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Username";
            // 
            // canbtn
            // 
            this.canbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canbtn.Location = new System.Drawing.Point(271, 307);
            this.canbtn.Name = "canbtn";
            this.canbtn.Size = new System.Drawing.Size(94, 38);
            this.canbtn.TabIndex = 11;
            this.canbtn.Text = "Cancel";
            this.canbtn.UseVisualStyleBackColor = false;
            this.canbtn.Click += new System.EventHandler(this.canbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Location = new System.Drawing.Point(382, 307);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 38);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add Agent";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // genderbox
            // 
            this.genderbox.BackColor = System.Drawing.Color.White;
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Location = new System.Drawing.Point(22, 250);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(121, 21);
            this.genderbox.TabIndex = 7;
            // 
            // ano
            // 
            this.ano.AutoSize = true;
            this.ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano.Location = new System.Drawing.Point(301, 249);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(45, 21);
            this.ano.TabIndex = 9;
            this.ano.Text = "No";
            this.ano.UseVisualStyleBackColor = true;
            this.ano.CheckedChanged += new System.EventHandler(this.ano_CheckedChanged);
            // 
            // ayes
            // 
            this.ayes.AutoSize = true;
            this.ayes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayes.Location = new System.Drawing.Point(244, 249);
            this.ayes.Name = "ayes";
            this.ayes.Size = new System.Drawing.Size(51, 21);
            this.ayes.TabIndex = 8;
            this.ayes.Text = "Yes";
            this.ayes.UseVisualStyleBackColor = true;
            this.ayes.CheckedChanged += new System.EventHandler(this.ayes_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Is Admin?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // pwdtxt
            // 
            this.pwdtxt.Location = new System.Drawing.Point(244, 120);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(169, 20);
            this.pwdtxt.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gender";
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(244, 59);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(232, 20);
            this.mailtxt.TabIndex = 2;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(22, 185);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(169, 20);
            this.contacttxt.TabIndex = 5;
            this.contacttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttxt_KeyPress);
            this.contacttxt.Leave += new System.EventHandler(this.contacttxt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(22, 59);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(169, 20);
            this.nametxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Agent Name";
            // 
            // apnl
            // 
            this.apnl.Controls.Add(this.dpnl);
            this.apnl.Controls.Add(this.agentdataview);
            this.apnl.Location = new System.Drawing.Point(1, 1);
            this.apnl.Name = "apnl";
            this.apnl.Size = new System.Drawing.Size(1166, 657);
            this.apnl.TabIndex = 5;
            this.apnl.Visible = false;
            // 
            // loading
            // 
            this.loading.Image = global::Chinarhomes.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(114, -4);
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
            this.formlbl.Location = new System.Drawing.Point(-1, 2);
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(119, 20);
            this.formlbl.TabIndex = 48;
            this.formlbl.Text = "Gathering Data";
            this.formlbl.Visible = false;
            // 
            // agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 660);
            this.Controls.Add(this.apnl);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.formlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agents";
            this.Text = "agents";
            this.Load += new System.EventHandler(this.agents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentdataview)).EndInit();
            this.dpnl.ResumeLayout(false);
            this.dpnl.PerformLayout();
            this.apnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView agentdataview;
        private System.Windows.Forms.Panel dpnl;
        private System.Windows.Forms.CheckBox ano;
        private System.Windows.Forms.CheckBox ayes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.Button canbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnewbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel apnl;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Label formlbl;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errlbl;
    }
}