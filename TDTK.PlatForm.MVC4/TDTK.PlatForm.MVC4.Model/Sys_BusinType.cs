using System;

namespace TDTK.PlatForm.MVC4.Model
{
    /// <summary>
    /// Sys_BusinType:实体类(属性说明自动提取数据库字段的描述信息)
    /// 
    /// </summary>
    [Serializable]
    public partial class Sys_BusinType
    {
        public Sys_BusinType()
        { }
        #region Model
        private string _busintypeid;
        private string _busintypename;
        private string _iscanedit;
        /// <summary>
        /// 
        /// </summary>
        public string BusinTypeID
        {
            set { _busintypeid = value; }
            get { return _busintypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinTypeName
        {
            set { _busintypename = value; }
            get { return _busintypename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IsCanEdit
        {
            set { _iscanedit = value; }
            get { return _iscanedit; }
        }
        #endregion Model

    }
}
