using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_CoalKind:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_CoalKind
	{
		public TT_CoalKind()
		{}
		#region Model
		private string _coalkindcode;
		private string _coalkindname;
		private decimal? _proportion;
		private string _remark;
		private string _isforbid;
		private string _typecode;
		private decimal? _taxpercent;
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
		public string CoalKindName
		{
			set{ _coalkindname=value;}
			get{return _coalkindname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Proportion
		{
			set{ _proportion=value;}
			get{return _proportion;}
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
		public string IsForbid
		{
			set{ _isforbid=value;}
			get{return _isforbid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeCode
		{
			set{ _typecode=value;}
			get{return _typecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TaxPercent
		{
			set{ _taxpercent=value;}
			get{return _taxpercent;}
		}
		#endregion Model

	}
}

