using System;
using System.IO;

namespace labwork16 
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("c:/projects/kvur.txt")) //берем переменый из файла
            {
                string[] mass = reader.ReadLine().Split(' ');//читаем числа через пробел
                int a = Convert.ToInt32(mass[0]); //первое число
                int b = Convert.ToInt32(mass[1]); //второе число
                int c = Convert.ToInt32(mass[2]); //третье число

                Console.WriteLine($"Квадратное уравнение имеет вид {a}x^2+{b}x+{c}=0"); //вывод данных на консоль

                double x1, x2; //задание переменных

                var discriminant = Math.Pow(b, 2) - 4 * a * c;//дискриминант
                if (discriminant < 0) //выполнять, если верно условие
                {
                    Console.WriteLine("Квадратное уравнение не имеет корней"); //вывод на консоль
                }
                else //другой исход
                {
                    if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня 
                    {
                        x1 = -b / (2 * a); //вычисление корня
                        x2 = x1; //вычисление корня
                    }
                    else //уравнение имеет два разных корня
                    {
                        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a); //вычисление корня
                        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a); //вычисление корня
                    }
                    Console.WriteLine($"Корни уравнения {x1},{x2}");//вывод на консоль

                    StreamWriter w = new StreamWriter("c:/projects/korni.txt", true); //ввод в файл 
                    w.WriteLine($"{x1}"); //ввод в файл первого конрня
                    w.WriteLine($"{x2}"); //ввод в файл второго корня
                    w.Close(); //закрыть файл
                }
                Console.WriteLine("данные введены в файл korni.txt"); //вывод на консоль
                Console.ReadLine(); //программа ожидает нажатия клавиши для завершения работы

            }

        }
    }
}