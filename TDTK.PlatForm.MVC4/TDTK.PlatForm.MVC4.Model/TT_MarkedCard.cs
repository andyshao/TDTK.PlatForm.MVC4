using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_MarkedCard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_MarkedCard
	{
		public TT_MarkedCard()
		{}
		#region Model
		private string _markedcardno;
		private string _markedcardcode;
		private string _collcode;
		private string _coalkindcode;
		private string _markedcardstate;
		private DateTime? _sendcarddate;
		private string _operator;
		private string _departname;
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
		public string MarkedCardState
		{
			set{ _markedcardstate=value;}
			get{return _markedcardstate;}
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
		#endregion Model

	}
}

