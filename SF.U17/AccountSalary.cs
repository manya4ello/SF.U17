using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.U17
{
    public class AccountSalary : Account, IAccount
    {
        public AccountSalary(double balance) : base(balance)
        {
        }

        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}
