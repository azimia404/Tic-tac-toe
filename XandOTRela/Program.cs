using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XandOTRela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание объектов
            char[,] map = new char[3, 3];
            Chicken chicken = new Chicken();
            Mapper mapper = new Mapper();
            //Заполнение массива числами
            map = mapper.Zapolnize(map);

            Console.WriteLine();
            //Визуализация массива
            map = mapper.Visualise(map);

            //Выбор клетки
            while(!chicken.WinnnerHor(map))
            {
                map = mapper.Goal(map);
                
            }
            while (true) ;
        }
    }
}
