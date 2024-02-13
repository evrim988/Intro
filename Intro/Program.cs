// See https://aka.ms/new-console-template for more information
using Intro.Entities;

Console.WriteLine("Hello, World!");

IndividualCustomer customer = new IndividualCustomer();
customer.Id = 1;
customer.NationalIdentity = "123456789";
customer.FirstName = "Evrim";
customer.LastName = "Çalışkan";
customer.CustomerNumber = "1452";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "123456789";
customer2.FirstName = "Ali";
customer2.LastName = "Öztürk";
customer2.CustomerNumber = "22455";

IndividualCustomer customer3 = new IndividualCustomer();
customer3.Id = 3;
customer3.NationalIdentity = "123456789";
customer3.FirstName = "Evrim";
customer3.LastName = "Çalışkan";
customer3.CustomerNumber = "35455";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id =4;
customer4.Name = "Kodlamaİo";
customer4.TaxNumber = "123456789";
customer4.CustomerNumber = "4456456";

CorporateCustomer customer5 = new CorporateCustomer();
customer5.Id = 5;
customer5.Name = "Udemy";
customer5.TaxNumber = "686545513";
customer5.CustomerNumber = "5767";


BaseCustomer[] customers = { customer, customer2, customer3, customer4, customer5 };

foreach (BaseCustomer item in customers)
{
    Console.WriteLine(item.CustomerNumber);
}