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
                //(1≤ n ≤ 10)
                string a = Console.ReadLine();
                if (int.Parse(a) < 1 || int.Parse(a) > 10) break;
                string[] d = new string[int.Parse(a)];
                bool pt1 = false;
                for(int b = 1; b <= int.Parse(a); b++)
                {
                    string c = Console.ReadLine();
                    if (c.Length >= 100||c=="")
                    {
                        pt1 = true;
                        break;
                    }
                    d[b - 1] = c;
                }
                if (pt1 == true) break;
                else
                {
                    int i = 0;
                    for(int e = 0; e < int.Parse(a); e++)
                    {
                        string[] pt2 = new string[d[e].Length];
                        int[] pt3 = new int[d[e].Length];
                        i = 0;
                        for (int f = 0; f < d[e].Length; f++)
                        {
                            if (f == 0)
                            {
                                pt2[i] = d[e].Substring(f, 1);
                                pt3[i]+=1;
                            }
                            else
                            {
                                bool pt5 = false;
                                for (int g = 0; g <= i; g++)
                                {
                                    if (d[e].Substring(f, 1) == pt2[g])
                                    {
                                        pt3[g]+=1;
                                        pt5 = true;
                                        break;
                                    }
                                }
                                if (pt5 == false)
                                {
                                    i++;
                                    pt2[i] = d[e].Substring(f, 1);
                                    pt3[i]+=1;
                                }
                            }
                        }
                        int big = -1;
                        for(int p = 0; p < pt3.Length; p++)
                        {
                            if (pt3[p] > big)
                            {
                                big = pt3[p];
                            }
                        }
                        for (int p = 0; p < pt3.Length; p++)
                        {
                            if (pt3[p] == big)
                            {
                                Console.WriteLine(pt2[p]);
                            }
                        }
                    }
                }
            }
        }
    }
}
