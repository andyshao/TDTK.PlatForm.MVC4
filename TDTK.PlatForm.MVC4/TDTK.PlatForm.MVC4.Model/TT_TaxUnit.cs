using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_TaxUnit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_TaxUnit
	{
		public TT_TaxUnit()
		{}
		#region Model
		private string _unitcode;
		private string _unitname;
		private string _remark;
		private string _isforbid;
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
		public string UnitName
		{
			set{ _unitname=value;}
			get{return _unitname;}
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
		#endregion Model

	}
}

