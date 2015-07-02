using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTK.PlatForm.MVC4.DBUtility;

namespace TDTK.PlatForm.MVC4.WebUI.Portal.Common
{
    /// <summary>
    /// 数据帮助类
    /// </summary>
    public static class DataHelper
    {
        #region 获取下拉列表数据
        /// <summary>
        /// 获取下拉列表数据
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strText">显示文本</param>
        /// <param name="strValue">显示值</param>
        /// <param name="strWhere">条件</param>
        /// <param name="strInitializeText">初始化文本</param>
        /// <param name="strInitializeValue">初始化值</param>
        /// <returns></returns>
        public static List<SelectListItem> GetSelectListItems(string strTableName, string strText, string strValue, string strWhere, string strInitializeText, string strInitializeValue)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            string strSql = "SELECT " + strText + "," + strValue + " FROM " + strTableName + " Where " + strWhere;
            DataSet dstTemp = new DataSet();
            dstTemp = DbHelperSQL.Query(strSql);
            if (dstTemp.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dstTemp.Tables[0].Rows.Count; i++)
                {
                    list.Add(new SelectListItem() { Text = dstTemp.Tables[0].Rows[i][strText].ToString(), Value = dstTemp.Tables[0].Rows[i][strValue].ToString() });
                }
            }
            list.Insert(0, new SelectListItem() { Text = strInitializeText, Value = strInitializeValue, Selected = true });
            return list;
        }
        
        #endregion
    }
}