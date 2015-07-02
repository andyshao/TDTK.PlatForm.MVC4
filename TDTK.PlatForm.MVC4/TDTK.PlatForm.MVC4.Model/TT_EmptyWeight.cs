using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_EmptyWeight:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_EmptyWeight
	{
		public TT_EmptyWeight()
		{}
		#region Model
		private string _emptycode;
		private string _carcode;
		private string _remotecardcode;
		private string _navicertcode;
		private decimal? _emptyweight;
		private string _bangtype;
		private string _roomcode;
		private string _frontimage;
		private string _operator;
		private DateTime? _bangtime;
		private string _isloadweight= "0";
		private string _carno;
		private string _carownername;
		private string _carowneridcard;
		private string _carownerphone;
		private string _randomcode;
		/// <summary>
		/// 
		/// </summary>
		public string EmptyCode
		{
			set{ _emptycode=value;}
			get{return _emptycode;}
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
		public string RemoteCardCode
		{
			set{ _remotecardcode=value;}
			get{return _remotecardcode;}
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
		public decimal? EmptyWeight
		{
			set{ _emptyweight=value;}
			get{return _emptyweight;}
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
		public string RoomCode
		{
			set{ _roomcode=value;}
			get{return _roomcode;}
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
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BangTime
		{
			set{ _bangtime=value;}
			get{return _bangtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsLoadWeight
		{
			set{ _isloadweight=value;}
			get{return _isloadweight;}
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
		public string RandomCode
		{
			set{ _randomcode=value;}
			get{return _randomcode;}
		}
		#endregion Model

	}
}

