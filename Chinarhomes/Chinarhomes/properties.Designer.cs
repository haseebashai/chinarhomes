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
            this.unverbtn = new System.Windows.Forms.Button();
            this.verbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadinglbl = new System.Windows.Forms.Label();
            this.dpnl = new System.Windows.Forms.Panel();
            this.tuvplbl = new System.Windows.Forms.Label();
            this.tvplbl = new System.Windows.Forms.Label();
            this.addpbtn = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.PictureBox();
            this.dpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // unverbtn
            // 
            this.unverbtn.Location = new System.Drawing.Point(44, 179);
            this.unverbtn.Name = "unverbtn";
            this.unverbtn.Size = new System.Drawing.Size(162, 35);
            this.unverbtn.TabIndex = 39;
            this.unverbtn.Text = "Check Unverified Properties";
            this.unverbtn.UseVisualStyleBackColor = false;
            this.unverbtn.Click += new System.EventHandler(this.unverbtn_Click);
            // 
            // verbtn
            // 
            this.verbtn.Location = new System.Drawing.Point(44, 125);
            this.verbtn.Name = "verbtn";
            this.verbtn.Size = new System.Drawing.Size(162, 35);
            this.verbtn.TabIndex = 40;
            this.verbtn.Text = "Check Verified Properties";
            this.verbtn.UseVisualStyleBackColor = false;
            this.verbtn.Click += new System.EventHandler(this.verbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Properties";
            // 
            // loadinglbl
            // 
            this.loadinglbl.AutoSize = true;
            this.loadinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadinglbl.Location = new System.Drawing.Point(-2, 261);
            this.loadinglbl.Name = "loadinglbl";
            this.loadinglbl.Size = new System.Drawing.Size(172, 25);
            this.loadinglbl.TabIndex = 42;
            this.loadinglbl.Text = "Loading Highlights";
            // 
            // dpnl
            // 
            this.dpnl.Controls.Add(this.tuvplbl);
            this.dpnl.Controls.Add(this.tvplbl);
            this.dpnl.Location = new System.Drawing.Point(3, 289);
            this.dpnl.Name = "dpnl";
            this.dpnl.Size = new System.Drawing.Size(650, 306);
            this.dpnl.TabIndex = 43;
            // 
            // tuvplbl
            // 
            this.tuvplbl.AutoSize = true;
            this.tuvplbl.Location = new System.Drawing.Point(10, 69);
            this.tuvplbl.Name = "tuvplbl";
            this.tuvplbl.Size = new System.Drawing.Size(0, 13);
            this.tuvplbl.TabIndex = 1;
            // 
            // tvplbl
            // 
            this.tvplbl.AutoSize = true;
            this.tvplbl.Location = new System.Drawing.Point(10, 34);
            this.tvplbl.Name = "tvplbl";
            this.tvplbl.Size = new System.Drawing.Size(0, 13);
            this.tvplbl.TabIndex = 0;
            // 
            // addpbtn
            // 
            this.addpbtn.Location = new System.Drawing.Point(44, 70);
            this.addpbtn.Name = "addpbtn";
            this.addpbtn.Size = new System.Drawing.Size(162, 35);
            this.addpbtn.TabIndex = 45;
            this.addpbtn.Text = "Add New Property";
            this.addpbtn.UseVisualStyleBackColor = false;
            this.addpbtn.Click += new System.EventHandler(this.addpbtn_Click);
            // 
            // loading
            // 
            this.loading.Image = global::Chinarhomes.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(165, 259);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(31, 32);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 44;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 705);
            this.Controls.Add(this.addpbtn);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.dpnl);
            this.Controls.Add(this.loadinglbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verbtn);
            this.Controls.Add(this.unverbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "properties";
            this.Text = "properties";
            this.dpnl.ResumeLayout(false);
            this.dpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button unverbtn;
        private System.Windows.Forms.Button verbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loadinglbl;
        private System.Windows.Forms.Panel dpnl;
        private System.Windows.Forms.Label tuvplbl;
        private System.Windows.Forms.Label tvplbl;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Button addpbtn;
    }
}