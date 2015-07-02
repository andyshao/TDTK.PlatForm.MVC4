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
    /// 数据访问类:TT_TaxUnit
    /// </summary>
    public partial class TT_TaxUnit : ITT_TaxUnit
    {
        public TT_TaxUnit()
        { }

        public bool Exists(Model.TT_TaxUnit t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_TaxUnit");
            strSql.Append(" where UnitCode=@UnitCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UnitCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.UnitCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TDTK.PlatForm.MVC4.Model.TT_TaxUnit model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_TaxUnit(");
            strSql.Append("UnitCode,UnitName,Remark,IsForbid)");
            strSql.Append(" values (");
            strSql.Append("@UnitCode,@UnitName,@Remark,@IsForbid)");
            SqlParameter[] parameters = {
					new SqlParameter("@UnitCode", SqlDbType.VarChar,10),
					new SqlParameter("@UnitName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1)};
            parameters[0].Value = model.UnitCode;
            parameters[1].Value = model.UnitName;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.IsForbid;

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
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_TaxUnit model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_TaxUnit set ");
            strSql.Append("UnitName=@UnitName,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsForbid=@IsForbid");
            strSql.Append(" where UnitCode=@UnitCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UnitName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@UnitCode", SqlDbType.VarChar,10)};
            parameters[0].Value = model.UnitName;
            parameters[1].Value = model.Remark;
            parameters[2].Value = model.IsForbid;
            parameters[3].Value = model.UnitCode;

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

        public bool Delete(Model.TT_TaxUnit t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TaxUnit ");
            strSql.Append(" where UnitCode=@UnitCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UnitCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.UnitCode;

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
            strSql.Append("delete from TT_TaxUnit ");
            strSql.Append(" where UnitCode in (" + IDlist + ")  ");
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

        public Model.TT_TaxUnit GetModel(Model.TT_TaxUnit t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 UnitCode,UnitName,Remark,IsForbid from TT_TaxUnit ");
            strSql.Append(" where UnitCode=@UnitCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UnitCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.UnitCode;

            TDTK.PlatForm.MVC4.Model.TT_TaxUnit model = new TDTK.PlatForm.MVC4.Model.TT_TaxUnit();
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

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.TT_TaxUnit DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_TaxUnit model = new TDTK.PlatForm.MVC4.Model.TT_TaxUnit();
            if (row != null)
            {
                if (row["UnitCode"] != null)
                {
                    model.UnitCode = row["UnitCode"].ToString();
                }
                if (row["UnitName"] != null)
                {
                    model.UnitName = row["UnitName"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UnitCode,UnitName,Remark,IsForbid ");
            strSql.Append(" FROM TT_TaxUnit ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" UnitCode,UnitName,Remark,IsForbid ");
            strSql.Append(" FROM TT_TaxUnit ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TT_TaxUnit ");
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
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
                strSql.Append("order by T.UnitCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_TaxUnit T ");
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
