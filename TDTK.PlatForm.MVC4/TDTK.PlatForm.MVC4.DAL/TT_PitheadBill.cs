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
    /// 数据访问类:TT_PitheadBill
    /// </summary>
    public partial class TT_PitheadBill : ITT_PitheadBill
    {
        public TT_PitheadBill()
        { }
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("PBid", "TT_PitheadBill");
        }
        public bool Exists(Model.TT_PitheadBill t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TT_PitheadBill");
            strSql.Append(" where PBid=@PBid ");
            SqlParameter[] parameters = {
					new SqlParameter("@PBid", SqlDbType.Int,4)			};
            parameters[0].Value = t.PBid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.TT_PitheadBill t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TT_PitheadBill(");
            strSql.Append("PBid,StartIedition,EndIedition,StartNumber,EndNumber,Changnumber,BalanceNum,Remark,PBDate)");
            strSql.Append(" values (");
            strSql.Append("@PBid,@StartIedition,@EndIedition,@StartNumber,@EndNumber,@Changnumber,@BalanceNum,@Remark,@PBDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@PBid", SqlDbType.Int,4),
					new SqlParameter("@StartIedition", SqlDbType.VarChar,10),
					new SqlParameter("@EndIedition", SqlDbType.VarChar,10),
					new SqlParameter("@StartNumber", SqlDbType.VarChar,30),
					new SqlParameter("@EndNumber", SqlDbType.VarChar,30),
					new SqlParameter("@Changnumber", SqlDbType.Int,4),
					new SqlParameter("@BalanceNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@PBDate", SqlDbType.DateTime)};
            parameters[0].Value = t.PBid;
            parameters[1].Value = t.StartIedition;
            parameters[2].Value = t.EndIedition;
            parameters[3].Value = t.StartNumber;
            parameters[4].Value = t.EndNumber;
            parameters[5].Value = t.Changnumber;
            parameters[6].Value = t.BalanceNum;
            parameters[7].Value = t.Remark;
            parameters[8].Value = t.PBDate;

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

        public bool Update(Model.TT_PitheadBill t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TT_PitheadBill set ");
            strSql.Append("StartIedition=@StartIedition,");
            strSql.Append("EndIedition=@EndIedition,");
            strSql.Append("StartNumber=@StartNumber,");
            strSql.Append("EndNumber=@EndNumber,");
            strSql.Append("Changnumber=@Changnumber,");
            strSql.Append("BalanceNum=@BalanceNum,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("PBDate=@PBDate");
            strSql.Append(" where PBid=@PBid ");
            SqlParameter[] parameters = {
					new SqlParameter("@StartIedition", SqlDbType.VarChar,10),
					new SqlParameter("@EndIedition", SqlDbType.VarChar,10),
					new SqlParameter("@StartNumber", SqlDbType.VarChar,30),
					new SqlParameter("@EndNumber", SqlDbType.VarChar,30),
					new SqlParameter("@Changnumber", SqlDbType.Int,4),
					new SqlParameter("@BalanceNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@PBDate", SqlDbType.DateTime),
					new SqlParameter("@PBid", SqlDbType.Int,4)};
            parameters[0].Value = t.StartIedition;
            parameters[1].Value = t.EndIedition;
            parameters[2].Value = t.StartNumber;
            parameters[3].Value = t.EndNumber;
            parameters[4].Value = t.Changnumber;
            parameters[5].Value = t.BalanceNum;
            parameters[6].Value = t.Remark;
            parameters[7].Value = t.PBDate;
            parameters[8].Value = t.PBid;

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

        public bool Delete(Model.TT_PitheadBill t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TT_PitheadBill ");
            strSql.Append(" where PBid=@PBid ");
            SqlParameter[] parameters = {
					new SqlParameter("@PBid", SqlDbType.Int,4)			};
            parameters[0].Value = t.PBid;

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
            strSql.Append("delete from TT_PitheadBill ");
            strSql.Append(" where PBid in (" + IDlist + ")  ");
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

        public Model.TT_PitheadBill GetModel(Model.TT_PitheadBill t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PBid,StartIedition,EndIedition,StartNumber,EndNumber,Changnumber,BalanceNum,Remark,PBDate from TT_PitheadBill ");
            strSql.Append(" where PBid=@PBid ");
            SqlParameter[] parameters = {
					new SqlParameter("@PBid", SqlDbType.Int,4)			};
            parameters[0].Value = t.PBid;

            TDTK.PlatForm.MVC4.Model.TT_PitheadBill model = new TDTK.PlatForm.MVC4.Model.TT_PitheadBill();
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

        public Model.TT_PitheadBill DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.TT_PitheadBill model = new TDTK.PlatForm.MVC4.Model.TT_PitheadBill();
            if (row != null)
            {
                if (row["PBid"] != null && row["PBid"].ToString() != "")
                {
                    model.PBid = int.Parse(row["PBid"].ToString());
                }
                if (row["StartIedition"] != null)
                {
                    model.StartIedition = row["StartIedition"].ToString();
                }
                if (row["EndIedition"] != null)
                {
                    model.EndIedition = row["EndIedition"].ToString();
                }
                if (row["StartNumber"] != null)
                {
                    model.StartNumber = row["StartNumber"].ToString();
                }
                if (row["EndNumber"] != null)
                {
                    model.EndNumber = row["EndNumber"].ToString();
                }
                if (row["Changnumber"] != null && row["Changnumber"].ToString() != "")
                {
                    model.Changnumber = int.Parse(row["Changnumber"].ToString());
                }
                if (row["BalanceNum"] != null && row["BalanceNum"].ToString() != "")
                {
                    model.BalanceNum = int.Parse(row["BalanceNum"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["PBDate"] != null && row["PBDate"].ToString() != "")
                {
                    model.PBDate = DateTime.Parse(row["PBDate"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PBid,StartIedition,EndIedition,StartNumber,EndNumber,Changnumber,BalanceNum,Remark,PBDate ");
            strSql.Append(" FROM TT_PitheadBill ");
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
            strSql.Append(" PBid,StartIedition,EndIedition,StartNumber,EndNumber,Changnumber,BalanceNum,Remark,PBDate ");
            strSql.Append(" FROM TT_PitheadBill ");
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
            strSql.Append("select count(1) FROM TT_PitheadBill ");
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
                strSql.Append("order by T.PBid desc");
            }
            strSql.Append(")AS Row, T.*  from TT_PitheadBill T ");
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
