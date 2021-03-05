using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string CollectGettersAndSetter(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.NonPublic
                | BindingFlags.Public | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (var method in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            return sb.ToString();
        }


        public string RevealPrivateMethods(string invesigatedClassName)
        {
            Type classType = Type.GetType(invesigatedClassName);

            MethodInfo[] classPrivateMethods = classType.GetMethods(BindingFlags.NonPublic
                | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {invesigatedClassName}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in classPrivateMethods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString();
        }





        public string AnalyzeAcessModifiers(string investigatedClassName)
        {
            Type classType = Type.GetType(investigatedClassName);
            
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance
                | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.NonPublic
                | BindingFlags.Instance);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance
                | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString();

        }








        public string StealFieldInfo(string investigatedClass,string[] requestedFields)
        {           

            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = classType.GetFields( BindingFlags.Instance |
               BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString();

        }
    }
}
