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
   public partial class TT_CollRunCoalKindBLL:ITT_CollRunCoalKindService
    {
       private readonly ITT_CollRunCoalKind dal=DataAccess.CreateTT_CollRunCoalKind();
       public TT_CollRunCoalKindBLL()
		{}
        public bool Exists(TT_CollRunCoalKind t)
        {
            return dal.Exists(t);
        }

        public int Add(TT_CollRunCoalKind t)
        {
            return dal.Add(t);
        }

        public bool Update(TT_CollRunCoalKind t)
        {
            return dal.Update(t);
        }

        public bool Delete(TT_CollRunCoalKind t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        public TT_CollRunCoalKind GetModel(TT_CollRunCoalKind t)
        {
            return dal.GetModel(t);
        }

        public TT_CollRunCoalKind DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind GetModelByCache(string CollCode, string CoalKindCode)
        {
            TT_CollRunCoalKind crc = new TT_CollRunCoalKind();
            crc.CollCode = CollCode;
            crc.CoalKindCode = CoalKindCode;
            string CacheKey = "TT_CollRunCoalKindModel-" + CollCode + CoalKindCode;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(crc);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind)objModel;
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
        public List<TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind> modelList = new List<TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.TT_CollRunCoalKind model;
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

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
    }
}
