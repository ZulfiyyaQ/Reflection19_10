using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask19_10.Models
{
    internal abstract class Fruit
    {
		private int _price;

		private string _sort;

        public Fruit(int price,string sort)
        {
			_price = price;
			_sort = sort;
        }

		public virtual void Taste()
		{
            Console.WriteLine("Dadi sirindir");
        }

    }
}
