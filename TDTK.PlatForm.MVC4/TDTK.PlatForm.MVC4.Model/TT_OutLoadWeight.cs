using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_OutLoadWeight:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_OutLoadWeight
	{
		public TT_OutLoadWeight()
		{}
		#region Model
		private string _outweightcode;
		private string _otrafficcode;
		private string _navicertcode;
		private string _coalkindcode;
		private string _coalkindname;
		private string _carno;
		private decimal? _currentweight;
		private decimal? _onetweight=0.00M;
		private decimal? _overweight=0.00M;
		private decimal? _taxamount=0.00M;
		private decimal? _fundamount=0.00M;
		private string _taxtype;
		private string _randomcode;
		private string _frontimage;
		private string _backimage;
		private string _upimage;
		private string _roomimage;
		private string _roomcode;
		private string _roomname;
		private string _operator;
		private DateTime _weighttime;
		private string _outtype;
		private string _bangtype;
		private string _divelicense;
		private string _cardriverphone;
		private decimal? _emptyweight;
		private string _carowneridcard;
		private string _collname;
		private string _isnormal;
		private string _sendunits;
		private string _tounits;
		private decimal? _billweight;
		private string _carnoimage;
		private string _outweightimage;
		private string _customers;
		private string _carownername;
		private DateTime? _exceptleft;
		private string _cartype;
		/// <summary>
		/// 
		/// </summary>
		public string OutWeightCode
		{
			set{ _outweightcode=value;}
			get{return _outweightcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OTrafficCode
		{
			set{ _otrafficcode=value;}
			get{return _otrafficcode;}
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
		public string CarNo
		{
			set{ _carno=value;}
			get{return _carno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CurrentWeight
		{
			set{ _currentweight=value;}
			get{return _currentweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ONetWeight
		{
			set{ _onetweight=value;}
			get{return _onetweight;}
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
		public string TaxType
		{
			set{ _taxtype=value;}
			get{return _taxtype;}
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
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime WeightTime
		{
			set{ _weighttime=value;}
			get{return _weighttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutType
		{
			set{ _outtype=value;}
			get{return _outtype;}
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
		public string DiveLicense
		{
			set{ _divelicense=value;}
			get{return _divelicense;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarDriverPhone
		{
			set{ _cardriverphone=value;}
			get{return _cardriverphone;}
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
		public string CarownerIDCard
		{
			set{ _carowneridcard=value;}
			get{return _carowneridcard;}
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
		public string IsNormal
		{
			set{ _isnormal=value;}
			get{return _isnormal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendUnits
		{
			set{ _sendunits=value;}
			get{return _sendunits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToUnits
		{
			set{ _tounits=value;}
			get{return _tounits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BillWeight
		{
			set{ _billweight=value;}
			get{return _billweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarNoImage
		{
			set{ _carnoimage=value;}
			get{return _carnoimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutWeightImage
		{
			set{ _outweightimage=value;}
			get{return _outweightimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Customers
		{
			set{ _customers=value;}
			get{return _customers;}
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
		public DateTime? ExceptLeft
		{
			set{ _exceptleft=value;}
			get{return _exceptleft;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarType
		{
			set{ _cartype=value;}
			get{return _cartype;}
		}
		#endregion Model

	}
}

