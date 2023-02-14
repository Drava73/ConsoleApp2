using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassaArray arr = new ClassaArray(5,5);
            ClassaArray arr2 = new ClassaArray(5, 5);
            arr = arr + arr2;
            arr.Point();

            Console.ReadLine();
        }
    }
}
