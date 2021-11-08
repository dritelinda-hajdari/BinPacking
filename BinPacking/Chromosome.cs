using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinPacking
{
    public class Chromosome
    {
		private List<Bin> bins = new List<Bin>();
		private double fitness = 0;

		public double Fitness()
		{
			double sum = 0;
			double F, f, c, k;

			k = 2;

			for (int i = 0; i < bins.Count; i++)
			{
				var tempBin = bins[i];
				f = tempBin.getFilled();
				c = tempBin.getCapacity();
				sum = sum + Math.Pow(f / c, k);
			}

			F = sum / bins.Count;

			return F;
		}

		public void setFitness()
		{
			this.fitness = Fitness();
		}

		public Double getFitness()
		{
			setFitness();

			return fitness;
		}

		public int countBins()
		{
			return this.bins.Count;
		}

		public List<Bin> getBins()
        {
			return this.bins;
        }

		public void insertRandom(List<Element> items)
		{
			firstFitItems(shuffleList(items));
		}

		private void firstFitItems(List<Element> items)
		{
			Boolean oldBin = false;
			for (int i = 0; i < items.Count; i++)
			{
				Element elem = items[i];

				for (int j = 0; j < bins.Count; j++)
				{
					if (oldBin = bins[j].addElement(elem))
					{
						continue;
					}
					oldBin = false;
				}
				if (oldBin)
				{
					continue;
				}
				Bin bin = new Bin();
				bin.addElement(elem);
				bins.Add(bin);
			}
		}

		public static List<Element> shuffleList(List<Element> items)
		{
			Random rnd = new Random();
			return items.OrderBy((item) => rnd.Next()).ToList();
		}

		public override string ToString()
		{
			return bins.ToString();
		}

        public override bool Equals(object obj)
        {
            return this.getFitness().Equals(((Chromosome)obj).getFitness());
		}
	}
}
