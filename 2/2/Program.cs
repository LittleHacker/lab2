using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double a = 0;
            double b = 0;
            double total;
            ConsoleKeyInfo key = Console.ReadKey();
            char oper = key.KeyChar;

            do
            {
                Console.Write("Меню:\n1) A \n2) В \n3) '+', или '-', или '*', или '/' \n 4) Вывод\n 5) Выйти из программы\n\nВаше решение: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Введите первое число:");
                        a = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Введите второе число:");
                        b = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Введите оператор:");
                        oper = Convert.ToChar(Console.ReadLine());
                        break;
                      

                    case 5:
                        Console.WriteLine("Вы решили выйти");
                        break;
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\n\t\t\tНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 5);
        }
           
    }
   
}