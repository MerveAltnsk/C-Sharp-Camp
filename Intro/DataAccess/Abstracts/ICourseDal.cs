using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts
{
    public interface ICourseDal                 //interface ,arayüz, şablon bunlar imzalardan oluşur
    {
        List<Course> GetAll();                  //imzalar
        void Add(Course course);                //yani implamente edecek sınıflar bu ikisini içermek zorunda
    }
}
