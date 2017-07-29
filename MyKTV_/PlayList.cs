using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV_
{
    /// <summary>
    /// 此类主要管理歌曲播放列表
    /// </summary>
    class PlayList
    {
        //歌曲播放列表数组
        private static Song[] songList = new Song[50];
        //当前播放的歌曲在数组中的索引
        private static int songIndex;
        //当前播放列表中歌曲的总数
        private static int num;     

        public static int Num { get => num; set => num = value; }
        public static Song[] SongList { get => songList; set => songList = value; }
        public static int SongIndex { get => songIndex; set => songIndex = value; }

        /// <summary>
        /// 当前播放的歌曲名称
        /// </summary>
        /// <returns>返回歌曲名称</returns>
        public static string PlayingSongName()
        {
            return SongList[SongIndex].SongName;
        }
        /// <summary>
        ///获取当前播放的歌曲
        /// </summary>
        /// <returns>返回歌曲对象</returns>
        public static Song GetPlaySong()
        {
            return SongList[SongIndex];
        }
        /// <summary>
        /// 获取下一首要播放的歌曲的名称
        /// </summary>
        /// <returns>返回下一首要播放的歌曲名称</returns>
        public static string NextSongName()
        {            
            return SongList[SongIndex+1].SongName;
        }
        /// <summary>
        /// 点播一首歌曲
        /// </summary>
        /// <param name="song">点播的歌曲对象</param>
        public static void AddSong(Song song)
        {
            SongList[Num++] = song;               
        }
        /// <summary>
        /// 切歌
        /// </summary>
        public static void CutSong()
        {
            if (Num!=1||Num!=0)
            {
                  //删除数组第一个元素，其他元素前移填补第一项
                SongList[0] = null;
                for (int i = 0,j=1; i < num -1; i++,j++)
                {
                    //元素前移
                    SongList[i] = SongList[j];
                }
                //置空最后一个元素后总数减一
                SongList[num-- - 1] = null;
            }
        }      
        /// <summary>
        /// 播放下一首歌曲
        /// </summary>
        public static void MoveOn()
        {
            SongIndex++;
        }
  
    }
}
