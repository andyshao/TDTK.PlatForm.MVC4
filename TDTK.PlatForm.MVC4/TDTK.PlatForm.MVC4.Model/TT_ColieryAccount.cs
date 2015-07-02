using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_ColieryAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_ColieryAccount
	{
		public TT_ColieryAccount()
		{}
		#region Model
		private string _collcode;
		private decimal? _account=0.00M;
		private decimal? _enabledcardnum=0.00M;
		private decimal? _lowaccount=0.00M;
		private decimal? _markcardnum=0.00M;
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
		public decimal? Account
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EnabledCardNum
		{
			set{ _enabledcardnum=value;}
			get{return _enabledcardnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LowAccount
		{
			set{ _lowaccount=value;}
			get{return _lowaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MarkCardNum
		{
			set{ _markcardnum=value;}
			get{return _markcardnum;}
		}
		#endregion Model

	}
}

