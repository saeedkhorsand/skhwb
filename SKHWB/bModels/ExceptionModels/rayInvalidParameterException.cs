using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.Models.ExceptionModels
{

    public class rayInvalidParameterException : rayBasicException
    {
        public rayInvalidParameterException(string Message="پارامتر های ورودی به درستی مقدار دهی نشده اند")
            :base(Message)
        {

        }
    }
}
