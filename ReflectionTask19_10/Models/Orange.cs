using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask19_10.Models
{
    internal class Orange:Fruit
    {
        
        int _vitaminC;

        public Orange(int vitaminc ,int price, string sort) : base(price, sort)
        {
            _vitaminC = vitaminc;
        }
        public override void Taste()
        {
            Console.WriteLine("Dadi tursdur");
        }
    }
}
