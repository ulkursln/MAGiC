namespace MAGiC.Utility
{
    partial class OutlookBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OutlookBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OutlookBar";
            this.Size = new System.Drawing.Size(166, 48);
            this.DoubleClick += new System.EventHandler(this.OutlookBar_DoubleClick);
            this.Load += new System.EventHandler(this.OutlookBar_Load);
            base.Click += new System.EventHandler(this.OutlookBar_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OutlookBar_MouseMove);
            this.Resize += new System.EventHandler(this.OutlookBar_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OutlookBar_Paint);
            this.MouseLeave += new System.EventHandler(this.OutlookBar_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
