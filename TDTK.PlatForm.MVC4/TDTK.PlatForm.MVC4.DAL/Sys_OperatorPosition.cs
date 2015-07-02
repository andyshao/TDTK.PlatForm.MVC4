using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.DBUtility;
using TDTK.PlatForm.MVC4.Model;
using System.Data;
using System.Data.SqlClient;
namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:Sys_OperatorPosition
    /// </summary>
    public partial class Sys_OperatorPosition : ISys_OperatorPosition
    {
        public Sys_OperatorPosition()
        { }

        public bool Exists(Model.Sys_OperatorPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_OperatorPosition");
            strSql.Append(" where PositonCode=@PositonCode and UserCode=@UserCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositonCode", SqlDbType.VarChar,10),
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.PositonCode;
            parameters[1].Value = t.UserCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_OperatorPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_OperatorPosition(");
            strSql.Append("PositonCode,UserCode)");
            strSql.Append(" values (");
            strSql.Append("@PositonCode,@UserCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@PositonCode", SqlDbType.VarChar,10),
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.PositonCode;
            parameters[1].Value = t.UserCode;

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

        public bool Update(Model.Sys_OperatorPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_OperatorPosition set ");
            strSql.Append("PositonCode=@PositonCode,");
            strSql.Append("UserCode=@UserCode");
            strSql.Append(" where PositonCode=@PositonCode and UserCode=@UserCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositonCode", SqlDbType.VarChar,10),
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.PositonCode;
            parameters[1].Value = t.UserCode;

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

        public bool Delete(Model.Sys_OperatorPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_OperatorPosition ");
            strSql.Append(" where PositonCode=@PositonCode and UserCode=@UserCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositonCode", SqlDbType.VarChar,10),
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.PositonCode;
            parameters[1].Value = t.UserCode;

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

        public Model.Sys_OperatorPosition GetModel(Model.Sys_OperatorPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PositonCode,UserCode from Sys_OperatorPosition ");
            strSql.Append(" where PositonCode=@PositonCode and UserCode=@UserCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositonCode", SqlDbType.VarChar,10),
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.PositonCode;
            parameters[1].Value = t.UserCode;

            TDTK.PlatForm.MVC4.Model.Sys_OperatorPosition model = new TDTK.PlatForm.MVC4.Model.Sys_OperatorPosition();
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

        public Model.Sys_OperatorPosition DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_OperatorPosition model = new TDTK.PlatForm.MVC4.Model.Sys_OperatorPosition();
            if (row != null)
            {
                if (row["PositonCode"] != null)
                {
                    model.PositonCode = row["PositonCode"].ToString();
                }
                if (row["UserCode"] != null)
                {
                    model.UserCode = row["UserCode"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PositonCode,UserCode ");
            strSql.Append(" FROM Sys_OperatorPosition ");
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
            strSql.Append(" PositonCode,UserCode ");
            strSql.Append(" FROM Sys_OperatorPosition ");
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
            strSql.Append("select count(1) FROM Sys_OperatorPosition ");
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
                strSql.Append("order by T.UserCode desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_OperatorPosition T ");
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
