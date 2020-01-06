using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using IP2Region;

namespace Y_Utils
{
    /// <summary>
    /// ip2region
    /// </summary>
    public class U_IP
    {
        static U_IP _instance = null;
        private static DbSearcher _dbSearcher { get; set; } = null;

        U_IP()
        {
            if (_dbSearcher == null)
            {
                _dbSearcher = new DbSearcher(Environment.CurrentDirectory+"/../../IP2REGION/ip2region.db");
            }
        }
        public static U_IP GetInstance()
        {
            if (_instance == null)
            {
                _instance = new U_IP();
            }
            return _instance;
        }

        /// <summary>
        /// 获取IP地区
        /// </summary>
        /// <param name="ip"></param>
        /// <returns>中国|0|香港|香港|香港宽频</returns>
        public async Task<string> GetRegionAsync(string ip)
        {
            var region = await _dbSearcher.MemorySearchAsync(ip);
            return region.Region;
        }

        /// <summary>
        /// 获取IP地区
        /// </summary>
        /// <param name="ip"></param>
        /// <returns>中国|0|香港|香港|香港宽频</returns>
        public string GetRegion(string ip)
        {
            var region = _dbSearcher.MemorySearch(ip);
            return region.Region;
        }

        /// <summary>
        /// 获取IP
        /// </summary>
        /// <param name="context"></param>
        /// <returns>IP</returns>
        public static string GetIp(HttpContext context)
        {
            var headers = context.Request.Headers;
            if (!headers.AllKeys.Contains("X-Forwarded-For"))
            {
                if (!headers.AllKeys.Contains("HTTP_X_FORWARDED_FOR"))
                {
                    if (!headers.AllKeys.Contains("REMOTE_ADDR"))
                    {
                        return context.Request.UserHostAddress.ToString();
                    }
                    else
                    {
                        return headers.Get("REMOTE_ADDR");
                    }
                }
                else
                {
                    return headers.Get("HTTP_X_FORWARDED_FOR");
                }
            }
            else
            {
                return headers.Get("X-Forwarded-For");
            }
        }
    }
}
