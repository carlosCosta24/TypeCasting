using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        enum Favorite {
            juice, 
            fruits,
            beer,
            cigarettes,

        }
        static void Main(string[] args)
        {

            int Int = 25;
            // automatic casting: from int to double
            double NewDouble = Int;

            //manual casting

            double D1 = 25.3;
            int NewD3 = (int)D1;

            //Type conversion methods
            int Age = 27;
            double Wight = 69.50;
            bool married = false;

            // converting enums
            Console.WriteLine(Favorite.beer);
            int Fruit = (int)Favorite.juice;
            Console.WriteLine(Fruit);

            var cig = (Favorite)3;
            Console.WriteLine(cig);

            Console.WriteLine(Int);
            Console.WriteLine(NewDouble);
            Console.WriteLine(NewD3);

            Console.WriteLine(Convert.ToString(Age));
            Console.WriteLine(Convert.ToDouble(Age));
            Console.WriteLine(Convert.ToInt32(Wight));
            Console.WriteLine(Convert.ToString(married));

            Console.ReadKey();
        }
    }
}
