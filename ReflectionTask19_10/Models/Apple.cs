using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask19_10.Models
{
    internal class Apple:Fruit
    {
        int _vitaminA;
        int _vitaminB;

        public Apple(int vitamina, int vitaminb ,int price, string sort) : base(price, sort)
        {
            _vitaminA = vitamina;
            _vitaminB = vitaminb;
            
        }
        

    }
}
