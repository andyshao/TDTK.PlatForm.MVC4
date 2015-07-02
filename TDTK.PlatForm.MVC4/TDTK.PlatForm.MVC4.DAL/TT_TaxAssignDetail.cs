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
    /// 数据访问类:TT_TaxAssignDetail
    /// </summary>
    public partial class TT_TaxAssignDetail : ITT_TaxAssignDetail
    {
        public TT_TaxAssignDetail()
        { }

        public bool Exists(Model.TT_TaxAssignDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_TaxAssignDetail");
            strSql.Append(" where AssignID=@AssignID");
            SqlParameter[] parameters = {
					new SqlParameter("@AssignID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.AssignID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TDTK.PlatForm.MVC4.Model.TT_TaxAssignDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_TaxAssignDetail(");
            strSql.Append("ItemDetailID,UnitCode,AssignAmount,OperateTime,Operator)");
            strSql.Append(" values (");
            strSql.Append("@ItemDetailID,@UnitCode,@AssignAmount,@OperateTime,@Operator)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemDetailID", SqlDbType.BigInt,8),
					new SqlParameter("@UnitCode", SqlDbType.VarChar,10),
					new SqlParameter("@AssignAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OperateTime", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.ItemDetailID;
            parameters[1].Value = model.UnitCode;
            parameters[2].Value = model.AssignAmount;
            parameters[3].Value = model.OperateTime;
            parameters[4].Value = model.Operator;

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
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_TaxAssignDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_TaxAssignDetail set ");
            strSql.Append("ItemDetailID=@ItemDetailID,");
            strSql.Append("UnitCode=@UnitCode,");
            strSql.Append("AssignAmount=@AssignAmount,");
            strSql.Append("OperateTime=@OperateTime,");
            strSql.Append("Operator=@Operator");
            strSql.Append(" where AssignID=@AssignID");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemDetailID", SqlDbType.BigInt,8),
					new SqlParameter("@UnitCode", SqlDbType.VarChar,10),
					new SqlParameter("@AssignAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OperateTime", SqlDbType.DateTime),
					new SqlParameter("@Operator", SqlDbType.NVarChar,20),
					new SqlParameter("@AssignID", SqlDbType.BigInt,8)};
            parameters[0].Value = model.ItemDetailID;
            parameters[1].Value = model.UnitCode;
            parameters[2].Value = model.AssignAmount;
            parameters[3].Value = model.OperateTime;
            parameters[4].Value = model.Operator;
            parameters[5].Value = model.AssignID;

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

        public bool Delete(Model.TT_TaxAssignDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TaxAssignDetail ");
            strSql.Append(" where AssignID=@AssignID");
            SqlParameter[] parameters = {
					new SqlParameter("@AssignID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.AssignID;

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
            strSql.Append("delete from TT_TaxAssignDetail ");
            strSql.Append(" where AssignID in (" + IDlist + ")  ");
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

        public Model.TT_TaxAssignDetail GetModel(Model.TT_TaxAssignDetail t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 AssignID,ItemDetailID,UnitCode,AssignAmount,OperateTime,Operator from TT_TaxAssignDetail ");
            strSql.Append(" where AssignID=@AssignID");
            SqlParameter[] parameters = {
					new SqlParameter("@AssignID", SqlDbType.BigInt)
			};
            parameters[0].Value = t.AssignID;

            TDTK.PlatForm.MVC4.Model.TT_TaxAssignDetail model = new TDTK.PlatForm.MVC4.Model.TT_TaxAssignDetail();
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
        public TDTK.PlatForm.MVC4.Model.TT_TaxAssignDetail DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_TaxAssignDetail model = new TDTK.PlatForm.MVC4.Model.TT_TaxAssignDetail();
            if (row != null)
            {
                if (row["AssignID"] != null && row["AssignID"].ToString() != "")
                {
                    model.AssignID = long.Parse(row["AssignID"].ToString());
                }
                if (row["ItemDetailID"] != null && row["ItemDetailID"].ToString() != "")
                {
                    model.ItemDetailID = long.Parse(row["ItemDetailID"].ToString());
                }
                if (row["UnitCode"] != null)
                {
                    model.UnitCode = row["UnitCode"].ToString();
                }
                if (row["AssignAmount"] != null && row["AssignAmount"].ToString() != "")
                {
                    model.AssignAmount = decimal.Parse(row["AssignAmount"].ToString());
                }
                if (row["OperateTime"] != null && row["OperateTime"].ToString() != "")
                {
                    model.OperateTime = DateTime.Parse(row["OperateTime"].ToString());
                }
                if (row["Operator"] != null)
                {
                    model.Operator = row["Operator"].ToString();
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
            strSql.Append("select AssignID,ItemDetailID,UnitCode,AssignAmount,OperateTime,Operator ");
            strSql.Append(" FROM TT_TaxAssignDetail ");
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
            strSql.Append(" AssignID,ItemDetailID,UnitCode,AssignAmount,OperateTime,Operator ");
            strSql.Append(" FROM TT_TaxAssignDetail ");
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
            strSql.Append("select count(1) FROM TT_TaxAssignDetail ");
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
                strSql.Append("order by T.AssignID desc");
            }
            strSql.Append(")AS Row, T.*  from TT_TaxAssignDetail T ");
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
