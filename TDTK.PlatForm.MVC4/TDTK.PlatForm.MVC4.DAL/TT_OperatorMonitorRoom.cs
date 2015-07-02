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
    /// 数据访问类:TT_OperatorMonitorRoom
    /// </summary>
    public partial class TT_OperatorMonitorRoom : ITT_OperatorMonitorRoom
    {
        public TT_OperatorMonitorRoom()
        { }

        public bool Exists(Model.TT_OperatorMonitorRoom t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_OperatorMonitorRoom");
            strSql.Append(" where UserCode=@UserCode and RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,50)			};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.RoomCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_OperatorMonitorRoom t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_OperatorMonitorRoom(");
            strSql.Append("UserCode,RoomCode)");
            strSql.Append(" values (");
            strSql.Append("@UserCode,@RoomCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,50)};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.RoomCode;

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

        public bool Update(Model.TT_OperatorMonitorRoom t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_OperatorMonitorRoom set ");
            strSql.Append("UserCode=@UserCode,");
            strSql.Append("RoomCode=@RoomCode");
            strSql.Append(" where UserCode=@UserCode and RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,50)};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.RoomCode;

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

        public bool Delete(Model.TT_OperatorMonitorRoom t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_OperatorMonitorRoom ");
            strSql.Append(" where UserCode=@UserCode and RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,50)			};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.RoomCode;

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

        public Model.TT_OperatorMonitorRoom GetModel(Model.TT_OperatorMonitorRoom t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 UserCode,RoomCode from TT_OperatorMonitorRoom ");
            strSql.Append(" where UserCode=@UserCode and RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,50)			};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.RoomCode;

            TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom model = new TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom();
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

        public Model.TT_OperatorMonitorRoom DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom model = new TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom();
            if (row != null)
            {
                if (row["UserCode"] != null)
                {
                    model.UserCode = row["UserCode"].ToString();
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserCode,RoomCode ");
            strSql.Append(" FROM TT_OperatorMonitorRoom ");
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
            strSql.Append(" UserCode,RoomCode ");
            strSql.Append(" FROM TT_OperatorMonitorRoom ");
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
            strSql.Append("select count(1) FROM TT_OperatorMonitorRoom ");
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
                strSql.Append("order by T.RoomCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_OperatorMonitorRoom T ");
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
