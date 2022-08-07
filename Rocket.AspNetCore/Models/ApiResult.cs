using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.AspNetCore.Models
{
    public class ApiResult
    {
        public StatusCode Status { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public static ApiResult Ok() => new ApiResult()
        {
            Status = StatusCode.Success,
            Message = "操作成功"
        };

        public static ApiResult Ok(object data) => new ApiResult()
        {
            Status = StatusCode.Success,
            Message = "操作成功",
            Data = data
        };

        public static ApiResult Fail() => new ApiResult()
        {
            Status = StatusCode.Fail,
            Message = "操作失败"
        };

        public static ApiResult Fail(string message) => new ApiResult()
        {
            Status = StatusCode.Fail,
            Message = message
        };

        public static ApiResult Fail(object data) => new ApiResult()
        {
            Status = StatusCode.Fail,
            Message = "操作失败",
            Data = data
        };

        public static ApiResult Fail(StatusCode status, object data) => new ApiResult()
        {
            Status = status,
            Message = "操作失败",
            Data = data
        };
    }
}
