using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y_DAL;

namespace BIService
{
    public interface IUserInfoService : IBaseService
    {
        AccountInfo GetAccountInfoById(int id);
        AccountInfo GetAccountInfoByAccountId(int AccountId);

    }
}
