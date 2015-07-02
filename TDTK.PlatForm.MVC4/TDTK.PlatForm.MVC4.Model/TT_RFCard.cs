using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_RFCard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_RFCard
	{
		public TT_RFCard()
		{}
		#region Model
		private string _cardcode;
		private DateTime? _initialtime;
		private string _intialperson;
		/// <summary>
		/// 
		/// </summary>
		public string CardCode
		{
			set{ _cardcode=value;}
			get{return _cardcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InitialTime
		{
			set{ _initialtime=value;}
			get{return _initialtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IntialPerson
		{
			set{ _intialperson=value;}
			get{return _intialperson;}
		}
		#endregion Model

	}
}

