using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.DBUtility;
using TDTK.PlatForm.MVC4.Model;
using System.Data;
using System.Data.SqlClient;

namespace TDTK.PlatForm.MVC4.DAL
{
    /// <summary>
    /// 数据访问类:Sys_Menu
    /// </summary>
    public partial class Sys_Menu : ISys_Menu
    {
        public Sys_Menu()
        { }


        public bool Exists(Model.Sys_Menu t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_Menu");
            strSql.Append(" where MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.NVarChar,20)			};
            parameters[0].Value = t.MenuID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public int Add(Model.Sys_Menu t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_Menu(");
            strSql.Append("MenuID,MenuName,MenuUrl,FunctionID,IsLeaf,MenuLevel,RootID,ParentsID,DisplayOrder,IcValue,IsPop,MenuSeq)");
            strSql.Append(" values (");
            strSql.Append("@MenuID,@MenuName,@MenuUrl,@FunctionID,@IsLeaf,@MenuLevel,@RootID,@ParentsID,@DisplayOrder,@IcValue,@IsPop,@MenuSeq)");
            SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.NVarChar,20),
					new SqlParameter("@MenuName", SqlDbType.NVarChar,50),
					new SqlParameter("@MenuUrl", SqlDbType.VarChar,300),
					new SqlParameter("@FunctionID", SqlDbType.NVarChar,100),
					new SqlParameter("@IsLeaf", SqlDbType.VarChar,1),
					new SqlParameter("@MenuLevel", SqlDbType.VarChar,1),
					new SqlParameter("@RootID", SqlDbType.VarChar,32),
					new SqlParameter("@ParentsID", SqlDbType.VarChar,32),
					new SqlParameter("@DisplayOrder", SqlDbType.Decimal,5),
					new SqlParameter("@IcValue", SqlDbType.VarChar,200),
					new SqlParameter("@IsPop", SqlDbType.VarChar,1),
					new SqlParameter("@MenuSeq", SqlDbType.VarChar,300)};
            parameters[0].Value = t.MenuID;
            parameters[1].Value = t.MenuName;
            parameters[2].Value = t.MenuUrl;
            parameters[3].Value = t.FunctionID;
            parameters[4].Value = t.IsLeaf;
            parameters[5].Value = t.MenuLevel;
            parameters[6].Value = t.RootID;
            parameters[7].Value = t.ParentsID;
            parameters[8].Value = t.DisplayOrder;
            parameters[9].Value = t.IcValue;
            parameters[10].Value = t.IsPop;
            parameters[11].Value = t.MenuSeq;

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

        public bool Update(Model.Sys_Menu t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_Menu set ");
            strSql.Append("MenuName=@MenuName,");
            strSql.Append("MenuUrl=@MenuUrl,");
            strSql.Append("FunctionID=@FunctionID,");
            strSql.Append("IsLeaf=@IsLeaf,");
            strSql.Append("MenuLevel=@MenuLevel,");
            strSql.Append("RootID=@RootID,");
            strSql.Append("ParentsID=@ParentsID,");
            strSql.Append("DisplayOrder=@DisplayOrder,");
            strSql.Append("IcValue=@IcValue,");
            strSql.Append("IsPop=@IsPop,");
            strSql.Append("MenuSeq=@MenuSeq");
            strSql.Append(" where MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MenuName", SqlDbType.NVarChar,50),
					new SqlParameter("@MenuUrl", SqlDbType.VarChar,300),
					new SqlParameter("@FunctionID", SqlDbType.NVarChar,100),
					new SqlParameter("@IsLeaf", SqlDbType.VarChar,1),
					new SqlParameter("@MenuLevel", SqlDbType.VarChar,1),
					new SqlParameter("@RootID", SqlDbType.VarChar,32),
					new SqlParameter("@ParentsID", SqlDbType.VarChar,32),
					new SqlParameter("@DisplayOrder", SqlDbType.Decimal,5),
					new SqlParameter("@IcValue", SqlDbType.VarChar,200),
					new SqlParameter("@IsPop", SqlDbType.VarChar,1),
					new SqlParameter("@MenuSeq", SqlDbType.VarChar,300),
					new SqlParameter("@MenuID", SqlDbType.NVarChar,20)};
            parameters[0].Value = t.MenuName;
            parameters[1].Value = t.MenuUrl;
            parameters[2].Value = t.FunctionID;
            parameters[3].Value = t.IsLeaf;
            parameters[4].Value = t.MenuLevel;
            parameters[5].Value = t.RootID;
            parameters[6].Value = t.ParentsID;
            parameters[7].Value = t.DisplayOrder;
            parameters[8].Value = t.IcValue;
            parameters[9].Value = t.IsPop;
            parameters[10].Value = t.MenuSeq;
            parameters[11].Value = t.MenuID;

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

        public bool Delete(Model.Sys_Menu t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_Menu ");
            strSql.Append(" where MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.NVarChar,20)			};
            parameters[0].Value = t.MenuID;

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
            strSql.Append("delete from Sys_Menu ");
            strSql.Append(" where MenuID in (" + IDlist + ")  ");
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

        public Model.Sys_Menu GetModel(Model.Sys_Menu t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MenuID,MenuName,MenuUrl,FunctionID,IsLeaf,MenuLevel,RootID,ParentsID,DisplayOrder,IcValue,IsPop,MenuSeq from Sys_Menu ");
            strSql.Append(" where MenuID=@MenuID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.NVarChar,20)			};
            parameters[0].Value = t.MenuID;

            TDTK.PlatForm.MVC4.Model.Sys_Menu model = new TDTK.PlatForm.MVC4.Model.Sys_Menu();
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

        public Model.Sys_Menu DataRowToModel(DataRow row)
        {
            TDTK.PlatForm.MVC4.Model.Sys_Menu model = new TDTK.PlatForm.MVC4.Model.Sys_Menu();
            if (row != null)
            {
                if (row["MenuID"] != null)
                {
                    model.MenuID = row["MenuID"].ToString();
                }
                if (row["MenuName"] != null)
                {
                    model.MenuName = row["MenuName"].ToString();
                }
                if (row["MenuUrl"] != null)
                {
                    model.MenuUrl = row["MenuUrl"].ToString();
                }
                if (row["FunctionID"] != null)
                {
                    model.FunctionID = row["FunctionID"].ToString();
                }
                if (row["IsLeaf"] != null)
                {
                    model.IsLeaf = row["IsLeaf"].ToString();
                }
                if (row["MenuLevel"] != null)
                {
                    model.MenuLevel = row["MenuLevel"].ToString();
                }
                if (row["RootID"] != null)
                {
                    model.RootID = row["RootID"].ToString();
                }
                if (row["ParentsID"] != null)
                {
                    model.ParentsID = row["ParentsID"].ToString();
                }
                if (row["DisplayOrder"] != null && row["DisplayOrder"].ToString() != "")
                {
                    model.DisplayOrder = decimal.Parse(row["DisplayOrder"].ToString());
                }
                if (row["IcValue"] != null)
                {
                    model.IcValue = row["IcValue"].ToString();
                }
                if (row["IsPop"] != null)
                {
                    model.IsPop = row["IsPop"].ToString();
                }
                if (row["MenuSeq"] != null)
                {
                    model.MenuSeq = row["MenuSeq"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MenuID,MenuName,MenuUrl,FunctionID,IsLeaf,MenuLevel,RootID,ParentsID,DisplayOrder,IcValue,IsPop,MenuSeq ");
            strSql.Append(" FROM Sys_Menu ");
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
            strSql.Append(" MenuID,MenuName,MenuUrl,FunctionID,IsLeaf,MenuLevel,RootID,ParentsID,DisplayOrder,IcValue,IsPop,MenuSeq ");
            strSql.Append(" FROM Sys_Menu ");
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
            strSql.Append("select count(1) FROM Sys_Menu ");
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
                strSql.Append("order by T.MenuID desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_Menu T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取树形菜单
        /// </summary>
        /// <param name="rootID">根节点id</param>
        /// <returns></returns>
        public Dictionary<TreeRoot, List<TreeItems>> GetTree(string rootID)
        {
            Dictionary<TreeRoot, List<TreeItems>> d = new Dictionary<TreeRoot, List<TreeItems>>();

            //获取菜单的根节点信息
            string sqlRoots = " select * FROM [Sys_Menu] where RootID='"+rootID+"' and IsLeaf=0";
            DataSet dsRoots = DbHelperSQL.Query(sqlRoots);

            if (dsRoots.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsRoots.Tables[0].Rows.Count; i++)
                {
                    TreeRoot treeRoot = new TreeRoot();
                    string root = dsRoots.Tables[0].Rows[i]["MenuID"].ToString();
                    //添加根节点id 名称
                    treeRoot.ID = root;
                    treeRoot.Name = dsRoots.Tables[0].Rows[i]["MenuName"].ToString();
                    //获取根节点下的所有子节点
                    string sqlChild = " select * FROM [Sys_Menu] where RootID='s0002' and ParentsID='" + root + "' order by DisplayOrder";
                    DataSet dsChild = DbHelperSQL.Query(sqlChild);
                    List<TreeItems> list = new List<TreeItems>();
                    TreeItems items = null;

                    if (dsChild.Tables[0].Rows.Count > 0)
                    {
                        for (int e = 0; e < dsChild.Tables[0].Rows.Count; e++)
                        {
                            items = new TreeItems();
                            string name = dsChild.Tables[0].Rows[e]["MenuName"].ToString();
                            string url = dsChild.Tables[0].Rows[e]["MenuUrl"].ToString();
                            items.Name = name;
                            items.TreeUrl = url;
                            list.Add(items);
                        }

                    }
                    d.Add(treeRoot, list);
                }
            }
            return d;
        }
    }
   
    
}
