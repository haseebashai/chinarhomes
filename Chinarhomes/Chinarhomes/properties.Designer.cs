namespace Chinarhomes
{
    partial class properties
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.propdataview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.proppnl = new System.Windows.Forms.Panel();
            this.dpnl = new System.Windows.Forms.Panel();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pidlbl = new System.Windows.Forms.Label();
            this.vno = new System.Windows.Forms.CheckBox();
            this.vyes = new System.Windows.Forms.CheckBox();
            this.distancetxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.timestamptxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.furnishedtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.floorstxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roomstxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.typetxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.areatxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tagstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.areaptxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editpropbtn = new System.Windows.Forms.Button();
            this.bpnl = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.propdataview)).BeginInit();
            this.proppnl.SuspendLayout();
            this.dpnl.SuspendLayout();
            this.bpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // propdataview
            // 
            this.propdataview.AllowUserToAddRows = false;
            this.propdataview.AllowUserToDeleteRows = false;
            this.propdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.propdataview.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.propdataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.propdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propdataview.Location = new System.Drawing.Point(13, 32);
            this.propdataview.MultiSelect = false;
            this.propdataview.Name = "propdataview";
            this.propdataview.ReadOnly = true;
            this.propdataview.Size = new System.Drawing.Size(1153, 255);
            this.propdataview.TabIndex = 0;
            this.propdataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.propdataview_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Properties";
            // 
            // proppnl
            // 
            this.proppnl.Controls.Add(this.bpnl);
            this.proppnl.Controls.Add(this.dpnl);
            this.proppnl.Controls.Add(this.label1);
            this.proppnl.Controls.Add(this.propdataview);
            this.proppnl.Location = new System.Drawing.Point(1, 1);
            this.proppnl.Name = "proppnl";
            this.proppnl.Size = new System.Drawing.Size(1177, 701);
            this.proppnl.TabIndex = 2;
            // 
            // dpnl
            // 
            this.dpnl.Controls.Add(this.button1);
            this.dpnl.Controls.Add(this.listView1);
            this.dpnl.Controls.Add(this.label19);
            this.dpnl.Controls.Add(this.panel2);
            this.dpnl.Controls.Add(this.label18);
            this.dpnl.Controls.Add(this.label17);
            this.dpnl.Controls.Add(this.panel1);
            this.dpnl.Controls.Add(this.pidlbl);
            this.dpnl.Controls.Add(this.vno);
            this.dpnl.Controls.Add(this.vyes);
            this.dpnl.Controls.Add(this.distancetxt);
            this.dpnl.Controls.Add(this.label16);
            this.dpnl.Controls.Add(this.timestamptxt);
            this.dpnl.Controls.Add(this.label15);
            this.dpnl.Controls.Add(this.label12);
            this.dpnl.Controls.Add(this.agetxt);
            this.dpnl.Controls.Add(this.label13);
            this.dpnl.Controls.Add(this.furnishedtxt);
            this.dpnl.Controls.Add(this.label14);
            this.dpnl.Controls.Add(this.label11);
            this.dpnl.Controls.Add(this.floorstxt);
            this.dpnl.Controls.Add(this.label9);
            this.dpnl.Controls.Add(this.roomstxt);
            this.dpnl.Controls.Add(this.label10);
            this.dpnl.Controls.Add(this.typetxt);
            this.dpnl.Controls.Add(this.pricetxt);
            this.dpnl.Controls.Add(this.label7);
            this.dpnl.Controls.Add(this.desctxt);
            this.dpnl.Controls.Add(this.label8);
            this.dpnl.Controls.Add(this.locationtxt);
            this.dpnl.Controls.Add(this.label6);
            this.dpnl.Controls.Add(this.areatxt);
            this.dpnl.Controls.Add(this.label5);
            this.dpnl.Controls.Add(this.tagstxt);
            this.dpnl.Controls.Add(this.label4);
            this.dpnl.Controls.Add(this.areaptxt);
            this.dpnl.Controls.Add(this.label3);
            this.dpnl.Controls.Add(this.label2);
            this.dpnl.Enabled = false;
            this.dpnl.Location = new System.Drawing.Point(8, 289);
            this.dpnl.Name = "dpnl";
            this.dpnl.Size = new System.Drawing.Size(1166, 355);
            this.dpnl.TabIndex = 2;
            this.dpnl.Visible = false;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(2, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(113, 35);
            this.cancelbtn.TabIndex = 39;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Visible = false;
            // 
            // updbtn
            // 
            this.updbtn.Location = new System.Drawing.Point(121, 4);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(113, 35);
            this.updbtn.TabIndex = 38;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Visible = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(557, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Description";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(560, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 300);
            this.panel2.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(184, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Details";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(2, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Quick info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(187, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 300);
            this.panel1.TabIndex = 33;
            // 
            // pidlbl
            // 
            this.pidlbl.AutoSize = true;
            this.pidlbl.Location = new System.Drawing.Point(13, 68);
            this.pidlbl.Name = "pidlbl";
            this.pidlbl.Size = new System.Drawing.Size(0, 13);
            this.pidlbl.TabIndex = 32;
            // 
            // vno
            // 
            this.vno.AutoSize = true;
            this.vno.Location = new System.Drawing.Point(66, 306);
            this.vno.Name = "vno";
            this.vno.Size = new System.Drawing.Size(40, 17);
            this.vno.TabIndex = 31;
            this.vno.Text = "No";
            this.vno.UseVisualStyleBackColor = true;
            // 
            // vyes
            // 
            this.vyes.AutoSize = true;
            this.vyes.Location = new System.Drawing.Point(16, 306);
            this.vyes.Name = "vyes";
            this.vyes.Size = new System.Drawing.Size(44, 17);
            this.vyes.TabIndex = 30;
            this.vyes.Text = "Yes";
            this.vyes.UseVisualStyleBackColor = true;
            // 
            // distancetxt
            // 
            this.distancetxt.Location = new System.Drawing.Point(393, 185);
            this.distancetxt.Name = "distancetxt";
            this.distancetxt.Size = new System.Drawing.Size(148, 20);
            this.distancetxt.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(390, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Distance from City";
            // 
            // timestamptxt
            // 
            this.timestamptxt.Location = new System.Drawing.Point(393, 247);
            this.timestamptxt.Name = "timestamptxt";
            this.timestamptxt.Size = new System.Drawing.Size(148, 20);
            this.timestamptxt.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(390, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Added on";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Verified";
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(393, 123);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(148, 20);
            this.agetxt.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(390, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Property Age";
            // 
            // furnishedtxt
            // 
            this.furnishedtxt.Location = new System.Drawing.Point(393, 61);
            this.furnishedtxt.Name = "furnishedtxt";
            this.furnishedtxt.Size = new System.Drawing.Size(148, 20);
            this.furnishedtxt.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(390, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Furnished";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Type of Property";
            // 
            // floorstxt
            // 
            this.floorstxt.Location = new System.Drawing.Point(219, 61);
            this.floorstxt.Name = "floorstxt";
            this.floorstxt.Size = new System.Drawing.Size(87, 20);
            this.floorstxt.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "No. of Floors";
            // 
            // roomstxt
            // 
            this.roomstxt.Location = new System.Drawing.Point(219, 123);
            this.roomstxt.Name = "roomstxt";
            this.roomstxt.Size = new System.Drawing.Size(87, 20);
            this.roomstxt.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "No. of Rooms";
            // 
            // typetxt
            // 
            this.typetxt.Location = new System.Drawing.Point(16, 185);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(148, 20);
            this.typetxt.TabIndex = 14;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(16, 247);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(148, 20);
            this.pricetxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price";
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(586, 58);
            this.desctxt.Multiline = true;
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(236, 265);
            this.desctxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Description";
            // 
            // locationtxt
            // 
            this.locationtxt.Location = new System.Drawing.Point(16, 123);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(148, 20);
            this.locationtxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Property Location";
            // 
            // areatxt
            // 
            this.areatxt.Location = new System.Drawing.Point(219, 185);
            this.areatxt.Name = "areatxt";
            this.areatxt.Size = new System.Drawing.Size(124, 20);
            this.areatxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Area in Sq. ft.";
            // 
            // tagstxt
            // 
            this.tagstxt.Location = new System.Drawing.Point(219, 303);
            this.tagstxt.Name = "tagstxt";
            this.tagstxt.Size = new System.Drawing.Size(322, 20);
            this.tagstxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search Tags";
            // 
            // areaptxt
            // 
            this.areaptxt.Location = new System.Drawing.Point(219, 247);
            this.areaptxt.Name = "areaptxt";
            this.areaptxt.Size = new System.Drawing.Size(124, 20);
            this.areaptxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area of Plinth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Property ID";
            // 
            // editpropbtn
            // 
            this.editpropbtn.Location = new System.Drawing.Point(105, 4);
            this.editpropbtn.Name = "editpropbtn";
            this.editpropbtn.Size = new System.Drawing.Size(129, 35);
            this.editpropbtn.TabIndex = 40;
            this.editpropbtn.Text = "Edit Property";
            this.editpropbtn.UseVisualStyleBackColor = false;
            this.editpropbtn.Click += new System.EventHandler(this.editpropbtn_Click);
            // 
            // bpnl
            // 
            this.bpnl.Controls.Add(this.editpropbtn);
            this.bpnl.Controls.Add(this.updbtn);
            this.bpnl.Controls.Add(this.cancelbtn);
            this.bpnl.Location = new System.Drawing.Point(940, 650);
            this.bpnl.Name = "bpnl";
            this.bpnl.Size = new System.Drawing.Size(237, 42);
            this.bpnl.TabIndex = 41;
            this.bpnl.Visible = false;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Location = new System.Drawing.Point(840, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 238);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1037, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 705);
            this.Controls.Add(this.proppnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "properties";
            this.Text = "properties";
            ((System.ComponentModel.ISupportInitialize)(this.propdataview)).EndInit();
            this.proppnl.ResumeLayout(false);
            this.proppnl.PerformLayout();
            this.dpnl.ResumeLayout(false);
            this.dpnl.PerformLayout();
            this.bpnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView propdataview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel proppnl;
        private System.Windows.Forms.Panel dpnl;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox areatxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tagstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox areaptxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pidlbl;
        private System.Windows.Forms.CheckBox vno;
        private System.Windows.Forms.CheckBox vyes;
        private System.Windows.Forms.TextBox distancetxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox timestamptxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox furnishedtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox floorstxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roomstxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox typetxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Panel bpnl;
        private System.Windows.Forms.Button editpropbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}