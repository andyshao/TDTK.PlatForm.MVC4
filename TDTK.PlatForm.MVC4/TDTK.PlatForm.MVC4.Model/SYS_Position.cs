using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// SYS_Position:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_Position
	{
		public SYS_Position()
		{}
		#region Model
		private string _positioncode;
		private string _positionname;
		private string _remark;
		private string _isforbid;
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
		public string PositionName
		{
			set{ _positionname=value;}
			get{return _positionname;}
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

