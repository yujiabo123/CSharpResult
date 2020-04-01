using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Y_DAL;
using Y_Utils;

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

            #region AES 加密解密测试
            //string key = "12345678876543211234567887654abc";
            //string val = "我是ALEX";
            //Console.WriteLine(val);
            //string encryptAes = U_Encrypt.AesEncrypt(val,key);
            //Console.WriteLine(encryptAes);
            //string decryptAes = U_Encrypt.AesDecrypt(encryptAes, key);
            //Console.WriteLine(decryptAes);
            #endregion
            Console.WriteLine(Guid.NewGuid());

            //foreach (int i in Power(2, 8))
            //{
            //    Console.Write("{0} ", i);
            //}


            #region 数据库访问层测试
            //DbContext context = new Y_DAL.ApplicationDbContext();
            //using (BIService.IUserInfoService userInfoService = new BService.UserInfoService(context))
            //{
            //    try
            //    {
            //        Y_DAL.AccountInfo accountInfo = userInfoService.Find<AccountInfo>(6622);
            //        string name = accountInfo.Name;
            //        AccountInfo accountInfo1 = userInfoService.GetAccountInfoByAccountId(6621);
            //        string phone = accountInfo1.Phone.ToString();
            //        var entities = userInfoService.Set<AccountInfo>();
            //        foreach (var item in entities)
            //        {
            //            Console.WriteLine(item.Name);
            //        }
            //    }
            //    catch (Exception err)
            //    {
            //        Console.WriteLine(err.StackTrace);
            //    }
            //}
            #endregion

            Console.ReadLine();
        }

        public static IEnumerable Power(int number, int exponent)
        {
            int counter = 0;
            int result = 1;
            while (counter++ < exponent)
            {
                result = result * number;
                Thread.Sleep(2000);
                yield return result;
            }
        }

    }
}
