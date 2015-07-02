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
    /// 数据访问类:TT_PitheadBillExtend
    /// </summary>
    public partial class TT_PitheadBillExtend : ITT_PitheadBillExtend
    {
        public TT_PitheadBillExtend()
        { }

        public bool Exists(Model.TT_PitheadBillExtend t)
        {
            throw new NotImplementedException();
        }

        public int Add(Model.TT_PitheadBillExtend t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_PitheadBillExtend(");
            strSql.Append("PID,Iedition,CollCode,DrawPerson,PayPerson,ExtendDate)");
            strSql.Append(" values (");
            strSql.Append("@PID,@Iedition,@CollCode,@DrawPerson,@PayPerson,@ExtendDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@PID", SqlDbType.Int,4),
					new SqlParameter("@Iedition", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,4),
					new SqlParameter("@DrawPerson", SqlDbType.VarChar,40),
					new SqlParameter("@PayPerson", SqlDbType.VarChar,40),
					new SqlParameter("@ExtendDate", SqlDbType.DateTime)};
            parameters[0].Value = t.PID;
            parameters[1].Value = t.Iedition;
            parameters[2].Value = t.CollCode;
            parameters[3].Value = t.DrawPerson;
            parameters[4].Value = t.PayPerson;
            parameters[5].Value = t.ExtendDate;

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

        public bool Update(Model.TT_PitheadBillExtend t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_PitheadBillExtend set ");
            strSql.Append("PID=@PID,");
            strSql.Append("Iedition=@Iedition,");
            strSql.Append("CollCode=@CollCode,");
            strSql.Append("DrawPerson=@DrawPerson,");
            strSql.Append("PayPerson=@PayPerson,");
            strSql.Append("ExtendDate=@ExtendDate");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@PID", SqlDbType.Int,4),
					new SqlParameter("@Iedition", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,4),
					new SqlParameter("@DrawPerson", SqlDbType.VarChar,40),
					new SqlParameter("@PayPerson", SqlDbType.VarChar,40),
					new SqlParameter("@ExtendDate", SqlDbType.DateTime)};
            parameters[0].Value = t.PID;
            parameters[1].Value = t.Iedition;
            parameters[2].Value = t.CollCode;
            parameters[3].Value = t.DrawPerson;
            parameters[4].Value = t.PayPerson;
            parameters[5].Value = t.ExtendDate;

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

        public bool Delete(Model.TT_PitheadBillExtend t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_PitheadBillExtend ");
            strSql.Append(" where ");
            strSql.Append("PID=@PID ");
            strSql.Append(" and Iedition=@Iedition and ");
            strSql.Append(" CollCode=@CollCode,");
            SqlParameter[] parameters = {
					new SqlParameter("@PID", SqlDbType.Int,4),
					new SqlParameter("@Iedition", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,4)};

            parameters[0].Value = t.PID;
            parameters[1].Value = t.Iedition;
            parameters[2].Value = t.CollCode;

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

        public Model.TT_PitheadBillExtend GetModel(Model.TT_PitheadBillExtend t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PID,Iedition,CollCode,DrawPerson,PayPerson,ExtendDate from TT_PitheadBillExtend ");
            strSql.Append(" where ");
            strSql.Append("PID=@PID ");
            strSql.Append(" and Iedition=@Iedition and ");
            strSql.Append(" CollCode=@CollCode,");
            SqlParameter[] parameters = {
					new SqlParameter("@PID", SqlDbType.Int,4),
					new SqlParameter("@Iedition", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,4)};

            parameters[0].Value = t.PID;
            parameters[1].Value = t.Iedition;
            parameters[2].Value = t.CollCode;

            TDTK.PlatForm.MVC4.Model.TT_PitheadBillExtend model = new TDTK.PlatForm.MVC4.Model.TT_PitheadBillExtend();
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

        public Model.TT_PitheadBillExtend DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_PitheadBillExtend model = new TDTK.PlatForm.MVC4.Model.TT_PitheadBillExtend();
            if (row != null)
            {
                if (row["PID"] != null && row["PID"].ToString() != "")
                {
                    model.PID = int.Parse(row["PID"].ToString());
                }
                if (row["Iedition"] != null)
                {
                    model.Iedition = row["Iedition"].ToString();
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["DrawPerson"] != null)
                {
                    model.DrawPerson = row["DrawPerson"].ToString();
                }
                if (row["PayPerson"] != null)
                {
                    model.PayPerson = row["PayPerson"].ToString();
                }
                if (row["ExtendDate"] != null && row["ExtendDate"].ToString() != "")
                {
                    model.ExtendDate = DateTime.Parse(row["ExtendDate"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PID,Iedition,CollCode,DrawPerson,PayPerson,ExtendDate ");
            strSql.Append(" FROM TT_PitheadBillExtend ");
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
            strSql.Append(" PID,Iedition,CollCode,DrawPerson,PayPerson,ExtendDate ");
            strSql.Append(" FROM TT_PitheadBillExtend ");
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
            strSql.Append("select count(1) FROM TT_PitheadBillExtend ");
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
                strSql.Append("order by T.PitheadCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_PitheadBillExtend T ");
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
