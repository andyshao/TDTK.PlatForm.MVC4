﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDTK.PlatForm.MVC4.IBLL
{
   public interface IBaseService<T> where T:class,new()
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(T t);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(T t);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(T t);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(T t);
        bool DeleteList(string IDlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        T GetModel(T t);
        T DataRowToModel(DataRow row);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法
    }
}
