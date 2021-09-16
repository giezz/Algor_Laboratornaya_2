using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки X и Y");
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты центра окружности X0 и Y0");
            int X0 = Convert.ToInt32(Console.ReadLine());
            int Y0 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите R окружности");
            int R = Convert.ToInt32(Console.ReadLine());

            if ((Math.Pow(X - X0, 2) + Math.Pow(Y - Y0, 2)) <= (R * R))
            {
                Console.WriteLine("Точка с координатами {" + X + " ; " +  Y + "} принадлежит окружности с радиусом " + R + " и с цетнром в {" + X0 + " ; " +  Y0 + "}");
            }
            else
            {
                Console.WriteLine("Точка с координатами {" + X + " ; " + Y + "} не принадлежит окружности с радиусом " + R + " и с цетнром в {" + X0 + " ; " + Y0 + "}");
            }

            Console.ReadKey();
        }
    }
}
