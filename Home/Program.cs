using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Program
    {
        static void Main()
        {
            Vector vector = new Vector(1, 4, 5);
            Vector vector1 = new Vector(6, 1, 8);
            Console.WriteLine(vector);
            Console.WriteLine(vector.Length());
            Vector v1 = Vector.Add(vector1, vector);
            Console.WriteLine(v1);
            Vector vector2 = vector.MultiplyByNumber(2);
            Console.WriteLine(vector2);

            Console.WriteLine(Converter.ToHexadecimal(123));
        }
    }
}
