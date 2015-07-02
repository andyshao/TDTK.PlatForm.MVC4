using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_Room:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_Room
	{
		public TT_Room()
		{}
		#region Model
		private string _roomcode;
		private string _villagecode;
		private string _roomname;
		private string _principal;
		private string _telephone;
		private string _transportmodel;
		private string _roomtype;
		private string _roomip;
		private string _onoff= "1";
		private decimal? _offlinetime=0M;
		private DateTime? _offlinebegin;
		private string _collcode;
		private string _isforbid;
		private string _remark;
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
		public string VillageCode
		{
			set{ _villagecode=value;}
			get{return _villagecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomName
		{
			set{ _roomname=value;}
			get{return _roomname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Principal
		{
			set{ _principal=value;}
			get{return _principal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TransportModel
		{
			set{ _transportmodel=value;}
			get{return _transportmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomType
		{
			set{ _roomtype=value;}
			get{return _roomtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomIp
		{
			set{ _roomip=value;}
			get{return _roomip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OnOff
		{
			set{ _onoff=value;}
			get{return _onoff;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OffLineTime
		{
			set{ _offlinetime=value;}
			get{return _offlinetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OffLineBegin
		{
			set{ _offlinebegin=value;}
			get{return _offlinebegin;}
		}
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

