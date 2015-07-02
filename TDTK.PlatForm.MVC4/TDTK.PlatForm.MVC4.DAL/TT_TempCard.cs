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
    /// 数据访问类:TT_TempCard
    /// </summary>
    public partial class TT_TempCard : ITT_TempCard
    {
        public TT_TempCard()
        { }

        public bool Exists(Model.TT_TempCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_TempCard");
            strSql.Append(" where TempCode=@TempCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.TempCode;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TDTK.PlatForm.MVC4.Model.TT_TempCard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_TempCard(");
            strSql.Append("TempCode,SendOperator,OperatorTime,TempCardState,IsForbid,RoomCode)");
            strSql.Append(" values (");
            strSql.Append("@TempCode,@SendOperator,@OperatorTime,@TempCardState,@IsForbid,@RoomCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@TempCode", SqlDbType.VarChar,20),
					new SqlParameter("@SendOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatorTime", SqlDbType.DateTime),
					new SqlParameter("@TempCardState", SqlDbType.VarChar,1),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10)};
            parameters[0].Value = model.TempCode;
            parameters[1].Value = model.SendOperator;
            parameters[2].Value = model.OperatorTime;
            parameters[3].Value = model.TempCardState;
            parameters[4].Value = model.IsForbid;
            parameters[5].Value = model.RoomCode;

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
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(TDTK.PlatForm.MVC4.Model.TT_TempCard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_TempCard set ");
            strSql.Append("SendOperator=@SendOperator,");
            strSql.Append("OperatorTime=@OperatorTime,");
            strSql.Append("TempCardState=@TempCardState,");
            strSql.Append("IsForbid=@IsForbid,");
            strSql.Append("RoomCode=@RoomCode");
            strSql.Append(" where TempCode=@TempCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@SendOperator", SqlDbType.NVarChar,20),
					new SqlParameter("@OperatorTime", SqlDbType.DateTime),
					new SqlParameter("@TempCardState", SqlDbType.VarChar,1),
					new SqlParameter("@IsForbid", SqlDbType.VarChar,1),
					new SqlParameter("@RoomCode", SqlDbType.VarChar,10),
					new SqlParameter("@TempCode", SqlDbType.VarChar,20)};
            parameters[0].Value = model.SendOperator;
            parameters[1].Value = model.OperatorTime;
            parameters[2].Value = model.TempCardState;
            parameters[3].Value = model.IsForbid;
            parameters[4].Value = model.RoomCode;
            parameters[5].Value = model.TempCode;

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

        public bool Delete(Model.TT_TempCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_TempCard ");
            strSql.Append(" where TempCode=@TempCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.TempCode;

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
            strSql.Append("delete from TT_TempCard ");
            strSql.Append(" where TempCode in (" + IDlist + ")  ");
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

        public Model.TT_TempCard GetModel(Model.TT_TempCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 TempCode,SendOperator,OperatorTime,TempCardState,IsForbid,RoomCode from TT_TempCard ");
            strSql.Append(" where TempCode=@TempCode ");
            SqlParameter[] parameters = {
					new SqlParameter("@TempCode", SqlDbType.VarChar,20)			};
            parameters[0].Value = t.TempCode;

            TDTK.PlatForm.MVC4.Model.TT_TempCard model = new TDTK.PlatForm.MVC4.Model.TT_TempCard();
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
        public TDTK.PlatForm.MVC4.Model.TT_TempCard DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_TempCard model = new TDTK.PlatForm.MVC4.Model.TT_TempCard();
            if (row != null)
            {
                if (row["TempCode"] != null)
                {
                    model.TempCode = row["TempCode"].ToString();
                }
                if (row["SendOperator"] != null)
                {
                    model.SendOperator = row["SendOperator"].ToString();
                }
                if (row["OperatorTime"] != null && row["OperatorTime"].ToString() != "")
                {
                    model.OperatorTime = DateTime.Parse(row["OperatorTime"].ToString());
                }
                if (row["TempCardState"] != null)
                {
                    model.TempCardState = row["TempCardState"].ToString();
                }
                if (row["IsForbid"] != null)
                {
                    model.IsForbid = row["IsForbid"].ToString();
                }
                if (row["RoomCode"] != null)
                {
                    model.RoomCode = row["RoomCode"].ToString();
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
            strSql.Append("select TempCode,SendOperator,OperatorTime,TempCardState,IsForbid,RoomCode ");
            strSql.Append(" FROM TT_TempCard ");
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
            strSql.Append(" TempCode,SendOperator,OperatorTime,TempCardState,IsForbid,RoomCode ");
            strSql.Append(" FROM TT_TempCard ");
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
            strSql.Append("select count(1) FROM TT_TempCard ");
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
                strSql.Append("order by T.TempCode desc");
            }
            strSql.Append(")AS Row, T.*  from TT_TempCard T ");
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
