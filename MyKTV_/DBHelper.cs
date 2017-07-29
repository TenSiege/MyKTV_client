using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MyKTV_
{
    /// <summary>
    /// 数据库辅助类，主要用来打开和关闭数据库的连接
    /// </summary>
   public class DBHelper
    {
        private SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=MyKTV;User ID=sa;Password=accp");//数据库连接对象
        public SqlConnection Connection//数据库连接对象属性
        {
            get { return connection; }
            set 
            {
                if (value!=null)
                {
                    connection = value; 
                }            
            }
        }
        #region 打开数据库连接和关闭数据库连接
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open || connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
            }
        }
        #endregion
        #region 数据库操作(单值查询，多值查询，非查询方法)
        /// <summary>
        /// 单值查询
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>查询结果</returns>
        public object ExecuteScalar(string sql)
        {
            object result = null;//查询数据库的结果
            try
            {
                //打开数据库连接
                this.OpenConnection();
                //创建Command命令对象
                SqlCommand comm = new SqlCommand(sql, connection);
                result = comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//输出异常信息
            }
            finally
            {
                this.CloseConnection();//关闭数据库连接
            }
            return result;//返回查询到的结果
        }
        /// <summary>
        /// 多值查询
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>查询结果</returns>
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader dr = null;
            try
            {
                this.OpenConnection();//打开连接
                SqlCommand comm = new SqlCommand(sql, connection);
                dr = comm.ExecuteReader();//获得Reader对象
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    this.CloseConnection();//关闭连接
            //}
            return dr;
        }
        /// <summary>
        /// 非查询方法
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>受影响的行数</returns>
        public int ExecuteNonQuery(string sql)
        {
            int result = 0;
            try
            {
                this.OpenConnection();
                SqlCommand comm = new SqlCommand(sql, connection);
                result = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }
            return result;
        }
        #endregion
        #region 根据sql语句返回DataSet对象
        public DataSet GetDataSet(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                //数据适配器
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                //填充数据集
                da.Fill(ds, "temp");
                //返回DataSet对象
            }
            catch (Exception ex)
            {
                //如出现异常则输出异常信息
                System.Windows.Forms.MessageBox.Show(ex.Message,"异常提示",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
            return ds;
        }
        #endregion
        #region 绑定组合框
        /// <summary>
        /// 绑定组合框的方法
        /// </summary>
        /// <param name="cmb">需要绑定的组合框对象</param>
        /// <param name="sql">查询的SQL语句</param>
        /// <param name="DisplayMember">需要绑定的显示字段</param>
        /// <param name="VauleMember">需要绑定的隐藏字段</param>
        public void BindComboBox(ComboBox cmb,string sql,string DisplayMember,string ValueMember)
        {
            DataSet ds = this.GetDataSet(sql);
            //新增一行
            DataRow row = ds.Tables["temp"].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables["temp"].Rows.InsertAt(row, 0);//插入到temp表的第一行
            cmb.DataSource = ds.Tables["temp"];//绑定数据源
            cmb.DisplayMember = DisplayMember;//绑定显示的值
            cmb.ValueMember = ValueMember;//绑定隐藏的值
            return;
        }
        #endregion
        #region 生成DataView视图
        /// <summary>
        /// 使用sql语句生成DataView视图
        /// </summary>
        /// <param name="sql">需要执行的sql语句</param>
        /// <returns>已生成好的DataView对象</returns>
        public DataView GetDataView(string sql)
        {
            DataView dv = new DataView();
            DataSet ds = GetDataSet(sql);
            //使用DataTable对象生成DataView视图对象
            dv = ds.Tables["temp"].DefaultView;
            return dv;
        }
        #endregion
        #region 填充ListView
        public void FillListView(string sql, ListView lv)
        {
            //添加前先清空所有项
            lv.Items.Clear();            
            //查询数据库
            SqlDataReader dr = ExecuteReader(sql);           
            //先插入一行标识数据
            ListViewItem item_ = new ListViewItem();
            item_.Text = "歌曲名称";
            item_.ImageIndex = 0;
            item_.SubItems.Add("艺术家");
            item_.SubItems.Add("点播次数");
            lv.Items.Add(item_);
            try
            {
                //填充ListView
                while (dr.Read())
                {
                    //创建ListView项
                    ListViewItem item = new ListViewItem();
                    item.Text = dr["song_name"].ToString();//歌曲名称
                    item.SubItems.Add(dr["singer_name"].ToString());//歌手名称
                    item.SubItems.Add(dr["song_play_count"].ToString());//点播次数
                    item.SubItems[0].Tag = dr["song_id"];//歌曲编号
                    item.Tag = dr["song_url"];//MV路径                
                    lv.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();//关闭dr对象
                OpenConnection();//关闭数据库连接
            }
        }
        #endregion
        #region 跟据ListView对象点播歌曲
        public void OrderSong(ListView lv,FrmMain frm)
        {
            int index = Convert.ToInt32(lv.FocusedItem.Index);
            if (lv.Items.Count == 0 || index == 0)
            {
                return;
            }
            //将点播的歌曲信息添加到播放列表中
            Song song = new Song();
            song.PlayState = Song.SongPlayState.unplayed;
            song.SongName = lv.Items[index].Text;
            song.SongURL = lv.Items[index].Tag.ToString();
            PlayList.AddSong(song);
            MessageBox.Show("点播" + lv.Items[index].Text + "成功!");
            //歌曲的点播次数加一
            int song_id = Convert.ToInt32(lv.Items[index].SubItems[0].Tag);
            ExecuteNonQuery(string.Format("update song_info set song_play_count = song_play_count + 1 where song_id = '{0}'", song_id));
           // FillListView(string.Format("select song_id,song_url,song_name,song_play_count,singer_name from singer_info,song_info where song_info.singer_id = singer_info.singer_id and singer_info.singer_id = '{0}'", singer_id), lv);
            //刷新播放列表
            frm.AddSong();
            if (PlayList.Num == 1)
            {
                frm.PlaySong();//如果播放列表无歌曲，则播放刚点歌曲
            }

        }
        #endregion
    }
}
