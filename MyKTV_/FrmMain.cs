using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV_
{
    public partial class FrmMain : Form
    {
        //int volume;//当前播放器的音量
        //数据库辅助类
        DBHelper db = new DBHelper();
        public FrmMain()
        {
            InitializeComponent();
        }
        #region 窗体加载
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //隐藏播放列表面板
            scSongList.Visible = false;
            pnlOrderBySongList.Visible = false;
        }
        #endregion
        #region 每秒实时刷新时间
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblShowTime.Text = DateTime.Now.ToString();
        }
        #endregion
        //#region 放大鼠标停留的pic控件
        //private void picSinger_MouseEnter(object sender, EventArgs e)
        //{
        //    PictureBox pic =(PictureBox)sender;//获得当前的控件对象

        //    pic.Width += 30;
        //    pic.Height += 30;
        //}
        //#endregion
        //#region 鼠标离开Pic时回归正常大小
        //private void picSinger_MouseLeave(object sender, EventArgs e)
        //{
        //    PictureBox pic = (PictureBox)sender;//获得当前的控件对象
        //    pic.Width -= 30;
        //    pic.Height -= 30;
        //}
        //#endregion
        #region 歌星点歌
        private void picSinger_Click(object sender, EventArgs e)
        {
            FrmOrderBySinger frmOrderBySinger = new FrmOrderBySinger();
            //传递当前窗体到将要打开的窗体
            frmOrderBySinger.frm = this;
            //显示窗体
            frmOrderBySinger.Show();
            //隐藏当前窗体
            this.Hide();

        }
        #endregion
        #region 拼音点歌
        private void picSongName_Click(object sender, EventArgs e)
        {
            FrmOrderBySongName frmOrderBySongName = new FrmOrderBySongName();
            frmOrderBySongName.frm = this;
            frmOrderBySongName.Show();
        }
        #endregion
        #region 刷新歌曲播放列表
        public void AddSong()
        {
            lvSongList.Items.Clear();
            //添加播放列表中的歌曲到播放列表中
            foreach (Song song in PlayList.SongList)
            {
                if (song != null)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = song.SongName;
                    item.SubItems.Add("抢歌");
                    item.SubItems.Add("顶歌");
                    lvSongList.Items.Add(item);
                }
            }
        }
        #endregion
        #region 当用户切歌时发生的事件
        public void tsmiCut_Click(object sender, EventArgs e)
        {
            CutSong();
        }
        #endregion
        #region 如果当前播放列表没有歌曲，则播放刚点播的歌曲
        public void PlaySong()
        {
            wmpPlaySong.URL = PlayList.SongList[0].SongURL;
        }
        #endregion
        #region 切歌
        public void CutSong()
        {
            if (PlayList.Num == 0)
            {
                MessageBox.Show("当前播放列表没有歌曲，请点播歌曲！");
            }
            else if (PlayList.Num == 1)
            {
                MessageBox.Show("已经到最后一首歌曲了！");
            }
            else//如果列表有歌曲
            {
                PlayList.CutSong();//调用切歌方法                                 
                //设置路径播放歌曲,播放的歌曲永远是播放列表的第一首歌曲
                wmpPlaySong.URL = PlayList.SongList[0].SongURL;
                AddSong();//刷新播放列表
            }
        }
        #endregion        
        #region 打开播放列表
        public void tsmiSongList_Click(object sender, EventArgs e)
        {
            pnlOrderBySongList.Visible = false;
            if (scSongList.Visible == false)
            {
                scSongList.Dock = DockStyle.Fill;
                scSongList.Visible = true;
            }
        }
        #endregion
        #region 返回主界面
        public void tsmiMain_Click(object sender, EventArgs e)
        {
            scSongList.Visible = false;
            pnlOrderBySongList.Visible = false;
        }
        #endregion
        #region 自动播放下一首歌曲
        private void timerNext_Tick(object sender, EventArgs e)
        {
            if ((int)wmpPlaySong.playState == 1)//判断是否停止播放
            {
                CutSong();
                wmpPlaySong.Ctlcontrols.play();
            }
        }
        #endregion
        #region 播放和暂停
        public void tsmiPlay_Click(object sender, EventArgs e)
        {
            if (wmpPlaySong.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                wmpPlaySong.Ctlcontrols.play();//播放
            }
            else
            {
                wmpPlaySong.Ctlcontrols.pause();//暂停
            }
        }
        #endregion
        #region 播放停止
        public void tsmiStop_Click(object sender, EventArgs e)
        {
            wmpPlaySong.Ctlcontrols.stop();
        }
        #endregion
        #region 静音
        public void tsmiMute_Click(object sender, EventArgs e)
        {
            //if (wmpPlaySong.settings.volume == 0)
            //{

            //    wmpPlaySong.settings.volume = volume;//如果已是静音状态，则恢复静音前的音量               
            //}
            //else
            //{
            //    volume = wmpPlaySong.settings.volume;//先得出静音前的音量
            //    wmpPlaySong.settings.volume = 0;//音量设为0
            //}
            //lblVolume.Text = wmpPlaySong.settings.volume.ToString();
            //tbVoiume.Value = wmpPlaySong.settings.volume;
            if (wmpPlaySong.settings.mute == false)
            {
                wmpPlaySong.settings.mute = true;
            }
            else
            {
                wmpPlaySong.settings.mute = false;
            }
        }
        #endregion
        #region 动态调整音量的数字大小
        private void tbVoiume_Scroll(object sender, EventArgs e)
        {
            lblVolume.Text = tbVoiume.Value.ToString();
            wmpPlaySong.settings.volume = tbVoiume.Value;
        }
        #endregion
        #region 单击任意地方时关闭音量调节框
        private void FrmMain_Click(object sender, EventArgs e)
        {
            pnlVolume.Visible = false;
        }
        #endregion
        #region 打开音量调节框
        public void tsmiVolume_Click(object sender, EventArgs e)
        {
            if (pnlVolume.Visible == false)
            {
                lblVolume.Text = wmpPlaySong.settings.volume.ToString();
                tbVoiume.Value = wmpPlaySong.settings.volume;
                pnlVolume.Visible = true;
            }
            else
            {
                pnlVolume.Visible = false;
              
            }
        }
        #endregion
        #region 重唱歌曲
        public  void tsmiRerun_Click(object sender, EventArgs e)
        {
            wmpPlaySong.Ctlcontrols.currentPosition = 0;
        }
        #endregion
        #region 排行点歌
        private void picClassify_Click(object sender, EventArgs e)
        {
            db.FillListView("select * from  song_info,singer_info where song_info.singer_id = singer_info.singer_id order by song_play_count desc", lvOrderBySongList);
            if (pnlOrderBySongList.Visible == false)
            {
                pnlOrderBySongList.Dock = DockStyle.Fill;
                pnlOrderBySongList.Visible = true;
            }                     
        }
        #endregion
        #region 排行榜点歌
        private void lvOrderBySongList_MouseClick(object sender, MouseEventArgs e)
        {
            db.OrderSong(lvOrderBySongList, this);
        }
        #endregion
        
    }
}
