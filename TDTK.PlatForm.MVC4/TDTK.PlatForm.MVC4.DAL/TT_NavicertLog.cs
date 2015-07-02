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
    /// 数据访问类:TT_NavicertLog
    /// </summary>
    public partial class TT_NavicertLog : ITT_NavicertLog
    {
        public TT_NavicertLog()
        { }

        public bool Exists(Model.TT_NavicertLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_NavicertLog");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_NavicertLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_NavicertLog(");
            strSql.Append("NavicertCode,BeforeState,AfterState,Event,Remark,Operator,OperateDate)");
            strSql.Append(" values (");
            strSql.Append("@NavicertCode,@BeforeState,@AfterState,@Event,@Remark,@Operator,@OperateDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@BeforeState", SqlDbType.VarChar,1),
					new SqlParameter("@AfterState", SqlDbType.VarChar,1),
					new SqlParameter("@Event", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateDate", SqlDbType.DateTime)};
            parameters[0].Value = t.NavicertCode;
            parameters[1].Value = t.BeforeState;
            parameters[2].Value = t.AfterState;
            parameters[3].Value = t.Event;
            parameters[4].Value = t.Remark;
            parameters[5].Value = t.Operator;
            parameters[6].Value = t.OperateDate;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows>0)
            {
                return rows;
            }
            else
            {
                return 0;
            }
        }

        public bool Update(Model.TT_NavicertLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_NavicertLog set ");
            strSql.Append("NavicertCode=@NavicertCode,");
            strSql.Append("BeforeState=@BeforeState,");
            strSql.Append("AfterState=@AfterState,");
            strSql.Append("Event=@Event,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("OperateDate=@OperateDate");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@BeforeState", SqlDbType.VarChar,1),
					new SqlParameter("@AfterState", SqlDbType.VarChar,1),
					new SqlParameter("@Event", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateDate", SqlDbType.DateTime),
					new SqlParameter("@LogID", SqlDbType.BigInt,8)};
            parameters[0].Value = t.NavicertCode;
            parameters[1].Value = t.BeforeState;
            parameters[2].Value = t.AfterState;
            parameters[3].Value = t.Event;
            parameters[4].Value = t.Remark;
            parameters[5].Value = t.Operator;
            parameters[6].Value = t.OperateDate;
            parameters[7].Value = t.LogID;

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

        public bool Delete(Model.TT_NavicertLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_NavicertLog ");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

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
            strSql.Append("delete from TT_NavicertLog ");
            strSql.Append(" where LogID in (" + IDlist + ")  ");
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

        public Model.TT_NavicertLog GetModel(Model.TT_NavicertLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 LogID,NavicertCode,BeforeState,AfterState,Event,Remark,Operator,OperateDate from TT_NavicertLog ");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

            TDTK.PlatForm.MVC4.Model.TT_NavicertLog model = new TDTK.PlatForm.MVC4.Model.TT_NavicertLog();
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

        public Model.TT_NavicertLog DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_NavicertLog model = new TDTK.PlatForm.MVC4.Model.TT_NavicertLog();
            if (row != null)
            {
                if (row["LogID"] != null && row["LogID"].ToString() != "")
                {
                    model.LogID = long.Parse(row["LogID"].ToString());
                }
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["BeforeState"] != null)
                {
                    model.BeforeState = row["BeforeState"].ToString();
                }
                if (row["AfterState"] != null)
                {
                    model.AfterState = row["AfterState"].ToString();
                }
                if (row["Event"] != null)
                {
                    model.Event = row["Event"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["OperateDate"] != null && row["OperateDate"].ToString() != "")
                {
                    model.OperateDate = DateTime.Parse(row["OperateDate"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LogID,NavicertCode,BeforeState,AfterState,Event,Remark,Operator,OperateDate ");
            strSql.Append(" FROM TT_NavicertLog ");
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
            strSql.Append(" LogID,NavicertCode,BeforeState,AfterState,Event,Remark,Operator,OperateDate ");
            strSql.Append(" FROM TT_NavicertLog ");
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
            strSql.Append("select count(1) FROM TT_NavicertLog ");
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
                strSql.Append("order by T.LogID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_NavicertLog T ");
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
