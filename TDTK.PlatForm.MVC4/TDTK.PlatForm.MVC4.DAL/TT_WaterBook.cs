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
    /// 数据访问类:TT_WaterBook
    /// </summary>
    public partial class TT_WaterBook : ITT_WaterBook
    {
        public TT_WaterBook()
        { }
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("JournalCode", "TT_WaterBook");
        }
        public bool Exists(Model.TT_WaterBook t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_WaterBook");
            strSql.Append(" where CollCode=@CollCode and JournalCode=@JournalCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@JournalCode", SqlDbType.Int,4)			};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.JournalCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TDTK.PlatForm.MVC4.Model.TT_WaterBook model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_WaterBook(");
            strSql.Append("TradeCode,CollCode,JournalCode,StartMoney,TradeMoney,EndMoney,Operator,TradeDate,TradeKind,Remark,WeightCode,AuditUser,AuditDate)");
            strSql.Append(" values (");
            strSql.Append("@TradeCode,@CollCode,@JournalCode,@StartMoney,@TradeMoney,@EndMoney,@Operator,@TradeDate,@TradeKind,@Remark,@WeightCode,@AuditUser,@AuditDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@TradeCode", SqlDbType.VarChar,20),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@JournalCode", SqlDbType.Int,4),
					new SqlParameter("@StartMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TradeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@EndMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@TradeDate", SqlDbType.DateTime),
					new SqlParameter("@TradeKind", SqlDbType.NVarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@WeightCode", SqlDbType.VarChar,35),
					new SqlParameter("@AuditUser", SqlDbType.NVarChar,20),
					new SqlParameter("@AuditDate", SqlDbType.DateTime)};
            parameters[0].Value = model.TradeCode;
            parameters[1].Value = model.CollCode;
            parameters[2].Value = model.JournalCode;
            parameters[3].Value = model.StartMoney;
            parameters[4].Value = model.TradeMoney;
            parameters[5].Value = model.EndMoney;
            parameters[6].Value = model.Operator;
            parameters[7].Value = model.TradeDate;
            parameters[8].Value = model.TradeKind;
            parameters[9].Value = model.Remark;
            parameters[10].Value = model.WeightCode;
            parameters[11].Value = model.AuditUser;
            parameters[12].Value = model.AuditDate;

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
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_WaterBook model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_WaterBook set ");
            strSql.Append("TradeCode=@TradeCode,");
            strSql.Append("StartMoney=@StartMoney,");
            strSql.Append("TradeMoney=@TradeMoney,");
            strSql.Append("EndMoney=@EndMoney,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("TradeDate=@TradeDate,");
            strSql.Append("TradeKind=@TradeKind,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("WeightCode=@WeightCode,");
            strSql.Append("AuditUser=@AuditUser,");
            strSql.Append("AuditDate=@AuditDate");
            strSql.Append(" where CollCode=@CollCode and JournalCode=@JournalCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TradeCode", SqlDbType.VarChar,20),
					new SqlParameter("@StartMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TradeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@EndMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@TradeDate", SqlDbType.DateTime),
					new SqlParameter("@TradeKind", SqlDbType.NVarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@WeightCode", SqlDbType.VarChar,35),
					new SqlParameter("@AuditUser", SqlDbType.NVarChar,20),
					new SqlParameter("@AuditDate", SqlDbType.DateTime),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@JournalCode", SqlDbType.Int,4)};
            parameters[0].Value = model.TradeCode;
            parameters[1].Value = model.StartMoney;
            parameters[2].Value = model.TradeMoney;
            parameters[3].Value = model.EndMoney;
            parameters[4].Value = model.Operator;
            parameters[5].Value = model.TradeDate;
            parameters[6].Value = model.TradeKind;
            parameters[7].Value = model.Remark;
            parameters[8].Value = model.WeightCode;
            parameters[9].Value = model.AuditUser;
            parameters[10].Value = model.AuditDate;
            parameters[11].Value = model.CollCode;
            parameters[12].Value = model.JournalCode;

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
        public bool Delete(Model.TT_WaterBook t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_WaterBook ");
            strSql.Append(" where CollCode=@CollCode and JournalCode=@JournalCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@JournalCode", SqlDbType.Int,4)			};
            parameters[0].Value =t.CollCode;
            parameters[1].Value =t.JournalCode;

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

        public Model.TT_WaterBook GetModel(Model.TT_WaterBook t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 TradeCode,CollCode,JournalCode,StartMoney,TradeMoney,EndMoney,Operator,TradeDate,TradeKind,Remark,WeightCode,AuditUser,AuditDate from TT_WaterBook ");
            strSql.Append(" where CollCode=@CollCode and JournalCode=@JournalCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@JournalCode", SqlDbType.Int,4)			};
            parameters[0].Value =t.CollCode;
            parameters[1].Value =t.JournalCode;

            TDTK.PlatForm.MVC4.Model.TT_WaterBook model = new TDTK.PlatForm.MVC4.Model.TT_WaterBook();
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
        public TDTK.PlatForm.MVC4.Model.TT_WaterBook DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_WaterBook model = new TDTK.PlatForm.MVC4.Model.TT_WaterBook();
            if (row != null)
            {
                if (row["TradeCode"] != null)
                {
                    model.TradeCode = row["TradeCode"].ToString();
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["JournalCode"] != null && row["JournalCode"].ToString() != "")
                {
                    model.JournalCode = int.Parse(row["JournalCode"].ToString());
                }
                if (row["StartMoney"] != null && row["StartMoney"].ToString() != "")
                {
                    model.StartMoney = decimal.Parse(row["StartMoney"].ToString());
                }
                if (row["TradeMoney"] != null && row["TradeMoney"].ToString() != "")
                {
                    model.TradeMoney = decimal.Parse(row["TradeMoney"].ToString());
                }
                if (row["EndMoney"] != null && row["EndMoney"].ToString() != "")
                {
                    model.EndMoney = decimal.Parse(row["EndMoney"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["TradeDate"] != null && row["TradeDate"].ToString() != "")
                {
                    model.TradeDate = DateTime.Parse(row["TradeDate"].ToString());
                }
                if (row["TradeKind"] != null)
                {
                    model.TradeKind = row["TradeKind"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["WeightCode"] != null)
                {
                    model.WeightCode = row["WeightCode"].ToString();
                }
                if (row["AuditUser"] != null)
                {
                    model.AuditUser = row["AuditUser"].ToString();
                }
                if (row["AuditDate"] != null && row["AuditDate"].ToString() != "")
                {
                    model.AuditDate = DateTime.Parse(row["AuditDate"].ToString());
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
            strSql.Append("select TradeCode,CollCode,JournalCode,StartMoney,TradeMoney,EndMoney,Operator,TradeDate,TradeKind,Remark,WeightCode,AuditUser,AuditDate ");
            strSql.Append(" FROM TT_WaterBook ");
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
            strSql.Append(" TradeCode,CollCode,JournalCode,StartMoney,TradeMoney,EndMoney,Operator,TradeDate,TradeKind,Remark,WeightCode,AuditUser,AuditDate ");
            strSql.Append(" FROM TT_WaterBook ");
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
            strSql.Append("select count(1) FROM TT_WaterBook ");
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
                strSql.Append("order by T.JournalCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_WaterBook T ");
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
