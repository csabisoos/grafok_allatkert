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
            List<List<int>> lista = new List<List<int>>();
            for (int i = 1; i < M; i++){
                sor = Console.ReadLine();
                sortomb = sor.Split(' ');
                List<int> par = new List<int> { int.Parse(sortomb[0]), int.Parse(sortomb[1])};
                lista.Add(par);
            }
            #endregion
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