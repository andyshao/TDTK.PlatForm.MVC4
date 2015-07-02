using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_CollBalance:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_CollBalance
	{
		public TT_CollBalance()
		{}
		#region Model
		private long _balanceid;
		private string _collcode;
		private DateTime? _balancedate;
		private decimal? _collaccount;
		private string _operator;
		/// <summary>
		/// 
		/// </summary>
		public long BalanceID
		{
			set{ _balanceid=value;}
			get{return _balanceid;}
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
		public DateTime? BalanceDate
		{
			set{ _balancedate=value;}
			get{return _balancedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CollAccount
		{
			set{ _collaccount=value;}
			get{return _collaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		#endregion Model

	}
}

