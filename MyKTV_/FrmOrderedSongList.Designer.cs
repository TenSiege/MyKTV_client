namespace MyKTV_
{
    partial class FrmOrderedSongList
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
            this.lvSongList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvSongList
            // 
            this.lvSongList.Location = new System.Drawing.Point(0, -1);
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.Size = new System.Drawing.Size(1007, 523);
            this.lvSongList.TabIndex = 0;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            // 
            // FrmOrderedSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 580);
            this.Controls.Add(this.lvSongList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderedSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "排行点歌";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSongList;
    }
}