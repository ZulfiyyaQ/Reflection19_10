using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask19_10.Models
{
    internal class Pineapple:Fruit
    {
        int _vitaminE;
        int _vitaminD;

        public Pineapple(int vitamine,int vitamind, int price, string sort) : base(price, sort)
        {
            _vitaminE = vitamine;
            _vitaminD = vitamind;
        }
    }
}
