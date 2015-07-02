using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.DBUtility;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.Model;

namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:Sys_Dictionary
    /// </summary>
    public partial class Sys_Dictionary : ISys_Dictionary
    {
        public Sys_Dictionary()
        { }

        public bool Exists(Model.Sys_Dictionary t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_Dictionary");
            strSql.Append(" where BusinID=@BusinID and BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinID", SqlDbType.VarChar,10),
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.BusinID;
            parameters[1].Value = t.BusinTypeID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_Dictionary t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_Dictionary(");
            strSql.Append("BusinID,BusinName,BusinTypeID,DisplayOrder,IsForbid,OtherInfo)");
            strSql.Append(" values (");
            strSql.Append("@BusinID,@BusinName,@BusinTypeID,@DisplayOrder,@IsForbid,@OtherInfo)");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinID", SqlDbType.VarChar,10),
					new SqlParameter("@BusinName", SqlDbType.NVarChar,100),
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10),
					new SqlParameter("@DisplayOrder", SqlDbType.Decimal,5),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@OtherInfo", SqlDbType.VarChar,20)};
            parameters[0].Value = t.BusinID;
            parameters[1].Value = t.BusinName;
            parameters[2].Value = t.BusinTypeID;
            parameters[3].Value = t.DisplayOrder;
            parameters[4].Value = t.IsForbid;
            parameters[5].Value = t.OtherInfo;

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

        public bool Update(Model.Sys_Dictionary t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_Dictionary set ");
            strSql.Append("BusinName=@BusinName,");
            strSql.Append("DisplayOrder=@DisplayOrder,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("OtherInfo=@OtherInfo");
            strSql.Append(" where BusinID=@BusinID and BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinName", SqlDbType.NVarChar,100),
					new SqlParameter("@DisplayOrder", SqlDbType.Decimal,5),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@OtherInfo", SqlDbType.VarChar,20),
					new SqlParameter("@BusinID", SqlDbType.VarChar,10),
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)};
            parameters[0].Value = t.BusinName;
            parameters[1].Value = t.DisplayOrder;
            parameters[2].Value = t.IsForbid;
            parameters[3].Value = t.OtherInfo;
            parameters[4].Value = t.BusinID;
            parameters[5].Value = t.BusinTypeID;

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

        public bool Delete(Model.Sys_Dictionary t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_Dictionary ");
            strSql.Append(" where BusinID=@BusinID and BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinID", SqlDbType.VarChar,10),
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.BusinID;
            parameters[1].Value = t.BusinTypeID;

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

        public Model.Sys_Dictionary GetModel(Model.Sys_Dictionary t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 BusinID,BusinName,BusinTypeID,DisplayOrder,IsForbid,OtherInfo from Sys_Dictionary ");
            strSql.Append(" where BusinID=@BusinID and BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinID", SqlDbType.VarChar,10),
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.BusinID;
            parameters[1].Value = t.BusinTypeID;

            TDTK.PlatForm.MVC4.Model.Sys_Dictionary model = new TDTK.PlatForm.MVC4.Model.Sys_Dictionary();
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

        public Model.Sys_Dictionary DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_Dictionary model = new TDTK.PlatForm.MVC4.Model.Sys_Dictionary();
            if (row != null)
            {
                if (row["BusinID"] != null)
                {
                    model.BusinID = row["BusinID"].ToString();
                }
                if (row["BusinName"] != null)
                {
                    model.BusinName = row["BusinName"].ToString();
                }
                if (row["BusinTypeID"] != null)
                {
                    model.BusinTypeID = row["BusinTypeID"].ToString();
                }
                if (row["DisplayOrder"] != null && row["DisplayOrder"].ToString() != "")
                {
                    model.DisplayOrder = decimal.Parse(row["DisplayOrder"].ToString());
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["OtherInfo"] != null)
                {
                    model.OtherInfo = row["OtherInfo"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BusinID,BusinName,BusinTypeID,DisplayOrder,IsForbid,OtherInfo ");
            strSql.Append(" FROM Sys_Dictionary ");
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
            strSql.Append(" BusinID,BusinName,BusinTypeID,DisplayOrder,IsForbid,OtherInfo ");
            strSql.Append(" FROM Sys_Dictionary ");
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
            strSql.Append("select count(1) FROM Sys_Dictionary ");
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
                strSql.Append("order by T.BusinTypeID desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_Dictionary T ");
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
