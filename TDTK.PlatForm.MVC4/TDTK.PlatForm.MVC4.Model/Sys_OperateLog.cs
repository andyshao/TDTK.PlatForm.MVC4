using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// Sys_OperateLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_OperateLog
	{
		public Sys_OperateLog()
		{}
		#region Model
		private long _logid;
		private string _logtype;
		private string _relationid;
		private string _operateip;
		private DateTime? _operatedate;
		private string _operator;
		private string _operatetable;
		private string _remark;
		private string _syscode;
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
		public string LogType
		{
			set{ _logtype=value;}
			get{return _logtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RelationID
		{
			set{ _relationid=value;}
			get{return _relationid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperateIP
		{
			set{ _operateip=value;}
			get{return _operateip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperateDate
		{
			set{ _operatedate=value;}
			get{return _operatedate;}
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
		public string OperateTable
		{
			set{ _operatetable=value;}
			get{return _operatetable;}
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
		public string SysCode
		{
			set{ _syscode=value;}
			get{return _syscode;}
		}
		#endregion Model

	}
}

