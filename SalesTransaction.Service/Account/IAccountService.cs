using System;
using System.Collections.Generic;
using System.Text;
//using SalesTransaction.Service.Account;
using SalesTransaction.Model;

namespace SalesTransaction.Service.Account
{
    public interface IAccountService
    {
        dynamic GetLogin(MvLogin login);
        dynamic GetUserDetail(string json);
    }
}
