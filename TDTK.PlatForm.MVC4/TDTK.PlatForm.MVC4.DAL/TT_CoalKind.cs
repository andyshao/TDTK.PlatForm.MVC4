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
    /// 数据访问类:TT_CoalKind
    /// </summary>
    public partial class TT_CoalKind : ITT_CoalKind
    {
        public TT_CoalKind()
        { }

        public bool Exists(Model.TT_CoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_CoalKind");
            strSql.Append(" where CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CoalKindCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_CoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_CoalKind(");
            strSql.Append("CoalKindCode,CoalKindName,Proportion,Remark,IsForbid,TypeCode,TaxPercent)");
            strSql.Append(" values (");
            strSql.Append("@CoalKindCode,@CoalKindName,@Proportion,@Remark,@IsForbid,@TypeCode,@TaxPercent)");
            SqlParameter[] parameters = {
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindName", SqlDbType.NVarChar,20),
					new SqlParameter("@Proportion", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@TypeCode", SqlDbType.VarChar,1),
					new SqlParameter("@TaxPercent", SqlDbType.Decimal,9)};
            parameters[0].Value = t.CoalKindCode;
            parameters[1].Value = t.CoalKindName;
            parameters[2].Value = t.Proportion;
            parameters[3].Value = t.Remark;
            parameters[4].Value = t.IsForbid;
            parameters[5].Value = t.TypeCode;
            parameters[6].Value = t.TaxPercent;

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

        public bool Update(Model.TT_CoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_CoalKind set ");
            strSql.Append("CoalKindName=@CoalKindName,");
            strSql.Append("Proportion=@Proportion,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("TypeCode=@TypeCode,");
            strSql.Append("TaxPercent=@TaxPercent");
            strSql.Append(" where CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CoalKindName", SqlDbType.NVarChar,20),
					new SqlParameter("@Proportion", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@TypeCode", SqlDbType.VarChar,1),
					new SqlParameter("@TaxPercent", SqlDbType.Decimal,9),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.CoalKindName;
            parameters[1].Value = t.Proportion;
            parameters[2].Value = t.Remark;
            parameters[3].Value = t.IsForbid;
            parameters[4].Value = t.TypeCode;
            parameters[5].Value = t.TaxPercent;
            parameters[6].Value = t.CoalKindCode;

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

        public bool Delete(Model.TT_CoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_CoalKind ");
            strSql.Append(" where CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CoalKindCode;

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
            strSql.Append("delete from TT_CoalKind ");
            strSql.Append(" where CoalKindCode in (" + IDlist + ")  ");
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

        public Model.TT_CoalKind GetModel(Model.TT_CoalKind t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CoalKindCode,CoalKindName,Proportion,Remark,IsForbid,TypeCode,TaxPercent from TT_CoalKind ");
            strSql.Append(" where CoalKindCode=@CoalKindCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CoalKindCode;

            TDTK.PlatForm.MVC4.Model.TT_CoalKind model = new TDTK.PlatForm.MVC4.Model.TT_CoalKind();
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

        public Model.TT_CoalKind DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_CoalKind model = new TDTK.PlatForm.MVC4.Model.TT_CoalKind();
            if (row != null)
            {
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
                if (row["CoalKindName"] != null)
                {
                    model.CoalKindName = row["CoalKindName"].ToString();
                }
                if (row["Proportion"] != null && row["Proportion"].ToString() != "")
                {
                    model.Proportion = decimal.Parse(row["Proportion"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["TypeCode"] != null)
                {
                    model.TypeCode = row["TypeCode"].ToString();
                }
                if (row["TaxPercent"] != null && row["TaxPercent"].ToString() != "")
                {
                    model.TaxPercent = decimal.Parse(row["TaxPercent"].ToString());
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CoalKindCode,CoalKindName,Proportion,Remark,IsForbid,TypeCode,TaxPercent ");
            strSql.Append(" FROM TT_CoalKind ");
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
            strSql.Append(" CoalKindCode,CoalKindName,Proportion,Remark,IsForbid,TypeCode,TaxPercent ");
            strSql.Append(" FROM TT_CoalKind ");
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
            strSql.Append("select count(1) FROM TT_CoalKind ");
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
                strSql.Append("order by T.CoalKindCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_CoalKind T ");
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
