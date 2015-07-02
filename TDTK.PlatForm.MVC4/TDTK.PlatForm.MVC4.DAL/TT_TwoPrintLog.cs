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
    /// 数据访问类:TT_TwoPrintLog
    /// </summary>
    public partial class TT_TwoPrintLog : ITT_TwoPrintLog
    {
        public TT_TwoPrintLog()
        { }

        public bool Exists(Model.TT_TwoPrintLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_TwoPrintLog");
            strSql.Append(" where LogID=@LogID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.LogID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TDTK.PlatForm.MVC4.Model.TT_TwoPrintLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_TwoPrintLog(");
            strSql.Append("LogID,LogType,Operator,PrintDate,PrintTable,PrintWeightCode)");
            strSql.Append(" values (");
            strSql.Append("@LogID,@LogType,@Operator,@PrintDate,@PrintTable,@PrintWeightCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.VarChar,32),
					new SqlParameter("@LogType", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@PrintDate", SqlDbType.DateTime),
					new SqlParameter("@PrintTable", SqlDbType.NVarChar,50),
					new SqlParameter("@PrintWeightCode", SqlDbType.VarChar,20)};
            parameters[0].Value = model.LogID;
            parameters[1].Value = model.LogType;
            parameters[2].Value = model.Operator;
            parameters[3].Value = model.PrintDate;
            parameters[4].Value = model.PrintTable;
            parameters[5].Value = model.PrintWeightCode;

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
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_TwoPrintLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_TwoPrintLog set ");
            strSql.Append("LogType=@LogType,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("PrintDate=@PrintDate,");
            strSql.Append("PrintTable=@PrintTable,");
            strSql.Append("PrintWeightCode=@PrintWeightCode");
            strSql.Append(" where LogID=@LogID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LogType", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@PrintDate", SqlDbType.DateTime),
					new SqlParameter("@PrintTable", SqlDbType.NVarChar,50),
					new SqlParameter("@PrintWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@LogID", SqlDbType.VarChar,32)};
            parameters[0].Value = model.LogType;
            parameters[1].Value = model.Operator;
            parameters[2].Value = model.PrintDate;
            parameters[3].Value = model.PrintTable;
            parameters[4].Value = model.PrintWeightCode;
            parameters[5].Value = model.LogID;

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

        public bool Delete(Model.TT_TwoPrintLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TwoPrintLog ");
            strSql.Append(" where LogID=@LogID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.LogID;

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
            strSql.Append("delete from TT_TwoPrintLog ");
            strSql.Append(" where LogID in (" + IDlist + ")  ");
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

        public Model.TT_TwoPrintLog GetModel(Model.TT_TwoPrintLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 LogID,LogType,Operator,PrintDate,PrintTable,PrintWeightCode from TT_TwoPrintLog ");
            strSql.Append(" where LogID=@LogID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.LogID;

            TDTK.PlatForm.MVC4.Model.TT_TwoPrintLog model = new TDTK.PlatForm.MVC4.Model.TT_TwoPrintLog();
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
        public TDTK.PlatForm.MVC4.Model.TT_TwoPrintLog DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_TwoPrintLog model = new TDTK.PlatForm.MVC4.Model.TT_TwoPrintLog();
            if (row != null)
            {
                if (row["LogID"] != null)
                {
                    model.LogID = row["LogID"].ToString();
                }
                if (row["LogType"] != null)
                {
                    model.LogType = row["LogType"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["PrintDate"] != null && row["PrintDate"].ToString() != "")
                {
                    model.PrintDate = DateTime.Parse(row["PrintDate"].ToString());
                }
                if (row["PrintTable"] != null)
                {
                    model.PrintTable = row["PrintTable"].ToString();
                }
                if (row["PrintWeightCode"] != null)
                {
                    model.PrintWeightCode = row["PrintWeightCode"].ToString();
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
            strSql.Append("select LogID,LogType,Operator,PrintDate,PrintTable,PrintWeightCode ");
            strSql.Append(" FROM TT_TwoPrintLog ");
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
            strSql.Append(" LogID,LogType,Operator,PrintDate,PrintTable,PrintWeightCode ");
            strSql.Append(" FROM TT_TwoPrintLog ");
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
            strSql.Append("select count(1) FROM TT_TwoPrintLog ");
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
                strSql.Append("order by T.LogID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_TwoPrintLog T ");
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
