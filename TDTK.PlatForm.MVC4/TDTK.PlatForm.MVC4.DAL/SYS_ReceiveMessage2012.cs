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
    /// 数据访问类:SYS_ReceiveMessage2012
    /// </summary>
    public partial class SYS_ReceiveMessage2012 : ISYS_ReceiveMessage2012
    {
        public SYS_ReceiveMessage2012()
        { }
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("RMID", "SYS_ReceiveMessage2012");
        }

        public bool Exists(Model.SYS_ReceiveMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SYS_ReceiveMessage2012");
            strSql.Append(" where RMID=@RMID");
            SqlParameter[] parameters = {
					new SqlParameter("@RMID", SqlDbType.Int,4)
			};
            parameters[0].Value = t.RMID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.SYS_ReceiveMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SYS_ReceiveMessage2012(");
            strSql.Append("PhoneNumber,MContent,ReceiveDate)");
            strSql.Append(" values (");
            strSql.Append("@PhoneNumber,@MContent,@ReceiveDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,12),
					new SqlParameter("@MContent", SqlDbType.VarChar,800),
					new SqlParameter("@ReceiveDate", SqlDbType.DateTime)};
            parameters[0].Value = t.PhoneNumber;
            parameters[1].Value = t.MContent;
            parameters[2].Value = t.ReceiveDate;

            object obj = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        public bool Update(Model.SYS_ReceiveMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SYS_ReceiveMessage2012 set ");
            strSql.Append("PhoneNumber=@PhoneNumber,");
            strSql.Append("MContent=@MContent,");
            strSql.Append("ReceiveDate=@ReceiveDate");
            strSql.Append(" where RMID=@RMID");
            SqlParameter[] parameters = {
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,12),
					new SqlParameter("@MContent", SqlDbType.VarChar,800),
					new SqlParameter("@ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@RMID", SqlDbType.Int,4)};
            parameters[0].Value = t.PhoneNumber;
            parameters[1].Value = t.MContent;
            parameters[2].Value = t.ReceiveDate;
            parameters[3].Value = t.RMID;

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

        public bool Delete(Model.SYS_ReceiveMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SYS_ReceiveMessage2012 ");
            strSql.Append(" where RMID=@RMID");
            SqlParameter[] parameters = {
					new SqlParameter("@RMID", SqlDbType.Int,4)
			};
            parameters[0].Value = t.RMID;

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
            strSql.Append("delete from SYS_ReceiveMessage2012 ");
            strSql.Append(" where RMID in (" + IDlist + ")  ");
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

        public Model.SYS_ReceiveMessage2012 GetModel(Model.SYS_ReceiveMessage2012 t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 RMID,PhoneNumber,MContent,ReceiveDate from SYS_ReceiveMessage2012 ");
            strSql.Append(" where RMID=@RMID");
            SqlParameter[] parameters = {
					new SqlParameter("@RMID", SqlDbType.Int,4)
			};
            parameters[0].Value = t.RMID;

            TDTK.PlatForm.MVC4.Model.SYS_ReceiveMessage2012 model = new TDTK.PlatForm.MVC4.Model.SYS_ReceiveMessage2012();
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

        public Model.SYS_ReceiveMessage2012 DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.SYS_ReceiveMessage2012 model = new TDTK.PlatForm.MVC4.Model.SYS_ReceiveMessage2012();
            if (row != null)
            {
                if (row["RMID"] != null && row["RMID"].ToString() != "")
                {
                    model.RMID = int.Parse(row["RMID"].ToString());
                }
                if (row["PhoneNumber"] != null)
                {
                    model.PhoneNumber = row["PhoneNumber"].ToString();
                }
                if (row["MContent"] != null)
                {
                    model.MContent = row["MContent"].ToString();
                }
                if (row["ReceiveDate"] != null && row["ReceiveDate"].ToString() != "")
                {
                    model.ReceiveDate = DateTime.Parse(row["ReceiveDate"].ToString());
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RMID,PhoneNumber,MContent,ReceiveDate ");
            strSql.Append(" FROM SYS_ReceiveMessage2012 ");
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
            strSql.Append(" RMID,PhoneNumber,MContent,ReceiveDate ");
            strSql.Append(" FROM SYS_ReceiveMessage2012 ");
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
            strSql.Append("select count(1) FROM SYS_ReceiveMessage2012 ");
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
                strSql.Append("order by T.RMID desc");
            }
            strSql.Append(")AS Row, T.*  from SYS_ReceiveMessage2012 T ");
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
