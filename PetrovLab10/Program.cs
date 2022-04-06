using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab10
{
    class Program
    {
        //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
        //Реализовать класс, в котором указанные значения представлены в виде свойств.
        //Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки начальных значений,
        //а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса.
        //Осуществить использование объекта в программе.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значения угла: градусы, минуты, секунды");
            int g;
            int m;
            int s;
            try
            {
                g = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Не допустимое значение градусов. Будет присвоено значение 0");
                g = 0;
            }
            try
            {
                m = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Не допустимое значение минут. Будет присвоено значение 0");
                m = 0;
            }
            try
            {
                s = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Не допустимое значение секунд. Будет присвоено значение 0");
                s = 0;
            }
            
            SetGradus setGradus = new SetGradus(g, m, s);
            Console.Write("Угол в радианах = ");
            setGradus.ToRadians();
            Console.ReadKey();
        }
    }
    class SetGradus 
    {
        private int gradus;
        private int min;
        private int sec;
        public int Gradus
        {
            set 
            {
                if (value>=0 && value<=360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Не допустимое значение градусов. Будет присвоено значение 0");
                    gradus = 0;
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
                    Console.WriteLine("Не допустимое значение минут. Будет присвоено значение 0");
                    min = 0;
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
                    Console.WriteLine("Не допустимое значение секунд. Будет присвоено значение 0");
                    sec = 0;
                }
            }
            get
            {
                return sec;
            }

        }
        public SetGradus(int gradus, int min = 0, int sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            double radian = ((gradus + ((double)min / 60) + ((double)sec / 3600)) * Math.PI) / 180;
            Console.WriteLine(radian);
        }
    }
}
