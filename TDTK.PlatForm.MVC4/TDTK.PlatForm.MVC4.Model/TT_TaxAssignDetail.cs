using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_TaxAssignDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_TaxAssignDetail
	{
		public TT_TaxAssignDetail()
		{}
		#region Model
		private long _assignid;
		private long? _itemdetailid;
		private string _unitcode;
		private decimal? _assignamount;
		private DateTime? _operatetime;
		private string _operator;
		/// <summary>
		/// 
		/// </summary>
		public long AssignID
		{
			set{ _assignid=value;}
			get{return _assignid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? ItemDetailID
		{
			set{ _itemdetailid=value;}
			get{return _itemdetailid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnitCode
		{
			set{ _unitcode=value;}
			get{return _unitcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AssignAmount
		{
			set{ _assignamount=value;}
			get{return _assignamount;}
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
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		#endregion Model

	}
}

