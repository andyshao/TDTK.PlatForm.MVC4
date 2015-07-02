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
    /// 数据访问类:TT_RFCard
    /// </summary>
    public partial class TT_RFCard : ITT_RFCard
    {
        public TT_RFCard()
        { }

        public bool Exists(Model.TT_RFCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_RFCard");
            strSql.Append(" where CardCode=@CardCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CardCode", SqlDbType.VarChar,12)			};
            parameters[0].Value = t.CardCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_RFCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_RFCard(");
            strSql.Append("CardCode,InitialTime,IntialPerson)");
            strSql.Append(" values (");
            strSql.Append("@CardCode,@InitialTime,@IntialPerson)");
            SqlParameter[] parameters = {
					new SqlParameter("@CardCode", SqlDbType.VarChar,12),
					new SqlParameter("@InitialTime", SqlDbType.DateTime),
					new SqlParameter("@IntialPerson", SqlDbType.NVarChar,40)};
            parameters[0].Value = t.CardCode;
            parameters[1].Value = t.InitialTime;
            parameters[2].Value = t.IntialPerson;

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

        public bool Update(Model.TT_RFCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_RFCard set ");
            strSql.Append("InitialTime=@InitialTime,");
            strSql.Append("IntialPerson=@IntialPerson");
            strSql.Append(" where CardCode=@CardCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@InitialTime", SqlDbType.DateTime),
					new SqlParameter("@IntialPerson", SqlDbType.NVarChar,40),
					new SqlParameter("@CardCode", SqlDbType.VarChar,12)};
            parameters[0].Value = t.InitialTime;
            parameters[1].Value = t.IntialPerson;
            parameters[2].Value = t.CardCode;

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

        public bool Delete(Model.TT_RFCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_RFCard ");
            strSql.Append(" where CardCode=@CardCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CardCode", SqlDbType.VarChar,12)			};
            parameters[0].Value = t.CardCode;

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
            strSql.Append("delete from TT_RFCard ");
            strSql.Append(" where CardCode in (" + IDlist + ")  ");
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

        public Model.TT_RFCard GetModel(Model.TT_RFCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CardCode,InitialTime,IntialPerson from TT_RFCard ");
            strSql.Append(" where CardCode=@CardCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CardCode", SqlDbType.VarChar,12)			};
            parameters[0].Value = t.CardCode;

            TDTK.PlatForm.MVC4.Model.TT_RFCard model = new TDTK.PlatForm.MVC4.Model.TT_RFCard();
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

        public Model.TT_RFCard DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_RFCard model = new TDTK.PlatForm.MVC4.Model.TT_RFCard();
            if (row != null)
            {
                if (row["CardCode"] != null)
                {
                    model.CardCode = row["CardCode"].ToString();
                }
                if (row["InitialTime"] != null && row["InitialTime"].ToString() != "")
                {
                    model.InitialTime = DateTime.Parse(row["InitialTime"].ToString());
                }
                if (row["IntialPerson"] != null)
                {
                    model.IntialPerson = row["IntialPerson"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CardCode,InitialTime,IntialPerson ");
            strSql.Append(" FROM TT_RFCard ");
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
            strSql.Append(" CardCode,InitialTime,IntialPerson ");
            strSql.Append(" FROM TT_RFCard ");
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
            strSql.Append("select count(1) FROM TT_RFCard ");
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
                strSql.Append("order by T.CardCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_RFCard T ");
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
