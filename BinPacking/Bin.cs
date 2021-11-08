using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinPacking
{
    public class Bin
    {
		private int capacity = 50;
		private int filled = 0;
		private List<Element> elements = new List<Element>();

		public List<Element> getAll()
		{
			return this.elements;
		}

		public bool addElement(Element elem)
		{
			if (filled + elem.getValue() <= capacity)
			{
				filled += elem.getValue();
				elements.Add(elem);
				return true;
			}

			return false;
		}

		public int getCapacity()
		{
			return capacity;
		}

		public int getFilled()
		{
			return filled;
		}

		public override string ToString()
		{
			string ret = "";
			for (int i = 0; i < elements.Count; i++)
			{
				if (ret.Length > 0)
				{
					ret = ret + ',';
				}

				ret = ret + elements[i].ToString();

			}

			return '[' + ret + ']';
		}
	}
}
