using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using SKHWB.Models;

namespace SKHWB.publicTools
{
    public static class Invoker
    {
        public static ResultModel CreateAndInvoke(string typeName,string methodName, object[] constructorArgs=null, object[] methodArgs=null)
        {
            try
            {
                Type type = Type.GetType(typeName);
                object instance = Activator.CreateInstance(type, constructorArgs);

                MethodInfo method = type.GetMethod(methodName);
                return new ResultModel(method.Invoke(instance, methodArgs));
            }
            catch (Exception Err)
            {
                return new ResultModel(Err);
            }
        }


        public static ResultModelG<T> CreateAndInvoke<T>(string typeName, string methodName, object[] constructorArgs = null, object[] methodArgs = null)
        {
            try
            {
                Type type = Type.GetType(typeName);
                object instance = Activator.CreateInstance(type, constructorArgs);

                MethodInfo method = type.GetMethod(methodName);
                return new ResultModelG<T>((T)method.Invoke(instance, methodArgs));
            }
            catch (Exception Err)
            {
                return new ResultModelG<T>(Err);
            }
        }
    }
}
