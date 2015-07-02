using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_RoomSupervise:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_RoomSupervise
	{
		public TT_RoomSupervise()
		{}
		#region Model
		private string _rscode;
		private string _roomcode;
		private string _mcode;
		private string _mpname;
		private string _phonenumber;
		private string _receivetypecode;
		private string _isforbid;
		/// <summary>
		/// 
		/// </summary>
		public string RSCode
		{
			set{ _rscode=value;}
			get{return _rscode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomCode
		{
			set{ _roomcode=value;}
			get{return _roomcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MCode
		{
			set{ _mcode=value;}
			get{return _mcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MPName
		{
			set{ _mpname=value;}
			get{return _mpname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PhoneNumber
		{
			set{ _phonenumber=value;}
			get{return _phonenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveTypeCode
		{
			set{ _receivetypecode=value;}
			get{return _receivetypecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsForBid
		{
			set{ _isforbid=value;}
			get{return _isforbid;}
		}
		#endregion Model

	}
}

