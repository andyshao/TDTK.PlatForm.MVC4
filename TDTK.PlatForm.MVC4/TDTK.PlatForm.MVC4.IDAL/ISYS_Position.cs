using System;
using System.Data;
using TDTK.PlatForm.MVC4.Model;
namespace TDTK.PlatForm.MVC4.IDAL
{
	/// <summary>
	/// 接口层SYS_Position
	/// </summary>
	public interface ISYS_Position:IBaseRepository<SYS_Position>
	{
        int GetMaxId();
	} 
}
