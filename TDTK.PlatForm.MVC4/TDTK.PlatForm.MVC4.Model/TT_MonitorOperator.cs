using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_MonitorOperator:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_MonitorOperator
	{
		public TT_MonitorOperator()
		{}
		#region Model
		private long _usercode;
		private long _monitorcode;
		/// <summary>
		/// 人员id
		/// </summary>
		public long UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		/// <summary>
		/// 定制id
		/// </summary>
		public long MonitorCode
		{
			set{ _monitorcode=value;}
			get{return _monitorcode;}
		}
		#endregion Model

	}
}

