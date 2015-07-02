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
    /// 数据访问类:TT_CollBalance
    /// </summary>
    public partial class TT_CollBalance : ITT_CollBalance
    {
        public TT_CollBalance()
        { }

        public bool Exists(Model.TT_CollBalance t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_CollBalance");
            strSql.Append(" where BalanceID=@BalanceID");
            SqlParameter[] parameters = {
					new SqlParameter("@BalanceID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.BalanceID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_CollBalance t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_CollBalance(");
            strSql.Append("CollCode,BalanceDate,CollAccount,Operator)");
            strSql.Append(" values (");
            strSql.Append("@CollCode,@BalanceDate,@CollAccount,@Operator)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@BalanceDate", SqlDbType.DateTime),
					new SqlParameter("@CollAccount", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20)};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.BalanceDate;
            parameters[2].Value = t.CollAccount;
            parameters[3].Value = t.Operator;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows >0)
            {
                return rows;
            }
            else
            {
                return 0;
            }
        }

        public bool Update(Model.TT_CollBalance t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_CollBalance set ");
            strSql.Append("CollCode=@CollCode,");
            strSql.Append("BalanceDate=@BalanceDate,");
            strSql.Append("CollAccount=@CollAccount,");
            strSql.Append("Operator=@Operator");
            strSql.Append(" where BalanceID=@BalanceID");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@BalanceDate", SqlDbType.DateTime),
					new SqlParameter("@CollAccount", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@BalanceID", SqlDbType.BigInt,8)};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.BalanceDate;
            parameters[2].Value = t.CollAccount;
            parameters[3].Value = t.Operator;
            parameters[4].Value = t.BalanceID;

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

        public bool Delete(Model.TT_CollBalance t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_CollBalance ");
            strSql.Append(" where BalanceID=@BalanceID");
            SqlParameter[] parameters = {
					new SqlParameter("@BalanceID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.BalanceID;

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
            strSql.Append("delete from TT_CollBalance ");
            strSql.Append(" where BalanceID in (" + IDlist + ")  ");
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

        public Model.TT_CollBalance GetModel(Model.TT_CollBalance t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 BalanceID,CollCode,BalanceDate,CollAccount,Operator from TT_CollBalance ");
            strSql.Append(" where BalanceID=@BalanceID");
            SqlParameter[] parameters = {
					new SqlParameter("@BalanceID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.BalanceID;

            TDTK.PlatForm.MVC4.Model.TT_CollBalance model = new TDTK.PlatForm.MVC4.Model.TT_CollBalance();
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

        public Model.TT_CollBalance DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_CollBalance model = new TDTK.PlatForm.MVC4.Model.TT_CollBalance();
            if (row != null)
            {
                if (row["BalanceID"] != null && row["BalanceID"].ToString() != "")
                {
                    model.BalanceID = long.Parse(row["BalanceID"].ToString());
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["BalanceDate"] != null && row["BalanceDate"].ToString() != "")
                {
                    model.BalanceDate = DateTime.Parse(row["BalanceDate"].ToString());
                }
                if (row["CollAccount"] != null && row["CollAccount"].ToString() != "")
                {
                    model.CollAccount = decimal.Parse(row["CollAccount"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BalanceID,CollCode,BalanceDate,CollAccount,Operator ");
            strSql.Append(" FROM TT_CollBalance ");
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
            strSql.Append(" BalanceID,CollCode,BalanceDate,CollAccount,Operator ");
            strSql.Append(" FROM TT_CollBalance ");
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
            strSql.Append("select count(1) FROM TT_CollBalance ");
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
                strSql.Append("order by T.BalanceID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_CollBalance T ");
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
