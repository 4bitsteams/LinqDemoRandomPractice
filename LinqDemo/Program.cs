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
                new Customer{
                    Id=1,Name="rubel",Phones=new []{
                    new Phone { Number="1234",PhoneType=PhoneType.Cell},
                    new Phone { Number="12345",PhoneType=PhoneType.Home}
                }},
                new Customer{
                    Id=2,Name="rubel1",Phones=new []{
                    new Phone { Number="123423",PhoneType=PhoneType.Cell},
                    new Phone { Number="123452321",PhoneType=PhoneType.Home}
                }},
            };

            var CustomerAddress = new[]{
                new Address { Id=1,CustomerId=1,Street="Street1",City="City1"},
                new Address { Id=2,CustomerId=2,Street="Street2",City="City2"},
            };

            var customerWithAddress = customers.NewJoin(CustomerAddress, c => c.Id, a => a.CustomerId, (c, a) => new { c.Name, a.Street, a.City });
            foreach (var item in customerWithAddress)
            {
                Console.WriteLine(item.City);
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
