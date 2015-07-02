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
    /// 数据访问类:TT_Navicert
    /// </summary>
    public partial class TT_Navicert : ITT_Navicert
    {
        public TT_Navicert()
        { }

        public bool Exists(Model.TT_Navicert t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_Navicert");
            strSql.Append(" where NavicertCode=@NavicertCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.NavicertCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_Navicert t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_Navicert(");
            strSql.Append("NavicertCode,RoomCode,CarCode,CarNo,CarType,CarOwnerName,CarOwnerPhone,CarOwnerIDCard,MostWeight,EmptyWeight,NavicertState,CardType,StartTime,EndTime,SendPerson,ClaimPersonName,IsForbid,Remark,NavicertNo)");
            strSql.Append(" values (");
            strSql.Append("@NavicertCode,@RoomCode,@CarCode,@CarNo,@CarType,@CarOwnerName,@CarOwnerPhone,@CarOwnerIDCard,@MostWeight,@EmptyWeight,@NavicertState,@CardType,@StartTime,@EndTime,@SendPerson,@ClaimPersonName,@IsForbid,@Remark,@NavicertNo)");
            SqlParameter[] parameters = {
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CarCode", SqlDbType.VarChar,20),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CarType", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@MostWeight", SqlDbType.Decimal,9),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@NavicertState", SqlDbType.VarChar,1),
					new SqlParameter("@CardType", SqlDbType.VarChar,1),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@SendPerson", SqlDbType.NVarChar,20),
					new SqlParameter("@ClaimPersonName", SqlDbType.NVarChar,20),
					new SqlParameter("@IsForbid", SqlDbType.Char,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@NavicertNo", SqlDbType.VarChar,20)};
            parameters[0].Value = t.NavicertCode;
            parameters[1].Value = t.RoomCode;
            parameters[2].Value = t.CarCode;
            parameters[3].Value = t.CarNo;
            parameters[4].Value = t.CarType;
            parameters[5].Value = t.CarOwnerName;
            parameters[6].Value = t.CarOwnerPhone;
            parameters[7].Value = t.CarOwnerIDCard;
            parameters[8].Value = t.MostWeight;
            parameters[9].Value = t.EmptyWeight;
            parameters[10].Value = t.NavicertState;
            parameters[11].Value = t.CardType;
            parameters[12].Value = t.StartTime;
            parameters[13].Value = t.EndTime;
            parameters[14].Value = t.SendPerson;
            parameters[15].Value = t.ClaimPersonName;
            parameters[16].Value = t.IsForbid;
            parameters[17].Value = t.Remark;
            parameters[18].Value = t.NavicertNo;

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

        public bool Update(Model.TT_Navicert t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_Navicert set ");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("CarCode=@CarCode,");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("CarType=@CarType,");
            strSql.Append("CarOwnerName=@CarOwnerName,");
            strSql.Append("CarOwnerPhone=@CarOwnerPhone,");
            strSql.Append("CarOwnerIDCard=@CarOwnerIDCard,");
            strSql.Append("MostWeight=@MostWeight,");
            strSql.Append("EmptyWeight=@EmptyWeight,");
            strSql.Append("NavicertState=@NavicertState,");
            strSql.Append("CardType=@CardType,");
            strSql.Append("StartTime=@StartTime,");
            strSql.Append("EndTime=@EndTime,");
            strSql.Append("SendPerson=@SendPerson,");
            strSql.Append("ClaimPersonName=@ClaimPersonName,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("NavicertNo=@NavicertNo");
            strSql.Append(" where NavicertCode=@NavicertCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CarCode", SqlDbType.VarChar,20),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CarType", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@MostWeight", SqlDbType.Decimal,9),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@NavicertState", SqlDbType.VarChar,1),
					new SqlParameter("@CardType", SqlDbType.VarChar,1),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@SendPerson", SqlDbType.NVarChar,20),
					new SqlParameter("@ClaimPersonName", SqlDbType.NVarChar,20),
					new SqlParameter("@IsForbid", SqlDbType.Char,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@NavicertNo", SqlDbType.VarChar,20),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20)};
            parameters[0].Value = t.RoomCode;
            parameters[1].Value = t.CarCode;
            parameters[2].Value = t.CarNo;
            parameters[3].Value = t.CarType;
            parameters[4].Value = t.CarOwnerName;
            parameters[5].Value = t.CarOwnerPhone;
            parameters[6].Value = t.CarOwnerIDCard;
            parameters[7].Value = t.MostWeight;
            parameters[8].Value = t.EmptyWeight;
            parameters[9].Value = t.NavicertState;
            parameters[10].Value = t.CardType;
            parameters[11].Value = t.StartTime;
            parameters[12].Value = t.EndTime;
            parameters[13].Value = t.SendPerson;
            parameters[14].Value = t.ClaimPersonName;
            parameters[15].Value = t.IsForbid;
            parameters[16].Value = t.Remark;
            parameters[17].Value = t.NavicertNo;
            parameters[18].Value = t.NavicertCode;

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

        public bool Delete(Model.TT_Navicert t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_Navicert ");
            strSql.Append(" where NavicertCode=@NavicertCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.NavicertCode;

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
            strSql.Append("delete from TT_Navicert ");
            strSql.Append(" where NavicertCode in (" + IDlist + ")  ");
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

        public Model.TT_Navicert GetModel(Model.TT_Navicert t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 NavicertCode,RoomCode,CarCode,CarNo,CarType,CarOwnerName,CarOwnerPhone,CarOwnerIDCard,MostWeight,EmptyWeight,NavicertState,CardType,StartTime,EndTime,SendPerson,ClaimPersonName,IsForbid,Remark,NavicertNo from TT_Navicert ");
            strSql.Append(" where NavicertCode=@NavicertCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.NavicertCode;

            TDTK.PlatForm.MVC4.Model.TT_Navicert model = new TDTK.PlatForm.MVC4.Model.TT_Navicert();
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

        public Model.TT_Navicert DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_Navicert model = new TDTK.PlatForm.MVC4.Model.TT_Navicert();
            if (row != null)
            {
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["CarCode"] != null)
                {
                    model.CarCode = row["CarCode"].ToString();
                }
                if (row["CarNo"] != null)
                {
                    model.CarNo = row["CarNo"].ToString();
                }
                if (row["CarType"] != null)
                {
                    model.CarType = row["CarType"].ToString();
                }
                if (row["CarOwnerName"] != null)
                {
                    model.CarOwnerName = row["CarOwnerName"].ToString();
                }
                if (row["CarOwnerPhone"] != null)
                {
                    model.CarOwnerPhone = row["CarOwnerPhone"].ToString();
                }
                if (row["CarOwnerIDCard"] != null)
                {
                    model.CarOwnerIDCard = row["CarOwnerIDCard"].ToString();
                }
                if (row["MostWeight"] != null && row["MostWeight"].ToString() != "")
                {
                    model.MostWeight = decimal.Parse(row["MostWeight"].ToString());
                }
                if (row["EmptyWeight"] != null && row["EmptyWeight"].ToString() != "")
                {
                    model.EmptyWeight = decimal.Parse(row["EmptyWeight"].ToString());
                }
                if (row["NavicertState"] != null)
                {
                    model.NavicertState = row["NavicertState"].ToString();
                }
                if (row["CardType"] != null)
                {
                    model.CardType = row["CardType"].ToString();
                }
                if (row["StartTime"] != null && row["StartTime"].ToString() != "")
                {
                    model.StartTime = DateTime.Parse(row["StartTime"].ToString());
                }
                if (row["EndTime"] != null && row["EndTime"].ToString() != "")
                {
                    model.EndTime = DateTime.Parse(row["EndTime"].ToString());
                }
                if (row["SendPerson"] != null)
                {
                    model.SendPerson = row["SendPerson"].ToString();
                }
                if (row["ClaimPersonName"] != null)
                {
                    model.ClaimPersonName = row["ClaimPersonName"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["NavicertNo"] != null)
                {
                    model.NavicertNo = row["NavicertNo"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NavicertCode,RoomCode,CarCode,CarNo,CarType,CarOwnerName,CarOwnerPhone,CarOwnerIDCard,MostWeight,EmptyWeight,NavicertState,CardType,StartTime,EndTime,SendPerson,ClaimPersonName,IsForbid,Remark,NavicertNo ");
            strSql.Append(" FROM TT_Navicert ");
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
            strSql.Append(" NavicertCode,RoomCode,CarCode,CarNo,CarType,CarOwnerName,CarOwnerPhone,CarOwnerIDCard,MostWeight,EmptyWeight,NavicertState,CardType,StartTime,EndTime,SendPerson,ClaimPersonName,IsForbid,Remark,NavicertNo ");
            strSql.Append(" FROM TT_Navicert ");
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
            strSql.Append("select count(1) FROM TT_Navicert ");
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
                strSql.Append("order by T.NavicertCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_Navicert T ");
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
