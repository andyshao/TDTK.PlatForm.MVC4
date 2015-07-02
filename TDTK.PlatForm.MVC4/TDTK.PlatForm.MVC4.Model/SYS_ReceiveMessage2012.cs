using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// SYS_ReceiveMessage2012:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_ReceiveMessage2012
	{
		public SYS_ReceiveMessage2012()
		{}
		#region Model
		private int _rmid;
		private string _phonenumber;
		private string _mcontent;
		private DateTime _receivedate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int RMID
		{
			set{ _rmid=value;}
			get{return _rmid;}
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
		public DateTime ReceiveDate
		{
			set{ _receivedate=value;}
			get{return _receivedate;}
		}
		#endregion Model

	}
}

