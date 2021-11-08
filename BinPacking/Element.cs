using System;
using System.Collections.Generic;
using System.Text;

namespace BinPacking
{
	public class Element
	{
		private int id;
		private int value;

		public Element(int id, int value)
		{
			this.id = id;
			this.value = value;
		}

		public int getValue()
		{
			return value;
		}

		public int getId()
		{
			return id;
		}

		public static List<Element> intArrToList(int[] arr)
		{
			List<Element> elements = new List<Element>();

			for (int i = 0; i < arr.Length; i++)
			{
				Element elem = new Element(i, arr[i]);
				elements.Add(elem);
			}

			return elements;
		}

		public override string ToString()
		{
			return $"{value}({id})";
		}

        public override bool Equals(object obj)
        {
			int size = this.value;
			int osize = (int)obj;
			return size.Equals(osize);
		}
    }
}
