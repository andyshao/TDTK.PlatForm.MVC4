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
    /// 数据访问类:TT_MonitorLoadWeight
    /// </summary>
    public partial class TT_MonitorLoadWeight : ITT_MonitorLoadWeight
    {
        public TT_MonitorLoadWeight()
        { }

        public bool Exists(Model.TT_MonitorLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_MonitorLoadWeight");
            strSql.Append(" where MonitorCode=@MonitorCode");
            SqlParameter[] parameters = {
					new SqlParameter("@MonitorCode", SqlDbType.BigInt)
			};
            parameters[0].Value = t.MonitorCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_MonitorLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_MonitorLoadWeight(");
            strSql.Append("MonitorName,ChineseName,IsCancel)");
            strSql.Append(" values (");
            strSql.Append("@MonitorName,@ChineseName,@IsCancel)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MonitorName", SqlDbType.NVarChar,50),
					new SqlParameter("@ChineseName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCancel", SqlDbType.Int,4)};
            parameters[0].Value = t.MonitorName;
            parameters[1].Value = t.ChineseName;
            parameters[2].Value = t.IsCancel;

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

        public bool Update(Model.TT_MonitorLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_MonitorLoadWeight set ");
            strSql.Append("MonitorName=@MonitorName,");
            strSql.Append("ChineseName=@ChineseName,");
            strSql.Append("IsCancel=@IsCancel");
            strSql.Append(" where MonitorCode=@MonitorCode");
            SqlParameter[] parameters = {
					new SqlParameter("@MonitorName", SqlDbType.NVarChar,50),
					new SqlParameter("@ChineseName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCancel", SqlDbType.Int,4),
					new SqlParameter("@MonitorCode", SqlDbType.BigInt,8)};
            parameters[0].Value = t.MonitorName;
            parameters[1].Value = t.ChineseName;
            parameters[2].Value = t.IsCancel;
            parameters[3].Value = t.MonitorCode;

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

        public bool Delete(Model.TT_MonitorLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_MonitorLoadWeight ");
            strSql.Append(" where MonitorCode=@MonitorCode");
            SqlParameter[] parameters = {
					new SqlParameter("@MonitorCode", SqlDbType.BigInt)
			};
            parameters[0].Value = t.MonitorCode;

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
            strSql.Append("delete from TT_MonitorLoadWeight ");
            strSql.Append(" where MonitorCode in (" + IDlist + ")  ");
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

        public Model.TT_MonitorLoadWeight GetModel(Model.TT_MonitorLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MonitorCode,MonitorName,ChineseName,IsCancel from TT_MonitorLoadWeight ");
            strSql.Append(" where MonitorCode=@MonitorCode");
            SqlParameter[] parameters = {
					new SqlParameter("@MonitorCode", SqlDbType.BigInt)
			};
            parameters[0].Value = t.MonitorCode;

            TDTK.PlatForm.MVC4.Model.TT_MonitorLoadWeight model = new TDTK.PlatForm.MVC4.Model.TT_MonitorLoadWeight();
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

        public Model.TT_MonitorLoadWeight DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_MonitorLoadWeight model = new TDTK.PlatForm.MVC4.Model.TT_MonitorLoadWeight();
            if (row != null)
            {
                if (row["MonitorCode"] != null && row["MonitorCode"].ToString() != "")
                {
                    model.MonitorCode = long.Parse(row["MonitorCode"].ToString());
                }
                if (row["MonitorName"] != null)
                {
                    model.MonitorName = row["MonitorName"].ToString();
                }
                if (row["ChineseName"] != null)
                {
                    model.ChineseName = row["ChineseName"].ToString();
                }
                if (row["IsCancel"] != null && row["IsCancel"].ToString() != "")
                {
                    model.IsCancel = int.Parse(row["IsCancel"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MonitorCode,MonitorName,ChineseName,IsCancel ");
            strSql.Append(" FROM TT_MonitorLoadWeight ");
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
            strSql.Append(" MonitorCode,MonitorName,ChineseName,IsCancel ");
            strSql.Append(" FROM TT_MonitorLoadWeight ");
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
            strSql.Append("select count(1) FROM TT_MonitorLoadWeight ");
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
            strSql.Append(")AS Row, T.*  from TT_MonitorLoadWeight T ");
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
