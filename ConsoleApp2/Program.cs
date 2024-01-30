using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Triangolo
{
    internal class Program
    {
        static void Main(string[] args)
            
            
        {
            Console.WriteLine("quanto è lungo il latoA?");
            int latoA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("quanto è lungo il latoB?");
            int latoB = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("qauanto è lungo il latoC?");
            int latoC = Convert.ToInt16(Console.ReadLine());

            Triangolo_op triangolo = new Triangolo_op(latoA, latoB, latoC);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Console.WriteLine(triangolo.CheckTypeTriangle());
            Console.ReadLine();
        }
    }
}
