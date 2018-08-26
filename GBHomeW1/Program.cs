using System;

namespace GBHomeW_1
{
    class Program
    {
        int firstnumber = 0;
        int secondnumber = 0;
        int sum = 0;
        string choosemenu = null;
        string stringnumber = null;          

        public void menu()
        {
            Console.WriteLine("Выберите нужную операцию: ");
            Console.WriteLine("\t1) Сложение двух целых чисел.");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        void chooseMenu()
        {
            choosemenu = Console.ReadLine();
            switch (choosemenu)
            {
                
            }
        }

        void twoIntSumm()
        {
            Console.WriteLine("Введите первое число: ");
            stringnumber = Console.ReadLine();
            firstnumber = Convert.ToInt32(stringnumber);
            Console.WriteLine("Введите второе число: ");
            stringnumber = Console.ReadLine();            
            secondnumber = Convert.ToInt32(stringnumber);
            sum = firstnumber + secondnumber;
            Console.WriteLine("Сумма " + firstnumber + " и " + secondnumber + " равно " + sum);
        }       

        static void Main(string[] args)
        {          
            while (true)
            {

            }

            Console.WriteLine("Приветствуем в приложении по сложению двух чисел!");
                        
            
        }
    }
}
