using System;

namespace TDTK.PlatForm.MVC4.Model
{
    /// <summary>
    /// CardLogin:实体类(属性说明自动提取数据库字段的描述信息)
    /// 登录卡
    /// </summary>
    [Serializable]
    public partial class CardLogin
    {
        public CardLogin()
        { }
        #region Model
        private int _id;
        private string _cardid;
        private string _username;
        private string _usercode;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CardID
        {
            set { _cardid = value; }
            get { return _cardid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserCode
        {
            set { _usercode = value; }
            get { return _usercode; }
        }
        #endregion Model

    }
}
