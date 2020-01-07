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
    public class UserInfoService : BaseService, IUserInfoService
    {
        public UserInfoService(DbContext dbContext) : base(dbContext)
        {

        }

        public AccountInfo GetAccountInfoById(int id)
        {
            return base.Find<AccountInfo>(id);
        }

        public AccountInfo GetAccountInfoByAccountId(int accountId)
        {
            var t = Query<AccountInfo>(i => i.AccountId.Equals(accountId)).ToList();
            return  t == null ? null : t.FirstOrDefault();
                    }
    }
}
