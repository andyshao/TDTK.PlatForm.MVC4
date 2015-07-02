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
    /// 数据访问类:TT_MessagePerson
    /// </summary>
    public partial class TT_MessagePerson : ITT_MessagePerson
    {
        public TT_MessagePerson()
        { }

        public bool Exists(Model.TT_MessagePerson t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_MessagePerson");
            strSql.Append(" where MCode=@MCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@MCode", SqlDbType.VarChar,4)			};
            parameters[0].Value = t.MCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_MessagePerson t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_MessagePerson(");
            strSql.Append("MCode,TypeCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid)");
            strSql.Append(" values (");
            strSql.Append("@MCode,@TypeCode,@MPName,@PhoneNumber,@ReceiveTypeCode,@IsForBid)");
            SqlParameter[] parameters = {
					new SqlParameter("@MCode", SqlDbType.VarChar,4),
					new SqlParameter("@TypeCode", SqlDbType.VarChar,1),
					new SqlParameter("@MPName", SqlDbType.NVarChar,20),
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,13),
					new SqlParameter("@ReceiveTypeCode", SqlDbType.VarChar,2),
					new SqlParameter("@IsForBid", SqlDbType.VarChar,1)};
            parameters[0].Value = t.MCode;
            parameters[1].Value = t.TypeCode;
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

        public bool Update(Model.TT_MessagePerson t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_MessagePerson set ");
            strSql.Append("TypeCode=@TypeCode,");
            strSql.Append("MPName=@MPName,");
            strSql.Append("PhoneNumber=@PhoneNumber,");
            strSql.Append("ReceiveTypeCode=@ReceiveTypeCode,");
            strSql.Append("IsForBid=@IsForBid");
            strSql.Append(" where MCode=@MCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TypeCode", SqlDbType.VarChar,1),
					new SqlParameter("@MPName", SqlDbType.NVarChar,20),
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,13),
					new SqlParameter("@ReceiveTypeCode", SqlDbType.VarChar,2),
					new SqlParameter("@IsForBid", SqlDbType.VarChar,1),
					new SqlParameter("@MCode", SqlDbType.VarChar,4)};
            parameters[0].Value = t.TypeCode;
            parameters[1].Value = t.MPName;
            parameters[2].Value = t.PhoneNumber;
            parameters[3].Value = t.ReceiveTypeCode;
            parameters[4].Value = t.IsForBid;
            parameters[5].Value = t.MCode;

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

        public bool Delete(Model.TT_MessagePerson t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_MessagePerson ");
            strSql.Append(" where MCode=@MCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@MCode", SqlDbType.VarChar,4)			};
            parameters[0].Value = t.MCode;

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
            strSql.Append("delete from TT_MessagePerson ");
            strSql.Append(" where MCode in (" + IDlist + ")  ");
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

        public Model.TT_MessagePerson GetModel(Model.TT_MessagePerson t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MCode,TypeCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid from TT_MessagePerson ");
            strSql.Append(" where MCode=@MCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@MCode", SqlDbType.VarChar,4)			};
            parameters[0].Value = t.MCode;

            TDTK.PlatForm.MVC4.Model.TT_MessagePerson model = new TDTK.PlatForm.MVC4.Model.TT_MessagePerson();
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

        public Model.TT_MessagePerson DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_MessagePerson model = new TDTK.PlatForm.MVC4.Model.TT_MessagePerson();
            if (row != null)
            {
                if (row["MCode"] != null)
                {
                    model.MCode = row["MCode"].ToString();
                }
                if (row["TypeCode"] != null)
                {
                    model.TypeCode = row["TypeCode"].ToString();
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

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MCode,TypeCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid ");
            strSql.Append(" FROM TT_MessagePerson ");
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
            strSql.Append(" MCode,TypeCode,MPName,PhoneNumber,ReceiveTypeCode,IsForBid ");
            strSql.Append(" FROM TT_MessagePerson ");
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
            strSql.Append("select count(1) FROM TT_MessagePerson ");
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
                strSql.Append("order by T.MCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_MessagePerson T ");
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
