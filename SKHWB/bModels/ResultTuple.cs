using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.Models
{
    [Serializable]
    public class ResultTuple<T1, T2>
    {
        public T1 ResultMessage { get; set; }
        public T2 ResultValue { get; set; }
        public ResultTuple() { }

        public ResultTuple(T1 ResultMessage, T2 ResultValue)
        {
            this.ResultMessage = ResultMessage;
            this.ResultValue = ResultValue;
        }
        public static implicit operator ResultTuple<T1, T2>(Tuple<T1, T2> t)
        {
            return new ResultTuple<T1, T2>()
            {
                ResultMessage = t.Item1,
                ResultValue = t.Item2
            };
        }
    }
}
