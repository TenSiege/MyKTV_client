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
    public partial class FrmOrderBySinger : Form
    {
        //用来保存上一级菜单
        public FrmMain frm = null;
        //数据库辅助类
        DBHelper db = new DBHelper();
        //用户选择的歌手性别
        string singer_sex;
        //用户选择的歌手编号
        int singer_id;
        public FrmOrderBySinger()
        {
            InitializeComponent();
        }
        #region 窗体加载
        private void FrmOrderBySinger_Load(object sender, EventArgs e)
        {
            //窗体刚打开时歌手信息列表不可见
            pnlSingerList.Visible = false;
            pnlSongList.Visible = false;
        }
        #endregion
        #region 按条件查询歌手信息
        private void picNvSinger_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic = (PictureBox)sender;
            //清空listview及imagelist中的所有项
            lvSingerLisrt.Items.Clear();
            ilSingerPhoto.Images.Clear();
            singer_sex = pic.Tag.ToString();
            //设立条件查询歌手信息
            string sql = string.Format("select singer_id,singer_name,singer_photo_url from dbo.singer_info where singer_sex = '{0}'", singer_sex);
            System.Data.SqlClient.SqlDataReader dr = null;
            //查询数据库          

            dr = db.ExecuteReader(sql.ToString());
            //图片索引步进值
            int i = 0;
            while (dr.Read())
            {
                //将图片添加到ImageList中
                Image im = Image.FromFile(dr["singer_photo_url"].ToString());
                ilSingerPhoto.Images.Add(im);
                //创建ListView项
                ListViewItem item = new ListViewItem();
                //添加图片到新建的项中
                item.ImageIndex = i++;
                //设置文字的颜色
                // item.ForeColor = Color.Wheat;
                //设置项的图片
                item.Text = dr["singer_name"].ToString();
                //设置项的歌手编号
                item.Tag = dr["singer_id"].ToString();
                lvSingerLisrt.Items.Add(item);
            }
            //关闭Dr对象
            dr.Close();
            db.CloseConnection();//关闭数据库连接
            //让返回图标显示
            picReturn.BringToFront();
            //显示查询完成的歌手信息
            pnlSingerList.Dock = DockStyle.Fill;//填充父容器
            pnlSingerList.Visible = true;

        }
        #endregion
        #region 返回pic
        private void picReturn_Click(object sender, EventArgs e)
        {
            //if(pnlSingerList.Visible ==true) //如果歌手信息列表处于打开状态
            //{
            //    //隐藏歌手信息界面
            //    pnlSingerList.Visible = false;
            //    return;
            //}
            //if (pnlSongList.Visible == true)//如果歌曲信息列表处于打开状态
            //{
            //    //隐藏歌曲信息界面
            //    pnlSongList.Dock = DockStyle.None;
            //    pnlSongList.Visible = false;
            //    pnlSingerList.Visible = true;
            //    return;
            //}
            ////上面条件都不成立时
            //this.Close();//关闭当前窗体
            ////打开上一级窗体
            //frm.Show();
            //返回主菜单
            if (pnlSingerList.Visible == false && pnlSongList.Visible == false)
            {
                this.Close();
                frm.Show();
            }
            //返回选择歌手类型菜单
            else if (pnlSingerList.Visible == true && pnlSongList.Visible == false)
            {
                pnlSingerList.Visible = false;
            }
            //返回选择歌手菜单
            else if (pnlSingerList.Visible == true && pnlSingerList.Visible == true)
            {
                pnlSongList.Visible = false;
                //移除歌曲列表第一行以外的所有项
                lvSongList.Items.Clear();
            }
        }
        #endregion
        #region 根据用户选择的歌手查询歌曲
        private void lvSingerLisrt_Click(object sender, EventArgs e)
        {
            if (lvSingerLisrt.SelectedItems.Count == 0)//如果未选中数据
            {
                return;
            }
            //获取当前选中的索引
            int index = Convert.ToInt32(lvSingerLisrt.FocusedItem.Index);
            //获取用户选择的项,并创建sql语句查询数据库
            singer_id = Convert.ToInt32(lvSingerLisrt.Items[index].Tag);
            string sql = string.Format("select song_id,song_url,song_name,song_play_count,singer_name from singer_info,song_info where song_info.singer_id = singer_info.singer_id and singer_info.singer_id = '{0}'", singer_id);
            db.FillListView(sql, lvSongList);//填充listView
            //歌手写真路径、歌手简介
            string sql_ = string.Format("select singer_photo_url,singer_Describe from singer_info where singer_id = '{0}'",singer_id);
            DataSet ds = new DataSet();
            ds = db.GetDataSet(sql_);
            #region 设置歌手写真及歌手简介
           picSingerPhoto.Image = Image.FromFile(ds.Tables["temp"].Rows[0][0].ToString());
            StringBuilder singerIntro = new StringBuilder(null);
            //歌手简介字符串每行只能有12个字,消除空格
            string intro = System.Text.RegularExpressions.Regex.Replace(ds.Tables["temp"].Rows[0][1].ToString(), @"\s", "");
            int i = 0;
            foreach (char Item in intro)
            {
                singerIntro.Append(Item);//添加每个字
                i++;
                if (i % 18 == 0)
                {
                    //每12个字换一行
                    singerIntro.Append("\n");
                }
            }
            //并赋给标签控件
            lblSingerIntro.Text = "\t" + singerIntro.ToString();
            #endregion
            //显示歌曲列表              
            pnlSongList.Dock = DockStyle.Fill;
            pnlSongList.Visible = true;
        }
        #endregion
        #region 点播歌曲
        private void lvSongList_Click(object sender, EventArgs e)
        {
            //int index = Convert.ToInt32(lvSongList.FocusedItem.Index);
            //if (lvSongList.Items.Count == 0 || index == 0)
            //{
            //    return;
            //}
            ////将点播的歌曲信息添加到播放列表中
            //Song song = new Song();
            //song.PlayState = Song.SongPlayState.unplayed;
            //song.SongName = lvSongList.Items[index].Text;
            //song.SongURL = lvSongList.Items[index].Tag.ToString();
            //PlayList.AddSong(song);
            //MessageBox.Show("点播" + lvSongList.Items[index].Text + "成功!");
            ////歌曲的点播次数加一
            //int song_id = Convert.ToInt32(lvSongList.Items[index].SubItems[0].Tag);
            //MessageBox.Show(song_id+"");
            //db.ExecuteNonQuery(string.Format("update song_info set song_play_count = song_play_count + 1 where song_id = '{0}'",song_id));            
            ////刷新播放列表
            //frm.AddSong();
            //if (PlayList.Num == 1)
            //{
            //    frm.PlaySong();//如果播放列表无歌曲，则播放刚点歌曲
            //}
            db.OrderSong(lvSongList,frm);
            db.FillListView(string.Format("select song_id,song_url,song_name,song_play_count,singer_name from singer_info,song_info where song_info.singer_id = singer_info.singer_id and singer_info.singer_id = '{0}'", singer_id), lvSongList);            
        }
        #endregion
    }
}
