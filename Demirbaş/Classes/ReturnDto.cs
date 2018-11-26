using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.Classes
{
    public class ReturnDto
    {
        public const string Success = "Process Succesfull", Failed = "Process Unsuccesfull", SerialError= "Changed Serial Number", WifiErro ="Changed WifiMac Number", EthMac="Changed Ethernet Mac";

        public bool Status { get; set; }
        public object ReturnObject { get; set; }
        public string Message { get; set; }
        public string ErrorPage { get; set; }

        public ReturnDto()
        {
        }

        public ReturnDto(bool status)
        {
            this.ErrorPage = "Error";
            this.Status = status;
        }

        public ReturnDto(bool status, string message)
        {
            this.ErrorPage = "Error";
            this.Status = status;
            this.Message = message;
        }

        public ReturnDto(bool status, string message, object returnObject)
        {
            this.ErrorPage = "Error";
            this.Status = status;
            this.Message = message;
            this.ReturnObject = returnObject;
        }
    }
}