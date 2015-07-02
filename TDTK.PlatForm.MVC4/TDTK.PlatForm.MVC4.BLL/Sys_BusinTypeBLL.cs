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
   public class Sys_BusinTypeBLL:ISys_BusinTypeService
    {
       private readonly ISys_BusinType dal=DataAccess.CreateSys_BusinType();
       public Sys_BusinTypeBLL()
		{}
        public bool Exists(Sys_BusinType t)
        {
            return dal.Exists(t);
        }

        public int Add(Sys_BusinType t)
        {
            return dal.Add(t);
        }

        public bool Update(Sys_BusinType t)
        {
            return dal.Update(t);
        }

        public bool Delete(Sys_BusinType t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        public Sys_BusinType GetModel(Sys_BusinType t)
        {
            return dal.GetModel(t);
        }
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.Sys_BusinType GetModelByCache(string BusinTypeID)
        {
            Sys_BusinType sbt = new Sys_BusinType();
            sbt.BusinTypeID = BusinTypeID;
            string CacheKey = "Sys_BusinTypeModel-" + BusinTypeID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(sbt);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.Sys_BusinType)objModel;
        }

        public Sys_BusinType DataRowToModel(System.Data.DataRow row)
        {
            return dal.DataRowToModel(row);
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
        public List<TDTK.PlatForm.MVC4.Model.Sys_BusinType> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.Sys_BusinType> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.Sys_BusinType> modelList = new List<TDTK.PlatForm.MVC4.Model.Sys_BusinType>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.Sys_BusinType model;
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
