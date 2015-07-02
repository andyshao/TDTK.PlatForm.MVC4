using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_PitheadBill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_PitheadBill
	{
		public TT_PitheadBill()
		{}
		#region Model
		private int _pbid;
		private string _startiedition;
		private string _endiedition;
		private string _startnumber;
		private string _endnumber;
		private int _changnumber;
		private int _balancenum;
		private string _remark;
		private DateTime _pbdate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int PBid
		{
			set{ _pbid=value;}
			get{return _pbid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartIedition
		{
			set{ _startiedition=value;}
			get{return _startiedition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndIedition
		{
			set{ _endiedition=value;}
			get{return _endiedition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartNumber
		{
			set{ _startnumber=value;}
			get{return _startnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndNumber
		{
			set{ _endnumber=value;}
			get{return _endnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Changnumber
		{
			set{ _changnumber=value;}
			get{return _changnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BalanceNum
		{
			set{ _balancenum=value;}
			get{return _balancenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PBDate
		{
			set{ _pbdate=value;}
			get{return _pbdate;}
		}
		#endregion Model

	}
}

