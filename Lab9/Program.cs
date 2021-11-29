using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        //1.    Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции
        //(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ.
        //Используйте обработку исключений для защиты от ввода некорректных данных.
        {

            Console.WriteLine("КАЛЬКУЛЯТОР\n");
            
            try
            {
                Console.Write("Введите первое число: ");
                float x = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите второе число: ");
                float y = Convert.ToSingle(Console.ReadLine());

                Console.Write("Введите математическую операцию (+ , - , / ,  *): ");
                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":
                        {
                            Console.WriteLine("\n{0} {2} {1} = {3}", x, y, symbol, x + y);
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("\n{0} {2} {1} = {3}", x, y, symbol, x - y);
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine("\n{0} {2} {1} = {3}", x, y, symbol, x * y);
                            break;
                        }
                    case "/":
                        {
                            if (y==0)
                            {
                               throw new Exception("Деление на 0 не предусмотрено");
                            }
                            Console.WriteLine("{0} {2} {1} = {3}", x, y, symbol, x / y);
                            break;
                        }
                    default:
                        throw new Exception("Введена некорретная операция");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("\n!Ошибка: {0}", ex.Message);
 
            }
         
            Console.ReadKey();
        }
               
        }
        
    }

