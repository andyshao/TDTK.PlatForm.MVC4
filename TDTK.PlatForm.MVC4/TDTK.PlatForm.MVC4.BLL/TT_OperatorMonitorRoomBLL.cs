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
   public partial class TT_OperatorMonitorRoomBLL:ITT_OperatorMonitorRoomService
    {
       private readonly ITT_OperatorMonitorRoom dal=DataAccess.CreateTT_OperatorMonitorRoom();
       public TT_OperatorMonitorRoomBLL()
		{}
        public bool Exists(TT_OperatorMonitorRoom t)
        {
            return dal.Exists(t);
        }

        public int Add(TT_OperatorMonitorRoom t)
        {
            return dal.Add(t);
        }

        public bool Update(TT_OperatorMonitorRoom t)
        {
            return dal.Update(t);
        }

        public bool Delete(TT_OperatorMonitorRoom t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        public TT_OperatorMonitorRoom GetModel(TT_OperatorMonitorRoom t)
        {
            return dal.GetModel(t);
        }

        public TT_OperatorMonitorRoom DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom GetModelByCache(string UserCode, string RoomCode)
        {
            TT_OperatorMonitorRoom omr = new TT_OperatorMonitorRoom();
            omr.UserCode = UserCode;
            omr.RoomCode = RoomCode;
            string CacheKey = "TT_OperatorMonitorRoomModel-" + UserCode + RoomCode;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(omr);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom)objModel;
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
        public List<TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom> modelList = new List<TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.TT_OperatorMonitorRoom model;
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
