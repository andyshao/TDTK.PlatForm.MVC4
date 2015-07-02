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
    /// 数据访问类:TT_LoadWeightByDay
    /// </summary>
    public partial class TT_LoadWeightByDay : ITT_LoadWeightByDay
    {
        public TT_LoadWeightByDay()
        { }

        public bool Exists(Model.TT_LoadWeightByDay t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_LoadWeightByDay");
            strSql.Append(" where RoomCode=@RoomCode and CollCode=@CollCode and CoalKindCode=@CoalKindCode and TaxGroup=@TaxGroup and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)			};
            parameters[0].Value = t.RoomCode;
            parameters[1].Value = t.CollCode;
            parameters[2].Value = t.CoalKindCode;
            parameters[3].Value = t.TaxGroup;
            parameters[4].Value = t.WeightTime;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_LoadWeightByDay t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_LoadWeightByDay(");
            strSql.Append("RoomCode,CollCode,CoalKindCode,TaxGroup,WeightTime,NetWeight,TaxAmount)");
            strSql.Append(" values (");
            strSql.Append("@RoomCode,@CollCode,@CoalKindCode,@TaxGroup,@WeightTime,@NetWeight,@TaxAmount)");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@WeightTime", SqlDbType.DateTime),
					new SqlParameter("@NetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TaxAmount", SqlDbType.Decimal,9)};
            parameters[0].Value = t.RoomCode;
            parameters[1].Value = t.CollCode;
            parameters[2].Value = t.CoalKindCode;
            parameters[3].Value = t.TaxGroup;
            parameters[4].Value = t.WeightTime;
            parameters[5].Value = t.NetWeight;
            parameters[6].Value = t.TaxAmount;

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

        public bool Update(Model.TT_LoadWeightByDay t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_LoadWeightByDay set ");
            strSql.Append("NetWeight=@NetWeight,");
            strSql.Append("TaxAmount=@TaxAmount");
            strSql.Append(" where RoomCode=@RoomCode and CollCode=@CollCode and CoalKindCode=@CoalKindCode and TaxGroup=@TaxGroup and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@NetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@TaxAmount", SqlDbType.Decimal,9),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)};
            parameters[0].Value = t.NetWeight;
            parameters[1].Value = t.TaxAmount;
            parameters[2].Value = t.RoomCode;
            parameters[3].Value = t.CollCode;
            parameters[4].Value = t.CoalKindCode;
            parameters[5].Value = t.TaxGroup;
            parameters[6].Value = t.WeightTime;

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

        public bool Delete(Model.TT_LoadWeightByDay t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_LoadWeightByDay ");
            strSql.Append(" where RoomCode=@RoomCode and CollCode=@CollCode and CoalKindCode=@CoalKindCode and TaxGroup=@TaxGroup and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)			};
            parameters[0].Value = t.RoomCode;
            parameters[1].Value = t.CollCode;
            parameters[2].Value = t.CoalKindCode;
            parameters[3].Value = t.TaxGroup;
            parameters[4].Value = t.WeightTime;

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

        public Model.TT_LoadWeightByDay GetModel(Model.TT_LoadWeightByDay t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 RoomCode,CollCode,CoalKindCode,TaxGroup,WeightTime,NetWeight,TaxAmount from TT_LoadWeightByDay ");
            strSql.Append(" where RoomCode=@RoomCode and CollCode=@CollCode and CoalKindCode=@CoalKindCode and TaxGroup=@TaxGroup and WeightTime=@WeightTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@CollCode", SqlDbType.VarChar,10),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@WeightTime", SqlDbType.DateTime)			};
            parameters[0].Value = t.RoomCode;
            parameters[1].Value = t.CollCode;
            parameters[2].Value = t.CoalKindCode;
            parameters[3].Value = t.TaxGroup;
            parameters[4].Value = t.WeightTime;

            TDTK.PlatForm.MVC4.Model.TT_LoadWeightByDay model = new TDTK.PlatForm.MVC4.Model.TT_LoadWeightByDay();
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

        public Model.TT_LoadWeightByDay DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_LoadWeightByDay model = new TDTK.PlatForm.MVC4.Model.TT_LoadWeightByDay();
            if (row != null)
            {
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["CollCode"] != null)
                {
                    model.CollCode = row["CollCode"].ToString();
                }
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
                if (row["TaxGroup"] != null && row["TaxGroup"].ToString() != "")
                {
                    model.TaxGroup = decimal.Parse(row["TaxGroup"].ToString());
                }
                if (row["WeightTime"] != null && row["WeightTime"].ToString() != "")
                {
                    model.WeightTime = DateTime.Parse(row["WeightTime"].ToString());
                }
                if (row["NetWeight"] != null && row["NetWeight"].ToString() != "")
                {
                    model.NetWeight = decimal.Parse(row["NetWeight"].ToString());
                }
                if (row["TaxAmount"] != null && row["TaxAmount"].ToString() != "")
                {
                    model.TaxAmount = decimal.Parse(row["TaxAmount"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RoomCode,CollCode,CoalKindCode,TaxGroup,WeightTime,NetWeight,TaxAmount ");
            strSql.Append(" FROM TT_LoadWeightByDay ");
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
            strSql.Append(" RoomCode,CollCode,CoalKindCode,TaxGroup,WeightTime,NetWeight,TaxAmount ");
            strSql.Append(" FROM TT_LoadWeightByDay ");
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
            strSql.Append("select count(1) FROM TT_LoadWeightByDay ");
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
            strSql.Append(")AS Row, T.*  from TT_LoadWeightByDay T ");
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
