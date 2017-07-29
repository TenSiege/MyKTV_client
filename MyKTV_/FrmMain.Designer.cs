namespace MyKTV_
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "歌曲名称",
            "",
            ""}, -1);
            this.picNewSong = new System.Windows.Forms.PictureBox();
            this.picClassify = new System.Windows.Forms.PictureBox();
            this.picSort = new System.Windows.Forms.PictureBox();
            this.picAdvanced = new System.Windows.Forms.PictureBox();
            this.picDrinks = new System.Windows.Forms.PictureBox();
            this.picLanguage = new System.Windows.Forms.PictureBox();
            this.picSongName = new System.Windows.Forms.PictureBox();
            this.picSinger = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsmiMain = new System.Windows.Forms.ToolStripButton();
            this.tsmiPlay = new System.Windows.Forms.ToolStripButton();
            this.tsmiStop = new System.Windows.Forms.ToolStripButton();
            this.tsmiRerun = new System.Windows.Forms.ToolStripButton();
            this.tsmiLeftCut = new System.Windows.Forms.ToolStripButton();
            this.tsmiRight = new System.Windows.Forms.ToolStripButton();
            this.tsmiCutSong = new System.Windows.Forms.ToolStripButton();
            this.tsmiVolume = new System.Windows.Forms.ToolStripButton();
            this.tsmiMute = new System.Windows.Forms.ToolStripButton();
            this.tsmiService = new System.Windows.Forms.ToolStripButton();
            this.tsmiSonglist = new System.Windows.Forms.ToolStripButton();
            this.scSongList = new System.Windows.Forms.SplitContainer();
            this.wmpPlaySong = new AxWMPLib.AxWindowsMediaPlayer();
            this.lvSongList = new System.Windows.Forms.ListView();
            this.songName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qiangGE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbVoiume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.pnlVolume = new System.Windows.Forms.Panel();
            this.timerNext = new System.Windows.Forms.Timer(this.components);
            this.pnlOrderBySongList = new System.Windows.Forms.Panel();
            this.lvOrderBySongList = new System.Windows.Forms.ListView();
            this.song_nam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.singer_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.song_play_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilimage = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picNewSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClassify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvanced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).BeginInit();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSongList)).BeginInit();
            this.scSongList.Panel1.SuspendLayout();
            this.scSongList.Panel2.SuspendLayout();
            this.scSongList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlaySong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVoiume)).BeginInit();
            this.pnlVolume.SuspendLayout();
            this.pnlOrderBySongList.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNewSong
            // 
            this.picNewSong.BackColor = System.Drawing.Color.Transparent;
            this.picNewSong.Image = ((System.Drawing.Image)(resources.GetObject("picNewSong.Image")));
            this.picNewSong.Location = new System.Drawing.Point(424, 121);
            this.picNewSong.Name = "picNewSong";
            this.picNewSong.Size = new System.Drawing.Size(170, 152);
            this.picNewSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNewSong.TabIndex = 1;
            this.picNewSong.TabStop = false;
            // 
            // picClassify
            // 
            this.picClassify.BackColor = System.Drawing.Color.Transparent;
            this.picClassify.Image = ((System.Drawing.Image)(resources.GetObject("picClassify.Image")));
            this.picClassify.Location = new System.Drawing.Point(604, 279);
            this.picClassify.Name = "picClassify";
            this.picClassify.Size = new System.Drawing.Size(334, 152);
            this.picClassify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClassify.TabIndex = 2;
            this.picClassify.TabStop = false;
            this.picClassify.Click += new System.EventHandler(this.picClassify_Click);
            // 
            // picSort
            // 
            this.picSort.BackColor = System.Drawing.Color.Transparent;
            this.picSort.Image = ((System.Drawing.Image)(resources.GetObject("picSort.Image")));
            this.picSort.Location = new System.Drawing.Point(432, 279);
            this.picSort.Name = "picSort";
            this.picSort.Size = new System.Drawing.Size(170, 152);
            this.picSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSort.TabIndex = 3;
            this.picSort.TabStop = false;
            // 
            // picAdvanced
            // 
            this.picAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.picAdvanced.Image = ((System.Drawing.Image)(resources.GetObject("picAdvanced.Image")));
            this.picAdvanced.Location = new System.Drawing.Point(768, 121);
            this.picAdvanced.Name = "picAdvanced";
            this.picAdvanced.Size = new System.Drawing.Size(170, 152);
            this.picAdvanced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAdvanced.TabIndex = 4;
            this.picAdvanced.TabStop = false;
            // 
            // picDrinks
            // 
            this.picDrinks.BackColor = System.Drawing.Color.Transparent;
            this.picDrinks.Image = ((System.Drawing.Image)(resources.GetObject("picDrinks.Image")));
            this.picDrinks.Location = new System.Drawing.Point(596, 121);
            this.picDrinks.Name = "picDrinks";
            this.picDrinks.Size = new System.Drawing.Size(170, 152);
            this.picDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDrinks.TabIndex = 5;
            this.picDrinks.TabStop = false;
            // 
            // picLanguage
            // 
            this.picLanguage.BackColor = System.Drawing.Color.Transparent;
            this.picLanguage.Image = ((System.Drawing.Image)(resources.GetObject("picLanguage.Image")));
            this.picLanguage.Location = new System.Drawing.Point(260, 279);
            this.picLanguage.Name = "picLanguage";
            this.picLanguage.Size = new System.Drawing.Size(170, 152);
            this.picLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLanguage.TabIndex = 6;
            this.picLanguage.TabStop = false;
            // 
            // picSongName
            // 
            this.picSongName.BackColor = System.Drawing.Color.Transparent;
            this.picSongName.Image = ((System.Drawing.Image)(resources.GetObject("picSongName.Image")));
            this.picSongName.Location = new System.Drawing.Point(88, 279);
            this.picSongName.Name = "picSongName";
            this.picSongName.Size = new System.Drawing.Size(170, 152);
            this.picSongName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSongName.TabIndex = 7;
            this.picSongName.TabStop = false;
            this.picSongName.Click += new System.EventHandler(this.picSongName_Click);
            // 
            // picSinger
            // 
            this.picSinger.BackColor = System.Drawing.Color.Transparent;
            this.picSinger.Image = ((System.Drawing.Image)(resources.GetObject("picSinger.Image")));
            this.picSinger.Location = new System.Drawing.Point(88, 121);
            this.picSinger.Name = "picSinger";
            this.picSinger.Size = new System.Drawing.Size(334, 152);
            this.picSinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSinger.TabIndex = 8;
            this.picSinger.TabStop = false;
            this.picSinger.Click += new System.EventHandler(this.picSinger_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(109, 19);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "当前时间：";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblShowTime.Location = new System.Drawing.Point(127, 9);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(64, 19);
            this.lblShowTime.TabIndex = 10;
            this.lblShowTime.Text = "00:00";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tsMenu
            // 
            this.tsMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMain,
            this.tsmiPlay,
            this.tsmiStop,
            this.tsmiRerun,
            this.tsmiLeftCut,
            this.tsmiRight,
            this.tsmiCutSong,
            this.tsmiVolume,
            this.tsmiMute,
            this.tsmiService,
            this.tsmiSonglist});
            this.tsMenu.Location = new System.Drawing.Point(0, 506);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1010, 74);
            this.tsMenu.TabIndex = 11;
            this.tsMenu.Text = "工具栏";
            // 
            // tsmiMain
            // 
            this.tsmiMain.ForeColor = System.Drawing.Color.Black;
            this.tsmiMain.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMain.Image")));
            this.tsmiMain.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMain.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmiMain.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiMain.Name = "tsmiMain";
            this.tsmiMain.Size = new System.Drawing.Size(47, 71);
            this.tsmiMain.Text = "主页";
            this.tsmiMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiMain.Click += new System.EventHandler(this.tsmiMain_Click);
            // 
            // tsmiPlay
            // 
            this.tsmiPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPlay.Image")));
            this.tsmiPlay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPlay.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiPlay.Name = "tsmiPlay";
            this.tsmiPlay.Size = new System.Drawing.Size(44, 71);
            this.tsmiPlay.Text = "播放";
            this.tsmiPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiPlay.Click += new System.EventHandler(this.tsmiPlay_Click);
            // 
            // tsmiStop
            // 
            this.tsmiStop.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStop.Image")));
            this.tsmiStop.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiStop.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(44, 71);
            this.tsmiStop.Text = "停止";
            this.tsmiStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiStop.Click += new System.EventHandler(this.tsmiStop_Click);
            // 
            // tsmiRerun
            // 
            this.tsmiRerun.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRerun.Image")));
            this.tsmiRerun.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiRerun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRerun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiRerun.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiRerun.Name = "tsmiRerun";
            this.tsmiRerun.Size = new System.Drawing.Size(44, 71);
            this.tsmiRerun.Text = "重唱";
            this.tsmiRerun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiRerun.Click += new System.EventHandler(this.tsmiRerun_Click);
            // 
            // tsmiLeftCut
            // 
            this.tsmiLeftCut.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLeftCut.Image")));
            this.tsmiLeftCut.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiLeftCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiLeftCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiLeftCut.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiLeftCut.Name = "tsmiLeftCut";
            this.tsmiLeftCut.Size = new System.Drawing.Size(60, 71);
            this.tsmiLeftCut.Text = "向左切换";
            this.tsmiLeftCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiRight
            // 
            this.tsmiRight.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRight.Image")));
            this.tsmiRight.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiRight.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiRight.Name = "tsmiRight";
            this.tsmiRight.Size = new System.Drawing.Size(60, 71);
            this.tsmiRight.Text = "向右切换";
            this.tsmiRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiCutSong
            // 
            this.tsmiCutSong.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCutSong.Image")));
            this.tsmiCutSong.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiCutSong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCutSong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCutSong.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiCutSong.Name = "tsmiCutSong";
            this.tsmiCutSong.Size = new System.Drawing.Size(44, 71);
            this.tsmiCutSong.Text = "切歌";
            this.tsmiCutSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiCutSong.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiVolume
            // 
            this.tsmiVolume.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVolume.Image")));
            this.tsmiVolume.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiVolume.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiVolume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiVolume.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiVolume.Name = "tsmiVolume";
            this.tsmiVolume.Size = new System.Drawing.Size(52, 71);
            this.tsmiVolume.Text = "音量";
            this.tsmiVolume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiVolume.Click += new System.EventHandler(this.tsmiVolume_Click);
            // 
            // tsmiMute
            // 
            this.tsmiMute.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMute.Image")));
            this.tsmiMute.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiMute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiMute.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiMute.Name = "tsmiMute";
            this.tsmiMute.Size = new System.Drawing.Size(52, 71);
            this.tsmiMute.Text = "静音";
            this.tsmiMute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiMute.Click += new System.EventHandler(this.tsmiMute_Click);
            // 
            // tsmiService
            // 
            this.tsmiService.Image = ((System.Drawing.Image)(resources.GetObject("tsmiService.Image")));
            this.tsmiService.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiService.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiService.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiService.Name = "tsmiService";
            this.tsmiService.Size = new System.Drawing.Size(52, 71);
            this.tsmiService.Text = "客服";
            this.tsmiService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiSonglist
            // 
            this.tsmiSonglist.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSonglist.Image")));
            this.tsmiSonglist.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsmiSonglist.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSonglist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSonglist.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.tsmiSonglist.Name = "tsmiSonglist";
            this.tsmiSonglist.Size = new System.Drawing.Size(60, 71);
            this.tsmiSonglist.Text = "播放列表";
            this.tsmiSonglist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiSonglist.Click += new System.EventHandler(this.tsmiSongList_Click);
            // 
            // scSongList
            // 
            this.scSongList.BackColor = System.Drawing.Color.Transparent;
            this.scSongList.Location = new System.Drawing.Point(819, 458);
            this.scSongList.Name = "scSongList";
            // 
            // scSongList.Panel1
            // 
            this.scSongList.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.scSongList.Panel1.Controls.Add(this.wmpPlaySong);
            // 
            // scSongList.Panel2
            // 
            this.scSongList.Panel2.Controls.Add(this.lvSongList);
            this.scSongList.Size = new System.Drawing.Size(69, 45);
            this.scSongList.SplitterDistance = 39;
            this.scSongList.TabIndex = 14;
            // 
            // wmpPlaySong
            // 
            this.wmpPlaySong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpPlaySong.Enabled = true;
            this.wmpPlaySong.Location = new System.Drawing.Point(0, 0);
            this.wmpPlaySong.Name = "wmpPlaySong";
            this.wmpPlaySong.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlaySong.OcxState")));
            this.wmpPlaySong.Size = new System.Drawing.Size(39, 45);
            this.wmpPlaySong.TabIndex = 0;
            // 
            // lvSongList
            // 
            this.lvSongList.BackColor = System.Drawing.Color.Silver;
            this.lvSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSongList.BackgroundImage")));
            this.lvSongList.BackgroundImageTiled = true;
            this.lvSongList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songName,
            this.qiangGE,
            this.ding});
            this.lvSongList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSongList.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSongList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvSongList.FullRowSelect = true;
            this.lvSongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSongList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvSongList.Location = new System.Drawing.Point(0, 0);
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.Size = new System.Drawing.Size(26, 45);
            this.lvSongList.TabIndex = 0;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            // 
            // songName
            // 
            this.songName.Text = "歌曲名称";
            this.songName.Width = 150;
            // 
            // qiangGE
            // 
            this.qiangGE.Text = "抢歌";
            this.qiangGE.Width = 150;
            // 
            // ding
            // 
            this.ding.Text = "顶";
            this.ding.Width = 150;
            // 
            // tbVoiume
            // 
            this.tbVoiume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbVoiume.Location = new System.Drawing.Point(0, 1);
            this.tbVoiume.Maximum = 100;
            this.tbVoiume.Name = "tbVoiume";
            this.tbVoiume.Size = new System.Drawing.Size(122, 45);
            this.tbVoiume.TabIndex = 15;
            this.tbVoiume.TickFrequency = 10;
            this.tbVoiume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbVoiume.Scroll += new System.EventHandler(this.tbVoiume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblVolume.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVolume.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVolume.Location = new System.Drawing.Point(131, 18);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(17, 16);
            this.lblVolume.TabIndex = 16;
            this.lblVolume.Text = "0";
            // 
            // pnlVolume
            // 
            this.pnlVolume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlVolume.Controls.Add(this.tbVoiume);
            this.pnlVolume.Controls.Add(this.lblVolume);
            this.pnlVolume.Location = new System.Drawing.Point(537, 467);
            this.pnlVolume.Name = "pnlVolume";
            this.pnlVolume.Size = new System.Drawing.Size(165, 46);
            this.pnlVolume.TabIndex = 17;
            this.pnlVolume.Visible = false;
            // 
            // timerNext
            // 
            this.timerNext.Enabled = true;
            this.timerNext.Interval = 2000;
            this.timerNext.Tick += new System.EventHandler(this.timerNext_Tick);
            // 
            // pnlOrderBySongList
            // 
            this.pnlOrderBySongList.BackColor = System.Drawing.Color.White;
            this.pnlOrderBySongList.Controls.Add(this.lvOrderBySongList);
            this.pnlOrderBySongList.Location = new System.Drawing.Point(16, 458);
            this.pnlOrderBySongList.Name = "pnlOrderBySongList";
            this.pnlOrderBySongList.Size = new System.Drawing.Size(25, 30);
            this.pnlOrderBySongList.TabIndex = 18;
            // 
            // lvOrderBySongList
            // 
            this.lvOrderBySongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvOrderBySongList.BackgroundImage")));
            this.lvOrderBySongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.song_nam,
            this.singer_name,
            this.song_play_count});
            this.lvOrderBySongList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrderBySongList.Font = new System.Drawing.Font("凌氏随手体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvOrderBySongList.ForeColor = System.Drawing.SystemColors.Info;
            this.lvOrderBySongList.FullRowSelect = true;
            this.lvOrderBySongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvOrderBySongList.Location = new System.Drawing.Point(0, 0);
            this.lvOrderBySongList.Name = "lvOrderBySongList";
            this.lvOrderBySongList.Size = new System.Drawing.Size(25, 30);
            this.lvOrderBySongList.SmallImageList = this.ilimage;
            this.lvOrderBySongList.TabIndex = 0;
            this.lvOrderBySongList.UseCompatibleStateImageBehavior = false;
            this.lvOrderBySongList.View = System.Windows.Forms.View.Details;
            this.lvOrderBySongList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvOrderBySongList_MouseClick);
            // 
            // song_nam
            // 
            this.song_nam.Text = "歌曲名称";
            this.song_nam.Width = 200;
            // 
            // singer_name
            // 
            this.singer_name.Text = "艺术家";
            this.singer_name.Width = 200;
            // 
            // song_play_count
            // 
            this.song_play_count.Text = "点播次数";
            this.song_play_count.Width = 200;
            // 
            // ilimage
            // 
            this.ilimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilimage.ImageStream")));
            this.ilimage.TransparentColor = System.Drawing.Color.Transparent;
            this.ilimage.Images.SetKeyName(0, "音乐.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 580);
            this.Controls.Add(this.pnlOrderBySongList);
            this.Controls.Add(this.pnlVolume);
            this.Controls.Add(this.scSongList);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picSinger);
            this.Controls.Add(this.picSongName);
            this.Controls.Add(this.picLanguage);
            this.Controls.Add(this.picDrinks);
            this.Controls.Add(this.picAdvanced);
            this.Controls.Add(this.picSort);
            this.Controls.Add(this.picClassify);
            this.Controls.Add(this.picNewSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Click += new System.EventHandler(this.FrmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picNewSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClassify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvanced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.scSongList.Panel1.ResumeLayout(false);
            this.scSongList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSongList)).EndInit();
            this.scSongList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlaySong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVoiume)).EndInit();
            this.pnlVolume.ResumeLayout(false);
            this.pnlVolume.PerformLayout();
            this.pnlOrderBySongList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picNewSong;
        private System.Windows.Forms.PictureBox picClassify;
        private System.Windows.Forms.PictureBox picSort;
        private System.Windows.Forms.PictureBox picAdvanced;
        private System.Windows.Forms.PictureBox picDrinks;
        private System.Windows.Forms.PictureBox picLanguage;
        private System.Windows.Forms.PictureBox picSongName;
        private System.Windows.Forms.PictureBox picSinger;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.SplitContainer scSongList;
        private System.Windows.Forms.ListView lvSongList;
        private System.Windows.Forms.ColumnHeader songName;
        private System.Windows.Forms.ColumnHeader qiangGE;
        private System.Windows.Forms.ColumnHeader ding;
        private System.Windows.Forms.TrackBar tbVoiume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Panel pnlVolume;
        private System.Windows.Forms.Timer timerNext;
        private System.Windows.Forms.Panel pnlOrderBySongList;
        private System.Windows.Forms.ListView lvOrderBySongList;
        private System.Windows.Forms.ColumnHeader song_nam;
        private System.Windows.Forms.ColumnHeader singer_name;
        private System.Windows.Forms.ColumnHeader song_play_count;
        private System.Windows.Forms.ImageList ilimage;
        public System.Windows.Forms.ToolStrip tsMenu;
        public System.Windows.Forms.ToolStripButton tsmiMain;
        public System.Windows.Forms.ToolStripButton tsmiPlay;
        public System.Windows.Forms.ToolStripButton tsmiStop;
        public System.Windows.Forms.ToolStripButton tsmiRerun;
        public System.Windows.Forms.ToolStripButton tsmiLeftCut;
        public System.Windows.Forms.ToolStripButton tsmiRight;
        public System.Windows.Forms.ToolStripButton tsmiSonglist;
        public System.Windows.Forms.ToolStripButton tsmiCutSong;
        public System.Windows.Forms.ToolStripButton tsmiVolume;
        public System.Windows.Forms.ToolStripButton tsmiMute;
        public System.Windows.Forms.ToolStripButton tsmiService;
        public AxWMPLib.AxWindowsMediaPlayer wmpPlaySong;
    }
}

