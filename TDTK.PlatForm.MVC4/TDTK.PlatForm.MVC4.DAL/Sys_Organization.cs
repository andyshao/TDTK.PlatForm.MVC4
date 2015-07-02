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
    /// 数据访问类:Sys_Organization
    /// </summary>
    public partial class Sys_Organization : ISys_Organization
    {
        public Sys_Organization()
        { }

        public bool Exists(Model.Sys_Organization t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_Organization");
            strSql.Append(" where OrgCode=@OrgCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.OrgCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_Organization t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_Organization(");
            strSql.Append("OrgCode,OrgName,OrgLevel,ParentOrgCode,OrgSeq,OrgType,LinkMan,LinkManTel,Email,IsForbid,Remark,SysCode)");
            strSql.Append(" values (");
            strSql.Append("@OrgCode,@OrgName,@OrgLevel,@ParentOrgCode,@OrgSeq,@OrgType,@LinkMan,@LinkManTel,@Email,@IsForbid,@Remark,@SysCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10),
					new SqlParameter("@OrgName", SqlDbType.NVarChar,50),
					new SqlParameter("@OrgLevel", SqlDbType.VarChar,1),
					new SqlParameter("@ParentOrgCode", SqlDbType.VarChar,10),
					new SqlParameter("@OrgSeq", SqlDbType.NVarChar,300),
					new SqlParameter("@OrgType", SqlDbType.VarChar,1),
					new SqlParameter("@LinkMan", SqlDbType.NVarChar,20),
					new SqlParameter("@LinkManTel", SqlDbType.NVarChar,20),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@SysCode", SqlDbType.VarChar,4)};
            parameters[0].Value = t.OrgCode;
            parameters[1].Value = t.OrgName;
            parameters[2].Value = t.OrgLevel;
            parameters[3].Value = t.ParentOrgCode;
            parameters[4].Value = t.OrgSeq;
            parameters[5].Value = t.OrgType;
            parameters[6].Value = t.LinkMan;
            parameters[7].Value = t.LinkManTel;
            parameters[8].Value = t.Email;
            parameters[9].Value = t.IsForbid;
            parameters[10].Value = t.Remark;
            parameters[11].Value = t.SysCode;

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

        public bool Update(Model.Sys_Organization t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_Organization set ");
            strSql.Append("OrgName=@OrgName,");
            strSql.Append("OrgLevel=@OrgLevel,");
            strSql.Append("ParentOrgCode=@ParentOrgCode,");
            strSql.Append("OrgSeq=@OrgSeq,");
            strSql.Append("OrgType=@OrgType,");
            strSql.Append("LinkMan=@LinkMan,");
            strSql.Append("LinkManTel=@LinkManTel,");
            strSql.Append("Email=@Email,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("SysCode=@SysCode");
            strSql.Append(" where OrgCode=@OrgCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@OrgName", SqlDbType.NVarChar,50),
					new SqlParameter("@OrgLevel", SqlDbType.VarChar,1),
					new SqlParameter("@ParentOrgCode", SqlDbType.VarChar,10),
					new SqlParameter("@OrgSeq", SqlDbType.NVarChar,300),
					new SqlParameter("@OrgType", SqlDbType.VarChar,1),
					new SqlParameter("@LinkMan", SqlDbType.NVarChar,20),
					new SqlParameter("@LinkManTel", SqlDbType.NVarChar,20),
					new SqlParameter("@Email", SqlDbType.NVarChar,100),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@SysCode", SqlDbType.VarChar,4),
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.OrgName;
            parameters[1].Value = t.OrgLevel;
            parameters[2].Value = t.ParentOrgCode;
            parameters[3].Value = t.OrgSeq;
            parameters[4].Value = t.OrgType;
            parameters[5].Value = t.LinkMan;
            parameters[6].Value = t.LinkManTel;
            parameters[7].Value = t.Email;
            parameters[8].Value = t.IsForbid;
            parameters[9].Value = t.Remark;
            parameters[10].Value = t.SysCode;
            parameters[11].Value = t.OrgCode;

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

        public bool Delete(Model.Sys_Organization t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_Organization ");
            strSql.Append(" where OrgCode=@OrgCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.OrgCode;

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
            strSql.Append("delete from Sys_Organization ");
            strSql.Append(" where OrgCode in (" + IDlist + ")  ");
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

        public Model.Sys_Organization GetModel(Model.Sys_Organization t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 OrgCode,OrgName,OrgLevel,ParentOrgCode,OrgSeq,OrgType,LinkMan,LinkManTel,Email,IsForbid,Remark,SysCode from Sys_Organization ");
            strSql.Append(" where OrgCode=@OrgCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.OrgCode;

            TDTK.PlatForm.MVC4.Model.Sys_Organization model = new TDTK.PlatForm.MVC4.Model.Sys_Organization();
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

        public Model.Sys_Organization DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_Organization model = new TDTK.PlatForm.MVC4.Model.Sys_Organization();
            if (row != null)
            {
                if (row["OrgCode"] != null)
                {
                    model.OrgCode = row["OrgCode"].ToString();
                }
                if (row["OrgName"] != null)
                {
                    model.OrgName = row["OrgName"].ToString();
                }
                if (row["OrgLevel"] != null)
                {
                    model.OrgLevel = row["OrgLevel"].ToString();
                }
                if (row["ParentOrgCode"] != null)
                {
                    model.ParentOrgCode = row["ParentOrgCode"].ToString();
                }
                if (row["OrgSeq"] != null)
                {
                    model.OrgSeq = row["OrgSeq"].ToString();
                }
                if (row["OrgType"] != null)
                {
                    model.OrgType = row["OrgType"].ToString();
                }
                if (row["LinkMan"] != null)
                {
                    model.LinkMan = row["LinkMan"].ToString();
                }
                if (row["LinkManTel"] != null)
                {
                    model.LinkManTel = row["LinkManTel"].ToString();
                }
                if (row["Email"] != null)
                {
                    model.Email = row["Email"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["SysCode"] != null)
                {
                    model.SysCode = row["SysCode"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OrgCode,OrgName,OrgLevel,ParentOrgCode,OrgSeq,OrgType,LinkMan,LinkManTel,Email,IsForbid,Remark,SysCode ");
            strSql.Append(" FROM Sys_Organization ");
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
            strSql.Append(" OrgCode,OrgName,OrgLevel,ParentOrgCode,OrgSeq,OrgType,LinkMan,LinkManTel,Email,IsForbid,Remark,SysCode ");
            strSql.Append(" FROM Sys_Organization ");
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
            strSql.Append("select count(1) FROM Sys_Organization ");
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
                strSql.Append("order by T.OrgCode desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_Organization T ");
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
