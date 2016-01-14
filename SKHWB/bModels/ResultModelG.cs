using SKHWB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.Models
{
    [Serializable]
    public class ResultModelG<T>
    {
        public string ResultMessage { get; set; }
        public bool Result { set; get; }
        public T ResultValue { set; get; }
        public ResultModelG()
        {
            this.Result = true;
        }

        public ResultModelG(Exception Err)
        {
            ResultMessage = Err.Message;
            Result = false;
        }
        public ResultModelG(bool Result = true, string ResultMessage = "تراکنش با موفقیت انجام شد")
        {
            this.Result = Result;
            this.ResultMessage = ResultMessage;
        }
        public ResultModelG(T ResultValue_Input, string ResultMessage_Model = "تراکنش با موفقیت انجام شد")
        {
            ResultValue = ResultValue_Input;
            Result = true;
            ResultMessage = ResultMessage_Model;
        }
        public ResultModelG(ResultModelG<T> R)
        {
            this.Result = R.Result;
            this.ResultMessage = R.ResultMessage;
        }
        public ResultModelG(ResultModel R)
        {
            this.Result = R.Result;
            this.ResultMessage = R.ResultMessage;
        }
    }
}
