using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// SYS_SucceedSendMessage2012:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_SucceedSendMessage2012
	{
		public SYS_SucceedSendMessage2012()
		{}
		#region Model
		private int _ssmid;
		private string _phonenumber;
		private string _mcontent;
		private DateTime _succeeddate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int SSMID
		{
			set{ _ssmid=value;}
			get{return _ssmid;}
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
		public string MContent
		{
			set{ _mcontent=value;}
			get{return _mcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SucceedDate
		{
			set{ _succeeddate=value;}
			get{return _succeeddate;}
		}
		#endregion Model

	}
}

