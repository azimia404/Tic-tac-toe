using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XandOTRela
{
    class Chicken
    {
        public Chicken()
        {

        }
        public bool WinnnerHor(char[,] map)
        {
            int o = 0;
            int x = 0;
            while (o != 3 & x != 3)
            {
                for(int a = 0; a < map.GetLength(0); a++)
                {
                    // Горизонтально
                    for (int i = 0; i < map.GetLength(1); i++)
                    {
                        if (map[a, i] == '0')
                        {
                            o++;
                        }
                        else if (map[a, i] == 'x')
                        {
                            x++;
                        }
                        
                    }

                    // Проверка
                    if (o == 3 || x == 3)
                    {
                        break;
                    }
                    else
                    {
                        o = 0;
                        x = 0;
                    }

                    // Вертикально
                    for (int c = 0; c < map.GetLength(1); c++)
                    {
                        if (map[c, a] == '0')
                        {
                            o++;
                        }
                        else if (map[c, a] == 'x')
                        {
                            x++;
                        }

                    }
                    // Проверка
                    if (o == 3 || x == 3)
                    {
                        break;
                    }
                    else
                    {
                        o = 0;
                        x = 0;
                    }

                    // По диагонали
                    for (int e = 0; e < map.GetLength(1); e++)
                    {
                        // Диаг.
                        if (map[e, e] == '0')
                        {
                            o++;
                        }
                        else if (map[e, e] == 'x')
                        {
                            x++;
                        }

                    }
                    // Проверка
                    if (o == 3 || x == 3)
                    {
                        break;
                    }
                    else
                    {
                        o = 0;
                        x = 0;
                    }

                    for (int e = 0; e < map.GetLength(1); e++)
                    {
                        // Обратная диаг.
                        if (map[map.GetLength(0) - 1 - e, e] == '0')
                        {
                            o++;
                        }
                        else if (map[map.GetLength(0) - 1 - e, e] == 'x')
                        {
                            x++;
                        }
                    }

                    // Проверка
                    if (o == 3 || x == 3)
                    {
                        break;
                    }
                    else
                    {
                        o = 0;
                        x = 0;
                    }
                }
                // Проверка
                if (o == 3 || x == 3)
                {
                    break;
                }



                Console.WriteLine("no winners");
                return (false);
            }
            Console.WriteLine(o == 3 ? "Nolik prazdnuet uspeh" : "Krestik oderzhal pobedu");
            return (true);
        }
    }
}
