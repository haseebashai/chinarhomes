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
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.addnewbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentdataview)).BeginInit();
            this.dpnl.SuspendLayout();
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
            this.agentdataview.Location = new System.Drawing.Point(12, 12);
            this.agentdataview.Name = "agentdataview";
            this.agentdataview.ReadOnly = true;
            this.agentdataview.Size = new System.Drawing.Size(1143, 260);
            this.agentdataview.TabIndex = 3;
            this.agentdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.agentdataview_CellClick);
            // 
            // dpnl
            // 
            this.dpnl.Controls.Add(this.label2);
            this.dpnl.Controls.Add(this.addnewbtn);
            this.dpnl.Controls.Add(this.usertxt);
            this.dpnl.Controls.Add(this.label1);
            this.dpnl.Controls.Add(this.button1);
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
            this.dpnl.Location = new System.Drawing.Point(2, 272);
            this.dpnl.Name = "dpnl";
            this.dpnl.Size = new System.Drawing.Size(1162, 355);
            this.dpnl.TabIndex = 4;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(294, 133);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(169, 20);
            this.usertxt.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 100;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(654, 266);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 38);
            this.addbtn.TabIndex = 99;
            this.addbtn.Text = "Add Agent";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Location = new System.Drawing.Point(516, 209);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(121, 21);
            this.genderbox.TabIndex = 32;
            // 
            // ano
            // 
            this.ano.AutoSize = true;
            this.ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano.Location = new System.Drawing.Point(348, 283);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(45, 21);
            this.ano.TabIndex = 31;
            this.ano.Text = "No";
            this.ano.UseVisualStyleBackColor = true;
            this.ano.CheckedChanged += new System.EventHandler(this.ano_CheckedChanged);
            // 
            // ayes
            // 
            this.ayes.AutoSize = true;
            this.ayes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayes.Location = new System.Drawing.Point(291, 283);
            this.ayes.Name = "ayes";
            this.ayes.Size = new System.Drawing.Size(51, 21);
            this.ayes.TabIndex = 30;
            this.ayes.Text = "Yes";
            this.ayes.UseVisualStyleBackColor = true;
            this.ayes.CheckedChanged += new System.EventHandler(this.ayes_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Is Admin?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(513, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // pwdtxt
            // 
            this.pwdtxt.Location = new System.Drawing.Point(516, 133);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(169, 20);
            this.pwdtxt.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(513, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gender";
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(516, 63);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(232, 20);
            this.mailtxt.TabIndex = 14;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(294, 209);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(169, 20);
            this.contacttxt.TabIndex = 13;
            this.contacttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacttxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(294, 63);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(169, 20);
            this.nametxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Agent Name";
            // 
            // addnewbtn
            // 
            this.addnewbtn.Location = new System.Drawing.Point(801, 266);
            this.addnewbtn.Name = "addnewbtn";
            this.addnewbtn.Size = new System.Drawing.Size(94, 38);
            this.addnewbtn.TabIndex = 103;
            this.addnewbtn.Text = "Add New Agent";
            this.addnewbtn.UseVisualStyleBackColor = false;
            this.addnewbtn.Visible = false;
            this.addnewbtn.Click += new System.EventHandler(this.addnewbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 104;
            this.label2.Text = "Add Agent";
            // 
            // agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 632);
            this.Controls.Add(this.dpnl);
            this.Controls.Add(this.agentdataview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agents";
            this.Text = "agents";
            this.Load += new System.EventHandler(this.agents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentdataview)).EndInit();
            this.dpnl.ResumeLayout(false);
            this.dpnl.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnewbtn;
        private System.Windows.Forms.Label label2;
    }
}