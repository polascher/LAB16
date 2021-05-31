using System;

namespace LAB16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру месяца от 1 до 12:");
            double num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Время года-зима");
                    break;
                case 2:
                    Console.WriteLine("Время года-зима");
                    break;
                case 3:
                    Console.WriteLine("Время года-весна");
                    break;
                case 4:
                    Console.WriteLine("Время года-весна");
                    break;
                case 5:
                    Console.WriteLine("Время года-весна");
                    break;
                case 6:
                    Console.WriteLine("Время года-лето");
                    break;
                case 7:
                    Console.WriteLine("Время года-лето");
                    break;
                case 8:
                    Console.WriteLine("Время года-лето");
                    break;
                case 9:
                    Console.WriteLine("Время года-осень");
                    break;
                case 10:
                    Console.WriteLine("Время года-осень");
                    break;
                case 11:
                    Console.WriteLine("Время года-осень");
                    break;
                case 12:
                    Console.WriteLine("Время года-зима");
                    break;
                default:
                    Console.WriteLine("Введено неверное число!");
                    break;
            }
        }
    }
}
