using System;
namespace TDTK.PlatForm.MVC4.Model
{
	/// <summary>
	/// TT_TempCard:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TT_TempCard
	{
		public TT_TempCard()
		{}
		#region Model
		private string _tempcode;
		private string _sendoperator;
		private DateTime? _operatortime;
		private string _tempcardstate;
		private string _isforbid;
		private string _roomcode;
		/// <summary>
		/// 
		/// </summary>
		public string TempCode
		{
			set{ _tempcode=value;}
			get{return _tempcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendOperator
		{
			set{ _sendoperator=value;}
			get{return _sendoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperatorTime
		{
			set{ _operatortime=value;}
			get{return _operatortime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempCardState
		{
			set{ _tempcardstate=value;}
			get{return _tempcardstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsForbid
		{
			set{ _isforbid=value;}
			get{return _isforbid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomCode
		{
			set{ _roomcode=value;}
			get{return _roomcode;}
		}
		#endregion Model

	}
}

