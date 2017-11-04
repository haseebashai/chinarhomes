namespace Chinarhomes
{
    partial class container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(container));
            this.mainpnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainpnl
            // 
            this.mainpnl.AutoScroll = true;
            this.mainpnl.AutoSize = true;
            this.mainpnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpnl.Location = new System.Drawing.Point(0, 0);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(1350, 683);
            this.mainpnl.TabIndex = 0;
            // 
            // container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 683);
            this.Controls.Add(this.mainpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chinarhomes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.container_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel mainpnl;
    }
}

