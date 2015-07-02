using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.DBUtility;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.Model;


namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:TT_CarInfo
    /// </summary>
    public partial class TT_CarInfo : ITT_CarInfo
    {
        public TT_CarInfo()
        { }

        public bool Exists(Model.TT_CarInfo t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_CarInfo");
            strSql.Append(" where CarCode=@CarCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CarCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.CarCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_CarInfo t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_CarInfo(");
            strSql.Append("CarCode,RemoteCardCode,RoomCode,CarNo,CarType,EmptyWeight,MostWeight,Operator,BangType,RandomCode,EmptyBangTime,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,DriveLicense,CarWidth,CarLength,CarHight,FirstImage,IsAuditing,AuditUser,AuditTime,Remark,DriverName,DriverIDCard,DriverPhone)");
            strSql.Append(" values (");
            strSql.Append("@CarCode,@RemoteCardCode,@RoomCode,@CarNo,@CarType,@EmptyWeight,@MostWeight,@Operator,@BangType,@RandomCode,@EmptyBangTime,@CarOwnerName,@CarOwnerIDCard,@CarOwnerPhone,@DriveLicense,@CarWidth,@CarLength,@CarHight,@FirstImage,@IsAuditing,@AuditUser,@AuditTime,@Remark,@DriverName,@DriverIDCard,@DriverPhone)");
            SqlParameter[] parameters = {
					new SqlParameter("@CarCode", SqlDbType.VarChar,20),
					new SqlParameter("@RemoteCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CarType", SqlDbType.NVarChar,20),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@MostWeight", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@BangType", SqlDbType.NVarChar,20),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4),
					new SqlParameter("@EmptyBangTime", SqlDbType.DateTime),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@DriveLicense", SqlDbType.NVarChar,20),
					new SqlParameter("@CarWidth", SqlDbType.Decimal,9),
					new SqlParameter("@CarLength", SqlDbType.Decimal,9),
					new SqlParameter("@CarHight", SqlDbType.Decimal,9),
					new SqlParameter("@FirstImage", SqlDbType.VarChar,32),
					new SqlParameter("@IsAuditing", SqlDbType.VarChar,1),
					new SqlParameter("@AuditUser", SqlDbType.NVarChar,20),
					new SqlParameter("@AuditTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@DriverName", SqlDbType.NVarChar,20),
					new SqlParameter("@DriverIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@DriverPhone", SqlDbType.NVarChar,20)};
            parameters[0].Value = t.CarCode;
            parameters[1].Value = t.RemoteCardCode;
            parameters[2].Value = t.RoomCode;
            parameters[3].Value = t.CarNo;
            parameters[4].Value = t.CarType;
            parameters[5].Value = t.EmptyWeight;
            parameters[6].Value = t.MostWeight;
            parameters[7].Value = t.Operator;
            parameters[8].Value = t.BangType;
            parameters[9].Value = t.RandomCode;
            parameters[10].Value = t.EmptyBangTime;
            parameters[11].Value = t.CarOwnerName;
            parameters[12].Value = t.CarOwnerIDCard;
            parameters[13].Value = t.CarOwnerPhone;
            parameters[14].Value = t.DriveLicense;
            parameters[15].Value = t.CarWidth;
            parameters[16].Value = t.CarLength;
            parameters[17].Value = t.CarHight;
            parameters[18].Value = t.FirstImage;
            parameters[19].Value = t.IsAuditing;
            parameters[20].Value = t.AuditUser;
            parameters[21].Value = t.AuditTime;
            parameters[22].Value = t.Remark;
            parameters[23].Value = t.DriverName;
            parameters[24].Value = t.DriverIDCard;
            parameters[25].Value = t.DriverPhone;

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

        public bool Update(Model.TT_CarInfo t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_CarInfo set ");
            strSql.Append("RemoteCardCode=@RemoteCardCode,");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("CarType=@CarType,");
            strSql.Append("EmptyWeight=@EmptyWeight,");
            strSql.Append("MostWeight=@MostWeight,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("BangType=@BangType,");
            strSql.Append("RandomCode=@RandomCode,");
            strSql.Append("EmptyBangTime=@EmptyBangTime,");
            strSql.Append("CarOwnerName=@CarOwnerName,");
            strSql.Append("CarOwnerIDCard=@CarOwnerIDCard,");
            strSql.Append("CarOwnerPhone=@CarOwnerPhone,");
            strSql.Append("DriveLicense=@DriveLicense,");
            strSql.Append("CarWidth=@CarWidth,");
            strSql.Append("CarLength=@CarLength,");
            strSql.Append("CarHight=@CarHight,");
            strSql.Append("FirstImage=@FirstImage,");
            strSql.Append("IsAuditing=@IsAuditing,");
            strSql.Append("AuditUser=@AuditUser,");
            strSql.Append("AuditTime=@AuditTime,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("DriverName=@DriverName,");
            strSql.Append("DriverIDCard=@DriverIDCard,");
            strSql.Append("DriverPhone=@DriverPhone");
            strSql.Append(" where CarCode=@CarCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@RemoteCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CarType", SqlDbType.NVarChar,20),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@MostWeight", SqlDbType.Decimal,9),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@BangType", SqlDbType.NVarChar,20),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4),
					new SqlParameter("@EmptyBangTime", SqlDbType.DateTime),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@DriveLicense", SqlDbType.NVarChar,20),
					new SqlParameter("@CarWidth", SqlDbType.Decimal,9),
					new SqlParameter("@CarLength", SqlDbType.Decimal,9),
					new SqlParameter("@CarHight", SqlDbType.Decimal,9),
					new SqlParameter("@FirstImage", SqlDbType.VarChar,32),
					new SqlParameter("@IsAuditing", SqlDbType.VarChar,1),
					new SqlParameter("@AuditUser", SqlDbType.NVarChar,20),
					new SqlParameter("@AuditTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@DriverName", SqlDbType.NVarChar,20),
					new SqlParameter("@DriverIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@DriverPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@CarCode", SqlDbType.VarChar,20)};
            parameters[0].Value = t.RemoteCardCode;
            parameters[1].Value = t.RoomCode;
            parameters[2].Value = t.CarNo;
            parameters[3].Value = t.CarType;
            parameters[4].Value = t.EmptyWeight;
            parameters[5].Value = t.MostWeight;
            parameters[6].Value = t.Operator;
            parameters[7].Value = t.BangType;
            parameters[8].Value = t.RandomCode;
            parameters[9].Value = t.EmptyBangTime;
            parameters[10].Value = t.CarOwnerName;
            parameters[11].Value = t.CarOwnerIDCard;
            parameters[12].Value = t.CarOwnerPhone;
            parameters[13].Value = t.DriveLicense;
            parameters[14].Value = t.CarWidth;
            parameters[15].Value = t.CarLength;
            parameters[16].Value = t.CarHight;
            parameters[17].Value = t.FirstImage;
            parameters[18].Value = t.IsAuditing;
            parameters[19].Value = t.AuditUser;
            parameters[20].Value = t.AuditTime;
            parameters[21].Value = t.Remark;
            parameters[22].Value = t.DriverName;
            parameters[23].Value = t.DriverIDCard;
            parameters[24].Value = t.DriverPhone;
            parameters[25].Value = t.CarCode;

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

        public bool Delete(Model.TT_CarInfo t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_CarInfo ");
            strSql.Append(" where CarCode=@CarCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CarCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.CarCode;

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
            strSql.Append("delete from TT_CarInfo ");
            strSql.Append(" where CarCode in (" + IDlist + ")  ");
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

        public Model.TT_CarInfo GetModel(Model.TT_CarInfo t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CarCode,RemoteCardCode,RoomCode,CarNo,CarType,EmptyWeight,MostWeight,Operator,BangType,RandomCode,EmptyBangTime,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,DriveLicense,CarWidth,CarLength,CarHight,FirstImage,IsAuditing,AuditUser,AuditTime,Remark,DriverName,DriverIDCard,DriverPhone from TT_CarInfo ");
            strSql.Append(" where CarCode=@CarCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CarCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.CarCode;

            TDTK.PlatForm.MVC4.Model.TT_CarInfo model = new TDTK.PlatForm.MVC4.Model.TT_CarInfo();
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

        public Model.TT_CarInfo DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_CarInfo model = new TDTK.PlatForm.MVC4.Model.TT_CarInfo();
            if (row != null)
            {
                if (row["CarCode"] != null)
                {
                    model.CarCode = row["CarCode"].ToString();
                }
                if (row["RemoteCardCode"] != null)
                {
                    model.RemoteCardCode = row["RemoteCardCode"].ToString();
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["CarNo"] != null)
                {
                    model.CarNo = row["CarNo"].ToString();
                }
                if (row["CarType"] != null)
                {
                    model.CarType = row["CarType"].ToString();
                }
                if (row["EmptyWeight"] != null && row["EmptyWeight"].ToString() != "")
                {
                    model.EmptyWeight = decimal.Parse(row["EmptyWeight"].ToString());
                }
                if (row["MostWeight"] != null && row["MostWeight"].ToString() != "")
                {
                    model.MostWeight = decimal.Parse(row["MostWeight"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["BangType"] != null)
                {
                    model.BangType = row["BangType"].ToString();
                }
                if (row["RandomCode"] != null)
                {
                    model.RandomCode = row["RandomCode"].ToString();
                }
                if (row["EmptyBangTime"] != null && row["EmptyBangTime"].ToString() != "")
                {
                    model.EmptyBangTime = DateTime.Parse(row["EmptyBangTime"].ToString());
                }
                if (row["CarOwnerName"] != null)
                {
                    model.CarOwnerName = row["CarOwnerName"].ToString();
                }
                if (row["CarOwnerIDCard"] != null)
                {
                    model.CarOwnerIDCard = row["CarOwnerIDCard"].ToString();
                }
                if (row["CarOwnerPhone"] != null)
                {
                    model.CarOwnerPhone = row["CarOwnerPhone"].ToString();
                }
                if (row["DriveLicense"] != null)
                {
                    model.DriveLicense = row["DriveLicense"].ToString();
                }
                if (row["CarWidth"] != null && row["CarWidth"].ToString() != "")
                {
                    model.CarWidth = decimal.Parse(row["CarWidth"].ToString());
                }
                if (row["CarLength"] != null && row["CarLength"].ToString() != "")
                {
                    model.CarLength = decimal.Parse(row["CarLength"].ToString());
                }
                if (row["CarHight"] != null && row["CarHight"].ToString() != "")
                {
                    model.CarHight = decimal.Parse(row["CarHight"].ToString());
                }
                if (row["FirstImage"] != null)
                {
                    model.FirstImage = row["FirstImage"].ToString();
                }
                if (row["IsAuditing"] != null)
                {
                    model.IsAuditing = row["IsAuditing"].ToString();
                }
                if (row["AuditUser"] != null)
                {
                    model.AuditUser = row["AuditUser"].ToString();
                }
                if (row["AuditTime"] != null && row["AuditTime"].ToString() != "")
                {
                    model.AuditTime = DateTime.Parse(row["AuditTime"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["DriverName"] != null)
                {
                    model.DriverName = row["DriverName"].ToString();
                }
                if (row["DriverIDCard"] != null)
                {
                    model.DriverIDCard = row["DriverIDCard"].ToString();
                }
                if (row["DriverPhone"] != null)
                {
                    model.DriverPhone = row["DriverPhone"].ToString();
                }
            }
            return model;
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CarCode,RemoteCardCode,RoomCode,CarNo,CarType,EmptyWeight,MostWeight,Operator,BangType,RandomCode,EmptyBangTime,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,DriveLicense,CarWidth,CarLength,CarHight,FirstImage,IsAuditing,AuditUser,AuditTime,Remark,DriverName,DriverIDCard,DriverPhone ");
            strSql.Append(" FROM TT_CarInfo ");
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
            strSql.Append(" CarCode,RemoteCardCode,RoomCode,CarNo,CarType,EmptyWeight,MostWeight,Operator,BangType,RandomCode,EmptyBangTime,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,DriveLicense,CarWidth,CarLength,CarHight,FirstImage,IsAuditing,AuditUser,AuditTime,Remark,DriverName,DriverIDCard,DriverPhone ");
            strSql.Append(" FROM TT_CarInfo ");
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
            strSql.Append("select count(1) FROM TT_CarInfo ");
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
                strSql.Append("order by T.CarCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_CarInfo T ");
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
