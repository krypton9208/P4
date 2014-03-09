using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataClasses1DataContext())
            {
               // context.Log = Console.Out;
                var suppliers = context.Products.GroupBy(
                    x => x.Supplier
                    );

                foreach (var item in suppliers)
                {
                    Console.WriteLine("{0} {1}",item.Key.SupplierID, item.Key.CompanyName);
                    foreach (var product in item)
                    {
                        Console.WriteLine("   - {0}", product.ProductName);     
                    }
                }
            }

        }
    }
}
