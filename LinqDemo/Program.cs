using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhereDemo();
            var customers = new[]
            {
                new Customer{Name="rubel",Phones=new []{
                    new Phone { Number="1234",PhoneType=PhoneType.Cell}, 
                    new Phone { Number="12345",PhoneType=PhoneType.Home} 
                }},
                new Customer{Name="rubel1",Phones=new []{
                    new Phone { Number="123423",PhoneType=PhoneType.Cell}, 
                    new Phone { Number="123452321",PhoneType=PhoneType.Home} 
                }},
            };

            var selectCustomer = customers.SelectMany(x => x.Phones);
            foreach (var item in selectCustomer)
            {
                Console.WriteLine(item.Number);
            }
            Console.ReadKey();
        }

        private static void WhereDemo()
        {
            var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenItems = items.NewWhere(x => x % 2 == 0);
            foreach (var item in evenItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
