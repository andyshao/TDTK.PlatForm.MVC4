using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_Navicert:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_Navicert
	{
		public TT_Navicert()
		{}
		#region Model
		private string _navicertcode;
		private string _roomcode;
		private string _carcode;
		private string _carno;
		private string _cartype;
		private string _carownername;
		private string _carownerphone;
		private string _carowneridcard;
		private decimal? _mostweight;
		private decimal? _emptyweight;
		private string _navicertstate;
		private string _cardtype;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private string _sendperson;
		private string _claimpersonname;
		private string _isforbid;
		private string _remark;
		private string _navicertno;
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
		public string CarCode
		{
			set{ _carcode=value;}
			get{return _carcode;}
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
		public string CarType
		{
			set{ _cartype=value;}
			get{return _cartype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarOwnerName
		{
			set{ _carownername=value;}
			get{return _carownername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarOwnerPhone
		{
			set{ _carownerphone=value;}
			get{return _carownerphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarOwnerIDCard
		{
			set{ _carowneridcard=value;}
			get{return _carowneridcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MostWeight
		{
			set{ _mostweight=value;}
			get{return _mostweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EmptyWeight
		{
			set{ _emptyweight=value;}
			get{return _emptyweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NavicertState
		{
			set{ _navicertstate=value;}
			get{return _navicertstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendPerson
		{
			set{ _sendperson=value;}
			get{return _sendperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClaimPersonName
		{
			set{ _claimpersonname=value;}
			get{return _claimpersonname;}
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
		/// <summary>
		/// 
		/// </summary>
		public string NavicertNo
		{
			set{ _navicertno=value;}
			get{return _navicertno;}
		}
		#endregion Model

	}
}

