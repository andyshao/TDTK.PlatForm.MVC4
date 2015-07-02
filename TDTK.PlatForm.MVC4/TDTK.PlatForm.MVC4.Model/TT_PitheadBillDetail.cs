using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_PitheadBillDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_PitheadBillDetail
	{
		public TT_PitheadBillDetail()
		{}
		#region Model
		private string _pitheadcode;
		private string _iedition;
		private DateTime _sendtime= DateTime.Now;
		private string _isused="0";
		private DateTime? _usetime;
		private string _collcode;
		private string _kindcode;
		/// <summary>
		/// 
		/// </summary>
		public string PitheadCode
		{
			set{ _pitheadcode=value;}
			get{return _pitheadcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Iedition
		{
			set{ _iedition=value;}
			get{return _iedition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsUsed
		{
			set{ _isused=value;}
			get{return _isused;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UseTime
		{
			set{ _usetime=value;}
			get{return _usetime;}
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
		public string KindCode
		{
			set{ _kindcode=value;}
			get{return _kindcode;}
		}
		#endregion Model

	}
}

