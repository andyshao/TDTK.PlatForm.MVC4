using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_MarkedCardSendRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_MarkedCardSendRecord
	{
		public TT_MarkedCardSendRecord()
		{}
		#region Model
		private long _recordid;
		private string _markedcardno;
		private string _markedcardcode;
		private string _collcode;
		private string _coalkindcode;
		private DateTime? _sendcarddate;
		private string _operator;
		private string _departname;
		private string _sendtype;
		/// <summary>
		/// 
		/// </summary>
		public long RecordID
		{
			set{ _recordid=value;}
			get{return _recordid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MarkedCardNo
		{
			set{ _markedcardno=value;}
			get{return _markedcardno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MarkedCardCode
		{
			set{ _markedcardcode=value;}
			get{return _markedcardcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CollCode
		{
			set{ _collcode=value;}
			get{return _collcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CoalKindCode
		{
			set{ _coalkindcode=value;}
			get{return _coalkindcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SendCardDate
		{
			set{ _sendcarddate=value;}
			get{return _sendcarddate;}
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
		public string DepartName
		{
			set{ _departname=value;}
			get{return _departname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendType
		{
			set{ _sendtype=value;}
			get{return _sendtype;}
		}
		#endregion Model

	}
}

