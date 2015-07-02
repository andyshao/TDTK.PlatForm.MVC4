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
    /// 数据访问类:TT_Room
    /// </summary>
    public partial class TT_Room : ITT_Room
    {
        public TT_Room()
        { }

        public bool Exists(Model.TT_Room t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_Room");
            strSql.Append(" where RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.RoomCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_Room t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_Room(");
            strSql.Append("RoomCode,VillageCode,RoomName,Principal,Telephone,TransportModel,RoomType,RoomIp,OnOff,OffLineTime,OffLineBegin,CollCode,IsForbid,Remark)");
            strSql.Append(" values (");
            strSql.Append("@RoomCode,@VillageCode,@RoomName,@Principal,@Telephone,@TransportModel,@RoomType,@RoomIp,@OnOff,@OffLineTime,@OffLineBegin,@CollCode,@IsForbid,@Remark)");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@VillageCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomName", SqlDbType.NVarChar,50),
					new SqlParameter("@Principal", SqlDbType.NVarChar,20),
					new SqlParameter("@Telephone", SqlDbType.NVarChar,20),
					new SqlParameter("@TransportModel", SqlDbType.NVarChar,50),
					new SqlParameter("@RoomType", SqlDbType.VarChar,1),
					new SqlParameter("@RoomIp", SqlDbType.VarChar,20),
					new SqlParameter("@OnOff", SqlDbType.VarChar,1),
					new SqlParameter("@OffLineTime", SqlDbType.Decimal,9),
					new SqlParameter("@OffLineBegin", SqlDbType.DateTime),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
            parameters[0].Value = t.RoomCode;
            parameters[1].Value = t.VillageCode;
            parameters[2].Value = t.RoomName;
            parameters[3].Value = t.Principal;
            parameters[4].Value = t.Telephone;
            parameters[5].Value = t.TransportModel;
            parameters[6].Value = t.RoomType;
            parameters[7].Value = t.RoomIp;
            parameters[8].Value = t.OnOff;
            parameters[9].Value = t.OffLineTime;
            parameters[10].Value = t.OffLineBegin;
            parameters[11].Value = t.CollCode;
            parameters[12].Value = t.IsForbid;
            parameters[13].Value = t.Remark;

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

        public bool Update(Model.TT_Room t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_Room set ");
            strSql.Append("VillageCode=@VillageCode,");
            strSql.Append("RoomName=@RoomName,");
            strSql.Append("Principal=@Principal,");
            strSql.Append("Telephone=@Telephone,");
            strSql.Append("TransportModel=@TransportModel,");
            strSql.Append("RoomType=@RoomType,");
            strSql.Append("RoomIp=@RoomIp,");
            strSql.Append("OnOff=@OnOff,");
            strSql.Append("OffLineTime=@OffLineTime,");
            strSql.Append("OffLineBegin=@OffLineBegin,");
            strSql.Append("CollCode=@CollCode,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@VillageCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomName", SqlDbType.NVarChar,50),
					new SqlParameter("@Principal", SqlDbType.NVarChar,20),
					new SqlParameter("@Telephone", SqlDbType.NVarChar,20),
					new SqlParameter("@TransportModel", SqlDbType.NVarChar,50),
					new SqlParameter("@RoomType", SqlDbType.VarChar,1),
					new SqlParameter("@RoomIp", SqlDbType.VarChar,20),
					new SqlParameter("@OnOff", SqlDbType.VarChar,1),
					new SqlParameter("@OffLineTime", SqlDbType.Decimal,9),
					new SqlParameter("@OffLineBegin", SqlDbType.DateTime),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.VillageCode;
            parameters[1].Value = t.RoomName;
            parameters[2].Value = t.Principal;
            parameters[3].Value = t.Telephone;
            parameters[4].Value = t.TransportModel;
            parameters[5].Value = t.RoomType;
            parameters[6].Value = t.RoomIp;
            parameters[7].Value = t.OnOff;
            parameters[8].Value = t.OffLineTime;
            parameters[9].Value = t.OffLineBegin;
            parameters[10].Value = t.CollCode;
            parameters[11].Value = t.IsForbid;
            parameters[12].Value = t.Remark;
            parameters[13].Value = t.RoomCode;

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

        public bool Delete(Model.TT_Room t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_Room ");
            strSql.Append(" where RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.RoomCode;

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
            strSql.Append("delete from TT_Room ");
            strSql.Append(" where RoomCode in (" + IDlist + ")  ");
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

        public Model.TT_Room GetModel(Model.TT_Room t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 RoomCode,VillageCode,RoomName,Principal,Telephone,TransportModel,RoomType,RoomIp,OnOff,OffLineTime,OffLineBegin,CollCode,IsForbid,Remark from TT_Room ");
            strSql.Append(" where RoomCode=@RoomCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10)			};
            parameters[0].Value = t.RoomCode;

            TDTK.PlatForm.MVC4.Model.TT_Room model = new TDTK.PlatForm.MVC4.Model.TT_Room();
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

        public Model.TT_Room DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_Room model = new TDTK.PlatForm.MVC4.Model.TT_Room();
            if (row != null)
            {
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["VillageCode"] != null)
                {
                    model.VillageCode = row["VillageCode"].ToString();
                }
                if (row["RoomName"] != null)
                {
                    model.RoomName = row["RoomName"].ToString();
                }
                if (row["Principal"] != null)
                {
                    model.Principal = row["Principal"].ToString();
                }
                if (row["Telephone"] != null)
                {
                    model.Telephone = row["Telephone"].ToString();
                }
                if (row["TransportModel"] != null)
                {
                    model.TransportModel = row["TransportModel"].ToString();
                }
                if (row["RoomType"] != null)
                {
                    model.RoomType = row["RoomType"].ToString();
                }
                if (row["RoomIp"] != null)
                {
                    model.RoomIp = row["RoomIp"].ToString();
                }
                if (row["OnOff"] != null)
                {
                    model.OnOff = row["OnOff"].ToString();
                }
                if (row["OffLineTime"] != null && row["OffLineTime"].ToString() != "")
                {
                    model.OffLineTime = decimal.Parse(row["OffLineTime"].ToString());
                }
                if (row["OffLineBegin"] != null && row["OffLineBegin"].ToString() != "")
                {
                    model.OffLineBegin = DateTime.Parse(row["OffLineBegin"].ToString());
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RoomCode,VillageCode,RoomName,Principal,Telephone,TransportModel,RoomType,RoomIp,OnOff,OffLineTime,OffLineBegin,CollCode,IsForbid,Remark ");
            strSql.Append(" FROM TT_Room ");
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
            strSql.Append(" RoomCode,VillageCode,RoomName,Principal,Telephone,TransportModel,RoomType,RoomIp,OnOff,OffLineTime,OffLineBegin,CollCode,IsForbid,Remark ");
            strSql.Append(" FROM TT_Room ");
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
            strSql.Append("select count(1) FROM TT_Room ");
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
                strSql.Append("order by T.RoomCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_Room T ");
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
