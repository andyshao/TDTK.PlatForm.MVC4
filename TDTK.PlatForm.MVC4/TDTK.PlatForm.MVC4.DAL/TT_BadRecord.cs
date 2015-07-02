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
    /// 数据访问类:TT_BadRecord
    /// </summary>
    public partial class TT_BadRecord : ITT_BadRecord
    {
        public TT_BadRecord()
        { }

        public bool Exists(Model.TT_BadRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_BadRecord");
            strSql.Append(" where RecordID=@RecordID ");
            SqlParameter[] parameters = {
					new SqlParameter("@RecordID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.RecordID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_BadRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_BadRecord(");
            strSql.Append("RecordID,NavicertCode,RoomCode,CarNo,Decript,BreakDate,AlarmType,AlarmStatus,CollCode,FrontImage,BackImage,UpImage,RoomImage)");
            strSql.Append(" values (");
            strSql.Append("@RecordID,@NavicertCode,@RoomCode,@CarNo,@Decript,@BreakDate,@AlarmType,@AlarmStatus,@CollCode,@FrontImage,@BackImage,@UpImage,@RoomImage)");
            SqlParameter[] parameters = {
					new SqlParameter("@RecordID", SqlDbType.VarChar,32),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@Decript", SqlDbType.NVarChar,200),
					new SqlParameter("@BreakDate", SqlDbType.DateTime),
					new SqlParameter("@AlarmType", SqlDbType.NVarChar,50),
					new SqlParameter("@AlarmStatus", SqlDbType.VarChar,1),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32)};
            parameters[0].Value = t.RecordID;
            parameters[1].Value = t.NavicertCode;
            parameters[2].Value = t.RoomCode;
            parameters[3].Value = t.CarNo;
            parameters[4].Value = t.Decript;
            parameters[5].Value = t.BreakDate;
            parameters[6].Value = t.AlarmType;
            parameters[7].Value = t.AlarmStatus;
            parameters[8].Value = t.CollCode;
            parameters[9].Value = t.FrontImage;
            parameters[10].Value = t.BackImage;
            parameters[11].Value = t.UpImage;
            parameters[12].Value = t.RoomImage;

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

        public bool Update(Model.TT_BadRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_BadRecord set ");
            strSql.Append("NavicertCode=@NavicertCode,");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("Decript=@Decript,");
            strSql.Append("BreakDate=@BreakDate,");
            strSql.Append("AlarmType=@AlarmType,");
            strSql.Append("AlarmStatus=@AlarmStatus,");
            strSql.Append("CollCode=@CollCode,");
            strSql.Append("FrontImage=@FrontImage,");
            strSql.Append("BackImage=@BackImage,");
            strSql.Append("UpImage=@UpImage,");
            strSql.Append("RoomImage=@RoomImage");
            strSql.Append(" where RecordID=@RecordID ");
            SqlParameter[] parameters = {
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@Decript", SqlDbType.NVarChar,200),
					new SqlParameter("@BreakDate", SqlDbType.DateTime),
					new SqlParameter("@AlarmType", SqlDbType.NVarChar,50),
					new SqlParameter("@AlarmStatus", SqlDbType.VarChar,1),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32),
					new SqlParameter("@RecordID", SqlDbType.VarChar,32)};
            parameters[0].Value = t.NavicertCode;
            parameters[1].Value = t.RoomCode;
            parameters[2].Value = t.CarNo;
            parameters[3].Value = t.Decript;
            parameters[4].Value = t.BreakDate;
            parameters[5].Value = t.AlarmType;
            parameters[6].Value = t.AlarmStatus;
            parameters[7].Value = t.CollCode;
            parameters[8].Value = t.FrontImage;
            parameters[9].Value = t.BackImage;
            parameters[10].Value = t.UpImage;
            parameters[11].Value = t.RoomImage;
            parameters[12].Value = t.RecordID;

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

        public bool Delete(Model.TT_BadRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_BadRecord ");
            strSql.Append(" where RecordID=@RecordID ");
            SqlParameter[] parameters = {
					new SqlParameter("@RecordID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.RecordID;

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
            strSql.Append("delete from TT_BadRecord ");
            strSql.Append(" where RecordID in (" + IDlist + ")  ");
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

        public Model.TT_BadRecord GetModel(Model.TT_BadRecord t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 RecordID,NavicertCode,RoomCode,CarNo,Decript,BreakDate,AlarmType,AlarmStatus,CollCode,FrontImage,BackImage,UpImage,RoomImage from TT_BadRecord ");
            strSql.Append(" where RecordID=@RecordID ");
            SqlParameter[] parameters = {
					new SqlParameter("@RecordID", SqlDbType.VarChar,32)			};
            parameters[0].Value = t.RecordID;

            TDTK.PlatForm.MVC4.Model.TT_BadRecord model = new TDTK.PlatForm.MVC4.Model.TT_BadRecord();
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

        public Model.TT_BadRecord DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_BadRecord model = new TDTK.PlatForm.MVC4.Model.TT_BadRecord();
            if (row != null)
            {
                if (row["RecordID"] != null)
                {
                    model.RecordID = row["RecordID"].ToString();
                }
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["CarNo"] != null)
                {
                    model.CarNo = row["CarNo"].ToString();
                }
                if (row["Decript"] != null)
                {
                    model.Decript = row["Decript"].ToString();
                }
                if (row["BreakDate"] != null && row["BreakDate"].ToString() != "")
                {
                    model.BreakDate = DateTime.Parse(row["BreakDate"].ToString());
                }
                if (row["AlarmType"] != null)
                {
                    model.AlarmType = row["AlarmType"].ToString();
                }
                if (row["AlarmStatus"] != null)
                {
                    model.AlarmStatus = row["AlarmStatus"].ToString();
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["FrontImage"] != null)
                {
                    model.FrontImage = row["FrontImage"].ToString();
                }
                if (row["BackImage"] != null)
                {
                    model.BackImage = row["BackImage"].ToString();
                }
                if (row["UpImage"] != null)
                {
                    model.UpImage = row["UpImage"].ToString();
                }
                if (row["RoomImage"] != null)
                {
                    model.RoomImage = row["RoomImage"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RecordID,NavicertCode,RoomCode,CarNo,Decript,BreakDate,AlarmType,AlarmStatus,CollCode,FrontImage,BackImage,UpImage,RoomImage ");
            strSql.Append(" FROM TT_BadRecord ");
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
            strSql.Append(" RecordID,NavicertCode,RoomCode,CarNo,Decript,BreakDate,AlarmType,AlarmStatus,CollCode,FrontImage,BackImage,UpImage,RoomImage ");
            strSql.Append(" FROM TT_BadRecord ");
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
            strSql.Append("select count(1) FROM TT_BadRecord ");
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
                strSql.Append("order by T.RecordID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_BadRecord T ");
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
