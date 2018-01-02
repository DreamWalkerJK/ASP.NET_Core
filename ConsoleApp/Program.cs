using System;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        /// <summary>
        /// 测试多线程
        /// 为多线程方法调用提供参数
        /// </summary>
        static void TestArea()
        {
            AreaClass AreaObject = new AreaClass();

            System.Threading.Thread Thread = new System.Threading.Thread(AreaObject.CalcAreaNull);
            AreaObject.Base = 30;
            AreaObject.Height = 40;
            Thread.Start();
        }

        /// <summary>
        /// 测试ping
        /// </summary>
        static void TestPing()
        {
            string targetHost = "bing.com";
            string data = "a quick brown fox jumped over the lazy dog";

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions
            {
                DontFragment = true
            };

            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1024;

            Console.WriteLine($"Pinging {targetHost}");
            PingReply reply = pingSender.Send(targetHost, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine($"Address: {reply.Address}");
                Console.WriteLine($"RoundTrip time: {reply.RoundtripTime}");
                Console.WriteLine($"Time to live: {reply.Options.Ttl}");
                Console.WriteLine($"Don't fragment: {reply.Options.DontFragment}");
                Console.WriteLine($"Buffer size: {reply.Buffer.Length}");
            }
            else
            {
                Console.WriteLine(reply.Status);
            }
        }
        static void Main(string[] args)
        {
            TestArea();
            Console.ReadKey();
        }
    }
}
