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
            Console.WriteLine("������� ��� ������ ����������� �����");
            string user = Console.ReadLine();

            if (user != null)
                _userList.Add(user);
            else
                Console.WriteLine("������ ����� �����");
        }
        public void AddCollector()
        {
            Console.WriteLine("������� ��� ������ ����������");
            string collector = Console.ReadLine();

            if (collector != null)
                _collectorList.Add(collector);
            else
                Console.WriteLine("������ ����� �����");
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
            Console.WriteLine("������ ������ ����� " + _bankName + ":");
            for (int i = 0; i < _userList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _userList[i]);
            }

        }
        public void ShowCollectorInfo()
        {
            Console.WriteLine("������ ������� ����� " + _bankName + ":");
            for (int i = 0; i < _collectorList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _collectorList[i]);
            }

        }
        public void WithdrawMoney(long Money)
        {
            if (Money <= 0)
            {
                Console.WriteLine("���� ������ �������");
            }
            else if (_bankBalance <= Money)
            {
                Console.WriteLine("������� ����� ������. ���� �� ��������");
            }
            else
            {
                _bankBalance -= Money;
            }
            Console.WriteLine("$$$$$$$$");
            Console.WriteLine("� ����� " + _bankName + " ���� ������� " + Money + " �����");
            Console.WriteLine("������ �����: " + _bankBalance + " �����");
            Console.WriteLine("$$$$$$$$");
        }
        public void DepositMoney(long Money)
        {
            if (Money <= 0)
            {
                Console.WriteLine("���������� ��� � ����");
            }
            else
            {
                _bankBalance += Money;
            }
            Console.WriteLine("$$$$$$$$");
            Console.WriteLine("� ���� " + _bankName + " ���� ������� " + Money + " �����");
            Console.WriteLine("������ �����: " + _bankBalance + " �����");
            Console.WriteLine("$$$$$$$$");

        }
        public void CollectMoneyFromUsers()
        {
            userCount = _userList.Count;
            collectorCount = _collectorList.Count;
            collectedMoney = userCount * collectorCount * 100;

            _bankBalance += collectedMoney;

            Console.WriteLine("$$$$$$$$");
            Console.WriteLine("�������� ������");
            Console.WriteLine("���������� �������������: " + userCount);
            Console.WriteLine("���������� �����������: " + collectorCount);
            Console.WriteLine("������� �����: " + collectedMoney);
            Console.WriteLine("����� ������: " + _bankBalance + " �����");
            Console.WriteLine("$$$$$$$$");
        }
        public void RunAwayWithMoney()
        {
            _bankBalance = 0;
            Console.WriteLine("����� ����� ������ � ���������. ������� ��� ���� � ����");
            Console.WriteLine("��� ������: " + _bankBalance);
        }
        public void End()
        {
            Console.WriteLine("����");
            string collector = Console.ReadLine();
        }
            

        
    }
}