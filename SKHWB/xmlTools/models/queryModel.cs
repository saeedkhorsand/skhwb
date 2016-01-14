using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.xmlTools.models
{
    public class queryModel
    {
        public string title { get; set; }
        public string form { get; set; }
        public string value { get; set; }

        public queryModel()
        {

        }

        public queryModel(string title, string value)
        {
            this.title = title;
            this.value = value;
        }

        public queryModel(string title, string form, string value)
        {
            this.title = title;
            this.form = form;
            this.value = value;
        }
    }
}
