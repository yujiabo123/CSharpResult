using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YU_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Y_Utils.U_IP.GetInstance().GetRegionAsync("61.244.148.166", ConfigurationManager.AppSettings.Get("PathIp2region")).Result);
            Console.WriteLine(Y_Utils.U_IP.GetInstance().GetRegionAsync("192.168.1.140", ConfigurationManager.AppSettings.Get("PathIp2region")).Result);

            //Y_Utils.U_Time();

            Console.ReadLine();
        }
    }
}
