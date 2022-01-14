using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int gradus = input(count);
            count = 2;
            int min = input(count);
            count = 3;
            int sec = input(count);
            Angle angle1 = new Angle(gradus, min, sec);
            angle1.ToRadians();
            Angle angle2 = new Angle(gradus);   //для проверки начальных значений минут и секунд
            angle2.ToRadians();                 //для проверки еачальных значений минут и секунд
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }

        static int input(int count)
        {
            int N = 0;
            string S = "";
            switch (count)
            {
                case 1:
                    S = "°";
                    break;
                case 2:
                    S = "'";
                    break;
                case 3:
                    S = "\"";
                    break;
            }
            Console.WriteLine("Введите значение угла: ");
            Console.Write("{0} ", S);
            try
            {
                N = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                N = input(count);
            }
            return N;
        }
    }

    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value >= -360 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение Градусов");
                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение минут");
                }
            }
            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение секунд");
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus = 0, int min = 0, int sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians()
        {
            Console.WriteLine("Вы ввели значение угла: {0}° {1}' {2}\"", Gradus, Min, Sec);
            double Rad = Gradus * (Math.PI / 180) + Min * (Math.PI / (60 * 180)) + Sec * (Math.PI / (3600 * 180));
            Console.WriteLine("Данное значение в радианах = {0}", Rad);
        }
    }
}
