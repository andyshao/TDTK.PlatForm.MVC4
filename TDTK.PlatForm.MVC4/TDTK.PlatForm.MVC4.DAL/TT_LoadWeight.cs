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
    /// 数据访问类:TT_LoadWeight
    /// </summary>
    public partial class TT_LoadWeight : ITT_LoadWeight
    {
        public TT_LoadWeight()
        { }

        public bool Exists(Model.TT_LoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_LoadWeight");
            strSql.Append(" where WeightCode=@WeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@WeightCode", SqlDbType.VarChar,35)			};
            parameters[0].Value = t.WeightCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_LoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_LoadWeight(");
            strSql.Append("WeightCode,TrafficCode,NavicertCode,MarkedCardCode,RemoteCardCode,EmptyCode,CollCode,CollName,CoalKindCode,CoalKindName,CarOwnerName,CarNo,CarType,LoadWeight,EmptyWeight,NetWeight,OverWeight,TaxAmount,FundAmount,RoomCode,RoomName,BangType,Operator,WeightTime,RandomCode,CustomerName,TaxType,IsFirstSite,FrontImage,BackImage,UpImage,RoomImage,TaxGroup,IsSealed)");
            strSql.Append(" values (");
            strSql.Append("@WeightCode,@TrafficCode,@NavicertCode,@MarkedCardCode,@RemoteCardCode,@EmptyCode,@CollCode,@CollName,@CoalKindCode,@CoalKindName,@CarOwnerName,@CarNo,@CarType,@LoadWeight,@EmptyWeight,@NetWeight,@OverWeight,@TaxAmount,@FundAmount,@RoomCode,@RoomName,@BangType,@Operator,@WeightTime,@RandomCode,@CustomerName,@TaxType,@IsFirstSite,@FrontImage,@BackImage,@UpImage,@RoomImage,@TaxGroup,@IsSealed)");
            SqlParameter[] parameters = {
					new SqlParameter("@WeightCode", SqlDbType.VarChar,35),
					new SqlParameter("@TrafficCode", SqlDbType.VarChar,35),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@MarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@RemoteCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@EmptyCode", SqlDbType.VarChar,20),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollName", SqlDbType.NVarChar,100),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CarType", SqlDbType.NVarChar,20),
					new SqlParameter("@LoadWeight", SqlDbType.Decimal,9),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@NetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OverWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TaxAmount", SqlDbType.Decimal,9),
					new SqlParameter("@FundAmount", SqlDbType.Decimal,9),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomName", SqlDbType.NVarChar,50),
					new SqlParameter("@BangType", SqlDbType.NVarChar,20),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@WeightTime", SqlDbType.DateTime),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4),
					new SqlParameter("@CustomerName", SqlDbType.NVarChar,20),
					new SqlParameter("@TaxType", SqlDbType.NVarChar,20),
					new SqlParameter("@IsFirstSite", SqlDbType.VarChar,1),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@IsSealed", SqlDbType.VarChar,1)};
            parameters[0].Value = t.WeightCode;
            parameters[1].Value = t.TrafficCode;
            parameters[2].Value = t.NavicertCode;
            parameters[3].Value = t.MarkedCardCode;
            parameters[4].Value = t.RemoteCardCode;
            parameters[5].Value = t.EmptyCode;
            parameters[6].Value = t.CollCode;
            parameters[7].Value = t.CollName;
            parameters[8].Value = t.CoalKindCode;
            parameters[9].Value = t.CoalKindName;
            parameters[10].Value = t.CarOwnerName;
            parameters[11].Value = t.CarNo;
            parameters[12].Value = t.CarType;
            parameters[13].Value = t.LoadWeight;
            parameters[14].Value = t.EmptyWeight;
            parameters[15].Value = t.NetWeight;
            parameters[16].Value = t.OverWeight;
            parameters[17].Value = t.TaxAmount;
            parameters[18].Value = t.FundAmount;
            parameters[19].Value = t.RoomCode;
            parameters[20].Value = t.RoomName;
            parameters[21].Value = t.BangType;
            parameters[22].Value = t.Operator;
            parameters[23].Value = t.WeightTime;
            parameters[24].Value = t.RandomCode;
            parameters[25].Value = t.CustomerName;
            parameters[26].Value = t.TaxType;
            parameters[27].Value = t.IsFirstSite;
            parameters[28].Value = t.FrontImage;
            parameters[29].Value = t.BackImage;
            parameters[30].Value = t.UpImage;
            parameters[31].Value = t.RoomImage;
            parameters[32].Value = t.TaxGroup;
            parameters[33].Value = t.IsSealed;

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

        public bool Update(Model.TT_LoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_LoadWeight set ");
            strSql.Append("TrafficCode=@TrafficCode,");
            strSql.Append("NavicertCode=@NavicertCode,");
            strSql.Append("MarkedCardCode=@MarkedCardCode,");
            strSql.Append("RemoteCardCode=@RemoteCardCode,");
            strSql.Append("EmptyCode=@EmptyCode,");
            strSql.Append("CollCode=@CollCode,");
            strSql.Append("CollName=@CollName,");
            strSql.Append("CoalKindCode=@CoalKindCode,");
            strSql.Append("CoalKindName=@CoalKindName,");
            strSql.Append("CarOwnerName=@CarOwnerName,");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("CarType=@CarType,");
            strSql.Append("LoadWeight=@LoadWeight,");
            strSql.Append("EmptyWeight=@EmptyWeight,");
            strSql.Append("NetWeight=@NetWeight,");
            strSql.Append("OverWeight=@OverWeight,");
            strSql.Append("TaxAmount=@TaxAmount,");
            strSql.Append("FundAmount=@FundAmount,");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("RoomName=@RoomName,");
            strSql.Append("BangType=@BangType,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("WeightTime=@WeightTime,");
            strSql.Append("RandomCode=@RandomCode,");
            strSql.Append("CustomerName=@CustomerName,");
            strSql.Append("TaxType=@TaxType,");
            strSql.Append("IsFirstSite=@IsFirstSite,");
            strSql.Append("FrontImage=@FrontImage,");
            strSql.Append("BackImage=@BackImage,");
            strSql.Append("UpImage=@UpImage,");
            strSql.Append("RoomImage=@RoomImage,");
            strSql.Append("TaxGroup=@TaxGroup,");
            strSql.Append("IsSealed=@IsSealed");
            strSql.Append(" where WeightCode=@WeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TrafficCode", SqlDbType.VarChar,35),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@MarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@RemoteCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@EmptyCode", SqlDbType.VarChar,20),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollName", SqlDbType.NVarChar,100),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarOwnerName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CarType", SqlDbType.NVarChar,20),
					new SqlParameter("@LoadWeight", SqlDbType.Decimal,9),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@NetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OverWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TaxAmount", SqlDbType.Decimal,9),
					new SqlParameter("@FundAmount", SqlDbType.Decimal,9),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomName", SqlDbType.NVarChar,50),
					new SqlParameter("@BangType", SqlDbType.NVarChar,20),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@WeightTime", SqlDbType.DateTime),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4),
					new SqlParameter("@CustomerName", SqlDbType.NVarChar,20),
					new SqlParameter("@TaxType", SqlDbType.NVarChar,20),
					new SqlParameter("@IsFirstSite", SqlDbType.VarChar,1),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@IsSealed", SqlDbType.VarChar,1),
					new SqlParameter("@WeightCode", SqlDbType.VarChar,35)};
            parameters[0].Value = t.TrafficCode;
            parameters[1].Value = t.NavicertCode;
            parameters[2].Value = t.MarkedCardCode;
            parameters[3].Value = t.RemoteCardCode;
            parameters[4].Value = t.EmptyCode;
            parameters[5].Value = t.CollCode;
            parameters[6].Value = t.CollName;
            parameters[7].Value = t.CoalKindCode;
            parameters[8].Value = t.CoalKindName;
            parameters[9].Value = t.CarOwnerName;
            parameters[10].Value = t.CarNo;
            parameters[11].Value = t.CarType;
            parameters[12].Value = t.LoadWeight;
            parameters[13].Value = t.EmptyWeight;
            parameters[14].Value = t.NetWeight;
            parameters[15].Value = t.OverWeight;
            parameters[16].Value = t.TaxAmount;
            parameters[17].Value = t.FundAmount;
            parameters[18].Value = t.RoomCode;
            parameters[19].Value = t.RoomName;
            parameters[20].Value = t.BangType;
            parameters[21].Value = t.Operator;
            parameters[22].Value = t.WeightTime;
            parameters[23].Value = t.RandomCode;
            parameters[24].Value = t.CustomerName;
            parameters[25].Value = t.TaxType;
            parameters[26].Value = t.IsFirstSite;
            parameters[27].Value = t.FrontImage;
            parameters[28].Value = t.BackImage;
            parameters[29].Value = t.UpImage;
            parameters[30].Value = t.RoomImage;
            parameters[31].Value = t.TaxGroup;
            parameters[32].Value = t.IsSealed;
            parameters[33].Value = t.WeightCode;

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

        public bool Delete(Model.TT_LoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_LoadWeight ");
            strSql.Append(" where WeightCode=@WeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@WeightCode", SqlDbType.VarChar,35)			};
            parameters[0].Value = t.WeightCode;

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
            strSql.Append("delete from TT_LoadWeight ");
            strSql.Append(" where WeightCode in (" + IDlist + ")  ");
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

        public Model.TT_LoadWeight GetModel(Model.TT_LoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 WeightCode,TrafficCode,NavicertCode,MarkedCardCode,RemoteCardCode,EmptyCode,CollCode,CollName,CoalKindCode,CoalKindName,CarOwnerName,CarNo,CarType,LoadWeight,EmptyWeight,NetWeight,OverWeight,TaxAmount,FundAmount,RoomCode,RoomName,BangType,Operator,WeightTime,RandomCode,CustomerName,TaxType,IsFirstSite,FrontImage,BackImage,UpImage,RoomImage,TaxGroup,IsSealed from TT_LoadWeight ");
            strSql.Append(" where WeightCode=@WeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@WeightCode", SqlDbType.VarChar,35)			};
            parameters[0].Value = t.WeightCode;

            TDTK.PlatForm.MVC4.Model.TT_LoadWeight model = new TDTK.PlatForm.MVC4.Model.TT_LoadWeight();
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

        public Model.TT_LoadWeight DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_LoadWeight model = new TDTK.PlatForm.MVC4.Model.TT_LoadWeight();
            if (row != null)
            {
                if (row["WeightCode"] != null)
                {
                    model.WeightCode = row["WeightCode"].ToString();
                }
                if (row["TrafficCode"] != null)
                {
                    model.TrafficCode = row["TrafficCode"].ToString();
                }
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["MarkedCardCode"] != null)
                {
                    model.MarkedCardCode = row["MarkedCardCode"].ToString();
                }
                if (row["RemoteCardCode"] != null)
                {
                    model.RemoteCardCode = row["RemoteCardCode"].ToString();
                }
                if (row["EmptyCode"] != null)
                {
                    model.EmptyCode = row["EmptyCode"].ToString();
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["CollName"] != null)
                {
                    model.CollName = row["CollName"].ToString();
                }
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
                if (row["CoalKindName"] != null)
                {
                    model.CoalKindName = row["CoalKindName"].ToString();
                }
                if (row["CarOwnerName"] != null)
                {
                    model.CarOwnerName = row["CarOwnerName"].ToString();
                }
                if (row["CarNo"] != null)
                {
                    model.CarNo = row["CarNo"].ToString();
                }
                if (row["CarType"] != null)
                {
                    model.CarType = row["CarType"].ToString();
                }
                if (row["LoadWeight"] != null && row["LoadWeight"].ToString() != "")
                {
                    model.LoadWeight = decimal.Parse(row["LoadWeight"].ToString());
                }
                if (row["EmptyWeight"] != null && row["EmptyWeight"].ToString() != "")
                {
                    model.EmptyWeight = decimal.Parse(row["EmptyWeight"].ToString());
                }
                if (row["NetWeight"] != null && row["NetWeight"].ToString() != "")
                {
                    model.NetWeight = decimal.Parse(row["NetWeight"].ToString());
                }
                if (row["OverWeight"] != null && row["OverWeight"].ToString() != "")
                {
                    model.OverWeight = decimal.Parse(row["OverWeight"].ToString());
                }
                if (row["TaxAmount"] != null && row["TaxAmount"].ToString() != "")
                {
                    model.TaxAmount = decimal.Parse(row["TaxAmount"].ToString());
                }
                if (row["FundAmount"] != null && row["FundAmount"].ToString() != "")
                {
                    model.FundAmount = decimal.Parse(row["FundAmount"].ToString());
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["RoomName"] != null)
                {
                    model.RoomName = row["RoomName"].ToString();
                }
                if (row["BangType"] != null)
                {
                    model.BangType = row["BangType"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["WeightTime"] != null && row["WeightTime"].ToString() != "")
                {
                    model.WeightTime = DateTime.Parse(row["WeightTime"].ToString());
                }
                if (row["RandomCode"] != null)
                {
                    model.RandomCode = row["RandomCode"].ToString();
                }
                if (row["CustomerName"] != null)
                {
                    model.CustomerName = row["CustomerName"].ToString();
                }
                if (row["TaxType"] != null)
                {
                    model.TaxType = row["TaxType"].ToString();
                }
                if (row["IsFirstSite"] != null)
                {
                    model.IsFirstSite = row["IsFirstSite"].ToString();
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
                if (row["TaxGroup"] != null && row["TaxGroup"].ToString() != "")
                {
                    model.TaxGroup = decimal.Parse(row["TaxGroup"].ToString());
                }
                if (row["IsSealed"] != null)
                {
                    model.IsSealed = row["IsSealed"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select WeightCode,TrafficCode,NavicertCode,MarkedCardCode,RemoteCardCode,EmptyCode,CollCode,CollName,CoalKindCode,CoalKindName,CarOwnerName,CarNo,CarType,LoadWeight,EmptyWeight,NetWeight,OverWeight,TaxAmount,FundAmount,RoomCode,RoomName,BangType,Operator,WeightTime,RandomCode,CustomerName,TaxType,IsFirstSite,FrontImage,BackImage,UpImage,RoomImage,TaxGroup,IsSealed ");
            strSql.Append(" FROM TT_LoadWeight ");
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
            strSql.Append(" WeightCode,TrafficCode,NavicertCode,MarkedCardCode,RemoteCardCode,EmptyCode,CollCode,CollName,CoalKindCode,CoalKindName,CarOwnerName,CarNo,CarType,LoadWeight,EmptyWeight,NetWeight,OverWeight,TaxAmount,FundAmount,RoomCode,RoomName,BangType,Operator,WeightTime,RandomCode,CustomerName,TaxType,IsFirstSite,FrontImage,BackImage,UpImage,RoomImage,TaxGroup,IsSealed ");
            strSql.Append(" FROM TT_LoadWeight ");
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
            strSql.Append("select count(1) FROM TT_LoadWeight ");
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
                strSql.Append("order by T.WeightCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_LoadWeight T ");
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
