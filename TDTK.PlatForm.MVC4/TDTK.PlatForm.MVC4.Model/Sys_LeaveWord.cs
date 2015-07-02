using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// Sys_LeaveWord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_LeaveWord
	{
		public Sys_LeaveWord()
		{}
		#region Model
		private string _leaveid;
		private string _leavetitle;
		private DateTime? _leavedate;
		private string _leavecontent;
		private string _operator;
		private string _receiveid;
		private string _isread;
		/// <summary>
		/// 
		/// </summary>
		public string LeaveID
		{
			set{ _leaveid=value;}
			get{return _leaveid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LeaveTitle
		{
			set{ _leavetitle=value;}
			get{return _leavetitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LeaveDate
		{
			set{ _leavedate=value;}
			get{return _leavedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LeaveContent
		{
			set{ _leavecontent=value;}
			get{return _leavecontent;}
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
		public string ReceiveID
		{
			set{ _receiveid=value;}
			get{return _receiveid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsRead
		{
			set{ _isread=value;}
			get{return _isread;}
		}
		#endregion Model

	}
}

