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
   public  class SYS_FailerSendMessage2012BLL:ISYS_FailerSendMessage2012Service
    {
       private readonly ISYS_FailerSendMessage2012 dal=DataAccess.CreateSYS_FailerSendMessage2012();
       public SYS_FailerSendMessage2012BLL()
		{}
       /// <summary>
       /// 得到最大ID
       /// </summary>
       public int GetMaxId()
       {
           return dal.GetMaxId();
       }

       public bool Exists(SYS_FailerSendMessage2012 t)
       {
           return dal.Exists(t);
       }

       public int Add(SYS_FailerSendMessage2012 t)
       {
           return dal.Add(t);
       }

       public bool Update(SYS_FailerSendMessage2012 t)
       {
           return dal.Update(t);
       }

       public bool Delete(SYS_FailerSendMessage2012 t)
       {
           return dal.Delete(t);
       }

       public bool DeleteList(string IDlist)
       {
           return dal.DeleteList(IDlist);
       }

       public SYS_FailerSendMessage2012 GetModel(SYS_FailerSendMessage2012 t)
       {
           return dal.GetModel(t);
       }
       /// <summary>
       /// 得到一个对象实体，从缓存中
       /// </summary>
       public TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012 GetModelByCache(int FSMID)
       {
           SYS_FailerSendMessage2012 sfm = new SYS_FailerSendMessage2012();
           sfm.FSMID = FSMID;
           string CacheKey = "SYS_FailerSendMessage2012Model-" + FSMID;
           object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
           if (objModel == null)
           {
               try
               {
                   objModel = dal.GetModel(sfm);
                   if (objModel != null)
                   {
                       int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                       Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                   }
               }
               catch { }
           }
           return (TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012)objModel;
       }

       public SYS_FailerSendMessage2012 DataRowToModel(DataRow row)
       {
           return dal.DataRowToModel(row);
       }

       public DataSet GetList(string strWhere)
       {
           return dal.GetList(strWhere);
       }

       public DataSet GetList(int Top, string strWhere, string filedOrder)
       {
           return dal.GetList(Top, strWhere, filedOrder);
       }
       /// <summary>
       /// 获得数据列表
       /// </summary>
       public List<TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012> GetModelList(string strWhere)
       {
           DataSet ds = dal.GetList(strWhere);
           return DataTableToList(ds.Tables[0]);
       }
       /// <summary>
       /// 获得数据列表
       /// </summary>
       public List<TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012> DataTableToList(DataTable dt)
       {
           List<TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012> modelList = new List<TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012>();
           int rowsCount = dt.Rows.Count;
           if (rowsCount > 0)
           {
               TDTK.PlatForm.MVC4.Model.SYS_FailerSendMessage2012 model;
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
    }
}
