using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_TwoPrintLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_TwoPrintLog
	{
		public TT_TwoPrintLog()
		{}
		#region Model
		private string _logid;
		private string _logtype;
		private string _operator;
		private DateTime? _printdate;
		private string _printtable;
		private string _printweightcode;
		/// <summary>
		/// 
		/// </summary>
		public string LogID
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
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PrintDate
		{
			set{ _printdate=value;}
			get{return _printdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PrintTable
		{
			set{ _printtable=value;}
			get{return _printtable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PrintWeightCode
		{
			set{ _printweightcode=value;}
			get{return _printweightcode;}
		}
		#endregion Model

	}
}

