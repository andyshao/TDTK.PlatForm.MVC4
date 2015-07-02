using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_TaxOutItemDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_TaxOutItemDetail
	{
		public TT_TaxOutItemDetail()
		{}
		#region Model
		private long _itemdetailid;
		private string _coalkindcode;
		private string _roomcode;
		private string _taxitemcode;
		private decimal? _amount;
		private DateTime? _effecttime;
		private string _operator;
		private DateTime? _operatetime;
		private decimal? _taxgroup;
		private string _isassigned;
		private string _isall;
		/// <summary>
		/// 
		/// </summary>
		public long ItemDetailId
		{
			set{ _itemdetailid=value;}
			get{return _itemdetailid;}
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
		public string RoomCode
		{
			set{ _roomcode=value;}
			get{return _roomcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaxItemCode
		{
			set{ _taxitemcode=value;}
			get{return _taxitemcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EffectTime
		{
			set{ _effecttime=value;}
			get{return _effecttime;}
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
		public DateTime? OperateTime
		{
			set{ _operatetime=value;}
			get{return _operatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TaxGroup
		{
			set{ _taxgroup=value;}
			get{return _taxgroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsAssigned
		{
			set{ _isassigned=value;}
			get{return _isassigned;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsAll
		{
			set{ _isall=value;}
			get{return _isall;}
		}
		#endregion Model

	}
}

