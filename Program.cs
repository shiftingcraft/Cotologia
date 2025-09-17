using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank TBank = new Bank(10000000, "TBank");
            TBank.AddUser();
            TBank.AddUser("Крошка Юрий");
            TBank.AddUser("Владимир Путин");
            TBank.ShowUserInfo();
            TBank.AddCollector();
            TBank.AddCollector("Асхаб Тамаев");
            TBank.AddCollector("Фог");
            TBank.ShowCollectorInfo();
            TBank.DepositMoney(1337);
            TBank.WithdrawMoney(1000000);
        }

    }
}
