using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using SKHWB.Models;
using SKHWB.xmlTools.models;

namespace SKHWB.xmlTools.controller
{
    public class xmlQueryController
    {
        public static string path { get; set; }
        private static List<queryModel> listOf_querys = new List<queryModel>();

        public static ResultModelG<List<queryModel>> getListOfQueryModels(string _path = "queries.xml")
        {
            var _rsultOfReadData = readData(_path);
            return _rsultOfReadData.Result ? new ResultModelG<List<queryModel>>(listOf_querys) : new ResultModelG<List<queryModel>>(_rsultOfReadData);
        }


        public static ResultModel readData(string _path = "queries.xml")
        {
            path = _path;
            try
            {
                //Load xml
                var xdoc = XDocument.Load(path);

                //Run query
                listOf_querys = (from lv1 in xdoc.Descendants("queries")
                                 select new queryModel()
                                 {
                                     title = lv1.Attribute("title").Value,
                                     value = lv1.Value
                                 }).ToList();
                return new ResultModel();
            }
            catch (Exception Err)
            {
                return new ResultModel(Err);
            }
        }


    }
}
