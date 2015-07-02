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
    /// 数据访问类:Sys_BusinType
    /// </summary>
    public partial class Sys_BusinType : ISys_BusinType
    {
        public Sys_BusinType()
        { }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Model.Sys_BusinType t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_BusinType");
            strSql.Append(" where BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.BusinTypeID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Sys_BusinType t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_BusinType(");
            strSql.Append("BusinTypeID,BusinTypeName,IsCanEdit)");
            strSql.Append(" values (");
            strSql.Append("@BusinTypeID,@BusinTypeName,@IsCanEdit)");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10),
					new SqlParameter("@BusinTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCanEdit", SqlDbType.VarChar,1)};
            parameters[0].Value = t.BusinTypeID;
            parameters[1].Value = t.BusinTypeName;
            parameters[2].Value = t.IsCanEdit;

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
        public bool Update(Model.Sys_BusinType t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_BusinType set ");
            strSql.Append("BusinTypeName=@BusinTypeName,");
            strSql.Append("IsCanEdit=@IsCanEdit");
            strSql.Append(" where BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinTypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCanEdit", SqlDbType.VarChar,1),
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)};
            parameters[0].Value = t.BusinTypeName;
            parameters[1].Value = t.IsCanEdit;
            parameters[2].Value = t.BusinTypeID;

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
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.Sys_BusinType t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_BusinType ");
            strSql.Append(" where BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.BusinTypeID;

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
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_BusinType ");
            strSql.Append(" where BusinTypeID in (" + IDlist + ")  ");
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
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Sys_BusinType GetModel(Model.Sys_BusinType t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 BusinTypeID,BusinTypeName,IsCanEdit from Sys_BusinType ");
            strSql.Append(" where BusinTypeID=@BusinTypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BusinTypeID", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.BusinTypeID;

            TDTK.PlatForm.MVC4.Model.Sys_BusinType model = new TDTK.PlatForm.MVC4.Model.Sys_BusinType();
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

        public Model.Sys_BusinType DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_BusinType model = new TDTK.PlatForm.MVC4.Model.Sys_BusinType();
            if (row != null)
            {
                if (row["BusinTypeID"] != null)
                {
                    model.BusinTypeID = row["BusinTypeID"].ToString();
                }
                if (row["BusinTypeName"] != null)
                {
                    model.BusinTypeName = row["BusinTypeName"].ToString();
                }
                if (row["IsCanEdit"] != null)
                {
                    model.IsCanEdit = row["IsCanEdit"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BusinTypeID,BusinTypeName,IsCanEdit ");
            strSql.Append(" FROM Sys_BusinType ");
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
            strSql.Append(" BusinTypeID,BusinTypeName,IsCanEdit ");
            strSql.Append(" FROM Sys_BusinType ");
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
            strSql.Append("select count(1) FROM Sys_BusinType ");
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
                strSql.Append("order by T.BusinTypeID desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_BusinType T ");
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
