using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_WaterBook:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_WaterBook
	{
		public TT_WaterBook()
		{}
		#region Model
		private string _tradecode;
		private string _collcode;
		private int _journalcode;
		private decimal? _startmoney;
		private decimal? _trademoney;
		private decimal? _endmoney;
		private string _operator;
		private DateTime? _tradedate;
		private string _tradekind;
		private string _remark;
		private string _weightcode;
		private string _audituser;
		private DateTime? _auditdate;
		/// <summary>
		/// 
		/// </summary>
		public string TradeCode
		{
			set{ _tradecode=value;}
			get{return _tradecode;}
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
		public int JournalCode
		{
			set{ _journalcode=value;}
			get{return _journalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? StartMoney
		{
			set{ _startmoney=value;}
			get{return _startmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TradeMoney
		{
			set{ _trademoney=value;}
			get{return _trademoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EndMoney
		{
			set{ _endmoney=value;}
			get{return _endmoney;}
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
		public DateTime? TradeDate
		{
			set{ _tradedate=value;}
			get{return _tradedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TradeKind
		{
			set{ _tradekind=value;}
			get{return _tradekind;}
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
		public string WeightCode
		{
			set{ _weightcode=value;}
			get{return _weightcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AuditUser
		{
			set{ _audituser=value;}
			get{return _audituser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AuditDate
		{
			set{ _auditdate=value;}
			get{return _auditdate;}
		}
		#endregion Model

	}
}

