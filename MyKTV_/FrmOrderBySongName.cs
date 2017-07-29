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
    public partial class FrmOrderBySongName : Form
    {
        //数据库辅助类
        DBHelper db = new DBHelper();
        public FrmMain frm = null;
        public FrmOrderBySongName()
        {
            InitializeComponent();
        }
        #region 字母键盘
        private void picA_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic = (PictureBox)sender;
            //获取点击的字母
            lblABC.Text += pic.Name.Substring(3);
        }
        #endregion
        #region 从右至左删除字母
        private void picDelete_Click(object sender, EventArgs e)
        {
            if (lblABC.Text.Length > 0)
            {
                lblABC.Text = lblABC.Text.Substring(0, lblABC.Text.Length - 1);
            }
        }
        #endregion
        #region 根据用户输入的拼音动态查询数据库
        private void lblABC_TextChanged(object sender, EventArgs e)
        {
            db.FillListView("select * from  song_info,singer_info where song_info.singer_id = singer_info.singer_id and song_ab = '" + lblABC.Text + "'", lvSongList);
        }
        #endregion
        #region 菜单功能项
        private void lvSongList_MouseClick(object sender, MouseEventArgs e)
        {
            db.OrderSong(lvSongList, frm);
        }

        private void tsmiMain_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }

        private void tsmiPlay_Click(object sender, EventArgs e)
        {
            frm.tsmiMute_Click(sender, e);
        }

        private void tsmiStop_Click(object sender, EventArgs e)
        {
            frm.tsmiStop_Click(sender, e);
        }

        private void tsmiRerun_Click(object sender, EventArgs e)
        {
            frm.tsmiRerun_Click(sender, e);
        }

        private void tsmiCutSong_Click(object sender, EventArgs e)
        {
            frm.tsmiCut_Click(sender, e);
        }

        private void tsmiVolume_Click(object sender, EventArgs e)
        {
            if (pnlVolume.Visible == false)
            {
                lblVolume.Text = frm.wmpPlaySong.settings.volume.ToString();
                tbVoiume.Value = frm.wmpPlaySong.settings.volume;
                pnlVolume.Visible = true;
            }
            else
            {
                pnlVolume.Visible = false;

            }
        }

        private void tsmiMute_Click(object sender, EventArgs e)
        {
            frm.tsmiMute_Click(sender, e);
        }
   
        private void toolStripButton8_Click(object sender, EventArgs e)
        {

            frm.tsmiSongList_Click(sender, e);
            this.Close();

        }
        #endregion
        #region 动态调整音量的数字大小
        private void tbVoiume_Scroll(object sender, EventArgs e)
        {
            lblVolume.Text = tbVoiume.Value.ToString();
            frm.wmpPlaySong.settings.volume = tbVoiume.Value;
        }
        #endregion
        private void FrmOrderBySongName_Load(object sender, EventArgs e)
        {
            db.FillListView("select * from  song_info,singer_info where song_info.singer_id = singer_info.singer_id and song_ab = '" + lblABC.Text + "'", lvSongList);
        }
    }
}
