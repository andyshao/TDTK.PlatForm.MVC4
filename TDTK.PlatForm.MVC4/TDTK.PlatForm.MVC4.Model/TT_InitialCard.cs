using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_InitialCard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_InitialCard
	{
		public TT_InitialCard()
		{}
		#region Model
		private string _cardid;
		private string _cardno;
		private string _cardtype;
		private DateTime? _initialtime;
		private string _intialperson;
		private string _coalkindcode;
		/// <summary>
		/// 
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardNO
		{
			set{ _cardno=value;}
			get{return _cardno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
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
		/// <summary>
		/// 
		/// </summary>
		public string CoalKindCode
		{
			set{ _coalkindcode=value;}
			get{return _coalkindcode;}
		}
		#endregion Model

	}
}

