using System;
using System.Data;
using TDTK.PlatForm.MVC4.Model;
namespace TDTK.PlatForm.MVC4.IDAL
{
	/// <summary>
	/// 接口层Sys_Operator
	/// </summary>
	public interface ISys_Operator:IBaseRepository<Sys_Operator>
	{
        string GetPosition(int userID);
	} 
}
