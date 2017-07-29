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
    public partial class FrmSongList : Form
    {
        //默认查询全部歌曲信息
        public string sql= "select song_name,singer_name,song_play_count  from 	dbo.singer_info,dbo.song_info where song_info.singer_id = singer_info.singer_id";//查询歌曲的sql语句
        //实例化数据库辅助类
        DBHelper db = new DBHelper();
        public FrmSongList()
        {
            InitializeComponent();
        }
        #region 根据sql语句查询歌曲并添加到dgv中
        public void FillDataGridView()
        {
            //获得临时数据集
            DataSet ds = new DataSet();
            ds = db.GetDataSet(sql);
            //绑定数据源
            dgvSongList.DataSource = ds.Tables["temp"];
        }
        #endregion
        #region 窗体加载
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            //dgv不自动生成新的列
            this.dgvSongList.AutoGenerateColumns = false;
            //显示歌曲列表信息
            FillDataGridView();
        }
        #endregion

    }
}
