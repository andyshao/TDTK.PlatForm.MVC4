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
    /// 数据访问类:Sys_Operator
    /// </summary>
    public partial class Sys_Operator : ISys_Operator
    {
        public Sys_Operator()
        { }

        /// <summary>
        /// 获取该用户下的所有职位信息，以字符串形式返回。每个职位以逗号分隔
        /// </summary>
        /// <param name="userID">用户id</param>
        /// <returns></returns>
        public string GetPosition(int userID)
        {
            try
            {
                string strsql = "SELECT * FROM SYS_OperatorPosition WHERE UserCode=" + userID + "";
                DataSet ds = DbHelperSQL.Query(strsql);
                StringBuilder strb = new StringBuilder();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        strb.Append(ds.Tables[0].Rows[i]["PositonCode"].ToString() + ",");
                    }
                    return strb.ToString().TrimEnd(',');
                }
                else
                {
                    return "'0'";
                }
            }
            catch
            {
                return "'0'";
            }
        }

        public bool Exists(Model.Sys_Operator t)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select count(1) from Sys_Operator");
            stringBuilder.Append(" where usercode=@usercode");
            SqlParameter[] sqlParmeter = { 
                                         new SqlParameter("@usercode",t.UserCode)
                                         };
            return DbHelperSQL.Exists(stringBuilder.ToString(), sqlParmeter);

        }

        public int Add(Model.Sys_Operator t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into Sys_Operator (");
            strSql.Append("UserCode,UserName,Password,IsForbid,OrgCode,Tel,Email,Address,ZipCode,PID,Gender,RegDate,MobileNo,TypeCode,IsChangePwd)");
            strSql.Append(" values (");
            strSql.Append("@UserCode,@UserName,@Password,@IsForbid,@OrgCode,@Tel,@Email,@Address,@ZipCode,@PID,@Gender,@RegDate,@MobileNo,@TypeCode,@IsChangePwd)");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10),
					new SqlParameter("@UserName", SqlDbType.NVarChar,20),
					new SqlParameter("@Password", SqlDbType.NVarChar,50),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10),
					new SqlParameter("@Tel", SqlDbType.NVarChar,20),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,200),
					new SqlParameter("@ZipCode", SqlDbType.VarChar,10),
					new SqlParameter("@PID", SqlDbType.VarChar,18),
					new SqlParameter("@Gender", SqlDbType.NVarChar,4),
					new SqlParameter("@RegDate", SqlDbType.DateTime),
					new SqlParameter("@MobileNo", SqlDbType.NVarChar,20),
					new SqlParameter("@TypeCode", SqlDbType.VarChar,10),
					new SqlParameter("@IsChangePwd", SqlDbType.VarChar,1)};
            parameters[0].Value = t.UserCode;
            parameters[1].Value = t.UserName;
            parameters[2].Value = t.Password;
            parameters[3].Value = t.IsForbid;
            parameters[4].Value = t.OrgCode;
            parameters[5].Value = t.Tel;
            parameters[6].Value = t.Email;
            parameters[7].Value = t.Address;
            parameters[8].Value = t.ZipCode;
            parameters[9].Value = t.PID;
            parameters[10].Value = t.Gender;
            parameters[11].Value = t.RegDate;
            parameters[12].Value = t.MobileNo;
            parameters[13].Value = t.TypeCode;
            parameters[14].Value = t.IsChangePwd;
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

        public bool Update(Model.Sys_Operator t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_Operator set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("Password=@Password,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("OrgCode=@OrgCode,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("Email=@Email,");
            strSql.Append("Address=@Address,");
            strSql.Append("ZipCode=@ZipCode,");
            strSql.Append("PID=@PID,");
            strSql.Append("Gender=@Gender,");
            strSql.Append("RegDate=@RegDate,");
            strSql.Append("MobileNo=@MobileNo,");
            strSql.Append("TypeCode=@TypeCode,");
            strSql.Append("IsChangePwd=@IsChangePwd");
            strSql.Append(" where UserCode=@UserCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,20),
					new SqlParameter("@Password", SqlDbType.NVarChar,50),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10),
					new SqlParameter("@Tel", SqlDbType.NVarChar,20),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,200),
					new SqlParameter("@ZipCode", SqlDbType.VarChar,10),
					new SqlParameter("@PID", SqlDbType.VarChar,18),
					new SqlParameter("@Gender", SqlDbType.NVarChar,4),
					new SqlParameter("@RegDate", SqlDbType.DateTime),
					new SqlParameter("@MobileNo", SqlDbType.NVarChar,20),
					new SqlParameter("@TypeCode", SqlDbType.VarChar,10),
					new SqlParameter("@IsChangePwd", SqlDbType.VarChar,1),
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.UserName;
            parameters[1].Value = t.Password;
            parameters[2].Value = t.IsForbid;
            parameters[3].Value = t.OrgCode;
            parameters[4].Value = t.Tel;
            parameters[5].Value = t.Email;
            parameters[6].Value = t.Address;
            parameters[7].Value = t.ZipCode;
            parameters[8].Value = t.PID;
            parameters[9].Value = t.Gender;
            parameters[10].Value = t.RegDate;
            parameters[11].Value = t.MobileNo;
            parameters[12].Value = t.TypeCode;
            parameters[13].Value = t.IsChangePwd;
            parameters[14].Value = t.UserCode;

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

        public bool Delete(Model.Sys_Operator t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_Operator ");
            strSql.Append(" where UserCode=@UserCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.UserCode;

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
            strSql.Append("delete from Sys_Operator ");
            strSql.Append(" where UserCode in (" + IDlist + ")  ");
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

        public Model.Sys_Operator GetModel(Model.Sys_Operator t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 UserCode,UserName,Password,IsForbid,OrgCode,Tel,Email,Address,ZipCode,PID,Gender,RegDate,MobileNo,TypeCode,IsChangePwd from Sys_Operator ");
            strSql.Append(" where UserCode=@UserCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.UserCode;

            TDTK.PlatForm.MVC4.Model.Sys_Operator model = new TDTK.PlatForm.MVC4.Model.Sys_Operator();
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

        public Model.Sys_Operator DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_Operator model = new TDTK.PlatForm.MVC4.Model.Sys_Operator();
            if (row != null)
            {
                if (row["UserCode"] != null)
                {
                    model.UserCode = row["UserCode"].ToString();
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["Password"] != null)
                {
                    model.Password = row["Password"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["OrgCode"] != null)
                {
                    model.OrgCode = row["OrgCode"].ToString();
                }
                if (row["Tel"] != null)
                {
                    model.Tel = row["Tel"].ToString();
                }
                if (row["Email"] != null)
                {
                    model.Email = row["Email"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["ZipCode"] != null)
                {
                    model.ZipCode = row["ZipCode"].ToString();
                }
                if (row["PID"] != null)
                {
                    model.PID = row["PID"].ToString();
                }
                if (row["Gender"] != null)
                {
                    model.Gender = row["Gender"].ToString();
                }
                if (row["RegDate"] != null && row["RegDate"].ToString() != "")
                {
                    model.RegDate = DateTime.Parse(row["RegDate"].ToString());
                }
                if (row["MobileNo"] != null)
                {
                    model.MobileNo = row["MobileNo"].ToString();
                }
                if (row["TypeCode"] != null)
                {
                    model.TypeCode = row["TypeCode"].ToString();
                }
                if (row["IsChangePwd"] != null)
                {
                    model.IsChangePwd = row["IsChangePwd"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserCode,UserName,Password,IsForbid,OrgCode,Tel,Email,Address,ZipCode,PID,Gender,RegDate,MobileNo,TypeCode,IsChangePwd ");
            strSql.Append(" FROM Sys_Operator ");
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
            strSql.Append(" UserCode,UserName,Password,IsForbid,OrgCode,Tel,Email,Address,ZipCode,PID,Gender,RegDate,MobileNo,TypeCode,IsChangePwd ");
            strSql.Append(" FROM Sys_Operator ");
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
            strSql.Append("select count(1) FROM Sys_Operator ");
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
                strSql.Append("order by T.UserCode desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_Operator T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="orderby">排序方式</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        public System.Data.DataSet GetListByPage2(string strWhere, string orderby, int pageIndex, int pageSize)
        {
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            return GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

    }
}
