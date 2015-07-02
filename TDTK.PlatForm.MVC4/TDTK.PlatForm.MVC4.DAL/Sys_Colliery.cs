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
    /// 数据访问类:Sys_Colliery
    /// </summary>
    public partial class Sys_Colliery : ISys_Colliery
    {
        public Sys_Colliery()
        { }


        public bool Exists(Model.Sys_Colliery t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_Colliery");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_Colliery t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_Colliery(");
            strSql.Append("CollCode,CollName,OrgCode,VillageCode,MineOwner,MinePhone,YearOutput,CollState,ImageLicence,ImageRevenue,ImageCompetency,Remark,IsForbid,CollProperty,ParcelCode)");
            strSql.Append(" values (");
            strSql.Append("@CollCode,@CollName,@OrgCode,@VillageCode,@MineOwner,@MinePhone,@YearOutput,@CollState,@ImageLicence,@ImageRevenue,@ImageCompetency,@Remark,@IsForbid,@CollProperty,@ParcelCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollName", SqlDbType.NVarChar,50),
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10),
					new SqlParameter("@VillageCode", SqlDbType.VarChar,10),
					new SqlParameter("@MineOwner", SqlDbType.NVarChar,20),
					new SqlParameter("@MinePhone", SqlDbType.NVarChar,20),
					new SqlParameter("@YearOutput", SqlDbType.Decimal,9),
					new SqlParameter("@CollState", SqlDbType.VarChar,1),
					new SqlParameter("@ImageLicence", SqlDbType.VarChar,32),
					new SqlParameter("@ImageRevenue", SqlDbType.VarChar,32),
					new SqlParameter("@ImageCompetency", SqlDbType.VarChar,32),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@CollProperty", SqlDbType.VarChar,1),
					new SqlParameter("@ParcelCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.CollCode;
            parameters[1].Value = t.CollName;
            parameters[2].Value = t.OrgCode;
            parameters[3].Value = t.VillageCode;
            parameters[4].Value = t.MineOwner;
            parameters[5].Value = t.MinePhone;
            parameters[6].Value = t.YearOutput;
            parameters[7].Value = t.CollState;
            parameters[8].Value = t.ImageLicence;
            parameters[9].Value = t.ImageRevenue;
            parameters[10].Value =t.ImageCompetency;
            parameters[11].Value =t.Remark;
            parameters[12].Value =t.IsForbid;
            parameters[13].Value =t.CollProperty;
            parameters[14].Value =t.ParcelCode;

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

        public bool Update(Model.Sys_Colliery t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_Colliery set ");
            strSql.Append("CollName=@CollName,");
            strSql.Append("OrgCode=@OrgCode,");
            strSql.Append("VillageCode=@VillageCode,");
            strSql.Append("MineOwner=@MineOwner,");
            strSql.Append("MinePhone=@MinePhone,");
            strSql.Append("YearOutput=@YearOutput,");
            strSql.Append("CollState=@CollState,");
            strSql.Append("ImageLicence=@ImageLicence,");
            strSql.Append("ImageRevenue=@ImageRevenue,");
            strSql.Append("ImageCompetency=@ImageCompetency,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("CollProperty=@CollProperty,");
            strSql.Append("ParcelCode=@ParcelCode");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollName", SqlDbType.NVarChar,50),
					new SqlParameter("@OrgCode", SqlDbType.VarChar,10),
					new SqlParameter("@VillageCode", SqlDbType.VarChar,10),
					new SqlParameter("@MineOwner", SqlDbType.NVarChar,20),
					new SqlParameter("@MinePhone", SqlDbType.NVarChar,20),
					new SqlParameter("@YearOutput", SqlDbType.Decimal,9),
					new SqlParameter("@CollState", SqlDbType.VarChar,1),
					new SqlParameter("@ImageLicence", SqlDbType.VarChar,32),
					new SqlParameter("@ImageRevenue", SqlDbType.VarChar,32),
					new SqlParameter("@ImageCompetency", SqlDbType.VarChar,32),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@CollProperty", SqlDbType.VarChar,1),
					new SqlParameter("@ParcelCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.CollName;
            parameters[1].Value = t.OrgCode;
            parameters[2].Value = t.VillageCode;
            parameters[3].Value = t.MineOwner;
            parameters[4].Value = t.MinePhone;
            parameters[5].Value = t.YearOutput;
            parameters[6].Value = t.CollState;
            parameters[7].Value = t.ImageLicence;
            parameters[8].Value = t.ImageRevenue;
            parameters[9].Value = t.ImageCompetency;
            parameters[10].Value = t.Remark;
            parameters[11].Value = t.IsForbid;
            parameters[12].Value = t.CollProperty;
            parameters[13].Value = t.ParcelCode;
            parameters[14].Value = t.CollCode;

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

        public bool Delete(Model.Sys_Colliery t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_Colliery ");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;

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
            strSql.Append("delete from Sys_Colliery ");
            strSql.Append(" where CollCode in (" + IDlist + ")  ");
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

        public Model.Sys_Colliery GetModel(Model.Sys_Colliery t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CollCode,CollName,OrgCode,VillageCode,MineOwner,MinePhone,YearOutput,CollState,ImageLicence,ImageRevenue,ImageCompetency,Remark,IsForbid,CollProperty,ParcelCode from Sys_Colliery ");
            strSql.Append(" where CollCode=@CollCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CollCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.CollCode;

            TDTK.PlatForm.MVC4.Model.Sys_Colliery model = new TDTK.PlatForm.MVC4.Model.Sys_Colliery();
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

        public Model.Sys_Colliery DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_Colliery model = new TDTK.PlatForm.MVC4.Model.Sys_Colliery();
            if (row != null)
            {
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["CollName"] != null)
                {
                    model.CollName = row["CollName"].ToString();
                }
                if (row["OrgCode"] != null)
                {
                    model.OrgCode = row["OrgCode"].ToString();
                }
                if (row["VillageCode"] != null)
                {
                    model.VillageCode = row["VillageCode"].ToString();
                }
                if (row["MineOwner"] != null)
                {
                    model.MineOwner = row["MineOwner"].ToString();
                }
                if (row["MinePhone"] != null)
                {
                    model.MinePhone = row["MinePhone"].ToString();
                }
                if (row["YearOutput"] != null && row["YearOutput"].ToString() != "")
                {
                    model.YearOutput = decimal.Parse(row["YearOutput"].ToString());
                }
                if (row["CollState"] != null)
                {
                    model.CollState = row["CollState"].ToString();
                }
                if (row["ImageLicence"] != null)
                {
                    model.ImageLicence = row["ImageLicence"].ToString();
                }
                if (row["ImageRevenue"] != null)
                {
                    model.ImageRevenue = row["ImageRevenue"].ToString();
                }
                if (row["ImageCompetency"] != null)
                {
                    model.ImageCompetency = row["ImageCompetency"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["CollProperty"] != null)
                {
                    model.CollProperty = row["CollProperty"].ToString();
                }
                if (row["ParcelCode"] != null)
                {
                    model.ParcelCode = row["ParcelCode"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CollCode,CollName,OrgCode,VillageCode,MineOwner,MinePhone,YearOutput,CollState,ImageLicence,ImageRevenue,ImageCompetency,Remark,IsForbid,CollProperty,ParcelCode ");
            strSql.Append(" FROM Sys_Colliery ");
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
            strSql.Append(" CollCode,CollName,OrgCode,VillageCode,MineOwner,MinePhone,YearOutput,CollState,ImageLicence,ImageRevenue,ImageCompetency,Remark,IsForbid,CollProperty,ParcelCode ");
            strSql.Append(" FROM Sys_Colliery ");
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
            strSql.Append("select count(1) FROM Sys_Colliery ");
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
                strSql.Append("order by T.CollCode desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_Colliery T ");
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
