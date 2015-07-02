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
    /// 数据访问类:Sys_LeaveWord
    /// </summary>
    public partial class Sys_LeaveWord : ISys_LeaveWord
    {
        public Sys_LeaveWord()
        { }


        public bool Exists(Model.Sys_LeaveWord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_LeaveWord");
            strSql.Append(" where LeaveID=@LeaveID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.LeaveID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_LeaveWord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_LeaveWord(");
            strSql.Append("LeaveID,LeaveTitle,LeaveDate,LeaveContent,Operator,ReceiveID,IsRead)");
            strSql.Append(" values (");
            strSql.Append("@LeaveID,@LeaveTitle,@LeaveDate,@LeaveContent,@Operator,@ReceiveID,@IsRead)");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveID", SqlDbType.VarChar,32),
					new SqlParameter("@LeaveTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@LeaveDate", SqlDbType.DateTime),
					new SqlParameter("@LeaveContent", SqlDbType.Text),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@ReceiveID", SqlDbType.VarChar,10),
					new SqlParameter("@IsRead", SqlDbType.VarChar,1)};
            parameters[0].Value = t.LeaveID;
            parameters[1].Value = t.LeaveTitle;
            parameters[2].Value = t.LeaveDate;
            parameters[3].Value = t.LeaveContent;
            parameters[4].Value = t.Operator;
            parameters[5].Value = t.ReceiveID;
            parameters[6].Value = t.IsRead;

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

        public bool Update(Model.Sys_LeaveWord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_LeaveWord set ");
            strSql.Append("LeaveTitle=@LeaveTitle,");
            strSql.Append("LeaveDate=@LeaveDate,");
            strSql.Append("LeaveContent=@LeaveContent,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("ReceiveID=@ReceiveID,");
            strSql.Append("IsRead=@IsRead");
            strSql.Append(" where LeaveID=@LeaveID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@LeaveDate", SqlDbType.DateTime),
					new SqlParameter("@LeaveContent", SqlDbType.Text),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@ReceiveID", SqlDbType.VarChar,10),
					new SqlParameter("@IsRead", SqlDbType.VarChar,1),
					new SqlParameter("@LeaveID", SqlDbType.VarChar,32)};
            parameters[0].Value = t.LeaveTitle;
            parameters[1].Value = t.LeaveDate;
            parameters[2].Value = t.LeaveContent;
            parameters[3].Value = t.Operator;
            parameters[4].Value = t.ReceiveID;
            parameters[5].Value = t.IsRead;
            parameters[6].Value = t.LeaveID;

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

        public bool Delete(Model.Sys_LeaveWord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_LeaveWord ");
            strSql.Append(" where LeaveID=@LeaveID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.LeaveID;

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
            strSql.Append("delete from Sys_LeaveWord ");
            strSql.Append(" where LeaveID in (" + IDlist + ")  ");
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

        public Model.Sys_LeaveWord GetModel(Model.Sys_LeaveWord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 LeaveID,LeaveTitle,LeaveDate,LeaveContent,Operator,ReceiveID,IsRead from Sys_LeaveWord ");
            strSql.Append(" where LeaveID=@LeaveID ");
            SqlParameter[] parameters = {
					new SqlParameter("@LeaveID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.LeaveID;

            TDTK.PlatForm.MVC4.Model.Sys_LeaveWord model = new TDTK.PlatForm.MVC4.Model.Sys_LeaveWord();
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

        public Model.Sys_LeaveWord DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_LeaveWord model = new TDTK.PlatForm.MVC4.Model.Sys_LeaveWord();
            if (row != null)
            {
                if (row["LeaveID"] != null)
                {
                    model.LeaveID = row["LeaveID"].ToString();
                }
                if (row["LeaveTitle"] != null)
                {
                    model.LeaveTitle = row["LeaveTitle"].ToString();
                }
                if (row["LeaveDate"] != null && row["LeaveDate"].ToString() != "")
                {
                    model.LeaveDate = DateTime.Parse(row["LeaveDate"].ToString());
                }
                if (row["LeaveContent"] != null)
                {
                    model.LeaveContent = row["LeaveContent"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["ReceiveID"] != null)
                {
                    model.ReceiveID = row["ReceiveID"].ToString();
                }
                if (row["IsRead"] != null)
                {
                    model.IsRead = row["IsRead"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LeaveID,LeaveTitle,LeaveDate,LeaveContent,Operator,ReceiveID,IsRead ");
            strSql.Append(" FROM Sys_LeaveWord ");
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
            strSql.Append(" LeaveID,LeaveTitle,LeaveDate,LeaveContent,Operator,ReceiveID,IsRead ");
            strSql.Append(" FROM Sys_LeaveWord ");
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
            strSql.Append("select count(1) FROM Sys_LeaveWord ");
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
                strSql.Append("order by T.LeaveID desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_LeaveWord T ");
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
