using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FWW.EsayRegister.Thrift;

namespace EsayRegisterDemo.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EsayService.Start();
                Console.WriteLine("Server was started...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
    public class TestImpl : EsayRegisterDemo.Contract.HelloService.Iface
    {
        public string hello(string name)
        {
            return string.Format("hello,{0} this is thrift service!",name);
        }
    }
}
