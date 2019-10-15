using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Андрея
{
    class Program
    {
        static void Main(string[] args)
        {
             
        treug odin = new treug();
            odin.info();
            bool l = true;
            while (l == true)
            {
                odin.spros();
                string resh = Console.ReadLine();
                switch (resh)
                {
                    case "Площадь": odin.Plosh(); break;
                    case "Углы": odin.ugly(); break;
                    case "Новый": odin.kof(); break;

                }
            }
            




            Console.ReadKey();
        }
    }
     class treug
    {
        public int a;
        public int b;
        public int c;
        public int k;
         


        public void Plosh()
        {
            
            int p = a + b + c;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Площадь этого треугольника равна:{s}");

        }
        public void ugly()
        {
            double cos1 = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2))/2*b*c;
            double cos2 = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / 2 * a * c;
            double cos3 = (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / 2 * b * a;
            double ugol1 = Math.Acos(cos1);
            double ugol2 = Math.Acos(cos2);
            double ugol3 = Math.Acos(cos3);
            Console.WriteLine($"Первый угол равен:{ugol1} Второй угол равен:{ugol2} Третий угол равен:{ugol3}");
        }
        public void kof()
        {
            Console.Write("Введите коэффициент:");
             k = Convert.ToInt32( Console.ReadLine());
            if ((k == 0)||(k==1))
            { Console.WriteLine("Стороны треугольника не поменялись."); }
            else
            {
                a *= k;
                b *= k;
                c *= k;
                Console.Write($"Новые стороны треугольника равны:{a},{b},{c}");
            }
            
        }
        public void spros()
        {
            Console.WriteLine("Что вы хотите найти?");
            Console.WriteLine("1.Площадь этого треугольника");
            Console.WriteLine("2.Все углы этого треугольника");
            Console.WriteLine("3.Новый треугольник,предварительно задав коэффициент подобия");
            Console.WriteLine("Напишите запрос:Площадь,Углы,Новый");


        }
        public void info()
        {
            Console.Write("Введите сторону a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c:");
            c = Convert.ToInt32(Console.ReadLine());
        }
    }
}
