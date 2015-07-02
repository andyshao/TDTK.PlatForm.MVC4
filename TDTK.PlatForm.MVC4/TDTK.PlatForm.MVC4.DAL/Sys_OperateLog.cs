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
    /// 数据访问类:Sys_OperateLog
    /// </summary>
    public partial class Sys_OperateLog : ISys_OperateLog
    {
        public Sys_OperateLog()
        { }

        public bool Exists(Model.Sys_OperateLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_OperateLog");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_OperateLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_OperateLog(");
            strSql.Append("LogType,RelationID,OperateIP,OperateDate,Operator,OperateTable,Remark,SysCode)");
            strSql.Append(" values (");
            strSql.Append("@LogType,@RelationID,@OperateIP,@OperateDate,@Operator,@OperateTable,@Remark,@SysCode)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@LogType", SqlDbType.NVarChar,50),
					new SqlParameter("@RelationID", SqlDbType.VarChar,20),
					new SqlParameter("@OperateIP", SqlDbType.VarChar,15),
					new SqlParameter("@OperateDate", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateTable", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@SysCode", SqlDbType.VarChar,20)};
            parameters[0].Value = t.LogType;
            parameters[1].Value = t.RelationID;
            parameters[2].Value = t.OperateIP;
            parameters[3].Value = t.OperateDate;
            parameters[4].Value = t.Operator;
            parameters[5].Value = t.OperateTable;
            parameters[6].Value = t.Remark;
            parameters[7].Value = t.SysCode;

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

        public bool Update(Model.Sys_OperateLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_OperateLog set ");
            strSql.Append("LogType=@LogType,");
            strSql.Append("RelationID=@RelationID,");
            strSql.Append("OperateIP=@OperateIP,");
            strSql.Append("OperateDate=@OperateDate,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("OperateTable=@OperateTable,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("SysCode=@SysCode");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogType", SqlDbType.NVarChar,50),
					new SqlParameter("@RelationID", SqlDbType.VarChar,20),
					new SqlParameter("@OperateIP", SqlDbType.VarChar,15),
					new SqlParameter("@OperateDate", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateTable", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@SysCode", SqlDbType.VarChar,20),
					new SqlParameter("@LogID", SqlDbType.BigInt,8)};
            parameters[0].Value = t.LogType;
            parameters[1].Value = t.RelationID;
            parameters[2].Value = t.OperateIP;
            parameters[3].Value = t.OperateDate;
            parameters[4].Value = t.Operator;
            parameters[5].Value = t.OperateTable;
            parameters[6].Value = t.Remark;
            parameters[7].Value = t.SysCode;
            parameters[8].Value = t.LogID;

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

        public bool Delete(Model.Sys_OperateLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_OperateLog ");
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
            strSql.Append("delete from Sys_OperateLog ");
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

        public Model.Sys_OperateLog GetModel(Model.Sys_OperateLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 LogID,LogType,RelationID,OperateIP,OperateDate,Operator,OperateTable,Remark,SysCode from Sys_OperateLog ");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

            TDTK.PlatForm.MVC4.Model.Sys_OperateLog model = new TDTK.PlatForm.MVC4.Model.Sys_OperateLog();
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

        public Model.Sys_OperateLog DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_OperateLog model = new TDTK.PlatForm.MVC4.Model.Sys_OperateLog();
            if (row != null)
            {
                if (row["LogID"] != null && row["LogID"].ToString() != "")
                {
                    model.LogID = long.Parse(row["LogID"].ToString());
                }
                if (row["LogType"] != null)
                {
                    model.LogType = row["LogType"].ToString();
                }
                if (row["RelationID"] != null)
                {
                    model.RelationID = row["RelationID"].ToString();
                }
                if (row["OperateIP"] != null)
                {
                    model.OperateIP = row["OperateIP"].ToString();
                }
                if (row["OperateDate"] != null && row["OperateDate"].ToString() != "")
                {
                    model.OperateDate = DateTime.Parse(row["OperateDate"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["OperateTable"] != null)
                {
                    model.OperateTable = row["OperateTable"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["SysCode"] != null)
                {
                    model.SysCode = row["SysCode"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LogID,LogType,RelationID,OperateIP,OperateDate,Operator,OperateTable,Remark,SysCode ");
            strSql.Append(" FROM Sys_OperateLog ");
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
            strSql.Append(" LogID,LogType,RelationID,OperateIP,OperateDate,Operator,OperateTable,Remark,SysCode ");
            strSql.Append(" FROM Sys_OperateLog ");
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
            strSql.Append("select count(1) FROM Sys_OperateLog ");
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
            strSql.Append(")AS Row, T.*  from Sys_OperateLog T ");
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
