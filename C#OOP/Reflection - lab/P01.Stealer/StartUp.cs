using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            /////1ex
            //string[] requestedFields = { "username", "password" };
            //string result = spy.StealFieldInfo("Stealer.Hacker", requestedFields);
            //Console.WriteLine(result);
            ////2 ex
            //string result = spy.AnalyzeAcessModifiers("Stealer.Hacker");
            //Console.WriteLine(result);
            ///3 ex
            ///
            //string result = spy.RevealPrivateMethods("Stealer.Hacker");
            //Console.WriteLine(result);
            ///4 ex
            ///
            string result = spy.CollectGettersAndSetter("Stealer.Hacker");
            Console.WriteLine(result);
          
        }
    }
}
