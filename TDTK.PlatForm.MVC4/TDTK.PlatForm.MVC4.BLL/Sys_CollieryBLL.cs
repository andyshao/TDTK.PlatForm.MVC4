﻿using System;
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
    public class Sys_CollieryBLL:ISys_CollieryService
    {
        private readonly ISys_Colliery dal = DataAccess.CreateSys_Colliery();
        public Sys_CollieryBLL()
        { }

        public bool Exists(Sys_Colliery t)
        {
            return dal.Exists(t);
        }

        public int Add(Sys_Colliery t)
        {
            return dal.Add(t);
        }

        public bool Update(Sys_Colliery t)
        {
            return dal.Update(t);
        }

        public bool Delete(Sys_Colliery t)
        {
            return dal.Delete(t);
        }

        public bool DeleteList(string IDlist)
        {
            
            return dal.DeleteList(IDlist);
        }

        public Sys_Colliery GetModel(Sys_Colliery t)
        {
            return dal.GetModel(t);
        }
        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public TDTK.PlatForm.MVC4.Model.Sys_Colliery GetModelByCache(string CollCode)
        {
            Sys_Colliery sc = new Sys_Colliery();
            sc.CollCode = CollCode;
            string CacheKey = "Sys_CollieryModel-" + CollCode;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(sc);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (TDTK.PlatForm.MVC4.Model.Sys_Colliery)objModel;
        }

        public Sys_Colliery DataRowToModel(System.Data.DataRow row)
        {
            return dal.DataRowToModel(row);
        }

        public System.Data.DataSet GetList(string strWhere)
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
        public List<TDTK.PlatForm.MVC4.Model.Sys_Colliery> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<TDTK.PlatForm.MVC4.Model.Sys_Colliery> DataTableToList(DataTable dt)
        {
            List<TDTK.PlatForm.MVC4.Model.Sys_Colliery> modelList = new List<TDTK.PlatForm.MVC4.Model.Sys_Colliery>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TDTK.PlatForm.MVC4.Model.Sys_Colliery model;
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
        /// 总记录数
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
