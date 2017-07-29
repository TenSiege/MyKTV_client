namespace MyKTV_
{
    partial class FrmSongList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSongList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSongList = new System.Windows.Forms.DataGridView();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_play_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnMainUI = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbtnServe = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReturn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSongList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tsMenu, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.24946F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.761388F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvSongList
            // 
            this.dgvSongList.AllowUserToAddRows = false;
            this.dgvSongList.AllowUserToDeleteRows = false;
            this.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.song_name,
            this.singer_name,
            this.song_play_count});
            this.dgvSongList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSongList.Location = new System.Drawing.Point(3, 26);
            this.dgvSongList.Name = "dgvSongList";
            this.dgvSongList.ReadOnly = true;
            this.dgvSongList.RowHeadersVisible = false;
            this.dgvSongList.RowTemplate.Height = 23;
            this.dgvSongList.Size = new System.Drawing.Size(713, 386);
            this.dgvSongList.TabIndex = 0;
            // 
            // song_name
            // 
            this.song_name.DataPropertyName = "song_name";
            this.song_name.HeaderText = "歌曲名";
            this.song_name.Name = "song_name";
            this.song_name.ReadOnly = true;
            this.song_name.Width = 300;
            // 
            // singer_name
            // 
            this.singer_name.DataPropertyName = "singer_name";
            this.singer_name.HeaderText = "歌手";
            this.singer_name.Name = "singer_name";
            this.singer_name.ReadOnly = true;
            this.singer_name.Width = 300;
            // 
            // song_play_count
            // 
            this.song_play_count.DataPropertyName = "song_play_count";
            this.song_play_count.HeaderText = "点播次数";
            this.song_play_count.Name = "song_play_count";
            this.song_play_count.ReadOnly = true;
            this.song_play_count.Width = 110;
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMainUI,
            this.tsbtnCut,
            this.tsbtnAgain,
            this.tsbtnOrder,
            this.tsbtnServe,
            this.tsbtnReturn});
            this.tsMenu.Location = new System.Drawing.Point(0, 421);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(719, 40);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbtnMainUI
            // 
            this.tsbtnMainUI.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMainUI.Image")));
            this.tsbtnMainUI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMainUI.Name = "tsbtnMainUI";
            this.tsbtnMainUI.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tsbtnMainUI.Size = new System.Drawing.Size(68, 37);
            this.tsbtnMainUI.Text = "主界面";
            this.tsbtnMainUI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCut.Image")));
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tsbtnCut.Size = new System.Drawing.Size(56, 37);
            this.tsbtnCut.Text = "切歌";
            this.tsbtnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnAgain
            // 
            this.tsbtnAgain.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgain.Image")));
            this.tsbtnAgain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgain.Name = "tsbtnAgain";
            this.tsbtnAgain.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tsbtnAgain.Size = new System.Drawing.Size(56, 37);
            this.tsbtnAgain.Text = "重唱";
            this.tsbtnAgain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnOrder
            // 
            this.tsbtnOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrder.Image")));
            this.tsbtnOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOrder.Name = "tsbtnOrder";
            this.tsbtnOrder.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tsbtnOrder.Size = new System.Drawing.Size(56, 37);
            this.tsbtnOrder.Text = "已点";
            this.tsbtnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnServe
            // 
            this.tsbtnServe.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnServe.Image")));
            this.tsbtnServe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnServe.Name = "tsbtnServe";
            this.tsbtnServe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tsbtnServe.Size = new System.Drawing.Size(56, 37);
            this.tsbtnServe.Text = "服务";
            this.tsbtnServe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnReturn
            // 
            this.tsbtnReturn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReturn.Image")));
            this.tsbtnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReturn.Name = "tsbtnReturn";
            this.tsbtnReturn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tsbtnReturn.Size = new System.Drawing.Size(56, 37);
            this.tsbtnReturn.Text = "返回";
            this.tsbtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FrmSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌曲列表";
            this.Load += new System.EventHandler(this.FrmSongList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvSongList;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_play_count;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnMainUI;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnOrder;
        private System.Windows.Forms.ToolStripButton tsbtnServe;
        private System.Windows.Forms.ToolStripButton tsbtnReturn;
    }
}