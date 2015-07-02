using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// SYS_FailerSendMessage2012:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_FailerSendMessage2012
	{
		public SYS_FailerSendMessage2012()
		{}
		#region Model
		private int _fsmid;
		private string _phonenumber;
		private string _mcontent;
		private DateTime _failerdate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int FSMID
		{
			set{ _fsmid=value;}
			get{return _fsmid;}
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
		public DateTime FailerDate
		{
			set{ _failerdate=value;}
			get{return _failerdate;}
		}
		#endregion Model

	}
}

