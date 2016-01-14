using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using SKHWB.Models;

namespace SKHWB.rayConnectionTools
{
    public class rayConnectionAccess
    {
        public static ResultModel GetConnectionString(Rayvarz.Systems.Catalog Cat = Rayvarz.Systems.Catalog.RAYVARZ)
        {
            try
            {
                Rayvarz.Systems.Properties.Connections.ConnectionsManager cmg =
                    new Rayvarz.Systems.Properties.Connections.ConnectionsManager(Rayvarz.Systems.Catalog.RAYVARZ);
                var connectionsPath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Rayvarz\\Connection\\Connections.xml");
                cmg.SetConnectionFromSourcePath(connectionsPath);
                var C = ((SqlConnection)cmg.Get_CheckDefaultCnString(Cat));
                System.Reflection.PropertyInfo property = C.GetType().GetProperty("ConnectionOptions", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                var optionsObject = property.GetValue(C, null);
                System.Reflection.MethodInfo method = optionsObject.GetType().GetMethod("UsersConnectionString");
                string connStr = method.Invoke(optionsObject, new object[] { false }) as string; // argument is "hidePassword" so we set it to false
                return new ResultModel(connStr);
            }
            catch (Exception Err)
            {
                return new ResultModel(Err);
            }
        }
    }
}
