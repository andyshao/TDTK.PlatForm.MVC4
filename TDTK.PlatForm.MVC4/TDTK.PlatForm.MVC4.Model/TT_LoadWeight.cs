using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_LoadWeight:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_LoadWeight
	{
		public TT_LoadWeight()
		{}
		#region Model
		private string _weightcode;
		private string _trafficcode;
		private string _navicertcode;
		private string _markedcardcode;
		private string _remotecardcode;
		private string _emptycode;
		private string _collcode;
		private string _collname;
		private string _coalkindcode;
		private string _coalkindname;
		private string _carownername;
		private string _carno;
		private string _cartype;
		private decimal? _loadweight;
		private decimal? _emptyweight;
		private decimal? _netweight;
		private decimal? _overweight;
		private decimal? _taxamount=0.0000M;
		private decimal? _fundamount=0.0000M;
		private string _roomcode;
		private string _roomname;
		private string _bangtype;
		private string _operator;
		private DateTime? _weighttime;
		private string _randomcode;
		private string _customername;
		private string _taxtype;
		private string _isfirstsite;
		private string _frontimage;
		private string _backimage;
		private string _upimage;
		private string _roomimage;
		private decimal? _taxgroup;
		private string _issealed="0";
		/// <summary>
		/// 
		/// </summary>
		public string WeightCode
		{
			set{ _weightcode=value;}
			get{return _weightcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TrafficCode
		{
			set{ _trafficcode=value;}
			get{return _trafficcode;}
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
		public string MarkedCardCode
		{
			set{ _markedcardcode=value;}
			get{return _markedcardcode;}
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
		public string EmptyCode
		{
			set{ _emptycode=value;}
			get{return _emptycode;}
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
		public string CollName
		{
			set{ _collname=value;}
			get{return _collname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CoalKindCode
		{
			set{ _coalkindcode=value;}
			get{return _coalkindcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CoalKindName
		{
			set{ _coalkindname=value;}
			get{return _coalkindname;}
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
		public decimal? LoadWeight
		{
			set{ _loadweight=value;}
			get{return _loadweight;}
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
		public decimal? NetWeight
		{
			set{ _netweight=value;}
			get{return _netweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OverWeight
		{
			set{ _overweight=value;}
			get{return _overweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TaxAmount
		{
			set{ _taxamount=value;}
			get{return _taxamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FundAmount
		{
			set{ _fundamount=value;}
			get{return _fundamount;}
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
		public string RoomName
		{
			set{ _roomname=value;}
			get{return _roomname;}
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
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? WeightTime
		{
			set{ _weighttime=value;}
			get{return _weighttime;}
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
		public string CustomerName
		{
			set{ _customername=value;}
			get{return _customername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaxType
		{
			set{ _taxtype=value;}
			get{return _taxtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsFirstSite
		{
			set{ _isfirstsite=value;}
			get{return _isfirstsite;}
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? TaxGroup
		{
			set{ _taxgroup=value;}
			get{return _taxgroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsSealed
		{
			set{ _issealed=value;}
			get{return _issealed;}
		}
		#endregion Model

	}
}

