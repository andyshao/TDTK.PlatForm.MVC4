using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_TaxItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_TaxItem
	{
		public TT_TaxItem()
		{}
		#region Model
		private string _taxitemcode;
		private string _itemname;
		private string _itemtype;
		private string _iscount;
		private string _isforbid;
		private string _remark;
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
		public string ItemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ItemType
		{
			set{ _itemtype=value;}
			get{return _itemtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsCount
		{
			set{ _iscount=value;}
			get{return _iscount;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

