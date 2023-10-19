using ReflectionTask19_10.Models;
using System.Reflection;

namespace ReflectionTask19_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[5]; 

            Basket[0] = new Apple(340, 204, 4, "Fuji");
            Basket[1] = new Pineapple(140, 300 ,10, "Cayenne");
            Basket[2] = new Orange(334,7, "Blood Oranges");
            Basket[3] = new Apple(120,300,8, "Pink Lady ");
            Basket[4] = new Orange(450,14, "Bergamot Oranges");

            Console.WriteLine("Basketdeki meyveler:");
            foreach (Fruit fruit in Basket)
            {
                Type type = fruit.GetType();
                Console.WriteLine(fruit.GetType().Name);
                fruit.Taste();
                FieldInfo[] fields = typeof(Fruit).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo field in fields)
                {

                    Console.WriteLine(field.Name + ": " + field.GetValue(fruit));

                }
                FieldInfo[] fields2 = fruit.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo field in fields2)
                {

                    Console.WriteLine(field.Name + ": " + field.GetValue(fruit));

                }
            }

            
        }
    }
}