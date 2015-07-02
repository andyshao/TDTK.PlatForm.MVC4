using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.Model;
using TDTK.PlatForm.MVC4.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:TT_TaxItem
    /// </summary>
    public partial class TT_TaxItem : ITT_TaxItem
    {
        public TT_TaxItem()
        { }

        public bool Exists(Model.TT_TaxItem t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_TaxItem");
            strSql.Append(" where TaxItemCode=@TaxItemCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TaxItemCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.TaxItemCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_TaxItem t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_TaxItem(");
            strSql.Append("TaxItemCode,ItemName,ItemType,IsCount,IsForbid,Remark)");
            strSql.Append(" values (");
            strSql.Append("@TaxItemCode,@ItemName,@ItemType,@IsCount,@IsForbid,@Remark)");
            SqlParameter[] parameters = {
					new SqlParameter("@TaxItemCode", SqlDbType.VarChar,10),
					new SqlParameter("@ItemName", SqlDbType.NVarChar,50),
					new SqlParameter("@ItemType", SqlDbType.VarChar,10),
					new SqlParameter("@IsCount", SqlDbType.VarChar,1),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
            parameters[0].Value = t.TaxItemCode;
            parameters[1].Value = t.ItemName;
            parameters[2].Value = t.ItemType;
            parameters[3].Value = t.IsCount;
            parameters[4].Value = t.IsForbid;
            parameters[5].Value = t.Remark;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return rows;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_TaxItem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_TaxItem set ");
            strSql.Append("ItemName=@ItemName,");
            strSql.Append("ItemType=@ItemType,");
            strSql.Append("IsCount=@IsCount,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where TaxItemCode=@TaxItemCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemName", SqlDbType.NVarChar,50),
					new SqlParameter("@ItemType", SqlDbType.VarChar,10),
					new SqlParameter("@IsCount", SqlDbType.VarChar,1),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@TaxItemCode", SqlDbType.VarChar,10)};
            parameters[0].Value = model.ItemName;
            parameters[1].Value = model.ItemType;
            parameters[2].Value = model.IsCount;
            parameters[3].Value = model.IsForbid;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.TaxItemCode;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(Model.TT_TaxItem t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TaxItem ");
            strSql.Append(" where TaxItemCode=@TaxItemCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TaxItemCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.TaxItemCode;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TaxItem ");
            strSql.Append(" where TaxItemCode in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Model.TT_TaxItem GetModel(Model.TT_TaxItem t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 TaxItemCode,ItemName,ItemType,IsCount,IsForbid,Remark from TT_TaxItem ");
            strSql.Append(" where TaxItemCode=@TaxItemCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TaxItemCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.TaxItemCode;

            TDTK.PlatForm.MVC4.Model.TT_TaxItem model = new TDTK.PlatForm.MVC4.Model.TT_TaxItem();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.TT_TaxItem DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_TaxItem model = new TDTK.PlatForm.MVC4.Model.TT_TaxItem();
            if (row != null)
            {
                if (row["TaxItemCode"] != null)
                {
                    model.TaxItemCode = row["TaxItemCode"].ToString();
                }
                if (row["ItemName"] != null)
                {
                    model.ItemName = row["ItemName"].ToString();
                }
                if (row["ItemType"] != null)
                {
                    model.ItemType = row["ItemType"].ToString();
                }
                if (row["IsCount"] != null)
                {
                    model.IsCount = row["IsCount"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TaxItemCode,ItemName,ItemType,IsCount,IsForbid,Remark ");
            strSql.Append(" FROM TT_TaxItem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" TaxItemCode,ItemName,ItemType,IsCount,IsForbid,Remark ");
            strSql.Append(" FROM TT_TaxItem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TT_TaxItem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.TaxItemCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_TaxItem T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}
