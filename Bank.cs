using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd
{
    internal class Bank
    {
        private long _bankBalance;
        private long userCount;
        private long collectorCount;
        private long collectedMoney;
        private long Nk;
        private List<string> _userList = new List<string>();
        private string _bankName;
        private List<string> _collectorList = new List<string>();

        public Bank(long bankBalance, string bankName)
        {
            _bankBalance = bankBalance;
            _bankName = bankName;
        }

        public void AddUser()
        {
            Console.WriteLine("Введите имя нового пользоватея банка");
            string user = Console.ReadLine();

            if (user != null)
                _userList.Add(user);
            else
                Console.WriteLine("Ошибка ввода имени");
        }
        public void AddCollector()
        {
            Console.WriteLine("Введите имя нового коллектора");
            string collector = Console.ReadLine();

            if (collector != null)
                _collectorList.Add(collector);
            else
                Console.WriteLine("Ошибка ввода имени");
        }
        public void AddUser(string user)
        {
            _userList.Add(user);
        }
        public void AddCollector(string collector)
        {
            _collectorList.Add(collector);
        }
        public void ShowUserInfo()
        {
            Console.WriteLine("Список крутых людей " + _bankName + ":");
            for (int i = 0; i < _userList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _userList[i]);
            }

        }
        public void ShowCollectorInfo()
        {
            Console.WriteLine("Список опасных людей " + _bankName + ":");
            for (int i = 0; i < _collectorList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _collectorList[i]);
            }

        }
        public void WithdrawMoney(long Money)
        {
            if (Money <= 0)
            {
                Console.WriteLine("Тебе нечего снимать");
            }
            else if (_bankBalance <= Money)
            {
                Console.WriteLine("Слишком много хочешь. Банк не позволит");
            }
            else
            {
                _bankBalance -= Money;
            }
            Console.WriteLine("$$$$$$$$");
            Console.WriteLine("С банка " + _bankName + " было списано " + Money + " денег");
            Console.WriteLine("Баланс банка: " + _bankBalance + " денег");
            Console.WriteLine("$$$$$$$$");
        }
        public void DepositMoney(long Money)
        {
            if (Money <= 0)
            {
                Console.WriteLine("Коллекторы уже в пути");
            }
            else
            {
                _bankBalance += Money;
            }
            Console.WriteLine("$$$$$$$$");
            Console.WriteLine("В банк " + _bankName + " было внесено " + Money + " денег");
            Console.WriteLine("Баланс банка: " + _bankBalance + " денег");
            Console.WriteLine("$$$$$$$$");

        }
        public void CollectMoneyFromUsers()
        {
            userCount = _userList.Count;
            collectorCount = _collectorList.Count;
            collectedMoney = userCount * collectorCount * 100;

            _bankBalance += collectedMoney;

            Console.WriteLine("$$$$$$$$");
            Console.WriteLine("Собираем деньги");
            Console.WriteLine("Количество пользователей: " + userCount);
            Console.WriteLine("Количество коллекторов: " + collectorCount);
            Console.WriteLine("Собрано денег: " + collectedMoney);
            Console.WriteLine("Новый баланс: " + _bankBalance + " денег");
            Console.WriteLine("$$$$$$$$");
        }
        public void RunAwayWithMoney()
        {
            _bankBalance = 0;
            Console.WriteLine("Глава банка улетел в швейцарию. Спасибо что были с нами");
            Console.WriteLine("Ваш баланс: " + _bankBalance);
        }
        public void End()
        {
            Console.WriteLine("Пока");
            string collector = Console.ReadLine();
        }
            

        
    }
}