using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.U17
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();

            //добавил чтобы просто видеть, что работает. Пришлось добавить и Balance и Interest в интерфейс IAccount
            Console.WriteLine($"Балланс - {account.Balance}, процент - {account.Interest}");

        }
    }
}
