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
    /// 数据访问类:TT_OutLoadWeight
    /// </summary>
    public partial class TT_OutLoadWeight : ITT_OutLoadWeight
    {
        public TT_OutLoadWeight()
        { }

        public bool Exists(Model.TT_OutLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_OutLoadWeight");
            strSql.Append(" where OutWeightCode=@OutWeightCode and TaxType=@TaxType and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@TaxType", SqlDbType.NVarChar,20),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)			};
            parameters[0].Value =t.OutWeightCode;
            parameters[1].Value =t.TaxType;
            parameters[2].Value =t.WeightTime;
                               
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_OutLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_OutLoadWeight(");
            strSql.Append("OutWeightCode,OTrafficCode,NavicertCode,CoalKindCode,CoalKindName,CarNo,CurrentWeight,ONetWeight,OverWeight,TaxAmount,FundAmount,TaxType,RandomCode,FrontImage,BackImage,UpImage,RoomImage,RoomCode,RoomName,Operator,WeightTime,OutType,BangType,DiveLicense,CarDriverPhone,EmptyWeight,CarownerIDCard,CollName,IsNormal,SendUnits,ToUnits,BillWeight,CarNoImage,OutWeightImage,Customers,CarOwnerName,ExceptLeft,CarType)");
            strSql.Append(" values (");
            strSql.Append("@OutWeightCode,@OTrafficCode,@NavicertCode,@CoalKindCode,@CoalKindName,@CarNo,@CurrentWeight,@ONetWeight,@OverWeight,@TaxAmount,@FundAmount,@TaxType,@RandomCode,@FrontImage,@BackImage,@UpImage,@RoomImage,@RoomCode,@RoomName,@Operator,@WeightTime,@OutType,@BangType,@DiveLicense,@CarDriverPhone,@EmptyWeight,@CarownerIDCard,@CollName,@IsNormal,@SendUnits,@ToUnits,@BillWeight,@CarNoImage,@OutWeightImage,@Customers,@CarOwnerName,@ExceptLeft,@CarType)");
            SqlParameter[] parameters = {
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@OTrafficCode", SqlDbType.VarChar,20),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CurrentWeight", SqlDbType.Decimal,9),
					new SqlParameter("@ONetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OverWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TaxAmount", SqlDbType.Decimal,9),
					new SqlParameter("@FundAmount", SqlDbType.Decimal,9),
					new SqlParameter("@TaxType", SqlDbType.NVarChar,20),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,4),
					new SqlParameter("@RoomName", SqlDbType.NVarChar,20),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@WeightTime", SqlDbType.DateTime),
					new SqlParameter("@OutType", SqlDbType.VarChar,1),
					new SqlParameter("@BangType", SqlDbType.NVarChar,50),
					new SqlParameter("@DiveLicense", SqlDbType.VarChar,50),
					new SqlParameter("@CarDriverPhone", SqlDbType.VarChar,50),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@CarownerIDCard", SqlDbType.VarChar,50),
					new SqlParameter("@CollName", SqlDbType.NVarChar,100),
					new SqlParameter("@IsNormal", SqlDbType.NVarChar,10),
					new SqlParameter("@SendUnits", SqlDbType.NVarChar,50),
					new SqlParameter("@ToUnits", SqlDbType.NVarChar,50),
					new SqlParameter("@BillWeight", SqlDbType.Decimal,9),
					new SqlParameter("@CarNoImage", SqlDbType.VarChar,50),
					new SqlParameter("@OutWeightImage", SqlDbType.VarChar,50),
					new SqlParameter("@Customers", SqlDbType.VarChar,50),
					new SqlParameter("@CarOwnerName", SqlDbType.VarChar,50),
					new SqlParameter("@ExceptLeft", SqlDbType.DateTime),
					new SqlParameter("@CarType", SqlDbType.VarChar,10)};
            parameters[0].Value = t.OutWeightCode;
            parameters[1].Value = t.OTrafficCode;
            parameters[2].Value = t.NavicertCode;
            parameters[3].Value = t.CoalKindCode;
            parameters[4].Value = t.CoalKindName;
            parameters[5].Value = t.CarNo;
            parameters[6].Value = t.CurrentWeight;
            parameters[7].Value = t.ONetWeight;
            parameters[8].Value = t.OverWeight;
            parameters[9].Value = t.TaxAmount;
            parameters[10].Value = t.FundAmount;
            parameters[11].Value = t.TaxType;
            parameters[12].Value = t.RandomCode;
            parameters[13].Value = t.FrontImage;
            parameters[14].Value = t.BackImage;
            parameters[15].Value = t.UpImage;
            parameters[16].Value = t.RoomImage;
            parameters[17].Value = t.RoomCode;
            parameters[18].Value = t.RoomName;
            parameters[19].Value = t.Operator;
            parameters[20].Value = t.WeightTime;
            parameters[21].Value = t.OutType;
            parameters[22].Value = t.BangType;
            parameters[23].Value = t.DiveLicense;
            parameters[24].Value = t.CarDriverPhone;
            parameters[25].Value = t.EmptyWeight;
            parameters[26].Value = t.CarownerIDCard;
            parameters[27].Value = t.CollName;
            parameters[28].Value = t.IsNormal;
            parameters[29].Value = t.SendUnits;
            parameters[30].Value = t.ToUnits;
            parameters[31].Value = t.BillWeight;
            parameters[32].Value = t.CarNoImage;
            parameters[33].Value = t.OutWeightImage;
            parameters[34].Value = t.Customers;
            parameters[35].Value = t.CarOwnerName;
            parameters[36].Value = t.ExceptLeft;
            parameters[37].Value = t.CarType;

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

        public bool Update(Model.TT_OutLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_OutLoadWeight set ");
            strSql.Append("OTrafficCode=@OTrafficCode,");
            strSql.Append("NavicertCode=@NavicertCode,");
            strSql.Append("CoalKindCode=@CoalKindCode,");
            strSql.Append("CoalKindName=@CoalKindName,");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("CurrentWeight=@CurrentWeight,");
            strSql.Append("ONetWeight=@ONetWeight,");
            strSql.Append("OverWeight=@OverWeight,");
            strSql.Append("TaxAmount=@TaxAmount,");
            strSql.Append("FundAmount=@FundAmount,");
            strSql.Append("RandomCode=@RandomCode,");
            strSql.Append("FrontImage=@FrontImage,");
            strSql.Append("BackImage=@BackImage,");
            strSql.Append("UpImage=@UpImage,");
            strSql.Append("RoomImage=@RoomImage,");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("RoomName=@RoomName,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("OutType=@OutType,");
            strSql.Append("BangType=@BangType,");
            strSql.Append("DiveLicense=@DiveLicense,");
            strSql.Append("CarDriverPhone=@CarDriverPhone,");
            strSql.Append("EmptyWeight=@EmptyWeight,");
            strSql.Append("CarownerIDCard=@CarownerIDCard,");
            strSql.Append("CollName=@CollName,");
            strSql.Append("IsNormal=@IsNormal,");
            strSql.Append("SendUnits=@SendUnits,");
            strSql.Append("ToUnits=@ToUnits,");
            strSql.Append("BillWeight=@BillWeight,");
            strSql.Append("CarNoImage=@CarNoImage,");
            strSql.Append("OutWeightImage=@OutWeightImage,");
            strSql.Append("Customers=@Customers,");
            strSql.Append("CarOwnerName=@CarOwnerName,");
            strSql.Append("ExceptLeft=@ExceptLeft,");
            strSql.Append("CarType=@CarType");
            strSql.Append(" where OutWeightCode=@OutWeightCode and TaxType=@TaxType and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@OTrafficCode", SqlDbType.VarChar,20),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindName", SqlDbType.NVarChar,20),
					new SqlParameter("@CarNo", SqlDbType.NVarChar,20),
					new SqlParameter("@CurrentWeight", SqlDbType.Decimal,9),
					new SqlParameter("@ONetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OverWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TaxAmount", SqlDbType.Decimal,9),
					new SqlParameter("@FundAmount", SqlDbType.Decimal,9),
					new SqlParameter("@RandomCode", SqlDbType.VarChar,4),
					new SqlParameter("@FrontImage", SqlDbType.VarChar,32),
					new SqlParameter("@BackImage", SqlDbType.VarChar,32),
					new SqlParameter("@UpImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomImage", SqlDbType.VarChar,32),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,4),
					new SqlParameter("@RoomName", SqlDbType.NVarChar,20),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OutType", SqlDbType.VarChar,1),
					new SqlParameter("@BangType", SqlDbType.NVarChar,50),
					new SqlParameter("@DiveLicense", SqlDbType.VarChar,50),
					new SqlParameter("@CarDriverPhone", SqlDbType.VarChar,50),
					new SqlParameter("@EmptyWeight", SqlDbType.Decimal,9),
					new SqlParameter("@CarownerIDCard", SqlDbType.VarChar,50),
					new SqlParameter("@CollName", SqlDbType.NVarChar,100),
					new SqlParameter("@IsNormal", SqlDbType.NVarChar,10),
					new SqlParameter("@SendUnits", SqlDbType.NVarChar,50),
					new SqlParameter("@ToUnits", SqlDbType.NVarChar,50),
					new SqlParameter("@BillWeight", SqlDbType.Decimal,9),
					new SqlParameter("@CarNoImage", SqlDbType.VarChar,50),
					new SqlParameter("@OutWeightImage", SqlDbType.VarChar,50),
					new SqlParameter("@Customers", SqlDbType.VarChar,50),
					new SqlParameter("@CarOwnerName", SqlDbType.VarChar,50),
					new SqlParameter("@ExceptLeft", SqlDbType.DateTime),
					new SqlParameter("@CarType", SqlDbType.VarChar,10),
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@TaxType", SqlDbType.NVarChar,20),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)};
            parameters[0].Value = t.OTrafficCode;
            parameters[1].Value = t.NavicertCode;
            parameters[2].Value = t.CoalKindCode;
            parameters[3].Value = t.CoalKindName;
            parameters[4].Value = t.CarNo;
            parameters[5].Value = t.CurrentWeight;
            parameters[6].Value = t.ONetWeight;
            parameters[7].Value = t.OverWeight;
            parameters[8].Value = t.TaxAmount;
            parameters[9].Value = t.FundAmount;
            parameters[10].Value = t.RandomCode;
            parameters[11].Value = t.FrontImage;
            parameters[12].Value = t.BackImage;
            parameters[13].Value = t.UpImage;
            parameters[14].Value = t.RoomImage;
            parameters[15].Value = t.RoomCode;
            parameters[16].Value = t.RoomName;
            parameters[17].Value = t.Operator;
            parameters[18].Value = t.OutType;
            parameters[19].Value = t.BangType;
            parameters[20].Value = t.DiveLicense;
            parameters[21].Value = t.CarDriverPhone;
            parameters[22].Value = t.EmptyWeight;
            parameters[23].Value = t.CarownerIDCard;
            parameters[24].Value = t.CollName;
            parameters[25].Value = t.IsNormal;
            parameters[26].Value = t.SendUnits;
            parameters[27].Value = t.ToUnits;
            parameters[28].Value = t.BillWeight;
            parameters[29].Value = t.CarNoImage;
            parameters[30].Value = t.OutWeightImage;
            parameters[31].Value = t.Customers;
            parameters[32].Value = t.CarOwnerName;
            parameters[33].Value = t.ExceptLeft;
            parameters[34].Value = t.CarType;
            parameters[35].Value = t.OutWeightCode;
            parameters[36].Value = t.TaxType;
            parameters[37].Value = t.WeightTime;

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

        public bool Delete(Model.TT_OutLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_OutLoadWeight ");
            strSql.Append(" where OutWeightCode=@OutWeightCode and TaxType=@TaxType and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@TaxType", SqlDbType.NVarChar,20),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)			};
            parameters[0].Value = t.OutWeightCode;
            parameters[1].Value = t.TaxType;
            parameters[2].Value = t.WeightTime;

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
            throw new NotImplementedException();
        }

        public Model.TT_OutLoadWeight GetModel(Model.TT_OutLoadWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 OutWeightCode,OTrafficCode,NavicertCode,CoalKindCode,CoalKindName,CarNo,CurrentWeight,ONetWeight,OverWeight,TaxAmount,FundAmount,TaxType,RandomCode,FrontImage,BackImage,UpImage,RoomImage,RoomCode,RoomName,Operator,WeightTime,OutType,BangType,DiveLicense,CarDriverPhone,EmptyWeight,CarownerIDCard,CollName,IsNormal,SendUnits,ToUnits,BillWeight,CarNoImage,OutWeightImage,Customers,CarOwnerName,ExceptLeft,CarType from TT_OutLoadWeight ");
            strSql.Append(" where OutWeightCode=@OutWeightCode and TaxType=@TaxType and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@TaxType", SqlDbType.NVarChar,20),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)			};
            parameters[0].Value = t.OutWeightCode;
            parameters[1].Value = t.TaxType;
            parameters[2].Value = t.WeightTime;

            TDTK.PlatForm.MVC4.Model.TT_OutLoadWeight model = new TDTK.PlatForm.MVC4.Model.TT_OutLoadWeight();
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

        public Model.TT_OutLoadWeight DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_OutLoadWeight model = new TDTK.PlatForm.MVC4.Model.TT_OutLoadWeight();
            if (row != null)
            {
                if (row["OutWeightCode"] != null)
                {
                    model.OutWeightCode = row["OutWeightCode"].ToString();
                }
                if (row["OTrafficCode"] != null)
                {
                    model.OTrafficCode = row["OTrafficCode"].ToString();
                }
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
                if (row["CoalKindName"] != null)
                {
                    model.CoalKindName = row["CoalKindName"].ToString();
                }
                if (row["CarNo"] != null)
                {
                    model.CarNo = row["CarNo"].ToString();
                }
                if (row["CurrentWeight"] != null && row["CurrentWeight"].ToString() != "")
                {
                    model.CurrentWeight = decimal.Parse(row["CurrentWeight"].ToString());
                }
                if (row["ONetWeight"] != null && row["ONetWeight"].ToString() != "")
                {
                    model.ONetWeight = decimal.Parse(row["ONetWeight"].ToString());
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
                if (row["TaxType"] != null)
                {
                    model.TaxType = row["TaxType"].ToString();
                }
                if (row["RandomCode"] != null)
                {
                    model.RandomCode = row["RandomCode"].ToString();
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
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["RoomName"] != null)
                {
                    model.RoomName = row["RoomName"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["WeightTime"] != null && row["WeightTime"].ToString() != "")
                {
                    model.WeightTime = DateTime.Parse(row["WeightTime"].ToString());
                }
                if (row["OutType"] != null)
                {
                    model.OutType = row["OutType"].ToString();
                }
                if (row["BangType"] != null)
                {
                    model.BangType = row["BangType"].ToString();
                }
                if (row["DiveLicense"] != null)
                {
                    model.DiveLicense = row["DiveLicense"].ToString();
                }
                if (row["CarDriverPhone"] != null)
                {
                    model.CarDriverPhone = row["CarDriverPhone"].ToString();
                }
                if (row["EmptyWeight"] != null && row["EmptyWeight"].ToString() != "")
                {
                    model.EmptyWeight = decimal.Parse(row["EmptyWeight"].ToString());
                }
                if (row["CarownerIDCard"] != null)
                {
                    model.CarownerIDCard = row["CarownerIDCard"].ToString();
                }
                if (row["CollName"] != null)
                {
                    model.CollName = row["CollName"].ToString();
                }
                if (row["IsNormal"] != null)
                {
                    model.IsNormal = row["IsNormal"].ToString();
                }
                if (row["SendUnits"] != null)
                {
                    model.SendUnits = row["SendUnits"].ToString();
                }
                if (row["ToUnits"] != null)
                {
                    model.ToUnits = row["ToUnits"].ToString();
                }
                if (row["BillWeight"] != null && row["BillWeight"].ToString() != "")
                {
                    model.BillWeight = decimal.Parse(row["BillWeight"].ToString());
                }
                if (row["CarNoImage"] != null)
                {
                    model.CarNoImage = row["CarNoImage"].ToString();
                }
                if (row["OutWeightImage"] != null)
                {
                    model.OutWeightImage = row["OutWeightImage"].ToString();
                }
                if (row["Customers"] != null)
                {
                    model.Customers = row["Customers"].ToString();
                }
                if (row["CarOwnerName"] != null)
                {
                    model.CarOwnerName = row["CarOwnerName"].ToString();
                }
                if (row["ExceptLeft"] != null && row["ExceptLeft"].ToString() != "")
                {
                    model.ExceptLeft = DateTime.Parse(row["ExceptLeft"].ToString());
                }
                if (row["CarType"] != null)
                {
                    model.CarType = row["CarType"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OutWeightCode,OTrafficCode,NavicertCode,CoalKindCode,CoalKindName,CarNo,CurrentWeight,ONetWeight,OverWeight,TaxAmount,FundAmount,TaxType,RandomCode,FrontImage,BackImage,UpImage,RoomImage,RoomCode,RoomName,Operator,WeightTime,OutType,BangType,DiveLicense,CarDriverPhone,EmptyWeight,CarownerIDCard,CollName,IsNormal,SendUnits,ToUnits,BillWeight,CarNoImage,OutWeightImage,Customers,CarOwnerName,ExceptLeft,CarType ");
            strSql.Append(" FROM TT_OutLoadWeight ");
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
            strSql.Append(" OutWeightCode,OTrafficCode,NavicertCode,CoalKindCode,CoalKindName,CarNo,CurrentWeight,ONetWeight,OverWeight,TaxAmount,FundAmount,TaxType,RandomCode,FrontImage,BackImage,UpImage,RoomImage,RoomCode,RoomName,Operator,WeightTime,OutType,BangType,DiveLicense,CarDriverPhone,EmptyWeight,CarownerIDCard,CollName,IsNormal,SendUnits,ToUnits,BillWeight,CarNoImage,OutWeightImage,Customers,CarOwnerName,ExceptLeft,CarType ");
            strSql.Append(" FROM TT_OutLoadWeight ");
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
            strSql.Append("select count(1) FROM TT_OutLoadWeight ");
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
                strSql.Append("order by T.WeightTime desc");
            }
            strSql.Append(")AS Row, T.*  from TT_OutLoadWeight T ");
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
