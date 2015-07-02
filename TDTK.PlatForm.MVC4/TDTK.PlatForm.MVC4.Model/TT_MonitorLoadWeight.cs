using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_MonitorLoadWeight:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_MonitorLoadWeight
	{
		public TT_MonitorLoadWeight()
		{}
		#region Model
		private long _monitorcode;
		private string _monitorname;
		private string _chinesename;
		private int _iscancel;
		/// <summary>
		/// 监控编号
		/// </summary>
		public long MonitorCode
		{
			set{ _monitorcode=value;}
			get{return _monitorcode;}
		}
		/// <summary>
		/// 监控列名称
		/// </summary>
		public string MonitorName
		{
			set{ _monitorname=value;}
			get{return _monitorname;}
		}
		/// <summary>
		/// 中文名称
		/// </summary>
		public string ChineseName
		{
			set{ _chinesename=value;}
			get{return _chinesename;}
		}
		/// <summary>
		/// 是否取消（1、取消 0、不取消）
		/// </summary>
		public int IsCancel
		{
			set{ _iscancel=value;}
			get{return _iscancel;}
		}
		#endregion Model

	}
}

