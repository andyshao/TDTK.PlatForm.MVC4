using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_BadHandle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_BadHandle
	{
		public TT_BadHandle()
		{}
		#region Model
		private string _handleid;
		private string _badrecordid;
		private string _operator;
		private DateTime? _operatedate;
		private string _result;
		private string _handleoperator;
		private DateTime? _handledate;
		/// <summary>
		/// 
		/// </summary>
		public string HandleID
		{
			set{ _handleid=value;}
			get{return _handleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BadRecordID
		{
			set{ _badrecordid=value;}
			get{return _badrecordid;}
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
		/// <summary>
		/// 
		/// </summary>
		public string Result
		{
			set{ _result=value;}
			get{return _result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HandleOperator
		{
			set{ _handleoperator=value;}
			get{return _handleoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? HandleDate
		{
			set{ _handledate=value;}
			get{return _handledate;}
		}
		#endregion Model

	}
}

