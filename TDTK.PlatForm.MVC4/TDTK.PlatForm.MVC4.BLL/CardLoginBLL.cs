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
    /// <summary>
    /// CardLogin
    /// </summary>
    public partial class CardLoginBLL : ICardLoginService
    {
        private readonly ICardLogin dal = DataAccess.CreateCardLogin();
        public CardLoginBLL()
        { }
        public bool Exists(Model.CardLogin t)
        {
            return dal.Exists(t);
        }

        public int Add(Model.CardLogin t)
        {
            return dal.Add(t);
        }

        public bool Update(Model.CardLogin t)
        {
            return dal.Update(t);
        }

        public bool Delete(Model.CardLogin t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        public Model.CardLogin GetModel(Model.CardLogin t)
        {
            return dal.GetModel(t);
        }
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.CardLogin GetModelByCache(int ID)
        {
            TDTK.PlatForm.MVC4.Model.CardLogin cl = new TDTK.PlatForm.MVC4.Model.CardLogin();
            cl.ID = ID;
            string CacheKey = "CardLoginModel-" + ID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(cl);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.CardLogin)objModel;
        }

        public Model.CardLogin DataRowToModel(System.Data.DataRow row)
        {
            return dal.DataRowToModel(row);
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
        public List<TDTK.PlatForm.MVC4.Model.CardLogin> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.CardLogin> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.CardLogin> modelList = new List<TDTK.PlatForm.MVC4.Model.CardLogin>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.CardLogin model;
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
        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
    }
}
