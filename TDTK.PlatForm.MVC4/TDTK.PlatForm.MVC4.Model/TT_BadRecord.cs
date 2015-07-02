using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_BadRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_BadRecord
	{
		public TT_BadRecord()
		{}
		#region Model
		private string _recordid;
		private string _navicertcode;
		private string _roomcode;
		private string _carno;
		private string _decript;
		private DateTime? _breakdate;
		private string _alarmtype;
		private string _alarmstatus="0";
		private string _collcode;
		private string _frontimage;
		private string _backimage;
		private string _upimage;
		private string _roomimage;
		/// <summary>
		/// 
		/// </summary>
		public string RecordID
		{
			set{ _recordid=value;}
			get{return _recordid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NavicertCode
		{
			set{ _navicertcode=value;}
			get{return _navicertcode;}
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
		public string CarNo
		{
			set{ _carno=value;}
			get{return _carno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Decript
		{
			set{ _decript=value;}
			get{return _decript;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BreakDate
		{
			set{ _breakdate=value;}
			get{return _breakdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AlarmType
		{
			set{ _alarmtype=value;}
			get{return _alarmtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AlarmStatus
		{
			set{ _alarmstatus=value;}
			get{return _alarmstatus;}
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
		public string FrontImage
		{
			set{ _frontimage=value;}
			get{return _frontimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BackImage
		{
			set{ _backimage=value;}
			get{return _backimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpImage
		{
			set{ _upimage=value;}
			get{return _upimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomImage
		{
			set{ _roomimage=value;}
			get{return _roomimage;}
		}
		#endregion Model

	}
}

