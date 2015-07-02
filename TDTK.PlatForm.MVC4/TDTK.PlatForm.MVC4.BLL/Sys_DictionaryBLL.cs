using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.DALFactory;
using TDTK.PlatForm.MVC4.IBLL;
using TDTK.PlatForm.MVC4.IDAL;
using TDTK.PlatForm.MVC4.Model;

namespace TDTK.PlatForm.MVC4.BLL
{
    public class Sys_DictionaryBLL : ISys_DictionaryServiece
    {
        private readonly ISys_Dictionary dal=DataAccess.CreateSys_Dictionary();
        public Sys_DictionaryBLL()
		{}
        public bool Exists(Sys_Dictionary t)
        {
            return dal.Exists(t);
        }

        public int Add(Sys_Dictionary t)
        {
            return dal.Add(t);
        }

        public bool Update(Sys_Dictionary t)
        {
            return dal.Update(t);
        }

        public bool Delete(Sys_Dictionary t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        public Sys_Dictionary GetModel(Sys_Dictionary t)
        {
            return dal.GetModel(t);
        }

        public Sys_Dictionary DataRowToModel(System.Data.DataRow row)
        {
            return dal.DataRowToModel(row);
        }
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.Sys_Dictionary GetModelByCache(string BusinID, string BusinTypeID)
        {
            Sys_Dictionary sd = new Sys_Dictionary();
            sd.BusinID = BusinID;
            sd.BusinTypeID = BusinTypeID;
            string CacheKey = "Sys_DictionaryModel-" + BusinID + BusinTypeID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(sd);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.Sys_Dictionary)objModel;
        }
        public System.Data.DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.Sys_Dictionary> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.Sys_Dictionary> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.Sys_Dictionary> modelList = new List<TDTK.PlatForm.MVC4.Model.Sys_Dictionary>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.Sys_Dictionary model;
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

        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
    }
}
