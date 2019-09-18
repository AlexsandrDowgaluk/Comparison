using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сравнение чисел";
            bool endApp = false;

         

            while (!endApp)
            {

                string numInput1 = "";
                string numInput2 = "";
                double numout1 = 0 ;
                double numout2 = 0;

                


                Console.Write("Введите первое число: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Ошибка ввода ");
                    numInput1 = Console.ReadLine();
                   

                }


                Console.Write("Введите второе число ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ошибка ввода");
                    numInput2 = Console.ReadLine();
                    
                    
                }
                numout1 = Convert.ToDouble(numInput1);
                numout2 = Convert.ToDouble(numInput2);
              



                if (numout1 > numout2)
                {
                    Console.Write("Большее число   " + numout1);
                }
              else if (numout1 < numout2)
                {
                    Console.Write("Большее число   " + numout2);
                }
                else if (numout1 == numout2)
                {
                    Console.Write("Числа равны");
                }
                   



                Console.WriteLine("------------------------\n");


                Console.Write("Нажмите q для закрытия приложения " + "Для продолжения нажмите Enter");
                if (Console.ReadLine() == "q") endApp = true;

                Console.WriteLine("\n");
            }
            return;


        }

    }
}

