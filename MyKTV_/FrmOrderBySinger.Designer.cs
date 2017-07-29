namespace MyKTV_
{
    partial class FrmOrderBySinger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderBySinger));
            this.lblOrderBySinger = new System.Windows.Forms.Label();
            this.picNvSinger = new System.Windows.Forms.PictureBox();
            this.picNanSinger = new System.Windows.Forms.PictureBox();
            this.picZhuHeSinger = new System.Windows.Forms.PictureBox();
            this.pnlSingerList = new System.Windows.Forms.Panel();
            this.lvSingerLisrt = new System.Windows.Forms.ListView();
            this.ilSingerPhoto = new System.Windows.Forms.ImageList(this.components);
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.lvSongList = new System.Windows.Forms.ListView();
            this.song_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.singer_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.song_play_conut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilSongList = new System.Windows.Forms.ImageList(this.components);
            this.lblSingerIntro = new System.Windows.Forms.Label();
            this.picSingerPhoto = new System.Windows.Forms.PictureBox();
            this.pnlSongList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picNvSinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNanSinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZhuHeSinger)).BeginInit();
            this.pnlSingerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSingerPhoto)).BeginInit();
            this.pnlSongList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderBySinger
            // 
            this.lblOrderBySinger.AutoSize = true;
            this.lblOrderBySinger.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderBySinger.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderBySinger.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblOrderBySinger.Location = new System.Drawing.Point(26, 9);
            this.lblOrderBySinger.Name = "lblOrderBySinger";
            this.lblOrderBySinger.Size = new System.Drawing.Size(149, 24);
            this.lblOrderBySinger.TabIndex = 1;
            this.lblOrderBySinger.Text = "-->歌星点歌";
            // 
            // picNvSinger
            // 
            this.picNvSinger.Image = ((System.Drawing.Image)(resources.GetObject("picNvSinger.Image")));
            this.picNvSinger.Location = new System.Drawing.Point(376, 37);
            this.picNvSinger.Name = "picNvSinger";
            this.picNvSinger.Size = new System.Drawing.Size(275, 145);
            this.picNvSinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNvSinger.TabIndex = 2;
            this.picNvSinger.TabStop = false;
            this.picNvSinger.Tag = "女";
            this.picNvSinger.Click += new System.EventHandler(this.picNvSinger_Click);
            // 
            // picNanSinger
            // 
            this.picNanSinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNanSinger.BackgroundImage")));
            this.picNanSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNanSinger.Image = ((System.Drawing.Image)(resources.GetObject("picNanSinger.Image")));
            this.picNanSinger.Location = new System.Drawing.Point(258, 185);
            this.picNanSinger.Name = "picNanSinger";
            this.picNanSinger.Size = new System.Drawing.Size(275, 145);
            this.picNanSinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNanSinger.TabIndex = 3;
            this.picNanSinger.TabStop = false;
            this.picNanSinger.Tag = "男";
            this.picNanSinger.Click += new System.EventHandler(this.picNvSinger_Click);
            // 
            // picZhuHeSinger
            // 
            this.picZhuHeSinger.Image = ((System.Drawing.Image)(resources.GetObject("picZhuHeSinger.Image")));
            this.picZhuHeSinger.Location = new System.Drawing.Point(385, 333);
            this.picZhuHeSinger.Name = "picZhuHeSinger";
            this.picZhuHeSinger.Size = new System.Drawing.Size(266, 151);
            this.picZhuHeSinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picZhuHeSinger.TabIndex = 4;
            this.picZhuHeSinger.TabStop = false;
            this.picZhuHeSinger.Tag = "组合";
            this.picZhuHeSinger.Click += new System.EventHandler(this.picNvSinger_Click);
            // 
            // pnlSingerList
            // 
            this.pnlSingerList.Controls.Add(this.lvSingerLisrt);
            this.pnlSingerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSingerList.Location = new System.Drawing.Point(0, 0);
            this.pnlSingerList.Name = "pnlSingerList";
            this.pnlSingerList.Size = new System.Drawing.Size(1025, 580);
            this.pnlSingerList.TabIndex = 5;
            // 
            // lvSingerLisrt
            // 
            this.lvSingerLisrt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSingerLisrt.BackgroundImage")));
            this.lvSingerLisrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSingerLisrt.Font = new System.Drawing.Font("凌氏随手体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSingerLisrt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lvSingerLisrt.LargeImageList = this.ilSingerPhoto;
            this.lvSingerLisrt.Location = new System.Drawing.Point(0, 0);
            this.lvSingerLisrt.Name = "lvSingerLisrt";
            this.lvSingerLisrt.Size = new System.Drawing.Size(1025, 580);
            this.lvSingerLisrt.TabIndex = 0;
            this.lvSingerLisrt.UseCompatibleStateImageBehavior = false;
            this.lvSingerLisrt.Click += new System.EventHandler(this.lvSingerLisrt_Click);
            // 
            // ilSingerPhoto
            // 
            this.ilSingerPhoto.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilSingerPhoto.ImageSize = new System.Drawing.Size(150, 100);
            this.ilSingerPhoto.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picReturn
            // 
            this.picReturn.BackColor = System.Drawing.Color.Transparent;
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(981, 9);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(32, 35);
            this.picReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReturn.TabIndex = 6;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // lvSongList
            // 
            this.lvSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSongList.BackgroundImage")));
            this.lvSongList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.song_name,
            this.singer_name,
            this.song_play_conut});
            this.lvSongList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSongList.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lvSongList.FullRowSelect = true;
            this.lvSongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSongList.Location = new System.Drawing.Point(305, 0);
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.Size = new System.Drawing.Size(717, 580);
            this.lvSongList.SmallImageList = this.ilSongList;
            this.lvSongList.TabIndex = 7;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            this.lvSongList.Click += new System.EventHandler(this.lvSongList_Click);
            // 
            // song_name
            // 
            this.song_name.Text = "歌曲名称";
            this.song_name.Width = 290;
            // 
            // singer_name
            // 
            this.singer_name.Text = "艺术家";
            this.singer_name.Width = 290;
            // 
            // song_play_conut
            // 
            this.song_play_conut.Text = "点播次数";
            this.song_play_conut.Width = 100;
            // 
            // ilSongList
            // 
            this.ilSongList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSongList.ImageStream")));
            this.ilSongList.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSongList.Images.SetKeyName(0, "yingyue.png");
            // 
            // lblSingerIntro
            // 
            this.lblSingerIntro.AutoSize = true;
            this.lblSingerIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblSingerIntro.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSingerIntro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSingerIntro.Location = new System.Drawing.Point(12, 222);
            this.lblSingerIntro.Name = "lblSingerIntro";
            this.lblSingerIntro.Size = new System.Drawing.Size(0, 16);
            this.lblSingerIntro.TabIndex = 1;
            // 
            // picSingerPhoto
            // 
            this.picSingerPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSingerPhoto.BackgroundImage")));
            this.picSingerPhoto.Location = new System.Drawing.Point(3, 0);
            this.picSingerPhoto.Name = "picSingerPhoto";
            this.picSingerPhoto.Size = new System.Drawing.Size(301, 219);
            this.picSingerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSingerPhoto.TabIndex = 0;
            this.picSingerPhoto.TabStop = false;
            // 
            // pnlSongList
            // 
            this.pnlSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSongList.BackgroundImage")));
            this.pnlSongList.Controls.Add(this.lblSingerIntro);
            this.pnlSongList.Controls.Add(this.lvSongList);
            this.pnlSongList.Controls.Add(this.picSingerPhoto);
            this.pnlSongList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSongList.Location = new System.Drawing.Point(0, 0);
            this.pnlSongList.Name = "pnlSongList";
            this.pnlSongList.Size = new System.Drawing.Size(1025, 580);
            this.pnlSongList.TabIndex = 9;
            // 
            // FrmOrderBySinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 580);
            this.Controls.Add(this.pnlSongList);
            this.Controls.Add(this.picReturn);
            this.Controls.Add(this.pnlSingerList);
            this.Controls.Add(this.picZhuHeSinger);
            this.Controls.Add(this.picNanSinger);
            this.Controls.Add(this.picNvSinger);
            this.Controls.Add(this.lblOrderBySinger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderBySinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌星点歌";
            this.Load += new System.EventHandler(this.FrmOrderBySinger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNvSinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNanSinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZhuHeSinger)).EndInit();
            this.pnlSingerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSingerPhoto)).EndInit();
            this.pnlSongList.ResumeLayout(false);
            this.pnlSongList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrderBySinger;
        private System.Windows.Forms.PictureBox picNvSinger;
        private System.Windows.Forms.PictureBox picNanSinger;
        private System.Windows.Forms.PictureBox picZhuHeSinger;
        private System.Windows.Forms.Panel pnlSingerList;
        private System.Windows.Forms.ListView lvSingerLisrt;
        private System.Windows.Forms.ImageList ilSingerPhoto;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.ListView lvSongList;
        private System.Windows.Forms.PictureBox picSingerPhoto;
        private System.Windows.Forms.Label lblSingerIntro;
        private System.Windows.Forms.Panel pnlSongList;
        private System.Windows.Forms.ImageList ilSongList;
        private System.Windows.Forms.ColumnHeader song_name;
        private System.Windows.Forms.ColumnHeader singer_name;
        private System.Windows.Forms.ColumnHeader song_play_conut;
    }
}