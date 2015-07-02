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
    /// 数据访问类:TT_PitheadBillDetail
    /// </summary>
    public partial class TT_PitheadBillDetail : ITT_PitheadBillDetail
    {
        public TT_PitheadBillDetail()
        { }

        public bool Exists(Model.TT_PitheadBillDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_PitheadBillDetail");
            strSql.Append(" where PitheadCode=@PitheadCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PitheadCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.PitheadCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_PitheadBillDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_PitheadBillDetail(");
            strSql.Append("PitheadCode,Iedition,SendTime,IsUsed,UseTime,CollCode,KindCode)");
            strSql.Append(" values (");
            strSql.Append("@PitheadCode,@Iedition,@SendTime,@IsUsed,@UseTime,@CollCode,@KindCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@PitheadCode", SqlDbType.VarChar,20),
					new SqlParameter("@Iedition", SqlDbType.VarChar,10),
					new SqlParameter("@SendTime", SqlDbType.DateTime),
					new SqlParameter("@IsUsed", SqlDbType.VarChar,1),
					new SqlParameter("@UseTime", SqlDbType.DateTime),
					new SqlParameter("@CollCode", SqlDbType.VarChar,4),
					new SqlParameter("@KindCode", SqlDbType.VarChar,4)};
            parameters[0].Value = t.PitheadCode;
            parameters[1].Value = t.Iedition;
            parameters[2].Value = t.SendTime;
            parameters[3].Value = t.IsUsed;
            parameters[4].Value = t.UseTime;
            parameters[5].Value = t.CollCode;
            parameters[6].Value = t.KindCode;

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

        public bool Update(Model.TT_PitheadBillDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_PitheadBillDetail set ");
            strSql.Append("Iedition=@Iedition,");
            strSql.Append("SendTime=@SendTime,");
            strSql.Append("IsUsed=@IsUsed,");
            strSql.Append("UseTime=@UseTime,");
            strSql.Append("CollCode=@CollCode,");
            strSql.Append("KindCode=@KindCode");
            strSql.Append(" where PitheadCode=@PitheadCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@Iedition", SqlDbType.VarChar,10),
					new SqlParameter("@SendTime", SqlDbType.DateTime),
					new SqlParameter("@IsUsed", SqlDbType.VarChar,1),
					new SqlParameter("@UseTime", SqlDbType.DateTime),
					new SqlParameter("@CollCode", SqlDbType.VarChar,4),
					new SqlParameter("@KindCode", SqlDbType.VarChar,4),
					new SqlParameter("@PitheadCode", SqlDbType.VarChar,20)};
            parameters[0].Value = t.Iedition;
            parameters[1].Value = t.SendTime;
            parameters[2].Value = t.IsUsed;
            parameters[3].Value = t.UseTime;
            parameters[4].Value = t.CollCode;
            parameters[5].Value = t.KindCode;
            parameters[6].Value = t.PitheadCode;

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

        public bool Delete(Model.TT_PitheadBillDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_PitheadBillDetail ");
            strSql.Append(" where PitheadCode=@PitheadCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PitheadCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.PitheadCode;

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
            strSql.Append("delete from TT_PitheadBillDetail ");
            strSql.Append(" where PitheadCode in (" + IDlist + ")  ");
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

        public Model.TT_PitheadBillDetail GetModel(Model.TT_PitheadBillDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PitheadCode,Iedition,SendTime,IsUsed,UseTime,CollCode,KindCode from TT_PitheadBillDetail ");
            strSql.Append(" where PitheadCode=@PitheadCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@PitheadCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.PitheadCode;

            TDTK.PlatForm.MVC4.Model.TT_PitheadBillDetail model = new TDTK.PlatForm.MVC4.Model.TT_PitheadBillDetail();
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

        public Model.TT_PitheadBillDetail DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_PitheadBillDetail model = new TDTK.PlatForm.MVC4.Model.TT_PitheadBillDetail();
            if (row != null)
            {
                if (row["PitheadCode"] != null)
                {
                    model.PitheadCode = row["PitheadCode"].ToString();
                }
                if (row["Iedition"] != null)
                {
                    model.Iedition = row["Iedition"].ToString();
                }
                if (row["SendTime"] != null && row["SendTime"].ToString() != "")
                {
                    model.SendTime = DateTime.Parse(row["SendTime"].ToString());
                }
                if (row["IsUsed"] != null)
                {
                    model.IsUsed = row["IsUsed"].ToString();
                }
                if (row["UseTime"] != null && row["UseTime"].ToString() != "")
                {
                    model.UseTime = DateTime.Parse(row["UseTime"].ToString());
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["KindCode"] != null)
                {
                    model.KindCode = row["KindCode"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PitheadCode,Iedition,SendTime,IsUsed,UseTime,CollCode,KindCode ");
            strSql.Append(" FROM TT_PitheadBillDetail ");
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
            strSql.Append(" PitheadCode,Iedition,SendTime,IsUsed,UseTime,CollCode,KindCode ");
            strSql.Append(" FROM TT_PitheadBillDetail ");
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
            strSql.Append("select count(1) FROM TT_PitheadBillDetail ");
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
            strSql.Append(")AS Row, T.*  from TT_PitheadBillDetail T ");
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
