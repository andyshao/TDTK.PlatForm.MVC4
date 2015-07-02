using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_OperatorMonitorRoom:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_OperatorMonitorRoom
	{
		public TT_OperatorMonitorRoom()
		{}
		#region Model
		private string _usercode;
		private string _roomcode;
		/// <summary>
		/// 
		/// </summary>
		public string UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomCode
		{
			set{ _roomcode=value;}
			get{return _roomcode;}
		}
		#endregion Model

	}
}

