using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// Sys_OperatorPosition:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_OperatorPosition
	{
		public Sys_OperatorPosition()
		{}
		#region Model
		private string _positoncode;
		private string _usercode;
		/// <summary>
		/// 
		/// </summary>
		public string PositonCode
		{
			set{ _positoncode=value;}
			get{return _positoncode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		#endregion Model

	}
}

