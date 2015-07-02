using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// Sys_Menu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_Menu
	{
		public Sys_Menu()
		{}
		#region Model
		private string _menuid;
		private string _menuname;
		private string _menuurl;
		private string _functionid;
		private string _isleaf;
		private string _menulevel;
		private string _rootid;
		private string _parentsid;
		private decimal? _displayorder;
		private string _icvalue;
		private string _ispop;
		private string _menuseq;
		/// <summary>
		/// 
		/// </summary>
		public string MenuID
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuName
		{
			set{ _menuname=value;}
			get{return _menuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuUrl
		{
			set{ _menuurl=value;}
			get{return _menuurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FunctionID
		{
			set{ _functionid=value;}
			get{return _functionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsLeaf
		{
			set{ _isleaf=value;}
			get{return _isleaf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuLevel
		{
			set{ _menulevel=value;}
			get{return _menulevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RootID
		{
			set{ _rootid=value;}
			get{return _rootid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ParentsID
		{
			set{ _parentsid=value;}
			get{return _parentsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IcValue
		{
			set{ _icvalue=value;}
			get{return _icvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsPop
		{
			set{ _ispop=value;}
			get{return _ispop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuSeq
		{
			set{ _menuseq=value;}
			get{return _menuseq;}
		}
		#endregion Model

	}
}

