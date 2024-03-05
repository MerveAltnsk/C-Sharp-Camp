using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class EfCourseDal: ICourseDal         //Dal Data Access Layer demek  - Dao - Repository gibi isimler olabilir veritabanıyla çalışılacak demektir
{
    List<Course> courses;
    public EfCourseDal()              //gerçek veritabanı olmadığı için constructor oluşturduk kısa yol ctor enter
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = ".NET 8 vs...";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "Java 17...";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12";
        course3.Price = 20;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        //burada database işlemleri yapılır
        //sql öğren
        return courses;
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }
}

