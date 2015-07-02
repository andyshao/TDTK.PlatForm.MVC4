using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_TransferAccounts:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_TransferAccounts
	{
		public TT_TransferAccounts()
		{}
		#region Model
		private long _transferid;
		private string _fromcollcode;
		private string _tocollcode;
		private decimal? _transfermoney;
		private string _operator;
		private DateTime? _operatetime;
		private string _orgname;
		/// <summary>
		/// 
		/// </summary>
		public long TransferID
		{
			set{ _transferid=value;}
			get{return _transferid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FromCollCode
		{
			set{ _fromcollcode=value;}
			get{return _fromcollcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToCollCode
		{
			set{ _tocollcode=value;}
			get{return _tocollcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TransferMoney
		{
			set{ _transfermoney=value;}
			get{return _transfermoney;}
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
		public DateTime? OperateTime
		{
			set{ _operatetime=value;}
			get{return _operatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrgName
		{
			set{ _orgname=value;}
			get{return _orgname;}
		}
		#endregion Model

	}
}

