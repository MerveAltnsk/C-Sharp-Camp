namespace Intro.Entities;

public class BaseCustomer                                 //Temel Müşteride ortak özellik var böylede istediğim sınıflara inheritance (miras) yapabiliriz
{
    public int Id { get; set; }
    public string CustomerNumber { get; set; }
}

