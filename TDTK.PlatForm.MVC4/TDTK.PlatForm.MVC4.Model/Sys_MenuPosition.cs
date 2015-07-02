using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// Sys_MenuPosition:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_MenuPosition
	{
		public Sys_MenuPosition()
		{}
		#region Model
		private string _positioncode;
		private string _menuid;
		/// <summary>
		/// 
		/// </summary>
		public string PositionCode
		{
			set{ _positioncode=value;}
			get{return _positioncode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuID
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		#endregion Model

	}
}

