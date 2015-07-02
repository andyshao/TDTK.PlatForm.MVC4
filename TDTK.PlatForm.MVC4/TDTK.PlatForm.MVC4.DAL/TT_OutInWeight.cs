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
    /// 数据访问类:TT_OutInWeight
    /// </summary>
    public partial class TT_OutInWeight : ITT_OutInWeight
    {
        public TT_OutInWeight()
        { }

        public bool Exists(Model.TT_OutInWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_OutInWeight");
            strSql.Append(" where InWeightCode=@InWeightCode and OutWeightCode=@OutWeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@InWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.InWeightCode;
            parameters[1].Value = t.OutWeightCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_OutInWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_OutInWeight(");
            strSql.Append("InWeightCode,OutWeightCode,CarNo,CarType,NavicertCode,InRoomName,OutRoomName,CoalKindName,InWeight,OutWeight,InWeightDate,OutWeightDate,ExceptLeft,InOutDemo)");
            strSql.Append(" values (");
            strSql.Append("@InWeightCode,@OutWeightCode,@CarNo,@CarType,@NavicertCode,@InRoomName,@OutRoomName,@CoalKindName,@InWeight,@OutWeight,@InWeightDate,@OutWeightDate,@ExceptLeft,@InOutDemo)");
            SqlParameter[] parameters = {
					new SqlParameter("@InWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@CarNo", SqlDbType.VarChar,10),
					new SqlParameter("@CarType", SqlDbType.VarChar,30),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,12),
					new SqlParameter("@InRoomName", SqlDbType.VarChar,20),
					new SqlParameter("@OutRoomName", SqlDbType.VarChar,20),
					new SqlParameter("@CoalKindName", SqlDbType.VarChar,10),
					new SqlParameter("@InWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OutWeight", SqlDbType.Decimal,9),
					new SqlParameter("@InWeightDate", SqlDbType.DateTime),
					new SqlParameter("@OutWeightDate", SqlDbType.DateTime),
					new SqlParameter("@ExceptLeft", SqlDbType.DateTime),
					new SqlParameter("@InOutDemo", SqlDbType.VarChar,100)};
            parameters[0].Value = t.InWeightCode;
            parameters[1].Value = t.OutWeightCode;
            parameters[2].Value = t.CarNo;
            parameters[3].Value = t.CarType;
            parameters[4].Value = t.NavicertCode;
            parameters[5].Value = t.InRoomName;
            parameters[6].Value = t.OutRoomName;
            parameters[7].Value = t.CoalKindName;
            parameters[8].Value = t.InWeight;
            parameters[9].Value = t.OutWeight;
            parameters[10].Value = t.InWeightDate;
            parameters[11].Value = t.OutWeightDate;
            parameters[12].Value = t.ExceptLeft;
            parameters[13].Value = t.InOutDemo;

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

        public bool Update(Model.TT_OutInWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_OutInWeight set ");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("CarType=@CarType,");
            strSql.Append("NavicertCode=@NavicertCode,");
            strSql.Append("InRoomName=@InRoomName,");
            strSql.Append("OutRoomName=@OutRoomName,");
            strSql.Append("CoalKindName=@CoalKindName,");
            strSql.Append("InWeight=@InWeight,");
            strSql.Append("OutWeight=@OutWeight,");
            strSql.Append("InWeightDate=@InWeightDate,");
            strSql.Append("OutWeightDate=@OutWeightDate,");
            strSql.Append("ExceptLeft=@ExceptLeft,");
            strSql.Append("InOutDemo=@InOutDemo");
            strSql.Append(" where InWeightCode=@InWeightCode and OutWeightCode=@OutWeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@CarNo", SqlDbType.VarChar,10),
					new SqlParameter("@CarType", SqlDbType.VarChar,30),
					new SqlParameter("@NavicertCode", SqlDbType.VarChar,12),
					new SqlParameter("@InRoomName", SqlDbType.VarChar,20),
					new SqlParameter("@OutRoomName", SqlDbType.VarChar,20),
					new SqlParameter("@CoalKindName", SqlDbType.VarChar,10),
					new SqlParameter("@InWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OutWeight", SqlDbType.Decimal,9),
					new SqlParameter("@InWeightDate", SqlDbType.DateTime),
					new SqlParameter("@OutWeightDate", SqlDbType.DateTime),
					new SqlParameter("@ExceptLeft", SqlDbType.DateTime),
					new SqlParameter("@InOutDemo", SqlDbType.VarChar,100),
					new SqlParameter("@InWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20)};
            parameters[0].Value = t.CarNo;
            parameters[1].Value = t.CarType;
            parameters[2].Value = t.NavicertCode;
            parameters[3].Value = t.InRoomName;
            parameters[4].Value = t.OutRoomName;
            parameters[5].Value = t.CoalKindName;
            parameters[6].Value = t.InWeight;
            parameters[7].Value = t.OutWeight;
            parameters[8].Value = t.InWeightDate;
            parameters[9].Value = t.OutWeightDate;
            parameters[10].Value = t.ExceptLeft;
            parameters[11].Value = t.InOutDemo;
            parameters[12].Value = t.InWeightCode;
            parameters[13].Value = t.OutWeightCode;

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

        public bool Delete(Model.TT_OutInWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_OutInWeight ");
            strSql.Append(" where InWeightCode=@InWeightCode and OutWeightCode=@OutWeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@InWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.InWeightCode;
            parameters[1].Value = t.OutWeightCode;

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

        public Model.TT_OutInWeight GetModel(Model.TT_OutInWeight t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 InWeightCode,OutWeightCode,CarNo,CarType,NavicertCode,InRoomName,OutRoomName,CoalKindName,InWeight,OutWeight,InWeightDate,OutWeightDate,ExceptLeft,InOutDemo from TT_OutInWeight ");
            strSql.Append(" where InWeightCode=@InWeightCode and OutWeightCode=@OutWeightCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@InWeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@OutWeightCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.InWeightCode;
            parameters[1].Value = t.OutWeightCode;

            TDTK.PlatForm.MVC4.Model.TT_OutInWeight model = new TDTK.PlatForm.MVC4.Model.TT_OutInWeight();
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

        public Model.TT_OutInWeight DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_OutInWeight model = new TDTK.PlatForm.MVC4.Model.TT_OutInWeight();
            if (row != null)
            {
                if (row["InWeightCode"] != null)
                {
                    model.InWeightCode = row["InWeightCode"].ToString();
                }
                if (row["OutWeightCode"] != null)
                {
                    model.OutWeightCode = row["OutWeightCode"].ToString();
                }
                if (row["CarNo"] != null)
                {
                    model.CarNo = row["CarNo"].ToString();
                }
                if (row["CarType"] != null)
                {
                    model.CarType = row["CarType"].ToString();
                }
                if (row["NavicertCode"] != null)
                {
                    model.NavicertCode = row["NavicertCode"].ToString();
                }
                if (row["InRoomName"] != null)
                {
                    model.InRoomName = row["InRoomName"].ToString();
                }
                if (row["OutRoomName"] != null)
                {
                    model.OutRoomName = row["OutRoomName"].ToString();
                }
                if (row["CoalKindName"] != null)
                {
                    model.CoalKindName = row["CoalKindName"].ToString();
                }
                if (row["InWeight"] != null && row["InWeight"].ToString() != "")
                {
                    model.InWeight = decimal.Parse(row["InWeight"].ToString());
                }
                if (row["OutWeight"] != null && row["OutWeight"].ToString() != "")
                {
                    model.OutWeight = decimal.Parse(row["OutWeight"].ToString());
                }
                if (row["InWeightDate"] != null && row["InWeightDate"].ToString() != "")
                {
                    model.InWeightDate = DateTime.Parse(row["InWeightDate"].ToString());
                }
                if (row["OutWeightDate"] != null && row["OutWeightDate"].ToString() != "")
                {
                    model.OutWeightDate = DateTime.Parse(row["OutWeightDate"].ToString());
                }
                if (row["ExceptLeft"] != null && row["ExceptLeft"].ToString() != "")
                {
                    model.ExceptLeft = DateTime.Parse(row["ExceptLeft"].ToString());
                }
                if (row["InOutDemo"] != null)
                {
                    model.InOutDemo = row["InOutDemo"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select InWeightCode,OutWeightCode,CarNo,CarType,NavicertCode,InRoomName,OutRoomName,CoalKindName,InWeight,OutWeight,InWeightDate,OutWeightDate,ExceptLeft,InOutDemo ");
            strSql.Append(" FROM TT_OutInWeight ");
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
            strSql.Append(" InWeightCode,OutWeightCode,CarNo,CarType,NavicertCode,InRoomName,OutRoomName,CoalKindName,InWeight,OutWeight,InWeightDate,OutWeightDate,ExceptLeft,InOutDemo ");
            strSql.Append(" FROM TT_OutInWeight ");
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
            strSql.Append("select count(1) FROM TT_OutInWeight ");
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
                strSql.Append("order by T.OutWeightCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_OutInWeight T ");
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
