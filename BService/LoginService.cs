using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIService;
using Y_DAL;

namespace BService
{
    public class LoginService : BaseService, ILoginService
    {
        public LoginService(DbContext context) : base(context)
        {

        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public string LoginByAccount(string account, string password)
        {
            //验证账号密码

          //AccountInfo accountInfo=  Set<AccountInfo>()
            //生成token
            throw new NotImplementedException();
        }

        public string LoginByPhone(string phone, string vertifycode)
        {
            throw new NotImplementedException();
        }

        public string LoginByQQ()
        {
            throw new NotImplementedException();
        }

        public string LoginByWeChat()
        {
            throw new NotImplementedException();
        }

        public string LoginByEmail()
        {
            throw new NotImplementedException();
        }
    }
}
