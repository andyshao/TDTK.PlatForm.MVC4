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
    /// 数据访问类:TT_MonitorOperator
    /// </summary>
    public partial class TT_MonitorOperator : ITT_MonitorOperator
    {
        public TT_MonitorOperator()
        { }

        public bool Exists(Model.TT_MonitorOperator t)
        {
            throw new NotImplementedException();
        }

        public int Add(Model.TT_MonitorOperator t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_MonitorOperator(");
            strSql.Append("UserCode,MonitorCode)");
            strSql.Append(" values (");
            strSql.Append("@UserCode,@MonitorCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.BigInt,8),
					new SqlParameter("@MonitorCode", SqlDbType.BigInt,8)};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.MonitorCode;

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

        public bool Update(Model.TT_MonitorOperator t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_MonitorOperator set ");
            strSql.Append("UserCode=@UserCode,");
            strSql.Append("MonitorCode=@MonitorCode");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.BigInt,8),
					new SqlParameter("@MonitorCode", SqlDbType.BigInt,8)};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.MonitorCode;

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

        public bool Delete(Model.TT_MonitorOperator t)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_MonitorOperator ");
            strSql.Append(" where ");
            strSql.Append("UserCode=@UserCode and ");
            strSql.Append("MonitorCode=@MonitorCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.BigInt,8),
					new SqlParameter("@MonitorCode", SqlDbType.BigInt,8)};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.MonitorCode;

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
            throw new NotImplementedException();
        }

        public Model.TT_MonitorOperator GetModel(Model.TT_MonitorOperator t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 UserCode,MonitorCode from TT_MonitorOperator ");
            strSql.Append(" where ");
            strSql.Append("UserCode=@UserCode and ");
            strSql.Append("MonitorCode=@MonitorCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.BigInt,8),
					new SqlParameter("@MonitorCode", SqlDbType.BigInt,8)};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.MonitorCode;

            TDTK.PlatForm.MVC4.Model.TT_MonitorOperator model = new TDTK.PlatForm.MVC4.Model.TT_MonitorOperator();
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

        public Model.TT_MonitorOperator DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_MonitorOperator model = new TDTK.PlatForm.MVC4.Model.TT_MonitorOperator();
            if (row != null)
            {
                if (row["UserCode"] != null && row["UserCode"].ToString() != "")
                {
                    model.UserCode = long.Parse(row["UserCode"].ToString());
                }
                if (row["MonitorCode"] != null && row["MonitorCode"].ToString() != "")
                {
                    model.MonitorCode = long.Parse(row["MonitorCode"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserCode,MonitorCode ");
            strSql.Append(" FROM TT_MonitorOperator ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" UserCode,MonitorCode ");
            strSql.Append(" FROM TT_MonitorOperator ");
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
            strSql.Append("select count(1) FROM TT_MonitorOperator ");
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
                strSql.Append("order by T.MonitorCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_MonitorOperator T ");
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
