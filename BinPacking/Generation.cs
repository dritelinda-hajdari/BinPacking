using System;
using System.Collections.Generic;
using System.Text;

namespace BinPacking
{
    public class Generation
    {
		private List<Chromosome> population = new List<Chromosome>();

		public static Generation initFirstGeneration(List<Element> items, int sop)
		{
			Generation gen = new Generation();

			for (int i = 0; i < sop; i++)
			{
				Chromosome chromosome = new Chromosome();
				chromosome.insertRandom(items);
				gen.addChromosome(chromosome);
			}

			return gen;
		}

		private void addChromosome(Chromosome chromosome)
		{
			population.Add(chromosome);
		}

		public void getBins()
		{
			Chromosome chromosome = this.population[0];
			Console.WriteLine("\nFitness: {0}, Capacity: 50", chromosome.getFitness());
			for (int i = 0; i < chromosome.countBins(); i++)
			{
				Bin bin = chromosome.getBins()[i];
				Console.WriteLine("\n\nBin: {0}, Filled: {1}\n", i, bin.getFilled());
				for (int j = 0; j < bin.getAll().Count; j++)
				{
					Element elem = bin.getAll()[j];
					Console.WriteLine("Element value: {0}", elem.getValue());
				}
			}
		}
	}
}
