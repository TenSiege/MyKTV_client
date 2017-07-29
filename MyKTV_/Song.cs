using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV_
{
    /// <summary>
    /// 提供歌曲名称、存放路径、播放状态的信息
    /// </summary>
    class Song
    {
        #region 成员变量
        /// <summary>
        /// 播放状态枚举
        /// again 重唱
        /// unplayed 未播放
        /// palayed 已播放
        /// cut 切歌
        /// </summary>
        public enum SongPlayState
        {
            unplayed, played, again, cut
        }
        private string songName;//歌曲名称字段

        public string SongName
        {
            get { return songName; }
            set { songName = value; }
        }
        private string songURL;//歌曲存放路径字段

        public string SongURL
        {
            get { return songURL; }
            set { songURL = value; }
        }

        private SongPlayState playState = SongPlayState.unplayed;//歌曲播放状态字段
        public SongPlayState PlayState
        {
            get
            {
                return playState;
            }

            set
            {
                playState = value;
            }
        }
        #endregion
        #region 成员方法
        /// <summary>
        /// 改变歌曲状态为已播放
        /// </summary>
        public void ChangePlayed()
        {
            playState = SongPlayState.played;
        }
        /// <summary>
        /// 改变播放状态为重唱
        /// </summary>
        public void ChangeAgain()
        {
            playState = SongPlayState.again;
        }
        /// <summary>
        /// 改变播放状态为切歌
        /// </summary>
        public void ChangeCut()
        {
            playState = SongPlayState.cut;
        }
        #endregion
    }
}
