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
    /// 数据访问类:TT_TransferAccounts
    /// </summary>
    public partial class TT_TransferAccounts : ITT_TransferAccounts
    {
        public TT_TransferAccounts()
        { }

        public bool Exists(Model.TT_TransferAccounts t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_TransferAccounts");
            strSql.Append(" where TransferID=@TransferID");
            SqlParameter[] parameters = {
					new SqlParameter("@TransferID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.TransferID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TDTK.PlatForm.MVC4.Model.TT_TransferAccounts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_TransferAccounts(");
            strSql.Append("FromCollCode,ToCollCode,TransferMoney,Operator,OperateTime,OrgName)");
            strSql.Append(" values (");
            strSql.Append("@FromCollCode,@ToCollCode,@TransferMoney,@Operator,@OperateTime,@OrgName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@FromCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@ToCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@TransferMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateTime", SqlDbType.DateTime),
					new SqlParameter("@OrgName", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.FromCollCode;
            parameters[1].Value = model.ToCollCode;
            parameters[2].Value = model.TransferMoney;
            parameters[3].Value = model.Operator;
            parameters[4].Value = model.OperateTime;
            parameters[5].Value = model.OrgName;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows>0)
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
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_TransferAccounts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_TransferAccounts set ");
            strSql.Append("FromCollCode=@FromCollCode,");
            strSql.Append("ToCollCode=@ToCollCode,");
            strSql.Append("TransferMoney=@TransferMoney,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("OperateTime=@OperateTime,");
            strSql.Append("OrgName=@OrgName");
            strSql.Append(" where TransferID=@TransferID");
            SqlParameter[] parameters = {
					new SqlParameter("@FromCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@ToCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@TransferMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateTime", SqlDbType.DateTime),
					new SqlParameter("@OrgName", SqlDbType.NVarChar,20),
					new SqlParameter("@TransferID", SqlDbType.BigInt,8)};
            parameters[0].Value = model.FromCollCode;
            parameters[1].Value = model.ToCollCode;
            parameters[2].Value = model.TransferMoney;
            parameters[3].Value = model.Operator;
            parameters[4].Value = model.OperateTime;
            parameters[5].Value = model.OrgName;
            parameters[6].Value = model.TransferID;

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
        public bool Delete(Model.TT_TransferAccounts t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TransferAccounts ");
            strSql.Append(" where TransferID=@TransferID");
            SqlParameter[] parameters = {
					new SqlParameter("@TransferID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.TransferID;

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
            strSql.Append("delete from TT_TransferAccounts ");
            strSql.Append(" where TransferID in (" + IDlist + ")  ");
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

        public Model.TT_TransferAccounts GetModel(Model.TT_TransferAccounts t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 TransferID,FromCollCode,ToCollCode,TransferMoney,Operator,OperateTime,OrgName from TT_TransferAccounts ");
            strSql.Append(" where TransferID=@TransferID");
            SqlParameter[] parameters = {
					new SqlParameter("@TransferID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.TransferID;

            TDTK.PlatForm.MVC4.Model.TT_TransferAccounts model = new TDTK.PlatForm.MVC4.Model.TT_TransferAccounts();
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

        public Model.TT_TransferAccounts DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_TransferAccounts model = new TDTK.PlatForm.MVC4.Model.TT_TransferAccounts();
            if (row != null)
            {
                if (row["TransferID"] != null && row["TransferID"].ToString() != "")
                {
                    model.TransferID = long.Parse(row["TransferID"].ToString());
                }
                if (row["FromCollCode"] != null)
                {
                    model.FromCollCode = row["FromCollCode"].ToString();
                }
                if (row["ToCollCode"] != null)
                {
                    model.ToCollCode = row["ToCollCode"].ToString();
                }
                if (row["TransferMoney"] != null && row["TransferMoney"].ToString() != "")
                {
                    model.TransferMoney = decimal.Parse(row["TransferMoney"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["OperateTime"] != null && row["OperateTime"].ToString() != "")
                {
                    model.OperateTime = DateTime.Parse(row["OperateTime"].ToString());
                }
                if (row["OrgName"] != null)
                {
                    model.OrgName = row["OrgName"].ToString();
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
            strSql.Append("select TransferID,FromCollCode,ToCollCode,TransferMoney,Operator,OperateTime,OrgName ");
            strSql.Append(" FROM TT_TransferAccounts ");
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
            strSql.Append(" TransferID,FromCollCode,ToCollCode,TransferMoney,Operator,OperateTime,OrgName ");
            strSql.Append(" FROM TT_TransferAccounts ");
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
            strSql.Append("select count(1) FROM TT_TransferAccounts ");
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
                strSql.Append("order by T.TransferID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_TransferAccounts T ");
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
