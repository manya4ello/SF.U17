using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.U17
{
    /// <summary>
    /// Базовый класс счета
    /// В данном случае он полностью дублируется интерфейсом, но это не обязвтельно
    /// </summary>
    public abstract class Account
    {
       
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account (double balance)
        {
            Balance = balance;       
        }
    }
}
