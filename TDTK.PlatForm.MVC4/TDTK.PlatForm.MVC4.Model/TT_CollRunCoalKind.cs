using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_CollRunCoalKind:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_CollRunCoalKind
	{
		public TT_CollRunCoalKind()
		{}
		#region Model
		private string _collcode;
		private string _coalkindcode;
		private string _isforbid="0";
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
		public string IsForbid
		{
			set{ _isforbid=value;}
			get{return _isforbid;}
		}
		#endregion Model

	}
}

