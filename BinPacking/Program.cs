using System;

namespace BinPacking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Bin Packing Problem--------------");
			int[] elements = { 5, 3, 2, 6, 36, 1, 8, 7, 1, 2, 4, 1, 10, 20 };

			Generation gen = Generation.initFirstGeneration(Element.intArrToList(elements), 100);
			gen.getBins();
		}
	}
}
