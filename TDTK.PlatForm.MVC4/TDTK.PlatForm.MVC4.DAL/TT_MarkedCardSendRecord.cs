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
    /// 数据访问类:TT_MarkedCardSendRecord
    /// </summary>
    public partial class TT_MarkedCardSendRecord : ITT_MarkedCardSendRecord
    {
        public TT_MarkedCardSendRecord()
        { }

        public bool Exists(Model.TT_MarkedCardSendRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_MarkedCardSendRecord");
            strSql.Append(" where RecordID=@RecordID");
            SqlParameter[] parameters = {
					new SqlParameter("@RecordID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.RecordID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_MarkedCardSendRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_MarkedCardSendRecord(");
            strSql.Append("MarkedCardNo,MarkedCardCode,CollCode,CoalKindCode,SendCardDate,Operator,DepartName,SendType)");
            strSql.Append(" values (");
            strSql.Append("@MarkedCardNo,@MarkedCardCode,@CollCode,@CoalKindCode,@SendCardDate,@Operator,@DepartName,@SendType)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MarkedCardNo", SqlDbType.NVarChar,20),
					new SqlParameter("@MarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@SendCardDate", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@DepartName", SqlDbType.NVarChar,20),
					new SqlParameter("@SendType", SqlDbType.NVarChar,10)};
            parameters[0].Value = t.MarkedCardNo;
            parameters[1].Value = t.MarkedCardCode;
            parameters[2].Value = t.CollCode;
            parameters[3].Value = t.CoalKindCode;
            parameters[4].Value = t.SendCardDate;
            parameters[5].Value = t.Operator;
            parameters[6].Value = t.DepartName;
            parameters[7].Value = t.SendType;

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

        public bool Update(Model.TT_MarkedCardSendRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_MarkedCardSendRecord set ");
            strSql.Append("MarkedCardNo=@MarkedCardNo,");
            strSql.Append("MarkedCardCode=@MarkedCardCode,");
            strSql.Append("CollCode=@CollCode,");
            strSql.Append("CoalKindCode=@CoalKindCode,");
            strSql.Append("SendCardDate=@SendCardDate,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("DepartName=@DepartName,");
            strSql.Append("SendType=@SendType");
            strSql.Append(" where RecordID=@RecordID");
            SqlParameter[] parameters = {
					new SqlParameter("@MarkedCardNo", SqlDbType.NVarChar,20),
					new SqlParameter("@MarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@SendCardDate", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@DepartName", SqlDbType.NVarChar,20),
					new SqlParameter("@SendType", SqlDbType.NVarChar,10),
					new SqlParameter("@RecordID", SqlDbType.BigInt,8)};
            parameters[0].Value = t.MarkedCardNo;
            parameters[1].Value = t.MarkedCardCode;
            parameters[2].Value = t.CollCode;
            parameters[3].Value = t.CoalKindCode;
            parameters[4].Value = t.SendCardDate;
            parameters[5].Value = t.Operator;
            parameters[6].Value = t.DepartName;
            parameters[7].Value = t.SendType;
            parameters[8].Value = t.RecordID;

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

        public bool Delete(Model.TT_MarkedCardSendRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_MarkedCardSendRecord ");
            strSql.Append(" where RecordID=@RecordID");
            SqlParameter[] parameters = {
					new SqlParameter("@RecordID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.RecordID;

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
            strSql.Append("delete from TT_MarkedCardSendRecord ");
            strSql.Append(" where RecordID in (" + IDlist + ")  ");
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

        public Model.TT_MarkedCardSendRecord GetModel(Model.TT_MarkedCardSendRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 RecordID,MarkedCardNo,MarkedCardCode,CollCode,CoalKindCode,SendCardDate,Operator,DepartName,SendType from TT_MarkedCardSendRecord ");
            strSql.Append(" where RecordID=@RecordID");
            SqlParameter[] parameters = {
					new SqlParameter("@RecordID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.RecordID;

            TDTK.PlatForm.MVC4.Model.TT_MarkedCardSendRecord model = new TDTK.PlatForm.MVC4.Model.TT_MarkedCardSendRecord();
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

        public Model.TT_MarkedCardSendRecord DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_MarkedCardSendRecord model = new TDTK.PlatForm.MVC4.Model.TT_MarkedCardSendRecord();
            if (row != null)
            {
                if (row["RecordID"] != null && row["RecordID"].ToString() != "")
                {
                    model.RecordID = long.Parse(row["RecordID"].ToString());
                }
                if (row["MarkedCardNo"] != null)
                {
                    model.MarkedCardNo = row["MarkedCardNo"].ToString();
                }
                if (row["MarkedCardCode"] != null)
                {
                    model.MarkedCardCode = row["MarkedCardCode"].ToString();
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
                if (row["SendCardDate"] != null && row["SendCardDate"].ToString() != "")
                {
                    model.SendCardDate = DateTime.Parse(row["SendCardDate"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["DepartName"] != null)
                {
                    model.DepartName = row["DepartName"].ToString();
                }
                if (row["SendType"] != null)
                {
                    model.SendType = row["SendType"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RecordID,MarkedCardNo,MarkedCardCode,CollCode,CoalKindCode,SendCardDate,Operator,DepartName,SendType ");
            strSql.Append(" FROM TT_MarkedCardSendRecord ");
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
            strSql.Append(" RecordID,MarkedCardNo,MarkedCardCode,CollCode,CoalKindCode,SendCardDate,Operator,DepartName,SendType ");
            strSql.Append(" FROM TT_MarkedCardSendRecord ");
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
            strSql.Append("select count(1) FROM TT_MarkedCardSendRecord ");
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
                strSql.Append("order by T.RecordID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_MarkedCardSendRecord T ");
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
