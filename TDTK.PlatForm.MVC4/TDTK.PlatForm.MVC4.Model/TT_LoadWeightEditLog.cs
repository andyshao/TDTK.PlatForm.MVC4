using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_LoadWeightEditLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_LoadWeightEditLog
	{
		public TT_LoadWeightEditLog()
		{}
		#region Model
		private long _logid;
		private string _weightcode;
		private decimal? _beforenetweight;
		private string _beforecollcode;
		private string _beforekindcode;
		private string _beforenavicertcode;
		private string _beforemarkedcardcode;
		private decimal? _afternetweight;
		private string _aftercollcode;
		private string _afterkindcode;
		private string _afternavicertcode;
		private string _aftermarkedcardcode;
		private string _remark;
		private string _operator;
		private DateTime? _operatedate;
		/// <summary>
		/// 
		/// </summary>
		public long LogID
		{
			set{ _logid=value;}
			get{return _logid;}
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
		public decimal? BeforeNetWeight
		{
			set{ _beforenetweight=value;}
			get{return _beforenetweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BeforeCollCode
		{
			set{ _beforecollcode=value;}
			get{return _beforecollcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BeforeKindCode
		{
			set{ _beforekindcode=value;}
			get{return _beforekindcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BeforeNavicertCode
		{
			set{ _beforenavicertcode=value;}
			get{return _beforenavicertcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BeforeMarkedCardCode
		{
			set{ _beforemarkedcardcode=value;}
			get{return _beforemarkedcardcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AfterNetWeight
		{
			set{ _afternetweight=value;}
			get{return _afternetweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AfterCollCode
		{
			set{ _aftercollcode=value;}
			get{return _aftercollcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AfterKindCode
		{
			set{ _afterkindcode=value;}
			get{return _afterkindcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AfterNavicertCode
		{
			set{ _afternavicertcode=value;}
			get{return _afternavicertcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AfterMarkedCardCode
		{
			set{ _aftermarkedcardcode=value;}
			get{return _aftermarkedcardcode;}
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
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperateDate
		{
			set{ _operatedate=value;}
			get{return _operatedate;}
		}
		#endregion Model

	}
}

