using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_PhamTungLam
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum;
            Book book1 = new Book(1, "Code C Sharp 1", 10.5, "FPT1");
            Book book2 = new Book(2, "Code C Sharp 2", 12.5, "FPT2");
            Book book3 = new Book(3, "Code C Sharp 3", 14.5, "FPT3");
            MobilePhone mb1 = new MobilePhone(4, "Nokia 10", 100.5, "Nokia");
            MobilePhone mb2 = new MobilePhone(5, "Samsung S20", 200.5, "Samsung");
            MobilePhone mb3 = new MobilePhone(5, "Iphone 11", 300.5, "Iphone");
            List<Product> product = new List<Product>();
            product.Add(book1);
            product.Add(book2);
            product.Add(book3);
            product.Add(mb1);
            product.Add(mb2);
            product.Add(mb3);
            sum = book1.computeTax() + book2.computeTax() + book3.computeTax() + mb1.computeTax() + mb2.computeTax() + mb3.computeTax();
            Console.WriteLine("The sum tax is: {0}", sum);
            Console.ReadLine();
        }
    }
}
