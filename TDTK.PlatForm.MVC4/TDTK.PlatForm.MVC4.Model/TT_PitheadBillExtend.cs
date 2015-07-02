using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_PitheadBillExtend:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_PitheadBillExtend
	{
		public TT_PitheadBillExtend()
		{}
		#region Model
		private int _pid;
		private string _iedition;
		private string _collcode;
		private string _drawperson;
		private string _payperson;
		private DateTime _extenddate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int PID
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Iedition
		{
			set{ _iedition=value;}
			get{return _iedition;}
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
		public string DrawPerson
		{
			set{ _drawperson=value;}
			get{return _drawperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayPerson
		{
			set{ _payperson=value;}
			get{return _payperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ExtendDate
		{
			set{ _extenddate=value;}
			get{return _extenddate;}
		}
		#endregion Model

	}
}

