using SalesTransaction.Model;
using System;
using System.Collections.Generic;
using System.Text;
//using SalesTransaction.Service.Account;


namespace SalesTransaction.Service.Account
{
    public interface IAccountService
    {
        dynamic GetLogin(MvLogin login);
        dynamic GetUserDetail(string json);
    }
}
