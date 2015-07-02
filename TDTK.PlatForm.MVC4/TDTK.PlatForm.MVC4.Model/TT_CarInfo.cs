using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_CarInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_CarInfo
	{
		public TT_CarInfo()
		{}
		#region Model
		private string _carcode;
		private string _remotecardcode;
		private string _roomcode;
		private string _carno;
		private string _cartype;
		private decimal? _emptyweight;
		private decimal? _mostweight;
		private string _operator;
		private string _bangtype;
		private string _randomcode;
		private DateTime? _emptybangtime;
		private string _carownername;
		private string _carowneridcard;
		private string _carownerphone;
		private string _drivelicense;
		private decimal? _carwidth;
		private decimal? _carlength;
		private decimal? _carhight;
		private string _firstimage;
		private string _isauditing;
		private string _audituser;
		private DateTime? _audittime;
		private string _remark="空车过磅";
		private string _drivername;
		private string _driveridcard;
		private string _driverphone;
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
		public string RemoteCardCode
		{
			set{ _remotecardcode=value;}
			get{return _remotecardcode;}
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
		public string CarType
		{
			set{ _cartype=value;}
			get{return _cartype;}
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
		public decimal? MostWeight
		{
			set{ _mostweight=value;}
			get{return _mostweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BangType
		{
			set{ _bangtype=value;}
			get{return _bangtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RandomCode
		{
			set{ _randomcode=value;}
			get{return _randomcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EmptyBangTime
		{
			set{ _emptybangtime=value;}
			get{return _emptybangtime;}
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
		public string CarOwnerIDCard
		{
			set{ _carowneridcard=value;}
			get{return _carowneridcard;}
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
		public string DriveLicense
		{
			set{ _drivelicense=value;}
			get{return _drivelicense;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CarWidth
		{
			set{ _carwidth=value;}
			get{return _carwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CarLength
		{
			set{ _carlength=value;}
			get{return _carlength;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CarHight
		{
			set{ _carhight=value;}
			get{return _carhight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FirstImage
		{
			set{ _firstimage=value;}
			get{return _firstimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsAuditing
		{
			set{ _isauditing=value;}
			get{return _isauditing;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AuditUser
		{
			set{ _audituser=value;}
			get{return _audituser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AuditTime
		{
			set{ _audittime=value;}
			get{return _audittime;}
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
		public string DriverName
		{
			set{ _drivername=value;}
			get{return _drivername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverIDCard
		{
			set{ _driveridcard=value;}
			get{return _driveridcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DriverPhone
		{
			set{ _driverphone=value;}
			get{return _driverphone;}
		}
		#endregion Model

	}
}

