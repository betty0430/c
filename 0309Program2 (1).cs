using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[,] pt = new int[6, 3];
                pt[0, 0] = 123; pt[0, 1] = 456; pt[0, 2] = 9000;
                pt[1, 0] = 456; pt[1, 1] = 789; pt[1, 2] = 5000;
                pt[2, 0] = 789; pt[2, 1] = 888; pt[2, 2] = 6000;
                pt[3, 0] = 336; pt[3, 1] = 558; pt[3, 2] = 10000;
                pt[4, 0] = 775; pt[4, 1] = 666; pt[4, 2] = 12000;
                pt[5, 0] = 566; pt[5, 1] = 221; pt[5, 2] = 7000;
                string[] a = Console.ReadLine().Split(' ');
                bool c = false;
                int who_x = 0;
                for (int b = 0; b < 6; b++)
                {
                    if ((pt[b, 0] == int.Parse(a[0])) && (pt[b, 1] == int.Parse(a[1])))
                    {
                        c = true; who_x = b;
                        Console.WriteLine("OK");
                        break;
                    }
                }

                if (c == false)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    while (true)
                    {
                        string[] d = Console.ReadLine().Split(' ');
                        switch (d[0])
                        {
                            case "L":
                                if (int.Parse(d[1]) < pt[who_x, 2])
                                {
                                    pt[who_x, 2] -= int.Parse(d[1]);
                                    Console.WriteLine("OK");
                                }
                                else Console.WriteLine("ERROR");
                                break;
                            case "S":
                                Console.WriteLine(pt[who_x, 2]);
                                break;
                            case "E":
                                Console.WriteLine("BYE");
                                break;
                            default:
                                Console.WriteLine("ERROR");
                                break;
                        }
                        if (d[0] == "E") break;
                    }
                }
            }
        }
    }
}
