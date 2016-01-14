using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.Models.ExceptionModels
{
    public class rayBasicException : Exception
    {
        public rayBasicException(string Message) : base(Message) { }
    }
}
