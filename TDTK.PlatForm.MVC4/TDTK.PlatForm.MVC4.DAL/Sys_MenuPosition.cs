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
    /// 数据访问类:Sys_MenuPosition
    /// </summary>
    public partial class Sys_MenuPosition : ISys_MenuPosition
    {
        public Sys_MenuPosition()
        { }

        public bool Exists(Model.Sys_MenuPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_MenuPosition");
            strSql.Append(" where PositionCode=@PositionCode and MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10),
					new SqlParameter("@MenuID", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.PositionCode;
            parameters[1].Value = t.MenuID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_MenuPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_MenuPosition(");
            strSql.Append("PositionCode,MenuID)");
            strSql.Append(" values (");
            strSql.Append("@PositionCode,@MenuID)");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10),
					new SqlParameter("@MenuID", SqlDbType.VarChar,20)};
            parameters[0].Value = t.PositionCode;
            parameters[1].Value = t.MenuID;

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

        public bool Update(Model.Sys_MenuPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_MenuPosition set ");
            strSql.Append("PositionCode=@PositionCode,");
            strSql.Append("MenuID=@MenuID");
            strSql.Append(" where PositionCode=@PositionCode and MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10),
					new SqlParameter("@MenuID", SqlDbType.VarChar,20)};
            parameters[0].Value = t.PositionCode;
            parameters[1].Value = t.MenuID;

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

        public bool Delete(Model.Sys_MenuPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_MenuPosition ");
            strSql.Append(" where PositionCode=@PositionCode and MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10),
					new SqlParameter("@MenuID", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.PositionCode;
            parameters[1].Value = t.MenuID;

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

        public Model.Sys_MenuPosition GetModel(Model.Sys_MenuPosition t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PositionCode,MenuID from Sys_MenuPosition ");
            strSql.Append(" where PositionCode=@PositionCode and MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PositionCode", SqlDbType.VarChar,10),
					new SqlParameter("@MenuID", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.PositionCode;
            parameters[1].Value = t.MenuID;

            TDTK.PlatForm.MVC4.Model.Sys_MenuPosition model = new TDTK.PlatForm.MVC4.Model.Sys_MenuPosition();
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

        public Model.Sys_MenuPosition DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_MenuPosition model = new TDTK.PlatForm.MVC4.Model.Sys_MenuPosition();
            if (row != null)
            {
                if (row["PositionCode"] != null)
                {
                    model.PositionCode = row["PositionCode"].ToString();
                }
                if (row["MenuID"] != null)
                {
                    model.MenuID = row["MenuID"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PositionCode,MenuID ");
            strSql.Append(" FROM Sys_MenuPosition ");
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
            strSql.Append(" PositionCode,MenuID ");
            strSql.Append(" FROM Sys_MenuPosition ");
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
            strSql.Append("select count(1) FROM Sys_MenuPosition ");
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
                strSql.Append("order by T.MenuID desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_MenuPosition T ");
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
