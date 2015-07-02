using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTK.PlatForm.MVC4.Model;
using TDTK.PlatForm.MVC4.BLL;
using TDTK.PlatForm.MVC4.DAL;
using TDTK.PlatForm.MVC4.DBUtility;
using System.Data;


namespace TDTK.PlatForm.MVC4.WebUI.Portal.Controllers
{
    public class OperatorController : Controller
    {
        //
        // GET: /Operator/

        public ActionResult Index()
        {
            GetDepartment();
            GetRoom();
            GetPosition();
            return View();
        }
        public ActionResult GetOperatorJsonData()
        {
            #region DataGrid前台请求的数据
            //初始化页码
            int page = 1;
            //初始化页容量
            int rows = 5;
            //根据前台请求：获取请求的页码，页容量
            if (Request["page"] != null)
            {
                page = Convert.ToInt32(Request["page"]);
            }
            if (Request["rows"] != null)
            {
                rows = Convert.ToInt32(Request["rows"]);
            }
            //排序字段
            string sort = "";
            if (Request["sort"] != null)
            {
                sort = Request["sort"].ToString();
            }
            else
            {
                sort = "UserCode";
            }
            //排序顺序“asc”，“desc”
            string order = "";
            if (Request["order"] != null)
            {
                order = Request["order"].ToString();
            }
            else
            {
                order = "asc";
            }
            //查询关键字:模糊查询
            string searchName = "";
            if (Request["searchName"] != null)
            {
                if (!string.IsNullOrEmpty(Request["searchName"].ToString()))
                {
                    searchName = "  UserName like'%" + Request["searchName"].ToString() + "%'  ";
                }
                else
                {
                    searchName = "";
                }

            }
            else
            {
                searchName = "";
            }
            #endregion


            DAL.Sys_Operator positionDAL = new DAL.Sys_Operator();
            DataSet ds = positionDAL.GetListByPage2(searchName, sort + " " + order, page, rows);
            List<Model.Sys_Operator> list = new List<Model.Sys_Operator>();
            Model.Sys_Operator p = null;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                p = new Model.Sys_Operator();
                p.UserCode = ds.Tables[0].Rows[i]["UserCode"].ToString();//用户编号
                p.UserName = ds.Tables[0].Rows[i]["UserName"].ToString();//用户名
                p.MobileNo = ds.Tables[0].Rows[i]["MobileNo"].ToString();//手机号
                p.OrgCode = ds.Tables[0].Rows[i]["OrgCode"].ToString();//部门编号
                p.TypeCode = ds.Tables[0].Rows[i]["TypeCode"].ToString();//职位编号
                p.IsForbid = ds.Tables[0].Rows[i]["IsForbid"].ToString();//是否禁用
                //部门名
                string orgName=(string)DbHelperSQL.GetSingle("select OrgName FROM [Coaltraffic].[dbo].[Sys_Organization] as org join Sys_Operator as op on  org.OrgCode=op.OrgCode where op.UserCode='"+p.UserCode+"'");
                //职位名
                string positionName = (string)DbHelperSQL.GetSingle("SELECT PositionName FROM  SYS_Position  a join Sys_OperatorPosition b on a.PositionCode=b.PositonCode where b.UserCode='" + p.UserCode + "'");
                p.OrgCode = orgName;//将部门名赋值到部门编号中
                p.TypeCode = positionName;//将职位名赋值到职位编号中
                list.Add(p);
            }
            //由于DataGrid请求的数据必须是json对象的数据，而且格式必须是   {totoal=总数,rows=数据对象}，所以下面对数据进行了加工
            var result = new { total = positionDAL.GetRecordCount(""), rows = list };
            //返回需要的json格式的数据
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult IsForbid()
        {
            //IsForbid PositionCode
            string UserCode = "";
            if (Request["UserCode"] != null)
            {
                UserCode = Request["UserCode"].ToString();
            }
            else
            {
                return Content("no:数据异常！");
            }
            #region 数据禁用、启用
            if (!string.IsNullOrEmpty(UserCode))
            {
                BLL.Sys_OperatorBLL pbl = new Sys_OperatorBLL();
                Model.Sys_Operator p = new TDTK.PlatForm.MVC4.Model.Sys_Operator();
                p.UserCode = UserCode;
                p = pbl.GetModel(p);
                string IsForbid = p.IsForbid;
                if (IsForbid == "1")
                {
                    p.IsForbid = "0";
                }
                else
                {
                    p.IsForbid = "1";
                }
                if (pbl.Update(p))
                {
                    if (IsForbid == "0")
                    {
                        return Content("ok:禁用成功！");
                    }
                    else
                    {
                        return Content("ok:启用成功！");
                    }
                }
                else
                {
                    return Content("no:操作失败！");
                }

            }
            #endregion
            else
            {
                return Content("no:操作有误！");
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Delete()
        {
            string UserCode = "";
            if (Request["UserCode"] != null)
            {
                UserCode = Request["UserCode"].ToString();
                Model.Sys_Operator p = new TDTK.PlatForm.MVC4.Model.Sys_Operator();
                BLL.Sys_OperatorBLL pb = new Sys_OperatorBLL();
                p.UserCode = UserCode;
                if (pb.Delete(p))
                {
                    return Content("ok");
                }
                else
                {
                    return Content("no");
                }

            }
            else
            {
                return Content("no");
            }

        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {
            //editPositionName  editRemark  editPositionCode
            //string editPositionName = "";
            //string editPositionCode = "";
            //string editRemark = "";
            //if (Request["editPositionName"] != null)
            //{
            //    editPositionName = Request["editPositionName"].ToString();
            //}
            //if (Request["editRemark"] != null)
            //{
            //    editRemark = Request["editRemark"].ToString();
            //}
            //if (Request["editPositionCode"] != null)
            //{
            //    editPositionCode = Request["editPositionCode"].ToString();
            //}
            //if (string.IsNullOrEmpty(editPositionName) && string.IsNullOrEmpty(editRemark))
            //{
            //    return Content("error:请填写完整！");
            //}
            //Model.SYS_Position p = new SYS_Position();
            //p.PositionCode = editPositionCode;
            //p.PositionName = editPositionName;
            //p.Remark = editRemark;
            //BLL.SYS_PositionBLL pb = new SYS_PositionBLL();
            //if (pb.Update(p))
            //{
            //    return Content("ok:修改成功");
            //}
            //else
            //{
            //    return Content("no:修改失败！");
            //}
            return View();

        }

        /// <summary>
        /// 获取一条数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDemoByID()
        {
            string UserCode = "";
            if (Request["UserCode"] != null)
            {
                UserCode = Request["UserCode"].ToString();
            }
            BLL.Sys_OperatorBLL pb = new Sys_OperatorBLL();
            Model.Sys_Operator p = new TDTK.PlatForm.MVC4.Model.Sys_Operator();
            p.UserCode = UserCode;
            Model.Sys_Operator pp = new TDTK.PlatForm.MVC4.Model.Sys_Operator();
            if (!string.IsNullOrEmpty(UserCode))
            {
                pp = pb.GetModel(p);
            }
            return Json(pp, JsonRequestBehavior.AllowGet);

        }

        #region 获取部门信息
        /// <summary>
        /// 获取部门信息
        /// </summary>
        private void GetDepartment()
        {
            List<SelectListItem> itemsDepartment = new List<SelectListItem>();
            itemsDepartment = TDTK.PlatForm.MVC4.WebUI.Portal.Common.DataHelper.GetSelectListItems("Sys_Organization", "OrgName", "OrgCode", " IsForbid='0'", "请选择部门", "");
            ViewBag.department = itemsDepartment;
        }
        #endregion

        #region 获取磅房信息
        /// <summary>
        /// 获取磅房信息
        /// </summary>
        private void GetRoom()
        {
            List<SelectListItem> itemsRoom = new List<SelectListItem>();
            itemsRoom = TDTK.PlatForm.MVC4.WebUI.Portal.Common.DataHelper.GetSelectListItems("TT_Room", "RoomName", "RoomCode", " IsForbid='0'", "请选择磅房", "");
            ViewBag.room = itemsRoom;
        }
        #endregion

        #region 获取职位信息
        /// <summary>
        /// 获取职位信息
        /// </summary>
        private void GetPosition()
        {
            List<SelectListItem> itemsPosition = new List<SelectListItem>();
            itemsPosition = TDTK.PlatForm.MVC4.WebUI.Portal.Common.DataHelper.GetSelectListItems("SYS_Position", "PositionName", "PositionCode", " IsForbid='0'", "请选择职位", "");
            ViewBag.Position = itemsPosition;
        }
        #endregion
    }
}
