using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y_Utils
{
    public class U_Time
    {
        public U_Time()
        {
            Console.WriteLine("时间戳:" + Y_Utils.U_Time.GetTimeStamp(DateTime.Now));
            Console.WriteLine("时间戳转换成时间格式:" + TransitionToDateTime(Y_Utils.U_Time.GetTimeStamp(DateTime.Now)));
            Console.WriteLine("获取当前时间月份的第一天:" + Y_Utils.U_Time.GetMonthStartDay(DateTime.Now));
            Console.WriteLine("获取当前时间月份的最后一天:" + Y_Utils.U_Time.GetMonthEndDay(DateTime.Now));
            Console.WriteLine("获取当前时间的周一:" + Y_Utils.U_Time.GetWeekStartDay(DateTime.Now));
            Console.WriteLine("获取当前时间的周日:" + GetWeekEndDay(DateTime.Now));
            Console.WriteLine("获取本季度第一天:" + GetQuarterStart(DateTime.Now));
            Console.WriteLine("获取本季度最后一天:" + GetQuarterEnd(DateTime.Now));
            Console.WriteLine("根据出生日期获得星座信息:" + GetConstellation(7, 3));
            Console.WriteLine(DateTime.Now.ToTimeStampUAO());
        }
        
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp(DateTime dateTime)
        {
            TimeSpan ts = dateTime - new DateTime(1970, 1, 1, 8, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }
        /// <summary>
        /// 时间戳转换成时间格式
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime TransitionToDateTime(string timeStamp)
        {
            TimeSpan timeSub = TimeSpan.FromMilliseconds(Convert.ToDouble(timeStamp));
            return new DateTime(1970, 1, 1, 8, 0, 0, 0).Add(timeSub);
        }
        /// <summary>
        /// 获取当前时间月份的第一天
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string GetMonthStartDay(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-01");
        }
        /// <summary>
        /// 获取当前时间月份的最后一天
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string GetMonthEndDay(DateTime dateTime)
        {
            return DateTime.Parse(dateTime.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 获取当前时间的周一
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string GetWeekStartDay(DateTime dateTime)
        {
            return dateTime.AddDays(1 - Convert.ToInt32(dateTime.DayOfWeek.ToString("d"))).ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 获取当前时间的周日
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string GetWeekEndDay(DateTime dateTime)
        {
            return dateTime.AddDays(1 - Convert.ToInt32(dateTime.DayOfWeek.ToString("d"))).AddDays(6).ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 获取本季度第一天
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string GetQuarterStart(DateTime dateTime)
        {
            return dateTime.AddMonths(0 - ((DateTime.Now.Month - 1) % 3)).ToString("yyyy-MM-01");
        }
        /// <summary>
        /// 获取本季度最后一天
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string GetQuarterEnd(DateTime dateTime)
        {
            return DateTime.Parse(dateTime.AddMonths(3 - ((DateTime.Now.Month - 1) % 3)).ToString("yyyy-MM-01")).AddDays(-1).ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 根据出生日期获得星座信息 
        /// </summary>
        /// <param name="birthMonth">出生月</param>
        /// <param name="birthDate">出生日</param>
        /// <returns></returns>
        public static Constellation GetConstellation(int birthMonth, int birthDate)
        {
            float birthdayF = birthMonth == 1 && birthDate < 20 ?
                13 + birthDate / 100f :
                birthMonth + birthDate / 100f;
            float[] bound = { 1.20F, 2.20F, 3.21F, 4.21F, 5.21F, 6.22F, 7.23F, 8.23F, 9.23F, 10.23F, 11.21F, 12.22F, 13.20F };
            Constellation[] constellations = new Constellation[12];
            for (int i = 0; i < constellations.Length; i++)
                constellations[i] = (Constellation)(i + 1);
            for (int i = 0; i < bound.Length - 1; i++)
            {
                float b = bound[i];
                float nextB = bound[i + 1];
                if (birthdayF >= b && birthdayF < nextB)
                    return constellations[i];
            }
            return Constellation.Acrab;
        }
        #region 查询星座
        public enum Constellation
        {
            Aquarius = 1,       // 水瓶座 1.20 - 2.18
            Pisces = 2,         // 双鱼座 2.19 - 3.20
            Aries = 3,          // 白羊座 3.21 - 4.19
            Taurus = 4,         // 金牛座 4.20 - 5.20
            Gemini = 5,         // 双子座 5.21 - 6.21
            Cancer = 6,         // 巨蟹座 6.22 - 7.22
            Leo = 7,            // 狮子座 7.23 - 8.22
            Virgo = 8,          // 处女座 8.23 - 9.22
            Libra = 9,          // 天秤座 9.23 - 10.23
            Acrab = 10,         // 天蝎座 10.24 - 11.22
            Sagittarius = 11,   // 射手座 11.23 - 12.21
            Capricornus = 12,   // 摩羯座 12.22 - 1.19
        }
        #endregion
    }
}
