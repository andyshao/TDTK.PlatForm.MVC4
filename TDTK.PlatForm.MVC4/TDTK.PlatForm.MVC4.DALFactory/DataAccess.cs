using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TDTK.PlatForm.MVC4.DALFactory
{
    /// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
    /// </summary>
    public sealed class DataAccess
    {
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];
        public DataAccess()
        { }

        #region CreateObject

        //不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath, string classNamespace)
        {
            try
            {
                object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                return objType;
            }
            catch//(System.Exception ex)
            {
                //string str=ex.Message;// 记录错误日志
                return null;
            }

        }
        //使用缓存
        private static object CreateObject(string AssemblyPath, string classNamespace)
        {
            object objType = DataCache.GetCache(classNamespace);
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                    DataCache.SetCache(classNamespace, objType);// 写入缓存
                }
                catch//(System.Exception ex)
                {
                    //string str=ex.Message;// 记录错误日志
                }
            }
            return objType;
        }
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

        #region CreateSysManage
        //public static TDTK.PlatForm.MVC4.IDAL.ISysManage CreateSysManage()
        //{
        //    //方式1			
        //    //return (TDTK.PlatForm.MVC4.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

        //    //方式2 			
        //    string classNamespace = AssemblyPath + ".SysManage";
        //    object objType = CreateObject(AssemblyPath, classNamespace);
        //    return (TDTK.PlatForm.MVC4.IDAL.ISysManage)objType;
        //}
        #endregion



        /// <summary>
        /// 创建CardLogin数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ICardLogin CreateCardLogin()
        {

            string ClassNamespace = AssemblyPath + ".CardLogin";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ICardLogin)objType;
        }


        /// <summary>
        /// 创建Sys_BusinType数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_BusinType CreateSys_BusinType()
        {

            string ClassNamespace = AssemblyPath + ".Sys_BusinType";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_BusinType)objType;
        }


        /// <summary>
        /// 创建Sys_Colliery数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_Colliery CreateSys_Colliery()
        {

            string ClassNamespace = AssemblyPath + ".Sys_Colliery";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_Colliery)objType;
        }


        /// <summary>
        /// 创建Sys_Dictionary数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_Dictionary CreateSys_Dictionary()
        {

            string ClassNamespace = AssemblyPath + ".Sys_Dictionary";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_Dictionary)objType;
        }


        /// <summary>
        /// 创建SYS_FailerSendMessage2012数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISYS_FailerSendMessage2012 CreateSYS_FailerSendMessage2012()
        {

            string ClassNamespace = AssemblyPath + ".SYS_FailerSendMessage2012";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISYS_FailerSendMessage2012)objType;
        }


        /// <summary>
        /// 创建Sys_FileSave数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_FileSave CreateSys_FileSave()
        {

            string ClassNamespace = AssemblyPath + ".Sys_FileSave";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_FileSave)objType;
        }


        /// <summary>
        /// 创建Sys_LeaveWord数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_LeaveWord CreateSys_LeaveWord()
        {

            string ClassNamespace = AssemblyPath + ".Sys_LeaveWord";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_LeaveWord)objType;
        }


        /// <summary>
        /// 创建Sys_Menu数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_Menu CreateSys_Menu()
        {

            string ClassNamespace = AssemblyPath + ".Sys_Menu";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_Menu)objType;
        }


        /// <summary>
        /// 创建Sys_MenuPosition数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_MenuPosition CreateSys_MenuPosition()
        {

            string ClassNamespace = AssemblyPath + ".Sys_MenuPosition";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_MenuPosition)objType;
        }


        /// <summary>
        /// 创建Sys_OperateLog数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_OperateLog CreateSys_OperateLog()
        {

            string ClassNamespace = AssemblyPath + ".Sys_OperateLog";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_OperateLog)objType;
        }


        /// <summary>
        /// 创建Sys_Operator数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_Operator CreateSys_Operator()
        {

            string ClassNamespace = AssemblyPath + ".Sys_Operator";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_Operator)objType;
        }


        /// <summary>
        /// 创建Sys_OperatorPosition数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_OperatorPosition CreateSys_OperatorPosition()
        {

            string ClassNamespace = AssemblyPath + ".Sys_OperatorPosition";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_OperatorPosition)objType;
        }


        /// <summary>
        /// 创建Sys_Organization数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISys_Organization CreateSys_Organization()
        {

            string ClassNamespace = AssemblyPath + ".Sys_Organization";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISys_Organization)objType;
        }


        /// <summary>
        /// 创建SYS_Position数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISYS_Position CreateSYS_Position()
        {

            string ClassNamespace = AssemblyPath + ".SYS_Position";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISYS_Position)objType;
        }


        /// <summary>
        /// 创建SYS_ReceiveMessage2012数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISYS_ReceiveMessage2012 CreateSYS_ReceiveMessage2012()
        {

            string ClassNamespace = AssemblyPath + ".SYS_ReceiveMessage2012";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISYS_ReceiveMessage2012)objType;
        }


        /// <summary>
        /// 创建SYS_SucceedSendMessage2012数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ISYS_SucceedSendMessage2012 CreateSYS_SucceedSendMessage2012()
        {

            string ClassNamespace = AssemblyPath + ".SYS_SucceedSendMessage2012";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ISYS_SucceedSendMessage2012)objType;
        }


        /// <summary>
        /// 创建TT_BadHandle数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_BadHandle CreateTT_BadHandle()
        {

            string ClassNamespace = AssemblyPath + ".TT_BadHandle";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_BadHandle)objType;
        }


        /// <summary>
        /// 创建TT_BadRecord数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_BadRecord CreateTT_BadRecord()
        {

            string ClassNamespace = AssemblyPath + ".TT_BadRecord";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_BadRecord)objType;
        }


        /// <summary>
        /// 创建TT_CarInfo数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_CarInfo CreateTT_CarInfo()
        {

            string ClassNamespace = AssemblyPath + ".TT_CarInfo";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_CarInfo)objType;
        }


        /// <summary>
        /// 创建TT_CheckBang数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_CheckBang CreateTT_CheckBang()
        {

            string ClassNamespace = AssemblyPath + ".TT_CheckBang";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_CheckBang)objType;
        }


        /// <summary>
        /// 创建TT_CoalKind数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_CoalKind CreateTT_CoalKind()
        {

            string ClassNamespace = AssemblyPath + ".TT_CoalKind";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_CoalKind)objType;
        }


        /// <summary>
        /// 创建TT_ColieryAccount数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_ColieryAccount CreateTT_ColieryAccount()
        {

            string ClassNamespace = AssemblyPath + ".TT_ColieryAccount";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_ColieryAccount)objType;
        }


        /// <summary>
        /// 创建TT_CollBalance数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_CollBalance CreateTT_CollBalance()
        {

            string ClassNamespace = AssemblyPath + ".TT_CollBalance";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_CollBalance)objType;
        }


        /// <summary>
        /// 创建TT_CollierySupervise数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_CollierySupervise CreateTT_CollierySupervise()
        {

            string ClassNamespace = AssemblyPath + ".TT_CollierySupervise";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_CollierySupervise)objType;
        }


        /// <summary>
        /// 创建TT_CollRunCoalKind数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_CollRunCoalKind CreateTT_CollRunCoalKind()
        {

            string ClassNamespace = AssemblyPath + ".TT_CollRunCoalKind";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_CollRunCoalKind)objType;
        }


        /// <summary>
        /// 创建TT_EmptyWeight数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_EmptyWeight CreateTT_EmptyWeight()
        {

            string ClassNamespace = AssemblyPath + ".TT_EmptyWeight";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_EmptyWeight)objType;
        }


        /// <summary>
        /// 创建TT_InitialCard数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_InitialCard CreateTT_InitialCard()
        {

            string ClassNamespace = AssemblyPath + ".TT_InitialCard";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_InitialCard)objType;
        }


        /// <summary>
        /// 创建TT_LoadWeight数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeight CreateTT_LoadWeight()
        {

            string ClassNamespace = AssemblyPath + ".TT_LoadWeight";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeight)objType;
        }


        /// <summary>
        /// 创建TT_LoadWeightBackup数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeightBackup CreateTT_LoadWeightBackup()
        {

            string ClassNamespace = AssemblyPath + ".TT_LoadWeightBackup";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeightBackup)objType;
        }


        /// <summary>
        /// 创建TT_LoadWeightByDay数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeightByDay CreateTT_LoadWeightByDay()
        {

            string ClassNamespace = AssemblyPath + ".TT_LoadWeightByDay";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeightByDay)objType;
        }


        /// <summary>
        /// 创建TT_LoadWeightEditLog数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeightEditLog CreateTT_LoadWeightEditLog()
        {

            string ClassNamespace = AssemblyPath + ".TT_LoadWeightEditLog";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_LoadWeightEditLog)objType;
        }


        /// <summary>
        /// 创建TT_MarkedCard数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_MarkedCard CreateTT_MarkedCard()
        {

            string ClassNamespace = AssemblyPath + ".TT_MarkedCard";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_MarkedCard)objType;
        }


        /// <summary>
        /// 创建TT_MarkedCardSendRecord数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_MarkedCardSendRecord CreateTT_MarkedCardSendRecord()
        {

            string ClassNamespace = AssemblyPath + ".TT_MarkedCardSendRecord";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_MarkedCardSendRecord)objType;
        }


        /// <summary>
        /// 创建TT_MessagePerson数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_MessagePerson CreateTT_MessagePerson()
        {

            string ClassNamespace = AssemblyPath + ".TT_MessagePerson";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_MessagePerson)objType;
        }


        /// <summary>
        /// 创建TT_MonitorLoadWeight数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_MonitorLoadWeight CreateTT_MonitorLoadWeight()
        {

            string ClassNamespace = AssemblyPath + ".TT_MonitorLoadWeight";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_MonitorLoadWeight)objType;
        }


        /// <summary>
        /// 创建TT_MonitorOperator数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_MonitorOperator CreateTT_MonitorOperator()
        {

            string ClassNamespace = AssemblyPath + ".TT_MonitorOperator";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_MonitorOperator)objType;
        }


        /// <summary>
        /// 创建TT_Navicert数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_Navicert CreateTT_Navicert()
        {

            string ClassNamespace = AssemblyPath + ".TT_Navicert";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_Navicert)objType;
        }


        /// <summary>
        /// 创建TT_NavicertLog数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_NavicertLog CreateTT_NavicertLog()
        {

            string ClassNamespace = AssemblyPath + ".TT_NavicertLog";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_NavicertLog)objType;
        }


        /// <summary>
        /// 创建TT_OperatorMonitorRoom数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_OperatorMonitorRoom CreateTT_OperatorMonitorRoom()
        {

            string ClassNamespace = AssemblyPath + ".TT_OperatorMonitorRoom";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_OperatorMonitorRoom)objType;
        }


        /// <summary>
        /// 创建TT_OutInWeight数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_OutInWeight CreateTT_OutInWeight()
        {

            string ClassNamespace = AssemblyPath + ".TT_OutInWeight";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_OutInWeight)objType;
        }


        /// <summary>
        /// 创建TT_OutLoadWeight数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_OutLoadWeight CreateTT_OutLoadWeight()
        {

            string ClassNamespace = AssemblyPath + ".TT_OutLoadWeight";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_OutLoadWeight)objType;
        }


        /// <summary>
        /// 创建TT_PitheadBill数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_PitheadBill CreateTT_PitheadBill()
        {

            string ClassNamespace = AssemblyPath + ".TT_PitheadBill";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_PitheadBill)objType;
        }


        /// <summary>
        /// 创建TT_PitheadBillDetail数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_PitheadBillDetail CreateTT_PitheadBillDetail()
        {

            string ClassNamespace = AssemblyPath + ".TT_PitheadBillDetail";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_PitheadBillDetail)objType;
        }


        /// <summary>
        /// 创建TT_PitheadBillExtend数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_PitheadBillExtend CreateTT_PitheadBillExtend()
        {

            string ClassNamespace = AssemblyPath + ".TT_PitheadBillExtend";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_PitheadBillExtend)objType;
        }


        /// <summary>
        /// 创建TT_RFCard数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_RFCard CreateTT_RFCard()
        {

            string ClassNamespace = AssemblyPath + ".TT_RFCard";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_RFCard)objType;
        }


        /// <summary>
        /// 创建TT_Room数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_Room CreateTT_Room()
        {

            string ClassNamespace = AssemblyPath + ".TT_Room";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_Room)objType;
        }


        /// <summary>
        /// 创建TT_RoomSupervise数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_RoomSupervise CreateTT_RoomSupervise()
        {

            string ClassNamespace = AssemblyPath + ".TT_RoomSupervise";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_RoomSupervise)objType;
        }


        /// <summary>
        /// 创建TT_Supervise数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_Supervise CreateTT_Supervise()
        {

            string ClassNamespace = AssemblyPath + ".TT_Supervise";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_Supervise)objType;
        }


        /// <summary>
        /// 创建TT_TaxAssignDetail数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TaxAssignDetail CreateTT_TaxAssignDetail()
        {

            string ClassNamespace = AssemblyPath + ".TT_TaxAssignDetail";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TaxAssignDetail)objType;
        }


        /// <summary>
        /// 创建TT_TaxItem数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TaxItem CreateTT_TaxItem()
        {

            string ClassNamespace = AssemblyPath + ".TT_TaxItem";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TaxItem)objType;
        }


        /// <summary>
        /// 创建TT_TaxItemDetail数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TaxItemDetail CreateTT_TaxItemDetail()
        {

            string ClassNamespace = AssemblyPath + ".TT_TaxItemDetail";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TaxItemDetail)objType;
        }


        /// <summary>
        /// 创建TT_TaxOutItemDetail数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TaxOutItemDetail CreateTT_TaxOutItemDetail()
        {

            string ClassNamespace = AssemblyPath + ".TT_TaxOutItemDetail";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TaxOutItemDetail)objType;
        }


        /// <summary>
        /// 创建TT_TaxUnit数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TaxUnit CreateTT_TaxUnit()
        {

            string ClassNamespace = AssemblyPath + ".TT_TaxUnit";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TaxUnit)objType;
        }


        /// <summary>
        /// 创建TT_TempCard数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TempCard CreateTT_TempCard()
        {

            string ClassNamespace = AssemblyPath + ".TT_TempCard";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TempCard)objType;
        }


        /// <summary>
        /// 创建TT_TransferAccounts数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TransferAccounts CreateTT_TransferAccounts()
        {

            string ClassNamespace = AssemblyPath + ".TT_TransferAccounts";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TransferAccounts)objType;
        }


        /// <summary>
        /// 创建TT_TwoPrintLog数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_TwoPrintLog CreateTT_TwoPrintLog()
        {

            string ClassNamespace = AssemblyPath + ".TT_TwoPrintLog";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_TwoPrintLog)objType;
        }


        /// <summary>
        /// 创建TT_WaterBook数据层接口。
        /// </summary>
        public static TDTK.PlatForm.MVC4.IDAL.ITT_WaterBook CreateTT_WaterBook()
        {

            string ClassNamespace = AssemblyPath + ".TT_WaterBook";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (TDTK.PlatForm.MVC4.IDAL.ITT_WaterBook)objType;
        }

    }
}
