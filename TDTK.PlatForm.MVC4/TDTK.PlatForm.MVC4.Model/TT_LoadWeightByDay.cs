using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_LoadWeightByDay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_LoadWeightByDay
	{
		public TT_LoadWeightByDay()
		{}
		#region Model
		private string _roomcode;
		private string _collcode;
		private string _coalkindcode;
		private decimal _taxgroup;
		private DateTime _weighttime;
		private decimal? _netweight;
		private decimal? _taxamount;
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
		public decimal TaxGroup
		{
			set{ _taxgroup=value;}
			get{return _taxgroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime WeightTime
		{
			set{ _weighttime=value;}
			get{return _weighttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NetWeight
		{
			set{ _netweight=value;}
			get{return _netweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TaxAmount
		{
			set{ _taxamount=value;}
			get{return _taxamount;}
		}
		#endregion Model

	}
}

