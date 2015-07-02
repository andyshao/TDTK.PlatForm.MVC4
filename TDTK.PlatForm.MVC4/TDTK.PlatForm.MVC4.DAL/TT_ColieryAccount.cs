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
    /// 数据访问类:TT_ColieryAccount
    /// </summary>
    public partial class TT_ColieryAccount : ITT_ColieryAccount
    {
        public TT_ColieryAccount()
        { }

        public bool Exists(Model.TT_ColieryAccount t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_ColieryAccount");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_ColieryAccount t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_ColieryAccount(");
            strSql.Append("CollCode,Account,EnabledCardNum,LowAccount,MarkCardNum)");
            strSql.Append(" values (");
            strSql.Append("@CollCode,@Account,@EnabledCardNum,@LowAccount,@MarkCardNum)");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@Account", SqlDbType.Decimal,9),
					new SqlParameter("@EnabledCardNum", SqlDbType.Decimal,5),
					new SqlParameter("@LowAccount", SqlDbType.Decimal,9),
					new SqlParameter("@MarkCardNum", SqlDbType.Decimal,5)};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.Account;
            parameters[2].Value = t.EnabledCardNum;
            parameters[3].Value = t.LowAccount;
            parameters[4].Value = t.MarkCardNum;

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

        public bool Update(Model.TT_ColieryAccount t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_ColieryAccount set ");
            strSql.Append("Account=@Account,");
            strSql.Append("EnabledCardNum=@EnabledCardNum,");
            strSql.Append("LowAccount=@LowAccount,");
            strSql.Append("MarkCardNum=@MarkCardNum");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@Account", SqlDbType.Decimal,9),
					new SqlParameter("@EnabledCardNum", SqlDbType.Decimal,5),
					new SqlParameter("@LowAccount", SqlDbType.Decimal,9),
					new SqlParameter("@MarkCardNum", SqlDbType.Decimal,5),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.Account;
            parameters[1].Value = t.EnabledCardNum;
            parameters[2].Value = t.LowAccount;
            parameters[3].Value = t.MarkCardNum;
            parameters[4].Value = t.CollCode;

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

        public bool Delete(Model.TT_ColieryAccount t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_ColieryAccount ");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;

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
            strSql.Append("delete from TT_ColieryAccount ");
            strSql.Append(" where CollCode in (" + IDlist + ")  ");
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

        public Model.TT_ColieryAccount GetModel(Model.TT_ColieryAccount t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CollCode,Account,EnabledCardNum,LowAccount,MarkCardNum from TT_ColieryAccount ");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;

            TDTK.PlatForm.MVC4.Model.TT_ColieryAccount model = new TDTK.PlatForm.MVC4.Model.TT_ColieryAccount();
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

        public Model.TT_ColieryAccount DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_ColieryAccount model = new TDTK.PlatForm.MVC4.Model.TT_ColieryAccount();
            if (row != null)
            {
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["Account"] != null && row["Account"].ToString() != "")
                {
                    model.Account = decimal.Parse(row["Account"].ToString());
                }
                if (row["EnabledCardNum"] != null && row["EnabledCardNum"].ToString() != "")
                {
                    model.EnabledCardNum = decimal.Parse(row["EnabledCardNum"].ToString());
                }
                if (row["LowAccount"] != null && row["LowAccount"].ToString() != "")
                {
                    model.LowAccount = decimal.Parse(row["LowAccount"].ToString());
                }
                if (row["MarkCardNum"] != null && row["MarkCardNum"].ToString() != "")
                {
                    model.MarkCardNum = decimal.Parse(row["MarkCardNum"].ToString());
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CollCode,Account,EnabledCardNum,LowAccount,MarkCardNum ");
            strSql.Append(" FROM TT_ColieryAccount ");
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
            strSql.Append(" CollCode,Account,EnabledCardNum,LowAccount,MarkCardNum ");
            strSql.Append(" FROM TT_ColieryAccount ");
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
            strSql.Append("select count(1) FROM TT_ColieryAccount ");
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
                strSql.Append("order by T.CollCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_ColieryAccount T ");
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
