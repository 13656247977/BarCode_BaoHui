using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHelper
{
    public class ApiProcess
    {

        /// <summary>
        /// API返回值成功
        /// </summary>
        public struct TrueData
        {
            public Result result { get; set; }
            public struct Result
            {
                public ResponseStatus responseStatus { get; set; }
                public long Id { get; set; }
                public string Number { get; set; }
                public JArray NeedReturnData { get; set; }
            }
            public struct ResponseStatus
            {
                public bool IsSuccess { get; set; }
                public JArray Errors { get; set; }
                public JArray SuccessEntitys { get; set; }
                public JArray SuccessMessages { get; set; }
                public int MsgCode { get; set; }
            }
        }


        /// <summary>
        /// API返回值失败
        /// </summary>
        public struct FalseData
        {
            public Result result { get; set; }
            public struct Result
            {
                public ResponseStatus responseStatus { get; set; }
                public string Id { get; set; }
                public string Number { get; set; }
                public JArray NeedReturnData { get; set; }
            }
            public struct ResponseStatus
            {
                public int ErrorCode { get; set; }
                public bool IsSuccess { get; set; }
                public List<Errors> errors { get; set; }
                public JArray SuccessEntitys { get; set; }
                public JArray SuccessMessages { get; set; }
                public int MsgCode { get; set; }
            }
            public struct Errors
            {
                public string FieldName { get; set; }
                public string Message { get; set; }
                public int DIndex { get; set; }
            }
        }
    }
}
