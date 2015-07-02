using System;
using System.Data;
using TDTK.PlatForm.MVC4.Model;
namespace TDTK.PlatForm.MVC4.IBLL
{
	/// <summary>
	/// 接口层Sys_Operator
	/// </summary>
    public interface ISys_OperatorService : IBaseService<Sys_Operator>
	{
       string GetPosition(int userID);
	} 
}
