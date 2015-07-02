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
   public partial class TT_InitialCardBLL:ITT_InitialCardService
    {
       private readonly ITT_InitialCard dal=DataAccess.CreateTT_InitialCard();
       public TT_InitialCardBLL()
		{}
        public bool Exists(TT_InitialCard t)
        {
            return dal.Exists(t);
        }

        public int Add(TT_InitialCard t)
        {
            return dal.Add(t);
        }

        public bool Update(TT_InitialCard t)
        {
            return dal.Update(t);
        }

        public bool Delete(TT_InitialCard t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        public TT_InitialCard GetModel(TT_InitialCard t)
        {
            return dal.GetModel(t);
        }

        public TT_InitialCard DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.TT_InitialCard GetModelByCache(string cardID,string cardNo)
        {
            TT_InitialCard ini = new TT_InitialCard();
            ini.CardID = cardID;
            ini.CardNO = cardNo;
            string CacheKey = "TT_InitialCardModel-"+cardID+cardNo;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ini);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.TT_InitialCard)objModel;
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
        public List<TDTK.PlatForm.MVC4.Model.TT_InitialCard> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.TT_InitialCard> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.TT_InitialCard> modelList = new List<TDTK.PlatForm.MVC4.Model.TT_InitialCard>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.TT_InitialCard model;
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
