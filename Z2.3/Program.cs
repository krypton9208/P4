using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Z2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            using( var context = new school1Ent())
            {
                foreach (var instructor in context.People.OfType<Instructor>())
                {
                    Console.WriteLine("{0}{1}", instructor.FirstName);
                }
            }

        }
    }
}
