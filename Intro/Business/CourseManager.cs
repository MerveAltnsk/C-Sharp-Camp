using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager                         // operasyon sınıfı operasyonlar düzenleniyor yani fonksiyonlar sınıfı da diyebiliriz
{
    privateCourseDal _courseDal;

    public List<Course> GetAll()                          //Bu bloğa metot deniyor basit bir simülasyon  
    {
        //Business rules ,iş kurallarını yazıcaz
 

        return courseDal.GetAll();                                            
    }
}
