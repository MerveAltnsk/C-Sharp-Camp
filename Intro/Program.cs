// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");



string message1 = "Krediler";
int term = 12;
double amount = 1111111.5;


bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if(isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Merve");
}
else
{
    Console.WriteLine("Giriş yapınız");
}

Console.WriteLine();

CourseManager courseManager = new ();                // yeni syntaxla bu şekilde de new yaptık diyebiliyoruz 
                      
                                                    // new dediğim anda o sınıfın constructor u çalışır
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}




Console.WriteLine();
Console.WriteLine("Kod bitti");
Console.WriteLine();
Console.WriteLine();



//2 tane bireysel müşteri 2 tane kurumsal müşteri
IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirtName = "Merve";
customer1.LastName = "Altınışık";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "5678965412";
customer2.FirtName = "Veronica";
customer2.LastName = "Light";
customer2.CustomerNumber = "123457";

CorporatrCustomer customer3 = new CorporatrCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "123458";
customer3.TaxNumber = "12345678987";

CorporatrCustomer customer4 = new CorporatrCustomer();
customer3.Id = 4;
customer3.Name = "Abc";
customer3.CustomerNumber = "123459";
customer3.TaxNumber = "12345678988";



BaseCustomer[] customers = {customer1, customer2, customer3, customer4};


//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}