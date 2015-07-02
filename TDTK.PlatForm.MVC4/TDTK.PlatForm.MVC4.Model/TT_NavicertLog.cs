using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_NavicertLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_NavicertLog
	{
		public TT_NavicertLog()
		{}
		#region Model
		private long _logid;
		private string _navicertcode;
		private string _beforestate;
		private string _afterstate;
		private string _event;
		private string _remark;
		private string _operator;
		private DateTime? _operatedate;
		/// <summary>
		/// 
		/// </summary>
		public long LogID
		{
			set{ _logid=value;}
			get{return _logid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NavicertCode
		{
			set{ _navicertcode=value;}
			get{return _navicertcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BeforeState
		{
			set{ _beforestate=value;}
			get{return _beforestate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AfterState
		{
			set{ _afterstate=value;}
			get{return _afterstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Event
		{
			set{ _event=value;}
			get{return _event;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperateDate
		{
			set{ _operatedate=value;}
			get{return _operatedate;}
		}
		#endregion Model

	}
}

