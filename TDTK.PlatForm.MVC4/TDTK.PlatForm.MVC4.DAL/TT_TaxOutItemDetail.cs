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
    /// 数据访问类:TT_TaxOutItemDetail
    /// </summary>
    public partial class TT_TaxOutItemDetail : ITT_TaxOutItemDetail
    {
        public TT_TaxOutItemDetail()
        { }

        public bool Exists(Model.TT_TaxOutItemDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_TaxOutItemDetail");
            strSql.Append(" where ItemDetailId=@ItemDetailId");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemDetailId", SqlDbType.BigInt)
			};
            parameters[0].Value = t.ItemDetailId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_TaxOutItemDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_TaxOutItemDetail(");
            strSql.Append("CoalKindCode,RoomCode,TaxItemCode,Amount,EffectTime,Operator,OperateTime,TaxGroup,IsAssigned,IsAll)");
            strSql.Append(" values (");
            strSql.Append("@CoalKindCode,@RoomCode,@TaxItemCode,@Amount,@EffectTime,@Operator,@OperateTime,@TaxGroup,@IsAssigned,@IsAll)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@TaxItemCode", SqlDbType.VarChar,10),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@EffectTime", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,40),
					new SqlParameter("@OperateTime", SqlDbType.DateTime),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@IsAssigned", SqlDbType.VarChar,1),
					new SqlParameter("@IsAll", SqlDbType.VarChar,1)};
            parameters[0].Value = t.CoalKindCode;
            parameters[1].Value = t.RoomCode;
            parameters[2].Value = t.TaxItemCode;
            parameters[3].Value = t.Amount;
            parameters[4].Value = t.EffectTime;
            parameters[5].Value = t.Operator;
            parameters[6].Value = t.OperateTime;
            parameters[7].Value = t.TaxGroup;
            parameters[8].Value = t.IsAssigned;
            parameters[9].Value = t.IsAll;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows>0)
            {
                return rows;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_TaxOutItemDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_TaxOutItemDetail set ");
            strSql.Append("CoalKindCode=@CoalKindCode,");
            strSql.Append("RoomCode=@RoomCode,");
            strSql.Append("TaxItemCode=@TaxItemCode,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("EffectTime=@EffectTime,");
            strSql.Append("Operator=@Operator,");
            strSql.Append("OperateTime=@OperateTime,");
            strSql.Append("TaxGroup=@TaxGroup,");
            strSql.Append("IsAssigned=@IsAssigned,");
            strSql.Append("IsAll=@IsAll");
            strSql.Append(" where ItemDetailId=@ItemDetailId");
            SqlParameter[] parameters = {
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@TaxItemCode", SqlDbType.VarChar,10),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@EffectTime", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,40),
					new SqlParameter("@OperateTime", SqlDbType.DateTime),
					new SqlParameter("@TaxGroup", SqlDbType.Decimal,9),
					new SqlParameter("@IsAssigned", SqlDbType.VarChar,1),
					new SqlParameter("@IsAll", SqlDbType.VarChar,1),
					new SqlParameter("@ItemDetailId", SqlDbType.BigInt,8)};
            parameters[0].Value = model.CoalKindCode;
            parameters[1].Value = model.RoomCode;
            parameters[2].Value = model.TaxItemCode;
            parameters[3].Value = model.Amount;
            parameters[4].Value = model.EffectTime;
            parameters[5].Value = model.Operator;
            parameters[6].Value = model.OperateTime;
            parameters[7].Value = model.TaxGroup;
            parameters[8].Value = model.IsAssigned;
            parameters[9].Value = model.IsAll;
            parameters[10].Value = model.ItemDetailId;

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

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.TT_TaxOutItemDetail t)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TaxOutItemDetail ");
            strSql.Append(" where ItemDetailId=@ItemDetailId");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemDetailId", SqlDbType.BigInt)
			};
            parameters[0].Value = t.ItemDetailId;

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
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string ItemDetailIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TaxOutItemDetail ");
            strSql.Append(" where ItemDetailId in (" + ItemDetailIdlist + ")  ");
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

              
        public Model.TT_TaxOutItemDetail GetModel(Model.TT_TaxOutItemDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ItemDetailId,CoalKindCode,RoomCode,TaxItemCode,Amount,EffectTime,Operator,OperateTime,TaxGroup,IsAssigned,IsAll from TT_TaxOutItemDetail ");
            strSql.Append(" where ItemDetailId=@ItemDetailId");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemDetailId", SqlDbType.BigInt)
			};
            parameters[0].Value = t.ItemDetailId;

            TDTK.PlatForm.MVC4.Model.TT_TaxOutItemDetail model = new TDTK.PlatForm.MVC4.Model.TT_TaxOutItemDetail();
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

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.TT_TaxOutItemDetail DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_TaxOutItemDetail model = new TDTK.PlatForm.MVC4.Model.TT_TaxOutItemDetail();
            if (row != null)
            {
                if (row["ItemDetailId"] != null && row["ItemDetailId"].ToString() != "")
                {
                    model.ItemDetailId = long.Parse(row["ItemDetailId"].ToString());
                }
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
                }
                if (row["TaxItemCode"] != null)
                {
                    model.TaxItemCode = row["TaxItemCode"].ToString();
                }
                if (row["Amount"] != null && row["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(row["Amount"].ToString());
                }
                if (row["EffectTime"] != null && row["EffectTime"].ToString() != "")
                {
                    model.EffectTime = DateTime.Parse(row["EffectTime"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
                }
                if (row["OperateTime"] != null && row["OperateTime"].ToString() != "")
                {
                    model.OperateTime = DateTime.Parse(row["OperateTime"].ToString());
                }
                if (row["TaxGroup"] != null && row["TaxGroup"].ToString() != "")
                {
                    model.TaxGroup = decimal.Parse(row["TaxGroup"].ToString());
                }
                if (row["IsAssigned"] != null)
                {
                    model.IsAssigned = row["IsAssigned"].ToString();
                }
                if (row["IsAll"] != null)
                {
                    model.IsAll = row["IsAll"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ItemDetailId,CoalKindCode,RoomCode,TaxItemCode,Amount,EffectTime,Operator,OperateTime,TaxGroup,IsAssigned,IsAll ");
            strSql.Append(" FROM TT_TaxOutItemDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ItemDetailId,CoalKindCode,RoomCode,TaxItemCode,Amount,EffectTime,Operator,OperateTime,TaxGroup,IsAssigned,IsAll ");
            strSql.Append(" FROM TT_TaxOutItemDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TT_TaxOutItemDetail ");
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
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
                strSql.Append("order by T.ItemDetailId desc");
            }
            strSql.Append(")AS Row, T.*  from TT_TaxOutItemDetail T ");
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
