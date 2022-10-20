using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ServiceHelper
{
    public class CreateErpStkTransfer
    {
        public static string CreateForm(ScanInfo info)
        {

            K3CloudApi client = new K3CloudApi();

            string formId = "STK_TransferDirect";
            StkTransferNewData stkData = SetDataStr(info);
            string jsonData = JsonConvert.SerializeObject(stkData);

            string Info = "提交成功！";

            if (client.CheckAuthInfo().ResponseStatus.IsSuccess)
            {
                string saveResultStr = client.Save(formId, jsonData);
                if (saveResultStr.Contains("\"IsSuccess\":true"))
                {
                    ApiProcess.TrueData saveResult = JsonConvert.DeserializeObject<ApiProcess.TrueData>(saveResultStr);
                    SubmitData submitData = new SubmitData();
                    submitData.Ids = saveResult.result.Id.ToString();
                    string submitResultStr = client.Submit(formId
                        , JsonConvert.SerializeObject(submitData));
                    if (submitResultStr.Contains("\"IsSuccess\":true"))
                    {
                        AuditData auditData = new AuditData();
                        auditData.Ids = saveResult.result.Id.ToString();
                        string auditResultStr = client.Audit(formId, JsonConvert.SerializeObject(auditData));
                        if (submitResultStr.Contains("\"IsSuccess\":true"))
                        {
                        }
                        else
                        {
                            ApiProcess.FalseData resultJson = JsonConvert.DeserializeObject<ApiProcess.FalseData>(auditResultStr.ToString());
                            Info = "审核失败：" + string.Join("\n", (from p in resultJson.result.responseStatus.errors
                                                                select p.Message).ToList());
                        }
                    }
                    else
                    {
                        ApiProcess.FalseData resultJson = JsonConvert.DeserializeObject<ApiProcess.FalseData>(submitResultStr.ToString());
                        Info = "提交失败：" + string.Join("\n", (from p in resultJson.result.responseStatus.errors
                                                            select p.Message).ToList());
                    }
                }
                else
                {
                    ApiProcess.FalseData resultJson = JsonConvert.DeserializeObject<ApiProcess.FalseData>(saveResultStr.ToString());
                    Info = "保存失败：" + string.Join("\n", (from p in resultJson.result.responseStatus.errors
                                                        select p.Message).ToList());
                }
            }
            else
            {
                Info = ("金蝶运星空登陆信息异常！");
            }
            return Info;
        }

        public static StkTransferNewData SetDataStr(ScanInfo info)
        {
            StkTransferNewData dataValue = new StkTransferNewData();

            DataTable dt = ServiceHelper.DbServiceHepler.GetDataTable(
                string.Format(@"SELECT * FROM V_ZZ_TM_MATERIAL_API
                                    WHERE FNUMBER='{0}'", info.barCode));

            if (dt == null || dt.Rows.Count <= 0)
            {
                return dataValue;
            }
            DataRow dr = dt.Rows[0];
            if (info.qty > StringParse.ObjectToDecimal(dr["FQTY"]))
            {
                throw new Exception("调拔数量大于库存数量，请确认！");
            }
            if (info.auxQty > StringParse.ObjectToDecimal(dr["FAUXQTY"]))
            {
                throw new Exception("调拔数量大于库存数量，请确认！");
            }
            //设置单据头
            StkTransferHead headData = new StkTransferHead();
            headData.FBillTypeID = new BaseData { FNumber = "ZJDB01_SYS" };
            headData.StockOutOrgId = new BaseData { FNumber = StringParse.ObjectToString(dr["FSTOCKSTATUSNUMBER"]) };
            headData.StockOrgId = new BaseData { FNumber = StringParse.ObjectToString(dr["FSTOCKSTATUSNUMBER"]) };
            headData.FOwnerTypeOutIdHead = StringParse.ObjectToString(dr["FOWNERTYPEID"]);
            headData.FOwnerOutIdHead = new BaseData { FNumber = StringParse.ObjectToString(dr["FOWNERNUMBER"]) };
            headData.FOwnerTypeIdHead = StringParse.ObjectToString(dr["FOWNERTYPEID"]);
            headData.FOwnerIdHead = new BaseData { FNumber = StringParse.ObjectToString(dr["FOWNERNUMBER"]) };
            //设置单据体
            StkTransferEntry entryData = new StkTransferEntry();
            entryData.FMaterialId = new BaseData { FNumber = StringParse.ObjectToString(dr["FMATERIALNUMBER"]) };
            entryData.FAuxPropId =
                new FlexsValue
                {
                    FAUXPROPID__FF100002 =
                                 new BaseData { FNumber = StringParse.ObjectToString(dr["FCZNUMBER"]) },
                    FAUXPROPID__FF100003 =
                                 new BaseData { FNumber = StringParse.ObjectToString(dr["FCDNUMBER"]) },
                    FAUXPROPID__FF100004 =
                                    string.IsNullOrWhiteSpace(StringParse.ObjectToString(dr["FDZCD"])) ? "C" : StringParse.ObjectToString(dr["FDZCD"]),
                    FAUXPROPID__FF100005 =
                                 new BaseData { FNumber = StringParse.ObjectToString(dr["FBMNUMBER"]) },
                    FAUXPROPID__FF100013 =
                                 new BaseData { FNumber = StringParse.ObjectToString(dr["FTYGCNUMBER"]) }
                };
            //来源信息
            entryData.FSrcStockId = new BaseData { FNumber = StringParse.ObjectToString(dr["FSTOCKNUMBER"]) };
            entryData.FSrcStockLocId = StringParse.ObjectToLong(dr["FSTOCKLOCID"]) == 0 ? "" :
                                       StringParse.ObjectToLong(dr["FSTOCKLOCID"]).ToString();
            entryData.FLot = new BaseData { FNumber = StringParse.ObjectToString(dr["FLOT_TEXT"]) };
            entryData.FSrcStockStatusId = new BaseData { FNumber = StringParse.ObjectToString(dr["FSTOCKSTATUSNUMBER"]) };
            entryData.FOwnerTypeOutId = StringParse.ObjectToString(dr["FOWNERTYPEID"]);
            entryData.FOwnerOutId = new BaseData { FNumber = StringParse.ObjectToString(dr["FOWNERNUMBER"]) };
            entryData.FKeeperTypeOutId = StringParse.ObjectToString(dr["FKEEPERTYPEID"]);
            entryData.FKeeperOutId = new BaseData { FNumber = StringParse.ObjectToString(dr["FKEEPERNUMBER"]) };
            entryData.FUnitID = new BaseData { FNumber = StringParse.ObjectToString(dr["FBASEUNITNUMBER"]) };
            entryData.FSecUnitId = new BaseData { FNumber = StringParse.ObjectToString(dr["FAUXUNITNUMBER"]) };
            entryData.FBaseUnitId = new BaseData { FNumber = StringParse.ObjectToString(dr["FBASEUNITNUMBER"]) };
            entryData.FQty = info.qty;
            entryData.FSecQty = info.auxQty;
            //目标信息
            string stockSql = string.Format("SELECT FNUMBER FROM T_BD_STOCK WHERE FSTOCKID={0}", info.stockId);
            entryData.FDestStockId = new BaseData
            {
                FNumber = StringParse.ObjectToString(ServiceHelper.DbServiceHepler.ExecuteScalar(stockSql))
            };
            entryData.FDestStockLocId = new StockLoc_dest
            {
                FDestStockLocId__FF100011 =
                                 new BaseData { FNumber = info.stockLocId }
            };
            entryData.FDestLot = entryData.FLot;
           //entryData.FDestStockLocId = info.stockLocId;
           entryData.FDestStockStatusId = new BaseData { FNumber = StringParse.ObjectToString(dr["FSTOCKSTATUSNUMBER"]) };
            entryData.FOwnerTypeId = StringParse.ObjectToString(dr["FOWNERTYPEID"]);
            entryData.FOwnerId = new BaseData { FNumber = StringParse.ObjectToString(dr["FOWNERNUMBER"]) };
            entryData.FKeeperTypeId = dr["FKEEPERTYPEID"].ToString();
            entryData.FKeeperId = new BaseData { FNumber = StringParse.ObjectToString(dr["FKEEPERNUMBER"]) };

            ///单据信息组合
            //设置单据体
            List<StkTransferEntry> newEntrys = new List<StkTransferEntry>();
            newEntrys.Add(entryData);
            headData.FBillEntry = newEntrys;
            //设置单据头
            dataValue.Model = headData;
            //返回数据
            return dataValue;
        }
    }
    /// <summary>
    /// 调拔单数据包
    /// </summary>
    public struct StkTransferNewData
    {
        public bool IsDeleteEntry
        {
            get { return true; }
        }
        public bool IsVerifyBaseDataField
        {
            get { return false; }
        }
        public bool IsEntryBatchFill
        {
            get { return true; }
        }
        public bool ValidateFlag
        {
            get { return true; }
        }
        public bool NumberSearch
        {
            get
            {
                return true;
            }
        }
        public bool IsAutoAdjustField
        {
            get { return true; }
        }
        public StkTransferHead Model { get; set; }
    }
    /// <summary>
    /// 调拔单据头数据包
    /// </summary>
    public struct StkTransferHead
    {
        //调出库存组织    FStockOutOrgId   FNumber
        public BaseData StockOutOrgId { get; set; }
        //调入库存组织    FStockOrgId     FNumber
        public BaseData StockOrgId { get; set; }
        //单据类型 
        public BaseData FBillTypeID { get; set; }
        //调出货主类型            
        public string FOwnerTypeOutIdHead { get; set; }
        //调出货主   
        public BaseData FOwnerOutIdHead { get; set; }
        //调入货主类型     
        public string FOwnerTypeIdHead { get; set; }
        //调入货主  
        public BaseData FOwnerIdHead { get; set; }
        //业务类型
        public string FBizType
        {
            get { return "NORMAL"; }
        }
        //调拨方向  
        public string FTransferDirect
        {
            get { return "GENERAL"; }
        }
        //调拨类型  
        //组织内调拨
        public string FTransferBizType
        {
            get { return "InnerOrgTransfer"; }
        }
        //日期    FDate
        public DateTime FDate
        {
            get { return DateTime.Now; }
        }
        public List<StkTransferEntry> FBillEntry { get; set; }
    }
    /// <summary>
    /// 调拨单据体数据包
    /// </summary>
    public struct StkTransferEntry
    {
        //行类型
        public string FRowType
        {
            get
            {
                return "Standard";
            }
        }
        //物料 
        public BaseData FMaterialId { get; set; }
        //辅助属性
        public FlexsValue FAuxPropId { get; set; }
        //调出仓库    
        public BaseData FSrcStockId { get; set; }
        //调出仓位      
        public string FSrcStockLocId { get; set; }
        //调出批号 
        public BaseData FLot { get; set; }
        //调出库存状态 
        public BaseData FSrcStockStatusId { get; set; }
        //调出货主类型            
        public string FOwnerTypeOutId { get; set; }
        //调出货主   
        public BaseData FOwnerOutId { get; set; }
        //调出保管者类型       
        public string FKeeperTypeOutId { get; set; }
        //调出保管者 
        public BaseData FKeeperOutId { get; set; }
        //单位 
        public BaseData FUnitID { get; set; }
        //辅单位 
        public BaseData FSecUnitId { get; set; }
        //基本单位  
        public BaseData FBaseUnitId { get; set; }
        //调拨数量   
        public decimal FQty { get; set; }
        //辅数量   
        public decimal FSecQty { get; set; }
        //调入仓库 
        public BaseData FDestStockId { get; set; }
        //调入仓位      
        public StockLoc_dest FDestStockLocId { get; set; }
        //调入批号
        public BaseData FDestLot { get; set; }
        //调入货主类型     
        public string FOwnerTypeId { get; set; }
        //调入货主  
        public BaseData FOwnerId { get; set; }
        //调入保管者类型       
        public string FKeeperTypeId { get; set; }
        //调入保管者  
        public BaseData FKeeperId { get; set; }
        //调入库存状态  
        public BaseData FDestStockStatusId { get; set; }
    }
    //基础资料
    public struct BaseData
    {
        public string FNumber { get; set; }
    }
    //仓位
    public struct StockLoc
    {
        public BaseData FSRCSTOCKLOCID__FF100011 { get; set; }
    }
    //仓位
    public struct StockLoc_dest
    {
        public BaseData FDestStockLocId__FF100011 { get; set; }
    }
    //辅助属性
    public struct FlexsValue
    {
        public BaseData FAUXPROPID__FF100002 { get; set; }
        public BaseData FAUXPROPID__FF100003 { get; set; }
        public BaseData FAUXPROPID__FF100005 { get; set; }
        public string FAUXPROPID__FF100004 { get; set; }
        public BaseData FAUXPROPID__FF100013 { get; set; }
    }
    public struct SubmitData
    {
        public long CreateOrgId { get; set; }
        public Array Numbers { get; set; }
        public string Ids { get; set; }
        public long SelectedPostId { get; set; }
        public string NetworkCtrl { get; set; }
    }
    public struct AuditData
    {
        public long CreateOrgId { get; set; }
        public Array Numbers { get; set; }
        public string Ids { get; set; }
        public string InterationFlags { get; set; }        
        public string NetworkCtrl { get; set; }
        public string IsVerifyProcInst { get; set; }
    }

    /// <summary>
    /// 条码界面传入信息
    /// </summary>
    public struct ScanInfo
    {
        public string barCode { get; set; }
        public decimal qty { get; set; }
        public decimal auxQty { get; set; }
        public long stockId { get; set; }
        public string stockLocId { get; set; }
        public string scbh { get; set; }
    }
}
