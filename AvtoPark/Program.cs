using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto[] avtomag = { new Avto  ("Ford", "Taurus", 1995, "Cherry"),
                                new Avto  ("Ford", "Focus", 2009, "Grey"),
                                new Avto  ("BMW", "X6", 2015, "Black"),
                                new Avto  ("BMW", "740", 2013, "White"),
                                new Avto  ("Audi", "Q7", 2013, "Black"),
                                new Avto  ("Audi", "RS-5", 2010, "Red")};
            Customers[] cust = { new Customers("BMW", "Sergey Pupkin", "050-555-55-66"),
                                new Customers("BMW", "Alex Loter", "050-323-32-32"),
                                new Customers("Audi", "Ivan Ivanov", "067-898-96-96"),
                                new Customers("Audi", "Oleg Mikshen", "073-038-38-56"),
                                new Customers("Ford", "Masha Frig", "067-787-78-87"),};

            var items = from av in avtomag
                        where av.Marka == "BMW"
                        select av;

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
