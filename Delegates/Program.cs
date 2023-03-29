using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate+=customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("hello");

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Topla;
            var sonuc = myDelegate3(3, 9);
            Console.WriteLine(sonuc); // en son verilen method geriye döndürülür.

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void SendMessage2(string msg)
        {
            Console.WriteLine(msg);
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful");
        }

        public void ShowAlert2(string alert) {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
    }

}
