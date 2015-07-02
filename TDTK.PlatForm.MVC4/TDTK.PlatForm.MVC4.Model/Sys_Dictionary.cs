using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// Sys_Dictionary:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_Dictionary
	{
		public Sys_Dictionary()
		{}
		#region Model
		private string _businid;
		private string _businname;
		private string _busintypeid;
		private decimal? _displayorder;
		private string _isforbid="0";
		private string _otherinfo;
		/// <summary>
		/// 
		/// </summary>
		public string BusinID
		{
			set{ _businid=value;}
			get{return _businid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinName
		{
			set{ _businname=value;}
			get{return _businname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinTypeID
		{
			set{ _busintypeid=value;}
			get{return _busintypeid;}
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
		public string IsForbid
		{
			set{ _isforbid=value;}
			get{return _isforbid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherInfo
		{
			set{ _otherinfo=value;}
			get{return _otherinfo;}
		}
		#endregion Model

	}
}

