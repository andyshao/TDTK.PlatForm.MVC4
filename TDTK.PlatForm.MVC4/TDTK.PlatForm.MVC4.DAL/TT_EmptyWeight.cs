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
    /// 数据访问类:TT_EmptyWeight
    /// </summary>
    public partial class TT_EmptyWeight : ITT_EmptyWeight
    {
        public TT_EmptyWeight()
        { }


        public bool Exists(Model.TT_EmptyWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_EmptyWeight");
            strSql.Append(" where EmptyCode=@EmptyCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmptyCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.EmptyCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_EmptyWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_EmptyWeight(");
            strSql.Append("EmptyCode,CarCode,RemoteCardCode,NavicertCode,EmptyWeight,BangType,RoomCode,FrontImage,Operator,BangTime,IsLoadWeight,CarNo,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,RandomCode)");
            strSql.Append(" values (");
            strSql.Append("@EmptyCode,@CarCode,@RemoteCardCode,@NavicertCode,@EmptyWeight,@BangType,@RoomCode,@FrontImage,@Operator,@BangTime,@IsLoadWeight,@CarNo,@CarOwnerName,@CarOwnerIDCard,@CarOwnerPhone,@RandomCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmptyCode", SqlDbType.VarChar,20),
					new SqlParameter("@CarCode", SqlDbType.VarChar,20),
					new SqlParameter("@RemoteCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@BangType", SqlDbType.NVarChar,20),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@Operator", SqlDbType.NVarChar,40),
					new SqlParameter("@BangTime", SqlDbType.DateTime),
					new SqlParameter("@IsLoadWeight", SqlDbType.VarChar,1),
					new SqlParameter("@CarNo", SqlDbType.VarChar,20),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4)};
            parameters[0].Value = t.EmptyCode;
            parameters[1].Value = t.CarCode;
            parameters[2].Value = t.RemoteCardCode;
            parameters[3].Value = t.NavicertCode;
            parameters[4].Value = t.EmptyWeight;
            parameters[5].Value = t.BangType;
            parameters[6].Value = t.RoomCode;
            parameters[7].Value = t.FrontImage;
            parameters[8].Value = t.Operator;
            parameters[9].Value = t.BangTime;
            parameters[10].Value = t.IsLoadWeight;
            parameters[11].Value = t.CarNo;
            parameters[12].Value = t.CarOwnerName;
            parameters[13].Value = t.CarOwnerIDCard;
            parameters[14].Value = t.CarOwnerPhone;
            parameters[15].Value = t.RandomCode;

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

        public bool Update(Model.TT_EmptyWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_EmptyWeight set ");
            strSql.Append("CarCode=@CarCode,");
            strSql.Append("RemoteCardCode=@RemoteCardCode,");
            strSql.Append("NavicertCode=@NavicertCode,");
            strSql.Append("EmptyWeight=@EmptyWeight,");
            strSql.Append("BangType=@BangType,");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("FrontImage=@FrontImage,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("BangTime=@BangTime,");
            strSql.Append("IsLoadWeight=@IsLoadWeight,");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("CarOwnerName=@CarOwnerName,");
            strSql.Append("CarOwnerIDCard=@CarOwnerIDCard,");
            strSql.Append("CarOwnerPhone=@CarOwnerPhone,");
            strSql.Append("RandomCode=@RandomCode");
            strSql.Append(" where EmptyCode=@EmptyCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CarCode", SqlDbType.VarChar,20),
					new SqlParameter("@RemoteCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@BangType", SqlDbType.NVarChar,20),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@Operator", SqlDbType.NVarChar,40),
					new SqlParameter("@BangTime", SqlDbType.DateTime),
					new SqlParameter("@IsLoadWeight", SqlDbType.VarChar,1),
					new SqlParameter("@CarNo", SqlDbType.VarChar,20),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerIDCard", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4),
					new SqlParameter("@EmptyCode", SqlDbType.VarChar,20)};
            parameters[0].Value = t.CarCode;
            parameters[1].Value = t.RemoteCardCode;
            parameters[2].Value = t.NavicertCode;
            parameters[3].Value = t.EmptyWeight;
            parameters[4].Value = t.BangType;
            parameters[5].Value = t.RoomCode;
            parameters[6].Value = t.FrontImage;
            parameters[7].Value = t.Operator;
            parameters[8].Value = t.BangTime;
            parameters[9].Value = t.IsLoadWeight;
            parameters[10].Value = t.CarNo;
            parameters[11].Value = t.CarOwnerName;
            parameters[12].Value = t.CarOwnerIDCard;
            parameters[13].Value = t.CarOwnerPhone;
            parameters[14].Value = t.RandomCode;
            parameters[15].Value = t.EmptyCode;

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

        public bool Delete(Model.TT_EmptyWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_EmptyWeight ");
            strSql.Append(" where EmptyCode=@EmptyCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmptyCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.EmptyCode;

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
            strSql.Append("delete from TT_EmptyWeight ");
            strSql.Append(" where EmptyCode in (" + IDlist + ")  ");
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

        public Model.TT_EmptyWeight GetModel(Model.TT_EmptyWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 EmptyCode,CarCode,RemoteCardCode,NavicertCode,EmptyWeight,BangType,RoomCode,FrontImage,Operator,BangTime,IsLoadWeight,CarNo,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,RandomCode from TT_EmptyWeight ");
            strSql.Append(" where EmptyCode=@EmptyCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmptyCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.EmptyCode;

            TDTK.PlatForm.MVC4.Model.TT_EmptyWeight model = new TDTK.PlatForm.MVC4.Model.TT_EmptyWeight();
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

        public Model.TT_EmptyWeight DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_EmptyWeight model = new TDTK.PlatForm.MVC4.Model.TT_EmptyWeight();
            if (row != null)
            {
                if (row["EmptyCode"] != null)
                {
                    model.EmptyCode = row["EmptyCode"].ToString();
                }
                if (row["CarCode"] != null)
                {
                    model.CarCode = row["CarCode"].ToString();
                }
                if (row["RemoteCardCode"] != null)
                {
                    model.RemoteCardCode = row["RemoteCardCode"].ToString();
                }
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["EmptyWeight"] != null && row["EmptyWeight"].ToString() != "")
                {
                    model.EmptyWeight = decimal.Parse(row["EmptyWeight"].ToString());
                }
                if (row["BangType"] != null)
                {
                    model.BangType = row["BangType"].ToString();
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["FrontImage"] != null)
                {
                    model.FrontImage = row["FrontImage"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["BangTime"] != null && row["BangTime"].ToString() != "")
                {
                    model.BangTime = DateTime.Parse(row["BangTime"].ToString());
                }
                if (row["IsLoadWeight"] != null)
                {
                    model.IsLoadWeight = row["IsLoadWeight"].ToString();
                }
                if (row["CarNo"] != null)
                {
                    model.CarNo = row["CarNo"].ToString();
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
                if (row["RandomCode"] != null)
                {
                    model.RandomCode = row["RandomCode"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmptyCode,CarCode,RemoteCardCode,NavicertCode,EmptyWeight,BangType,RoomCode,FrontImage,Operator,BangTime,IsLoadWeight,CarNo,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,RandomCode ");
            strSql.Append(" FROM TT_EmptyWeight ");
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
            strSql.Append(" EmptyCode,CarCode,RemoteCardCode,NavicertCode,EmptyWeight,BangType,RoomCode,FrontImage,Operator,BangTime,IsLoadWeight,CarNo,CarOwnerName,CarOwnerIDCard,CarOwnerPhone,RandomCode ");
            strSql.Append(" FROM TT_EmptyWeight ");
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
            strSql.Append("select count(1) FROM TT_EmptyWeight ");
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
                strSql.Append("order by T.EmptyCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_EmptyWeight T ");
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
