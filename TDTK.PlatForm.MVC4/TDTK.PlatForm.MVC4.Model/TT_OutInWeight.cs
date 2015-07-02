using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_OutInWeight:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_OutInWeight
	{
		public TT_OutInWeight()
		{}
		#region Model
		private string _inweightcode;
		private string _outweightcode;
		private string _carno;
		private string _cartype;
		private string _navicertcode;
		private string _inroomname;
		private string _outroomname;
		private string _coalkindname;
		private decimal? _inweight;
		private decimal? _outweight;
		private DateTime? _inweightdate;
		private DateTime? _outweightdate;
		private DateTime? _exceptleft;
		private string _inoutdemo;
		/// <summary>
		/// 
		/// </summary>
		public string InWeightCode
		{
			set{ _inweightcode=value;}
			get{return _inweightcode;}
		}
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
		public string NavicertCode
		{
			set{ _navicertcode=value;}
			get{return _navicertcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InRoomName
		{
			set{ _inroomname=value;}
			get{return _inroomname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutRoomName
		{
			set{ _outroomname=value;}
			get{return _outroomname;}
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
		public decimal? InWeight
		{
			set{ _inweight=value;}
			get{return _inweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OutWeight
		{
			set{ _outweight=value;}
			get{return _outweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InWeightDate
		{
			set{ _inweightdate=value;}
			get{return _inweightdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OutWeightDate
		{
			set{ _outweightdate=value;}
			get{return _outweightdate;}
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
		public string InOutDemo
		{
			set{ _inoutdemo=value;}
			get{return _inoutdemo;}
		}
		#endregion Model

	}
}

