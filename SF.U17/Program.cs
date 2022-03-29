using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.U17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAccount> accounts = new List<IAccount>()
            {
                new AccountRegular(100000),
                new AccountRegular(20000),
                new AccountRegular(800),
                new AccountSalary(900),
                new AccountSalary(8000) 
            };

            

            foreach (var account in accounts)
             Calculator.execute(account);

            

            

            Console.ReadKey();
        }
    }
}
