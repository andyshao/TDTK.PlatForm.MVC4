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
    /// 数据访问类:TT_InitialCard
    /// </summary>
    public partial class TT_InitialCard : ITT_InitialCard
    {
        public TT_InitialCard()
        { }

        public bool Exists(Model.TT_InitialCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_InitialCard");
            strSql.Append(" where CardID=@CardID and CardNO=@CardNO");
            SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,20),
                                        new SqlParameter("CardNO",SqlDbType.VarChar,20)};
            parameters[0].Value = t.CardID;
            parameters[1].Value = t.CardNO;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_InitialCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_InitialCard(");
            strSql.Append("CardID,CardNO,CardType,InitialTime,IntialPerson,CoalKindCode)");
            strSql.Append(" values (");
            strSql.Append("@CardID,@CardNO,@CardType,@InitialTime,@IntialPerson,@CoalKindCode)");
            SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,20),
					new SqlParameter("@CardNO", SqlDbType.VarChar,20),
					new SqlParameter("@CardType", SqlDbType.VarChar,1),
					new SqlParameter("@InitialTime", SqlDbType.DateTime),
					new SqlParameter("@IntialPerson", SqlDbType.NVarChar,40),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.CardID;
            parameters[1].Value = t.CardNO;
            parameters[2].Value = t.CardType;
            parameters[3].Value = t.InitialTime;
            parameters[4].Value = t.IntialPerson;
            parameters[5].Value = t.CoalKindCode;

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

        public bool Update(Model.TT_InitialCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_InitialCard set ");
            strSql.Append("CardID=@CardID,");
            strSql.Append("CardNO=@CardNO,");
            strSql.Append("CardType=@CardType,");
            strSql.Append("InitialTime=@InitialTime,");
            strSql.Append("IntialPerson=@IntialPerson,");
            strSql.Append("CoalKindCode=@CoalKindCode");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,20),
					new SqlParameter("@CardNO", SqlDbType.VarChar,20),
					new SqlParameter("@CardType", SqlDbType.VarChar,1),
					new SqlParameter("@InitialTime", SqlDbType.DateTime),
					new SqlParameter("@IntialPerson", SqlDbType.NVarChar,40),
					new SqlParameter("@CoalKindCode", SqlDbType.VarChar,10)};
            parameters[0].Value = t.CardID;
            parameters[1].Value = t.CardNO;
            parameters[2].Value = t.CardType;
            parameters[3].Value = t.InitialTime;
            parameters[4].Value = t.IntialPerson;
            parameters[5].Value = t.CoalKindCode;

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

        public bool Delete(Model.TT_InitialCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_InitialCard ");
            strSql.Append(" where CardID=@CardID and CardNO=@CardNO");
            SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,20),
                                        new SqlParameter("CardNO",SqlDbType.VarChar,20)};
            parameters[0].Value = t.CardID;
            parameters[1].Value = t.CardNO;

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

        public Model.TT_InitialCard GetModel(Model.TT_InitialCard t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CardID,CardNO,CardType,InitialTime,IntialPerson,CoalKindCode from TT_InitialCard ");
            strSql.Append(" where CardID=@CardID and CardNO=@CardNO");
            SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,20),
                                        new SqlParameter("CardNO",SqlDbType.VarChar,20)};
            parameters[0].Value = t.CardID;
            parameters[1].Value = t.CardNO;

            TDTK.PlatForm.MVC4.Model.TT_InitialCard model = new TDTK.PlatForm.MVC4.Model.TT_InitialCard();
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

        public Model.TT_InitialCard DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_InitialCard model = new TDTK.PlatForm.MVC4.Model.TT_InitialCard();
            if (row != null)
            {
                if (row["CardID"] != null)
                {
                    model.CardID = row["CardID"].ToString();
                }
                if (row["CardNO"] != null)
                {
                    model.CardNO = row["CardNO"].ToString();
                }
                if (row["CardType"] != null)
                {
                    model.CardType = row["CardType"].ToString();
                }
                if (row["InitialTime"] != null && row["InitialTime"].ToString() != "")
                {
                    model.InitialTime = DateTime.Parse(row["InitialTime"].ToString());
                }
                if (row["IntialPerson"] != null)
                {
                    model.IntialPerson = row["IntialPerson"].ToString();
                }
                if (row["CoalKindCode"] != null)
                {
                    model.CoalKindCode = row["CoalKindCode"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CardID,CardNO,CardType,InitialTime,IntialPerson,CoalKindCode ");
            strSql.Append(" FROM TT_InitialCard ");
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
            strSql.Append(" CardID,CardNO,CardType,InitialTime,IntialPerson,CoalKindCode ");
            strSql.Append(" FROM TT_InitialCard ");
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
            strSql.Append("select count(1) FROM TT_InitialCard ");
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
            strSql.Append(")AS Row, T.*  from TT_InitialCard T ");
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
