using System;
using System.Data;
using TDTK.PlatForm.MVC4.Model;
namespace TDTK.PlatForm.MVC4.IDAL
{
	/// <summary>
	/// 接口层SYS_FailerSendMessage2012
	/// </summary>
	public interface ISYS_FailerSendMessage2012:IBaseRepository<SYS_FailerSendMessage2012>
	{
        int GetMaxId();
	} 
}
