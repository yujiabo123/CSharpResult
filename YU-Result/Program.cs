using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y_DAL;

namespace YU_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Y_Utils.U_IP.GetInstance().GetRegionAsync("61.244.148.166").Result);
            //Console.WriteLine(Y_Utils.U_IP.GetInstance().GetRegionAsync("192.168.1.140").Result);
            //Console.WriteLine(Y_Utils.U_Time.TransitionToDateTime("1574748101736"));
            Console.WriteLine("*****************************");
            DbContext context = new Y_DAL.ApplicationDbContext();
            using (BIService.IUserInfoService userInfoService = new BService.UserInfoService(context))
            {
                try
                {
                    Y_DAL.AccountInfo accountInfo = userInfoService.Find<AccountInfo>(6622);
                    string name = accountInfo.Name;
                    AccountInfo accountInfo1 = userInfoService.GetAccountInfoByAccountId(6621);
                    string phone = accountInfo1.Phone.ToString();
                    var entities = userInfoService.Set<AccountInfo>();
                    foreach (var item in entities)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                }
               
            }
            Console.ReadLine();
        }
    }
}
