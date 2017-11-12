namespace Chinarhomes
{
    partial class dialogcontainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogcontainer));
            this.lbl = new System.Windows.Forms.Label();
            this.dialogpnl = new System.Windows.Forms.Panel();
            this.loadingimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadingimage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl.Location = new System.Drawing.Point(6, 2);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 24);
            this.lbl.TabIndex = 72;
            // 
            // dialogpnl
            // 
            this.dialogpnl.AutoScroll = true;
            this.dialogpnl.Location = new System.Drawing.Point(3, 29);
            this.dialogpnl.Name = "dialogpnl";
            this.dialogpnl.Size = new System.Drawing.Size(1185, 668);
            this.dialogpnl.TabIndex = 71;
            // 
            // loadingimage
            // 
            this.loadingimage.Location = new System.Drawing.Point(80, -1);
            this.loadingimage.Name = "loadingimage";
            this.loadingimage.Size = new System.Drawing.Size(40, 29);
            this.loadingimage.TabIndex = 73;
            this.loadingimage.TabStop = false;
            this.loadingimage.Visible = false;
            // 
            // dialogcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 696);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.loadingimage);
            this.Controls.Add(this.dialogpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dialogcontainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chinar Homes";
            ((System.ComponentModel.ISupportInitialize)(this.loadingimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.PictureBox loadingimage;
        public System.Windows.Forms.Panel dialogpnl;
    }
}