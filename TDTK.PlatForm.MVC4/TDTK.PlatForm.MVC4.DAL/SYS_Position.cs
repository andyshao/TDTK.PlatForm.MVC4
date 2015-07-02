using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.Model;
using TDTK.PlatForm.MVC4.DBUtility;
using System.Data;
using System.Data.SqlClient;



namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:SYS_Position
    /// </summary>
    public partial class SYS_Position : ISYS_Position
    {
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("PositionCode", "SYS_Position");
        }
        public SYS_Position()
        { }

        public bool Exists(Model.SYS_Position t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SYS_Position");
            strSql.Append(" where PositionCode=@PositionCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.PositionCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.SYS_Position t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SYS_Position(");
            strSql.Append("PositionCode,PositionName,Remark,IsForbid)");
            strSql.Append(" values (");
            strSql.Append("@PositionCode,@PositionName,@Remark,@IsForbid)");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10),
					new SqlParameter("@PositionName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1)};
            parameters[0].Value = t.PositionCode;
            parameters[1].Value = t.PositionName;
            parameters[2].Value = t.Remark;
            parameters[3].Value = t.IsForbid;

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

        public bool Update(Model.SYS_Position t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SYS_Position set ");
            strSql.Append("PositionName=@PositionName,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsForbid=@IsForbid");
            strSql.Append(" where PositionCode=@PositionCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.PositionName;
            parameters[1].Value = t.Remark;
            parameters[2].Value = t.IsForbid;
            parameters[3].Value = t.PositionCode;

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

        public bool Delete(Model.SYS_Position t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SYS_Position ");
            strSql.Append(" where PositionCode=@PositionCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.PositionCode;

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
            strSql.Append("delete from SYS_Position ");
            strSql.Append(" where PositionCode in (" + IDlist + ")  ");
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

        public Model.SYS_Position GetModel(Model.SYS_Position t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PositionCode,PositionName,Remark,IsForbid from SYS_Position ");
            strSql.Append(" where PositionCode=@PositionCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.PositionCode;

            TDTK.PlatForm.MVC4.Model.SYS_Position model = new TDTK.PlatForm.MVC4.Model.SYS_Position();
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

        public Model.SYS_Position DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.SYS_Position model = new TDTK.PlatForm.MVC4.Model.SYS_Position();
            if (row != null)
            {
                if (row["PositionCode"] != null)
                {
                    model.PositionCode = row["PositionCode"].ToString();
                }
                if (row["PositionName"] != null)
                {
                    model.PositionName = row["PositionName"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PositionCode,PositionName,Remark,IsForbid ");
            strSql.Append(" FROM SYS_Position ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" PositionCode,PositionName,Remark,IsForbid ");
            strSql.Append(" FROM SYS_Position ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM SYS_Position ");
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
        /// 分页获取数据
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="orderby">排序方式</param>
        /// <param name="startIndex">起始数据</param>
        /// <param name="endIndex">末尾数据</param>
        /// <returns></returns>
        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
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
                strSql.Append("order by T.PositionCode desc");
            }
            strSql.Append(")AS Row, T.*  from SYS_Position T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="orderby">排序方式</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        public System.Data.DataSet GetListByPage2(string strWhere, string orderby, int pageIndex, int pageSize)
        {
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            return GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
    }
}
