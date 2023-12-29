using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (amount >= balance)
                balance -= amount;
            else
                Console.WriteLine("So tien vuot qua so du. Rut tien khong thanh cong:");
        }
        public void tranferTo(Account acc, int amount)
        {

            if (amount >= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
            {
                Console.WriteLine("Giao dich khong thanh cong:");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account("99562", "Ngoc Han", 5000);
            Console.Write("Inter id value:");
            string id = Console.ReadLine();
            Console.Write("Inter name value:");
            string name = Console.ReadLine();
            Console.Write("Inter balance value:");
            int balance = int.Parse(Console.ReadLine());
            Account myFriend = new Account("99336", "Tu Luc", 3000);
            Console.WriteLine("--------Thong tin 2 tai khoan ban dau---------");
            Console.WriteLine("My Account: [ id:{0}, name:{1}, balance:{2}]", my.getId(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Acount: [id: {0}, nam: {1}, balance: {2} ]", myFriend.getId(), myFriend.getName(), myFriend.getBalance());
            my.debit(600);
            my.tranferTo(myFriend, 500);
            Console.WriteLine("--------Thong tin 2 tai khoan sau khi thuc hien giao dich-----------");
            Console.WriteLine("My Account: [ id:{0}, name:{1}, balance:{2}]", my.getId(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Acount: [id: {0}, nam: {1}, balance: {2} ]", myFriend.getId(), myFriend.getName(), myFriend.getBalance());
            Console.ReadLine();
        }
    }
}
