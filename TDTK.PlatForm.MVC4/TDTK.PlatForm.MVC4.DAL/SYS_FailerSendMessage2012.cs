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
    /// 数据访问类:SYS_FailerSendMessage2012
    /// </summary>
    public partial class SYS_FailerSendMessage2012 : ISYS_FailerSendMessage2012
    {
        public SYS_FailerSendMessage2012()
        { }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("FSMID", "SYS_FailerSendMessage2012");
        }
        public bool Exists(Model.SYS_FailerSendMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SYS_FailerSendMessage2012");
            strSql.Append(" where FSMID=@FSMID ");
            SqlParameter[] parameters = {
					new SqlParameter("@FSMID", SqlDbType.Int,4)			};
            parameters[0].Value = t.FSMID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.SYS_FailerSendMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SYS_FailerSendMessage2012(");
            strSql.Append("FSMID,PhoneNumber,MContent,FailerDate)");
            strSql.Append(" values (");
            strSql.Append("@FSMID,@PhoneNumber,@MContent,@FailerDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@FSMID", SqlDbType.Int,4),
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,11),
					new SqlParameter("@MContent", SqlDbType.VarChar,800),
					new SqlParameter("@FailerDate", SqlDbType.DateTime)};
            parameters[0].Value = t.FSMID;
            parameters[1].Value = t.PhoneNumber;
            parameters[2].Value = t.MContent;
            parameters[3].Value = t.FailerDate;

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

        public bool Update(Model.SYS_FailerSendMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SYS_FailerSendMessage2012 set ");
            strSql.Append("PhoneNumber=@PhoneNumber,");
            strSql.Append("MContent=@MContent,");
            strSql.Append("FailerDate=@FailerDate");
            strSql.Append(" where FSMID=@FSMID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,11),
					new SqlParameter("@MContent", SqlDbType.VarChar,800),
					new SqlParameter("@FailerDate", SqlDbType.DateTime),
					new SqlParameter("@FSMID", SqlDbType.Int,4)};
            parameters[0].Value = t.PhoneNumber;
            parameters[1].Value = t.MContent;
            parameters[2].Value = t.FailerDate;
            parameters[3].Value = t.FSMID;

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

        public bool Delete(Model.SYS_FailerSendMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SYS_FailerSendMessage2012 ");
            strSql.Append(" where FSMID=@FSMID ");
            SqlParameter[] parameters = {
					new SqlParameter("@FSMID", SqlDbType.Int,4)			};
            parameters[0].Value = t.FSMID;

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
            strSql.Append("delete from SYS_FailerSendMessage2012 ");
            strSql.Append(" where FSMID in (" + IDlist + ")  ");
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

        public Model.SYS_FailerSendMessage2012 GetModel(Model.SYS_FailerSendMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 FSMID,PhoneNumber,MContent,FailerDate from SYS_FailerSendMessage2012 ");
            strSql.Append(" where FSMID=@FSMID ");
            SqlParameter[] parameters = {
					new SqlParameter("@FSMID", SqlDbType.Int,4)			};
            parameters[0].Value = t.FSMID;

            TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012 model = new TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012();
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

        public Model.SYS_FailerSendMessage2012 DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012 model = new TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012();
            if (row != null)
            {
                if (row["FSMID"] != null && row["FSMID"].ToString() != "")
                {
                    model.FSMID = int.Parse(row["FSMID"].ToString());
                }
                if (row["PhoneNumber"] != null)
                {
                    model.PhoneNumber = row["PhoneNumber"].ToString();
                }
                if (row["MContent"] != null)
                {
                    model.MContent = row["MContent"].ToString();
                }
                if (row["FailerDate"] != null && row["FailerDate"].ToString() != "")
                {
                    model.FailerDate = DateTime.Parse(row["FailerDate"].ToString());
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FSMID,PhoneNumber,MContent,FailerDate ");
            strSql.Append(" FROM SYS_FailerSendMessage2012 ");
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
            strSql.Append(" FSMID,PhoneNumber,MContent,FailerDate ");
            strSql.Append(" FROM SYS_FailerSendMessage2012 ");
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
            strSql.Append("select count(1) FROM SYS_FailerSendMessage2012 ");
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
                strSql.Append("order by T.FSMID desc");
            }
            strSql.Append(")AS Row, T.*  from SYS_FailerSendMessage2012 T ");
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
