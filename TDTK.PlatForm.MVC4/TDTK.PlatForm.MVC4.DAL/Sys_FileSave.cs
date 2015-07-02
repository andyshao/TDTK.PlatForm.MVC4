using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.DBUtility;
using TDTK.PlatForm.MVC4.Model;
using System.Data.SqlClient;
using System.Data;

namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:Sys_FileSave
    /// </summary>
    public partial class Sys_FileSave : ISys_FileSave
    {
        public Sys_FileSave()
        { }


        public bool Exists(Model.Sys_FileSave t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_FileSave");
            strSql.Append(" where FileCode=@FileCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@FileCode", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.FileCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_FileSave t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_FileSave(");
            strSql.Append("FileCode,FileName,FilePath,FileSize,FileType,FileContent)");
            strSql.Append(" values (");
            strSql.Append("@FileCode,@FileName,@FilePath,@FileSize,@FileType,@FileContent)");
            SqlParameter[] parameters = {
					new SqlParameter("@FileCode", SqlDbType.VarChar,32),
					new SqlParameter("@FileName", SqlDbType.NVarChar,50),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@FileSize", SqlDbType.Decimal,9),
					new SqlParameter("@FileType", SqlDbType.VarChar,50),
					new SqlParameter("@FileContent", SqlDbType.Image)};
            parameters[0].Value = t.FileCode;
            parameters[1].Value = t.FileName;
            parameters[2].Value = t.FilePath;
            parameters[3].Value = t.FileSize;
            parameters[4].Value = t.FileType;
            parameters[5].Value = t.FileContent;

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

        public bool Update(Model.Sys_FileSave t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_FileSave set ");
            strSql.Append("FileName=@FileName,");
            strSql.Append("FilePath=@FilePath,");
            strSql.Append("FileSize=@FileSize,");
            strSql.Append("FileType=@FileType,");
            strSql.Append("FileContent=@FileContent");
            strSql.Append(" where FileCode=@FileCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@FileName", SqlDbType.NVarChar,50),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@FileSize", SqlDbType.Decimal,9),
					new SqlParameter("@FileType", SqlDbType.VarChar,50),
					new SqlParameter("@FileContent", SqlDbType.Image),
					new SqlParameter("@FileCode", SqlDbType.VarChar,32)};
            parameters[0].Value = t.FileName;
            parameters[1].Value = t.FilePath;
            parameters[2].Value = t.FileSize;
            parameters[3].Value = t.FileType;
            parameters[4].Value = t.FileContent;
            parameters[5].Value = t.FileCode;

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

        public bool Delete(Model.Sys_FileSave t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_FileSave ");
            strSql.Append(" where FileCode=@FileCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@FileCode", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.FileCode;

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
            strSql.Append("delete from Sys_FileSave ");
            strSql.Append(" where FileCode in (" + IDlist + ")  ");
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

        public Model.Sys_FileSave GetModel(Model.Sys_FileSave t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 FileCode,FileName,FilePath,FileSize,FileType,FileContent from Sys_FileSave ");
            strSql.Append(" where FileCode=@FileCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@FileCode", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.FileCode;

            TDTK.PlatForm.MVC4.Model.Sys_FileSave model = new TDTK.PlatForm.MVC4.Model.Sys_FileSave();
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

        public Model.Sys_FileSave DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_FileSave model = new TDTK.PlatForm.MVC4.Model.Sys_FileSave();
            if (row != null)
            {
                if (row["FileCode"] != null)
                {
                    model.FileCode = row["FileCode"].ToString();
                }
                if (row["FileName"] != null)
                {
                    model.FileName = row["FileName"].ToString();
                }
                if (row["FilePath"] != null)
                {
                    model.FilePath = row["FilePath"].ToString();
                }
                if (row["FileSize"] != null && row["FileSize"].ToString() != "")
                {
                    model.FileSize = decimal.Parse(row["FileSize"].ToString());
                }
                if (row["FileType"] != null)
                {
                    model.FileType = row["FileType"].ToString();
                }
                if (row["FileContent"] != null && row["FileContent"].ToString() != "")
                {
                    model.FileContent = (byte[])row["FileContent"];
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FileCode,FileName,FilePath,FileSize,FileType,FileContent ");
            strSql.Append(" FROM Sys_FileSave ");
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
            strSql.Append(" FileCode,FileName,FilePath,FileSize,FileType,FileContent ");
            strSql.Append(" FROM Sys_FileSave ");
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
            strSql.Append("select count(1) FROM Sys_FileSave ");
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
                strSql.Append("order by T.FileCode desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_FileSave T ");
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
