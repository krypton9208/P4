using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new School1Entities)
            {
                foreach (var item in Context.poepole
	            {
		            Console.WriteLine("cos tam coś tam z bazy");
                    if (item is Student)
                    {
                        if (item is Bussinesstudent)
                        {
                            Console.WriteLine({"0}", (item as Bussinessstudent.Credints);

                        }
                        else if (item is Instructor)
                        {
                            Console.WriteLine(item.date);
                        }
                    }
	            }

                foreach (var item in context.Peopole.ofType<BussinessStudent>))
                {
                    Console.WriteLine(item.lastname, item.Credits);
                }
	        {
                
		            //CRUD - create select update delete
                    BussinessStudent bs = new BussinessStudent
                    {
                        department = "other", 
                        credits = 1800,
                        firstname = "paweł"
                        lastname="siemienik"
                    };
                    context.people.Add(bs);
                    context.saveChanges();
                    
                    foreach (var item in context.)

	        }
            }
        
	{
		 
	}

        }
    }
}
