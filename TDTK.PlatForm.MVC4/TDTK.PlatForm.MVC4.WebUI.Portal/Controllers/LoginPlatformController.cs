using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTK.PlatForm.MVC4.WebUI.Portal.Common;
using TDTK.PlatForm.MVC4.BLL;
using TDTK.PlatForm.MVC4.Model;
using System.Text;
using System.Data;
using TDTK.PlatForm.MVC4.DBUtility;

namespace TDTK.PlatForm.MVC4.WebUI.Portal.Controllers
{
    public class LoginPlatformController : Controller
    {
        //
        // GET: /LoginPlatform/
        [HttpGet]
        public ActionResult Index()
        {
            GetDepartment();

            GetUser();

            return View();
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <returns></returns>
        public ActionResult UserLogin()
        {
            //验证码获取
            string validateCode = null;
            if (Session["ValidateCode"] != null)
            {
                validateCode = Session["ValidateCode"].ToString();
            }
            if (string.IsNullOrEmpty(validateCode))
            {
                return Content("no:验证码不能为空！！！");
            }
            Session["ValidateCode"] = null;
            //获取用户输入数据
            string ddldept = Request.Form["department"];
            string ddluser = Request.Form["ddluser"];
            string txtPassword = Request.Form["txtPassword"];
            string txtCheckCode = Request.Form["txtCheckCode"];
            //验证码对比
            if (!validateCode.Equals(txtCheckCode, StringComparison.InvariantCultureIgnoreCase))
            {
                return Content("no:验证码错误！！！");
            }
            //用户名密码比对
            Sys_OperatorBLL operatorBLL = new Sys_OperatorBLL();
            StringBuilder sb = new StringBuilder();
            sb.Append(" usercode='"+ddluser+"'");
            sb.Append(" and password='" + CommonMethod.MD5Crypt(txtPassword) + "'");
            DataSet ds = operatorBLL.GetList(sb.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["IsForbid"].ToString() == "1")
                {
                    return Content("no:该用户已经被禁用！！！");
                }

                Session["uid"] = ds.Tables[0].Rows[0]["UserCode"].ToString();
                Session["UserName"] = ds.Tables[0].Rows[0]["UserName"].ToString();
                //所属部门
                Session["orgID"] = ds.Tables[0].Rows[0]["OrgCode"].ToString();
                //所属于部门下的职位，一个人只属于一个部门，但可有多个职位，Session["PostionID"]保存的数据格式为数字
                //和逗号组成的字符串。（该用户下的所有职位）
                Session["PositionCode"]=operatorBLL.GetPosition(Convert.ToInt32(ddluser));
                
                //登录日志
                string strIP = System.Net.Dns.Resolve(System.Net.Dns.GetHostName()).AddressList[0].ToString();
                StringBuilder sbSql = new StringBuilder("");
                sbSql.Append("insert into Sys_OperateLog (LogType,OperateTable,Operator,OperateDate,OperateIP,Remark,SysCode,RelationID)");
                sbSql.Append(" values('登录','Sys_Operator','" + ds.Tables[0].Rows[0]["UserName"].ToString() + "',getdate(),'" + strIP + "','登录调运BS系统','s1000','')");
                DbHelperSQL.ExecuteSql(sbSql.ToString());

                return Content("ok:登录成功！！！");
            }
            else
            {
                return Content("no:用户名或密码错误！！！");
            }
        }

        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ValidateCode()
        {
            string strCheckCode = CreateRandomCode(4);
            //HttpCookie cookie = new HttpCookie("CookCode", strCheckCode);
            //CookieManager.AppendCookie("CookCode", strCheckCode);
            Session["ValidateCode"] = strCheckCode;
            CreateImage(strCheckCode);
            return View();
        }

        #region 获取部门信息
        /// <summary>
        /// 获取部门信息
        /// </summary>
        private void GetDepartment()
        {
            List<SelectListItem> itemsDepartment = new List<SelectListItem>();
            itemsDepartment = DataHelper.GetSelectListItems("Sys_Organization", "OrgName", "OrgCode", " IsForbid='0'", "请选择部门", "");
            ViewBag.department = itemsDepartment;
        }
        #endregion

        #region 获取用户信息
        private void GetUser(string departmentID = null)
        {
            List<SelectListItem> itemsUser = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(departmentID))
            {
                itemsUser = DataHelper.GetSelectListItems("Sys_Operator", "UserName", "UserCode", " IsForbid='0' and OrgCode='" + departmentID + "'", "请选择用户", "");
            }
            else
            {
                itemsUser = DataHelper.GetSelectListItems("Sys_Operator", "UserName", "UserCode", " IsForbid='0' ", "请选择用户", "");
            }
            ViewBag.ddluser = itemsUser;
        }
        #endregion

        #region 验证码相关
        /// <summary>
        /// 产生验证码

        /// </summary>
        /// <param name="codeCount">验证码的位数</param>
        /// <returns></returns>
        private string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;

            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(35);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }


        /// <summary>
        /// 产生图片
        /// </summary>
        /// <param name="checkCode">验证码</param>
        private void CreateImage(string checkCode)
        {
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;
            System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 13.5)), 22);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器 
                Random random = new Random();
                //清空图片背景色 
                g.Clear(Color.White);
                //画图片的背景噪音线 
                for (int i = 0; i < 25; i++)
                {

                    int x1 = random.Next(image.Width);

                    int x2 = random.Next(image.Width);

                    int y1 = random.Next(image.Height);

                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }


                Font font = new System.Drawing.Font("Arial", 12, (System.Drawing.FontStyle.Bold));
                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);
                g.DrawString(checkCode, font, brush, 2, 2);

                //画图片的前景噪音点 
                for (int i = 0; i < 100; i++)
                {

                    int x = random.Next(image.Width);

                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                //画图片的边框线 
                g.DrawRectangle(new Pen(Color.CadetBlue), 0, 0, image.Width - 1, image.Height - 1);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                Response.ClearContent();
                Response.ContentType = "image/Gif";
                Response.BinaryWrite(ms.ToArray());
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
        #endregion

    }
}
