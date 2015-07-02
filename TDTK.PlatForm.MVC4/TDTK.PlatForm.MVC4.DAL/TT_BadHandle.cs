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
    /// 数据访问类:TT_BadHandle
    /// </summary>
    public partial class TT_BadHandle : ITT_BadHandle
    {
        public TT_BadHandle()
        { }

        public bool Exists(Model.TT_BadHandle t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_BadHandle");
            strSql.Append(" where HandleID=@HandleID ");
            SqlParameter[] parameters = {
					new SqlParameter("@HandleID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.HandleID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_BadHandle t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_BadHandle(");
            strSql.Append("HandleID,BadRecordID,Operator,OperateDate,Result,HandleOperator,HandleDate)");
            strSql.Append(" values (");
            strSql.Append("@HandleID,@BadRecordID,@Operator,@OperateDate,@Result,@HandleOperator,@HandleDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@HandleID", SqlDbType.VarChar,32),
					new SqlParameter("@BadRecordID", SqlDbType.VarChar,32),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateDate", SqlDbType.DateTime),
					new SqlParameter("@Result", SqlDbType.NVarChar,200),
					new SqlParameter("@HandleOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@HandleDate", SqlDbType.DateTime)};
            parameters[0].Value = t.HandleID;
            parameters[1].Value = t.BadRecordID;
            parameters[2].Value = t.Operator;
            parameters[3].Value = t.OperateDate;
            parameters[4].Value = t.Result;
            parameters[5].Value = t.HandleOperator;
            parameters[6].Value = t.HandleDate;

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

        public bool Update(Model.TT_BadHandle t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_BadHandle set ");
            strSql.Append("BadRecordID=@BadRecordID,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("OperateDate=@OperateDate,");
            strSql.Append("Result=@Result,");
            strSql.Append("HandleOperator=@HandleOperator,");
            strSql.Append("HandleDate=@HandleDate");
            strSql.Append(" where HandleID=@HandleID ");
            SqlParameter[] parameters = {
					new SqlParameter("@BadRecordID", SqlDbType.VarChar,32),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateDate", SqlDbType.DateTime),
					new SqlParameter("@Result", SqlDbType.NVarChar,200),
					new SqlParameter("@HandleOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@HandleDate", SqlDbType.DateTime),
					new SqlParameter("@HandleID", SqlDbType.VarChar,32)};
            parameters[0].Value = t.BadRecordID;
            parameters[1].Value = t.Operator;
            parameters[2].Value = t.OperateDate;
            parameters[3].Value = t.Result;
            parameters[4].Value = t.HandleOperator;
            parameters[5].Value = t.HandleDate;
            parameters[6].Value = t.HandleID;

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

        public bool Delete(Model.TT_BadHandle t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_BadHandle ");
            strSql.Append(" where HandleID=@HandleID ");
            SqlParameter[] parameters = {
					new SqlParameter("@HandleID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.HandleID;

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
            strSql.Append("delete from TT_BadHandle ");
            strSql.Append(" where HandleID in (" + IDlist + ")  ");
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

        public Model.TT_BadHandle GetModel(Model.TT_BadHandle t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 HandleID,BadRecordID,Operator,OperateDate,Result,HandleOperator,HandleDate from TT_BadHandle ");
            strSql.Append(" where HandleID=@HandleID ");
            SqlParameter[] parameters = {
					new SqlParameter("@HandleID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.HandleID;

            TDTK.PlatForm.MVC4.Model.TT_BadHandle model = new TDTK.PlatForm.MVC4.Model.TT_BadHandle();
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

        public Model.TT_BadHandle DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_BadHandle model = new TDTK.PlatForm.MVC4.Model.TT_BadHandle();
            if (row != null)
            {
                if (row["HandleID"] != null)
                {
                    model.HandleID = row["HandleID"].ToString();
                }
                if (row["BadRecordID"] != null)
                {
                    model.BadRecordID = row["BadRecordID"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["OperateDate"] != null && row["OperateDate"].ToString() != "")
                {
                    model.OperateDate = DateTime.Parse(row["OperateDate"].ToString());
                }
                if (row["Result"] != null)
                {
                    model.Result = row["Result"].ToString();
                }
                if (row["HandleOperator"] != null)
                {
                    model.HandleOperator = row["HandleOperator"].ToString();
                }
                if (row["HandleDate"] != null && row["HandleDate"].ToString() != "")
                {
                    model.HandleDate = DateTime.Parse(row["HandleDate"].ToString());
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select HandleID,BadRecordID,Operator,OperateDate,Result,HandleOperator,HandleDate ");
            strSql.Append(" FROM TT_BadHandle ");
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
            strSql.Append(" HandleID,BadRecordID,Operator,OperateDate,Result,HandleOperator,HandleDate ");
            strSql.Append(" FROM TT_BadHandle ");
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
            strSql.Append("select count(1) FROM TT_BadHandle ");
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
                strSql.Append("order by T.HandleID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_BadHandle T ");
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
