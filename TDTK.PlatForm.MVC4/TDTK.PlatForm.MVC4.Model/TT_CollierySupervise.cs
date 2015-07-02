using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_CollierySupervise:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_CollierySupervise
	{
		public TT_CollierySupervise()
		{}
		#region Model
		private string _cscode;
		private string _collcode;
		private string _mcode;
		private string _mpname;
		private string _phonenumber;
		private string _receivetypecode;
		private string _isforbid;
		/// <summary>
		/// 
		/// </summary>
		public string CSCode
		{
			set{ _cscode=value;}
			get{return _cscode;}
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
		public string MCode
		{
			set{ _mcode=value;}
			get{return _mcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MPName
		{
			set{ _mpname=value;}
			get{return _mpname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PhoneNumber
		{
			set{ _phonenumber=value;}
			get{return _phonenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveTypeCode
		{
			set{ _receivetypecode=value;}
			get{return _receivetypecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsForBid
		{
			set{ _isforbid=value;}
			get{return _isforbid;}
		}
		#endregion Model

	}
}

