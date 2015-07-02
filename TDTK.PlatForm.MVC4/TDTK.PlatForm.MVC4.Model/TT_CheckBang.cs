using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_CheckBang:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_CheckBang
	{
		public TT_CheckBang()
		{}
		#region Model
		private string _checkcode;
		private string _weightcode;
		private string _navicertcode;
		private string _markedcardcode;
		private decimal? _netweight;
		private string _roomcode;
		private string _ispassed;
		private string _checkresult;
		private DateTime? _checktime= DateTime.Now;
		private string _operator;
		private string _frontimage;
		private string _backimage;
		private string _upimage;
		private string _roomimage;
		/// <summary>
		/// 
		/// </summary>
		public string CheckCode
		{
			set{ _checkcode=value;}
			get{return _checkcode;}
		}
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
		public decimal? NetWeight
		{
			set{ _netweight=value;}
			get{return _netweight;}
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
		public string IsPassed
		{
			set{ _ispassed=value;}
			get{return _ispassed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckResult
		{
			set{ _checkresult=value;}
			get{return _checkresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CheckTime
		{
			set{ _checktime=value;}
			get{return _checktime;}
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

