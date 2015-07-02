using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.IDAL;
using System.Data.SqlClient;
using System.Data;
using TDTK.PlatForm.MVC4.Model;
using TDTK.PlatForm.MVC4.DBUtility;

namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:TT_CheckBang
    /// </summary>
    public partial class TT_CheckBang : ITT_CheckBang
    {
        public TT_CheckBang()
        { }

        public bool Exists(Model.TT_CheckBang t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_CheckBang");
            strSql.Append(" where CheckCode=@CheckCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CheckCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.CheckCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_CheckBang t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_CheckBang(");
            strSql.Append("CheckCode,WeightCode,NavicertCode,MarkedCardCode,NetWeight,RoomCode,IsPassed,CheckResult,CheckTime,Operator,FrontImage,BackImage,UpImage,RoomImage)");
            strSql.Append(" values (");
            strSql.Append("@CheckCode,@WeightCode,@NavicertCode,@MarkedCardCode,@NetWeight,@RoomCode,@IsPassed,@CheckResult,@CheckTime,@Operator,@FrontImage,@BackImage,@UpImage,@RoomImage)");
            SqlParameter[] parameters = {
					new SqlParameter("@CheckCode", SqlDbType.VarChar,20),
					new SqlParameter("@WeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@MarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@NetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@IsPassed", SqlDbType.VarChar,1),
					new SqlParameter("@CheckResult", SqlDbType.NVarChar,200),
					new SqlParameter("@CheckTime", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32)};
            parameters[0].Value = t.CheckCode;
            parameters[1].Value = t.WeightCode;
            parameters[2].Value = t.NavicertCode;
            parameters[3].Value = t.MarkedCardCode;
            parameters[4].Value = t.NetWeight;
            parameters[5].Value = t.RoomCode;
            parameters[6].Value = t.IsPassed;
            parameters[7].Value = t.CheckResult;
            parameters[8].Value = t.CheckTime;
            parameters[9].Value = t.Operator;
            parameters[10].Value = t.FrontImage;
            parameters[11].Value = t.BackImage;
            parameters[12].Value = t.UpImage;
            parameters[13].Value = t.RoomImage;

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

        public bool Update(Model.TT_CheckBang t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_CheckBang set ");
            strSql.Append("WeightCode=@WeightCode,");
            strSql.Append("NavicertCode=@NavicertCode,");
            strSql.Append("MarkedCardCode=@MarkedCardCode,");
            strSql.Append("NetWeight=@NetWeight,");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("IsPassed=@IsPassed,");
            strSql.Append("CheckResult=@CheckResult,");
            strSql.Append("CheckTime=@CheckTime,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("FrontImage=@FrontImage,");
            strSql.Append("BackImage=@BackImage,");
            strSql.Append("UpImage=@UpImage,");
            strSql.Append("RoomImage=@RoomImage");
            strSql.Append(" where CheckCode=@CheckCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@WeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@MarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@NetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@IsPassed", SqlDbType.VarChar,1),
					new SqlParameter("@CheckResult", SqlDbType.NVarChar,200),
					new SqlParameter("@CheckTime", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32),
					new SqlParameter("@CheckCode", SqlDbType.VarChar,20)};
            parameters[0].Value = t.WeightCode;
            parameters[1].Value = t.NavicertCode;
            parameters[2].Value = t.MarkedCardCode;
            parameters[3].Value = t.NetWeight;
            parameters[4].Value = t.RoomCode;
            parameters[5].Value = t.IsPassed;
            parameters[6].Value = t.CheckResult;
            parameters[7].Value = t.CheckTime;
            parameters[8].Value = t.Operator;
            parameters[9].Value = t.FrontImage;
            parameters[10].Value = t.BackImage;
            parameters[11].Value = t.UpImage;
            parameters[12].Value = t.RoomImage;
            parameters[13].Value = t.CheckCode;

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

        public bool Delete(Model.TT_CheckBang t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_CheckBang ");
            strSql.Append(" where CheckCode=@CheckCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CheckCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.CheckCode;

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
            strSql.Append("delete from TT_CheckBang ");
            strSql.Append(" where CheckCode in (" + IDlist + ")  ");
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

        public Model.TT_CheckBang GetModel(Model.TT_CheckBang t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CheckCode,WeightCode,NavicertCode,MarkedCardCode,NetWeight,RoomCode,IsPassed,CheckResult,CheckTime,Operator,FrontImage,BackImage,UpImage,RoomImage from TT_CheckBang ");
            strSql.Append(" where CheckCode=@CheckCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CheckCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.CheckCode;

            TDTK.PlatForm.MVC4.Model.TT_CheckBang model = new TDTK.PlatForm.MVC4.Model.TT_CheckBang();
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

        public Model.TT_CheckBang DataRowToModel(System.Data.DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_CheckBang model = new TDTK.PlatForm.MVC4.Model.TT_CheckBang();
            if (row != null)
            {
                if (row["CheckCode"] != null)
                {
                    model.CheckCode = row["CheckCode"].ToString();
                }
                if (row["WeightCode"] != null)
                {
                    model.WeightCode = row["WeightCode"].ToString();
                }
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["MarkedCardCode"] != null)
                {
                    model.MarkedCardCode = row["MarkedCardCode"].ToString();
                }
                if (row["NetWeight"] != null && row["NetWeight"].ToString() != "")
                {
                    model.NetWeight = decimal.Parse(row["NetWeight"].ToString());
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["IsPassed"] != null)
                {
                    model.IsPassed = row["IsPassed"].ToString();
                }
                if (row["CheckResult"] != null)
                {
                    model.CheckResult = row["CheckResult"].ToString();
                }
                if (row["CheckTime"] != null && row["CheckTime"].ToString() != "")
                {
                    model.CheckTime = DateTime.Parse(row["CheckTime"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
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
            strSql.Append("select CheckCode,WeightCode,NavicertCode,MarkedCardCode,NetWeight,RoomCode,IsPassed,CheckResult,CheckTime,Operator,FrontImage,BackImage,UpImage,RoomImage ");
            strSql.Append(" FROM TT_CheckBang ");
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
            strSql.Append(" CheckCode,WeightCode,NavicertCode,MarkedCardCode,NetWeight,RoomCode,IsPassed,CheckResult,CheckTime,Operator,FrontImage,BackImage,UpImage,RoomImage ");
            strSql.Append(" FROM TT_CheckBang ");
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
            strSql.Append("select count(1) FROM TT_CheckBang ");
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
                strSql.Append("order by T.CheckCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_CheckBang T ");
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
