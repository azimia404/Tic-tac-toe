using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XandOTRela
{
    class Mapper
    {
        int schetchik = 0;
        public Mapper()
        {

        }

        public char[,] Zapolnize(char[,] map)
        {
            for (int line = 0; line < map.GetLength(0); line++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    map[line, col] = (map.GetLength(1) * line + col + 1).ToString()[0];
                }
            }
            return map;
        }
        public char[,] Visualise(char[,] map)
        {
            for (int line = 0; line < map.GetLength(0); line++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    Console.Write(map[line, col]);
                }
                Console.WriteLine();
            }
            return map;
        }
        public char[,] Gen(char[,] map, int a, char prikaz)
        {
            a -= 1;
            Console.Write("Координаты");
            //Console.WriteLine((a / map.GetLength(0), a > 2 ? a - map.GetLength(0) * (a / map.GetLength(0)) : a).ToString()); Мой старый код, не знаю почему я сделал так фен-шуйно
            Console.WriteLine((a / map.GetLength(0), a > 2 ? a % 3 : a).ToString());
            if (map[a / map.GetLength(0), a > map.GetLength(0) - 1 ? a % 3 : a] == 'x' || map[a / map.GetLength(0), a > map.GetLength(0) - 1 ? a % 3 : a] == '0')
            {
                Console.WriteLine("Прекрати зачеркивать");
                schetchik--;
                return map;
            }
            map[a / map.GetLength(0), a > map.GetLength(0)-1 ? a % 3 : a] = prikaz;
            return map;
        }
        public char[,] Goal(char[,] map)
        {
            if(schetchik % 2 == 0)
            {
                Console.WriteLine("Выбирает НООООООООООООЛИК");
                int goal = Trier();
                

                map = Gen(map, goal, '0');
            }
            else
            {
                Console.WriteLine("Выбирает КРЕЕЕЕЕЕЕЕЕЕЕСТИИИИИИИК");
                int goal = Trier();
                map = Gen(map, goal, 'x');
            }
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine();
            }
            Visualise(map);
            schetchik++;
            return map;
        }
        public int Trier()
        {
            int goal = 0;
            try
            {
                goal = int.Parse(Console.ReadLine());
            }
            catch
            {
                goal = Trier();
            }
            return goal;
        }
    }
}
