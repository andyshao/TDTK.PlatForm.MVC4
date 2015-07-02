using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.DALFactory;
using TDTK.PlatForm.MVC4.IBLL;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.Model;
using System.Data;

namespace TDTK.PlatForm.MVC4.BLL
{
    public class Sys_OperatorBLL : ISys_OperatorService
    {
       private readonly ISys_Operator dal=DataAccess.CreateSys_Operator();
       public Sys_OperatorBLL()
		{}
        public bool Exists(Sys_Operator t)
        {
            return dal.Exists(t);
        }

        public int Add(Sys_Operator t)
        {
            return dal.Add(t);
        }

        public bool Update(Sys_Operator t)
        {
            return dal.Update(t);
        }

        public bool Delete(Sys_Operator t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        public Sys_Operator GetModel(Sys_Operator t)
        {
            return dal.GetModel(t);
        }

        public Sys_Operator DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.Sys_Operator GetModelByCache(string UserCode)
        {
            Sys_Operator so = new Sys_Operator();
            so.UserCode = UserCode;
            string CacheKey = "Sys_OperatorModel-" + UserCode;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(so);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.Sys_Operator)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.Sys_Operator> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.Sys_Operator> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.Sys_Operator> modelList = new List<TDTK.PlatForm.MVC4.Model.Sys_Operator>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.Sys_Operator model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 获取该用户下的所有职位信息，以字符串形式返回。每个职位以逗号分隔
        /// </summary>
        /// <param name="userID">用户id</param>
        /// <returns></returns>
        public string GetPosition(int userID)
        {
            return dal.GetPosition(userID);
        }
    }
}
