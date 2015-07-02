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
    /// 数据访问类:TT_LoadWeightEditLog
    /// </summary>
    public partial class TT_LoadWeightEditLog : ITT_LoadWeightEditLog
    {
        public TT_LoadWeightEditLog()
        { }

        public bool Exists(Model.TT_LoadWeightEditLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_LoadWeightEditLog");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_LoadWeightEditLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_LoadWeightEditLog(");
            strSql.Append("WeightCode,BeforeNetWeight,BeforeCollCode,BeforeKindCode,BeforeNavicertCode,BeforeMarkedCardCode,AfterNetWeight,AfterCollCode,AfterKindCode,AfterNavicertCode,AfterMarkedCardCode,Remark,Operator,OperateDate)");
            strSql.Append(" values (");
            strSql.Append("@WeightCode,@BeforeNetWeight,@BeforeCollCode,@BeforeKindCode,@BeforeNavicertCode,@BeforeMarkedCardCode,@AfterNetWeight,@AfterCollCode,@AfterKindCode,@AfterNavicertCode,@AfterMarkedCardCode,@Remark,@Operator,@OperateDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@WeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@BeforeNetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@BeforeCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@BeforeKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@BeforeNavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@BeforeMarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@AfterNetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@AfterCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@AfterKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@AfterNavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@AfterMarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateDate", SqlDbType.DateTime)};
            parameters[0].Value = t.WeightCode;
            parameters[1].Value = t.BeforeNetWeight;
            parameters[2].Value = t.BeforeCollCode;
            parameters[3].Value = t.BeforeKindCode;
            parameters[4].Value = t.BeforeNavicertCode;
            parameters[5].Value = t.BeforeMarkedCardCode;
            parameters[6].Value = t.AfterNetWeight;
            parameters[7].Value = t.AfterCollCode;
            parameters[8].Value = t.AfterKindCode;
            parameters[9].Value = t.AfterNavicertCode;
            parameters[10].Value = t.AfterMarkedCardCode;
            parameters[11].Value = t.Remark;
            parameters[12].Value = t.Operator;
            parameters[13].Value = t.OperateDate;

            int  rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows >0)
            {
                return rows;
            }
            else
            {
                return 0;
            }
        }

        public bool Update(Model.TT_LoadWeightEditLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_LoadWeightEditLog set ");
            strSql.Append("WeightCode=@WeightCode,");
            strSql.Append("BeforeNetWeight=@BeforeNetWeight,");
            strSql.Append("BeforeCollCode=@BeforeCollCode,");
            strSql.Append("BeforeKindCode=@BeforeKindCode,");
            strSql.Append("BeforeNavicertCode=@BeforeNavicertCode,");
            strSql.Append("BeforeMarkedCardCode=@BeforeMarkedCardCode,");
            strSql.Append("AfterNetWeight=@AfterNetWeight,");
            strSql.Append("AfterCollCode=@AfterCollCode,");
            strSql.Append("AfterKindCode=@AfterKindCode,");
            strSql.Append("AfterNavicertCode=@AfterNavicertCode,");
            strSql.Append("AfterMarkedCardCode=@AfterMarkedCardCode,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("OperateDate=@OperateDate");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@WeightCode", SqlDbType.VarChar,20),
					new SqlParameter("@BeforeNetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@BeforeCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@BeforeKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@BeforeNavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@BeforeMarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@AfterNetWeight", SqlDbType.Decimal,9),
					new SqlParameter("@AfterCollCode", SqlDbType.VarChar,10),
					new SqlParameter("@AfterKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@AfterNavicertCode", SqlDbType.VarChar,20),
					new SqlParameter("@AfterMarkedCardCode", SqlDbType.VarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperateDate", SqlDbType.DateTime),
					new SqlParameter("@LogID", SqlDbType.BigInt,8)};
            parameters[0].Value = t.WeightCode;
            parameters[1].Value = t.BeforeNetWeight;
            parameters[2].Value = t.BeforeCollCode;
            parameters[3].Value = t.BeforeKindCode;
            parameters[4].Value = t.BeforeNavicertCode;
            parameters[5].Value = t.BeforeMarkedCardCode;
            parameters[6].Value = t.AfterNetWeight;
            parameters[7].Value = t.AfterCollCode;
            parameters[8].Value = t.AfterKindCode;
            parameters[9].Value = t.AfterNavicertCode;
            parameters[10].Value = t.AfterMarkedCardCode;
            parameters[11].Value = t.Remark;
            parameters[12].Value = t.Operator;
            parameters[13].Value = t.OperateDate;
            parameters[14].Value = t.LogID;

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

        public bool Delete(Model.TT_LoadWeightEditLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_LoadWeightEditLog ");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

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
            strSql.Append("delete from TT_LoadWeightEditLog ");
            strSql.Append(" where LogID in (" + IDlist + ")  ");
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

        public Model.TT_LoadWeightEditLog GetModel(Model.TT_LoadWeightEditLog t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 LogID,WeightCode,BeforeNetWeight,BeforeCollCode,BeforeKindCode,BeforeNavicertCode,BeforeMarkedCardCode,AfterNetWeight,AfterCollCode,AfterKindCode,AfterNavicertCode,AfterMarkedCardCode,Remark,Operator,OperateDate from TT_LoadWeightEditLog ");
            strSql.Append(" where LogID=@LogID");
            SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.LogID;

            TDTK.PlatForm.MVC4.Model.TT_LoadWeightEditLog model = new TDTK.PlatForm.MVC4.Model.TT_LoadWeightEditLog();
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

        public Model.TT_LoadWeightEditLog DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_LoadWeightEditLog model = new TDTK.PlatForm.MVC4.Model.TT_LoadWeightEditLog();
            if (row != null)
            {
                if (row["LogID"] != null && row["LogID"].ToString() != "")
                {
                    model.LogID = long.Parse(row["LogID"].ToString());
                }
                if (row["WeightCode"] != null)
                {
                    model.WeightCode = row["WeightCode"].ToString();
                }
                if (row["BeforeNetWeight"] != null && row["BeforeNetWeight"].ToString() != "")
                {
                    model.BeforeNetWeight = decimal.Parse(row["BeforeNetWeight"].ToString());
                }
                if (row["BeforeCollCode"] != null)
                {
                    model.BeforeCollCode = row["BeforeCollCode"].ToString();
                }
                if (row["BeforeKindCode"] != null)
                {
                    model.BeforeKindCode = row["BeforeKindCode"].ToString();
                }
                if (row["BeforeNavicertCode"] != null)
                {
                    model.BeforeNavicertCode = row["BeforeNavicertCode"].ToString();
                }
                if (row["BeforeMarkedCardCode"] != null)
                {
                    model.BeforeMarkedCardCode = row["BeforeMarkedCardCode"].ToString();
                }
                if (row["AfterNetWeight"] != null && row["AfterNetWeight"].ToString() != "")
                {
                    model.AfterNetWeight = decimal.Parse(row["AfterNetWeight"].ToString());
                }
                if (row["AfterCollCode"] != null)
                {
                    model.AfterCollCode = row["AfterCollCode"].ToString();
                }
                if (row["AfterKindCode"] != null)
                {
                    model.AfterKindCode = row["AfterKindCode"].ToString();
                }
                if (row["AfterNavicertCode"] != null)
                {
                    model.AfterNavicertCode = row["AfterNavicertCode"].ToString();
                }
                if (row["AfterMarkedCardCode"] != null)
                {
                    model.AfterMarkedCardCode = row["AfterMarkedCardCode"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["OperateDate"] != null && row["OperateDate"].ToString() != "")
                {
                    model.OperateDate = DateTime.Parse(row["OperateDate"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LogID,WeightCode,BeforeNetWeight,BeforeCollCode,BeforeKindCode,BeforeNavicertCode,BeforeMarkedCardCode,AfterNetWeight,AfterCollCode,AfterKindCode,AfterNavicertCode,AfterMarkedCardCode,Remark,Operator,OperateDate ");
            strSql.Append(" FROM TT_LoadWeightEditLog ");
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
            strSql.Append(" LogID,WeightCode,BeforeNetWeight,BeforeCollCode,BeforeKindCode,BeforeNavicertCode,BeforeMarkedCardCode,AfterNetWeight,AfterCollCode,AfterKindCode,AfterNavicertCode,AfterMarkedCardCode,Remark,Operator,OperateDate ");
            strSql.Append(" FROM TT_LoadWeightEditLog ");
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
            strSql.Append("select count(1) FROM TT_LoadWeightEditLog ");
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
                strSql.Append("order by T.LogID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_LoadWeightEditLog T ");
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
