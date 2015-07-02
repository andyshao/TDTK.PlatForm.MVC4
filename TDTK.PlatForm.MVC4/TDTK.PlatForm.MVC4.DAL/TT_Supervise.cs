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
    /// 数据访问类:TT_Supervise
    /// </summary>
    public partial class TT_Supervise : ITT_Supervise
    {
        public TT_Supervise()
        { }

        public bool Exists(Model.TT_Supervise t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_Supervise");
            strSql.Append(" where SCode=@SCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@SCode", SqlDbType.VarChar,4)			};
            parameters[0].Value = t.SCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_Supervise t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_Supervise(");
            strSql.Append("SCode,MCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid)");
            strSql.Append(" values (");
            strSql.Append("@SCode,@MCode,@MPName,@PhoneNumber,@ReceiveTypeCode,@IsForBid)");
            SqlParameter[] parameters = {
					new SqlParameter("@SCode", SqlDbType.VarChar,4),
					new SqlParameter("@MCode", SqlDbType.VarChar,4),
					new SqlParameter("@MPName", SqlDbType.NVarChar,20),
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,13),
					new SqlParameter("@ReceiveTypeCode", SqlDbType.VarChar,2),
					new SqlParameter("@IsForBid", SqlDbType.VarChar,1)};
            parameters[0].Value = t.SCode;
            parameters[1].Value = t.MCode;
            parameters[2].Value = t.MPName;
            parameters[3].Value = t.PhoneNumber;
            parameters[4].Value = t.ReceiveTypeCode;
            parameters[5].Value = t.IsForBid;

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

        public bool Update(Model.TT_Supervise t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_Supervise set ");
            strSql.Append("MCode=@MCode,");
            strSql.Append("MPName=@MPName,");
            strSql.Append("PhoneNumber=@PhoneNumber,");
            strSql.Append("ReceiveTypeCode=@ReceiveTypeCode,");
            strSql.Append("IsForBid=@IsForBid");
            strSql.Append(" where SCode=@SCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@MCode", SqlDbType.VarChar,4),
					new SqlParameter("@MPName", SqlDbType.NVarChar,20),
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,13),
					new SqlParameter("@ReceiveTypeCode", SqlDbType.VarChar,2),
					new SqlParameter("@IsForBid", SqlDbType.VarChar,1),
					new SqlParameter("@SCode", SqlDbType.VarChar,4)};
            parameters[0].Value = t.MCode;
            parameters[1].Value = t.MPName;
            parameters[2].Value = t.PhoneNumber;
            parameters[3].Value = t.ReceiveTypeCode;
            parameters[4].Value = t.IsForBid;
            parameters[5].Value = t.SCode;

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

        public bool Delete(Model.TT_Supervise t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_Supervise ");
            strSql.Append(" where SCode=@SCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@SCode", SqlDbType.VarChar,4)			};
            parameters[0].Value = t.SCode;

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
            strSql.Append("delete from TT_Supervise ");
            strSql.Append(" where SCode in (" + IDlist + ")  ");
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

        public Model.TT_Supervise GetModel(Model.TT_Supervise t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SCode,MCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid from TT_Supervise ");
            strSql.Append(" where SCode=@SCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@SCode", SqlDbType.VarChar,4)			};
            parameters[0].Value = t.SCode;

            TDTK.PlatForm.MVC4.Model.TT_Supervise model = new TDTK.PlatForm.MVC4.Model.TT_Supervise();
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

        public Model.TT_Supervise DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_Supervise model = new TDTK.PlatForm.MVC4.Model.TT_Supervise();
            if (row != null)
            {
                if (row["SCode"] != null)
                {
                    model.SCode = row["SCode"].ToString();
                }
                if (row["MCode"] != null)
                {
                    model.MCode = row["MCode"].ToString();
                }
                if (row["MPName"] != null)
                {
                    model.MPName = row["MPName"].ToString();
                }
                if (row["PhoneNumber"] != null)
                {
                    model.PhoneNumber = row["PhoneNumber"].ToString();
                }
                if (row["ReceiveTypeCode"] != null)
                {
                    model.ReceiveTypeCode = row["ReceiveTypeCode"].ToString();
                }
                if (row["IsForBid"] != null)
                {
                    model.IsForBid = row["IsForBid"].ToString();
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
            strSql.Append("select SCode,MCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid ");
            strSql.Append(" FROM TT_Supervise ");
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
            strSql.Append(" SCode,MCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid ");
            strSql.Append(" FROM TT_Supervise ");
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
            strSql.Append("select count(1) FROM TT_Supervise ");
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
                strSql.Append("order by T.SCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_Supervise T ");
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
