using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SKHWB.Models
{
    [Serializable]
    public class ResultModel
    {
        public string ResultMessage { get; set; }
        [Obsolete("Deprecated Property", false)]
        public string Status { get; set; }

        public bool Result { set; get; }
        [Obsolete("Please Use ResultModelG if You Need To Send Generic Value", false)]
        public object ResultValue { set; get; }
        public ResultModel() {
            this.Result = true;
        }

        public ResultModel(Exception Err)
        {
            ResultMessage = Err.Message;
            Result = false;
        }
        public ResultModel(bool Result=true, string ResultMessage = "تراکنش با موفقیت انجام شد")
        {
            this.Result = Result;
            this.ResultMessage = ResultMessage;
        }
        public ResultModel(object ResultValue_Input,string ResultMessage_Model="تراکنش با موفقیت انجام شد")
        {
            ResultValue = ResultValue_Input;
            Result = true;
            ResultMessage = ResultMessage_Model;
        }
        public ResultModel(ResultModel R) {
            this.Result = R.Result;
            this.ResultMessage = R.ResultMessage;
        }
    }
}