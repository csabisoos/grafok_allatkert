using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region beolvasas
            string sor = Console.ReadLine();
            string[] sortomb = sor.Split(' ');
            int N = int.Parse(sortomb[0]);
            int M = int.Parse(sortomb[1]);
            List<List<int>> ellista = new List<List<int>>();
            for (int i = 0; i < M; i++)
            {
                sor = Console.ReadLine();
                sortomb = sor.Split(' ');
                List<int> par = new List<int> { int.Parse(sortomb[0]), int.Parse(sortomb[1]) };
                ellista.Add(par);
            }
            //ellenorzes:
            /*
            for (int i = 0; i < ellista.Count; i++)
            {
                Console.Write(ellista[i][0]);
                Console.Write(" ");
                Console.WriteLine(ellista[i][1]);
            }
            /**/
            Console.WriteLine();
            #endregion

            Dictionary<int, int> szotar = new Dictionary<int, int>();
            foreach (List<int> par in ellista)
            {
                for (int i = 0;i < 2;i++)
                {
                    if (szotar.ContainsKey(par[i]))
                    {
                        szotar[par[i]] += 1;
                    }
                    else
                    {
                        szotar[par[i]] = 1;
                    }
                }
            }
            //ellenorzes
            /*
            Console.WriteLine("csucs/fokszam szotar:");
            foreach (int kulcs in szotar.Keys)
            {
                Console.Write(kulcs);
                Console.Write(" ");
                Console.WriteLine(szotar[kulcs]);
            }
            /**/

            //hany olyan sor van, ahol a masodik elem egyes?
            
            int db = 0;
            foreach (int kulcs in szotar.Keys)
            {
                if (szotar[kulcs] == 1)
                {
                    db++;
                }
            }
            Console.Write(db);
            /**/
            //melyik sorszamnak van a legnagyobb fokszama?
            //keressuk azt a kulcsot, amelyiknek a legnagyobb az erteke

            int maxkulcs = szotar.Keys.First();
            foreach (int kulcs in szotar.Keys) 
            {
                if (szotar[maxkulcs] < szotar[kulcs])
                {
                    maxkulcs = kulcs;

                }
            }
            Console.Write(" ");
            Console.WriteLine(maxkulcs);
        }
    }
}
/**peldabemenet /
5 7 
0 1
1 4
3 1
3 5
2 0
2 3
1 2
/**/