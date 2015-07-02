using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTK.PlatForm.MVC4.BLL;
using TDTK.PlatForm.MVC4.Model;

namespace TDTK.PlatForm.MVC4.WebUI.Portal.Controllers
{
    public class PositionController : Controller
    {
        //
        // GET: /Position/

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPositionJsonData()
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
                sort = "PositionCode";
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
                    searchName = "  PositionName like'%" + Request["searchName"].ToString() + "%'  ";
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



            DAL.SYS_Position positionDAL = new DAL.SYS_Position();
            DataSet ds = positionDAL.GetListByPage2(searchName, sort + " " + order, page, rows);
            List<Model.SYS_Position> list = new List<SYS_Position>();
            Model.SYS_Position p = null;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                p = new SYS_Position();
                p.PositionCode = ds.Tables[0].Rows[i]["PositionCode"].ToString();
                p.PositionName = ds.Tables[0].Rows[i]["PositionName"].ToString();
                p.Remark = ds.Tables[0].Rows[i]["Remark"].ToString();
                p.IsForbid = ds.Tables[0].Rows[i]["IsForbid"].ToString();
                list.Add(p);
            }
            //由于DataGrid请求的数据必须是json对象的数据，而且格式必须是   {totoal=总数,rows=数据对象}，所以下面对数据进行了加工
            var result = new { total = positionDAL.GetRecordCount(""), rows = list };
            //返回需要的json格式的数据
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 获取一条数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDemoByID()
        {
            string PositionCode = "";
            if (Request["PositionCode"] != null)
            {
                PositionCode = Request["PositionCode"].ToString();
            }
            BLL.SYS_PositionBLL pb = new SYS_PositionBLL();
            Model.SYS_Position p = new SYS_Position();
            p.PositionCode = PositionCode;
            Model.SYS_Position pp = new SYS_Position();
            if (!string.IsNullOrEmpty(PositionCode))
            {
                pp = pb.GetModel(p);
            }
            return Json(pp, JsonRequestBehavior.AllowGet);

        }
        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {
            //editPositionName  editRemark  editPositionCode
            string editPositionName = "";
            string editPositionCode = "";
            string editRemark = "";
            if (Request["editPositionName"] != null)
            {
                editPositionName = Request["editPositionName"].ToString();
            }
            if (Request["editRemark"] != null)
            {
                editRemark = Request["editRemark"].ToString();
            }
            if (Request["editPositionCode"] != null)
            {
                editPositionCode = Request["editPositionCode"].ToString();
            }
            if (string.IsNullOrEmpty(editPositionName) && string.IsNullOrEmpty(editRemark))
            {
                return Content("error:请填写完整！");
            }
            Model.SYS_Position p = new SYS_Position();
            p.PositionCode = editPositionCode;
            p.PositionName = editPositionName;
            p.Remark = editRemark;
            BLL.SYS_PositionBLL pb = new SYS_PositionBLL();
            if (pb.Update(p))
            {
                return Content("ok:修改成功");
            }
            else
            {
                return Content("no:修改失败！");
            }

        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            BLL.SYS_PositionBLL pb = new SYS_PositionBLL();
            Model.SYS_Position p = new SYS_Position();
            string editPositionName = "";
            string editRemark = "";
            if (Request["editPositionName"] != null)
            {
                editPositionName = Request["editPositionName"].ToString();
            }
            if (Request["editRemark"] != null)
            {
                editRemark = Request["editRemark"].ToString();
            }

            p.PositionCode = pb.GetMaxId().ToString();
            p.PositionName = editPositionName;
            p.Remark = editRemark;
            p.IsForbid = "0";

            if (pb.Add(p) > 0)
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Delete()
        {
            string editPositionCode = "";
            if (Request["PositionCode"] != null)
            {
                editPositionCode = Request["PositionCode"].ToString();
                Model.SYS_Position p = new SYS_Position();
                BLL.SYS_PositionBLL pb = new SYS_PositionBLL();
                p.PositionCode = editPositionCode;
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
        /// 禁用、启用
        /// </summary>
        /// <returns></returns>
        public ActionResult IsForbid()
        {
            //IsForbid PositionCode
            string PositionCode = "";
            if (Request["PositionCode"] != null)
            {
                PositionCode = Request["PositionCode"].ToString();
            }
            else
            {
                return Content("no:数据异常！");
            }
            #region 数据禁用、启用
            if (!string.IsNullOrEmpty(PositionCode))
            {
                BLL.SYS_PositionBLL pbl = new SYS_PositionBLL();
                Model.SYS_Position p = new SYS_Position();
                p.PositionCode = PositionCode;
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
    }
}
