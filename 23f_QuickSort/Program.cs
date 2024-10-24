using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23f_QuickSort
{
	internal class Program
	{
		static void QuickSort(List<int> lista) => QuickSort(lista, 0, lista.Count - 1);
		static void QuickSort(List<int>lista, int i, int j)
		{
			if (i<j)
			{
				int i_helye = Particional(lista, i, j); // a hajdanán i-edik elem a HELYÉRE került. És ez a hely az i_helye.
				QuickSort(lista, i, i_helye - 1);
				QuickSort(lista, i_helye + 1, j);
			}
		}

		static int Particional(List<int> lista, int i, int j) // i és j jelentése: i=kisebb , j = nagyobb
		{
			while (i!=j)
			{
				if (i<j != lista[i] < lista[j]) // ha nem állnak sorrendben
				{
					(lista[i], lista[j]) = (lista[j], lista[i]); // emberek cseréje
					(i, j) = (j, i); // kalapok cseréje
				}
				// j lép i irányába ha i<j , akkor -1, ha i>j akkor +1
				j += i.CompareTo(j);
			}
			return i;
		}

		static void Main(string[] args)
		{
			List<int> lista = new List<int> { 4, 7, 6, 9, 3, 4, 7, 1, 5 };
            Console.WriteLine(string.Join(" ", lista));
			QuickSort(lista);
			Console.WriteLine(string.Join(" ", lista));

		}
	}
}
