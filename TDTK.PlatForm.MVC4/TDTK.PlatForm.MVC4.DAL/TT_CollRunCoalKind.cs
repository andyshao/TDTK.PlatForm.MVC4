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
    /// 数据访问类:TT_CollRunCoalKind
    /// </summary>
    public partial class TT_CollRunCoalKind : ITT_CollRunCoalKind
    {
        public TT_CollRunCoalKind()
        { }

        public bool Exists(Model.TT_CollRunCoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_CollRunCoalKind");
            strSql.Append(" where CollCode=@CollCode and CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.CoalKindCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_CollRunCoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_CollRunCoalKind(");
            strSql.Append("CollCode,CoalKindCode,IsForbid)");
            strSql.Append(" values (");
            strSql.Append("@CollCode,@CoalKindCode,@IsForbid)");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1)};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.CoalKindCode;
            parameters[2].Value = t.IsForbid;

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

        public bool Update(Model.TT_CollRunCoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_CollRunCoalKind set ");
            strSql.Append("IsForbid=@IsForbid");
            strSql.Append(" where CollCode=@CollCode and CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.IsForbid;
            parameters[1].Value = t.CollCode;
            parameters[2].Value = t.CoalKindCode;

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

        public bool Delete(Model.TT_CollRunCoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_CollRunCoalKind ");
            strSql.Append(" where CollCode=@CollCode and CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.CoalKindCode;

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

        public Model.TT_CollRunCoalKind GetModel(Model.TT_CollRunCoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CollCode,CoalKindCode,IsForbid from TT_CollRunCoalKind ");
            strSql.Append(" where CollCode=@CollCode and CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.CoalKindCode;

            TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind model = new TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind();
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

        public Model.TT_CollRunCoalKind DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind model = new TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind();
            if (row != null)
            {
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CollCode,CoalKindCode,IsForbid ");
            strSql.Append(" FROM TT_CollRunCoalKind ");
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
            strSql.Append(" CollCode,CoalKindCode,IsForbid ");
            strSql.Append(" FROM TT_CollRunCoalKind ");
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
            strSql.Append("select count(1) FROM TT_CollRunCoalKind ");
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
                strSql.Append("order by T.CoalKindCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_CollRunCoalKind T ");
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
