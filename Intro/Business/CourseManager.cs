using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    
    Course Course = new Course()
    {
        Id = 1,
        Name = "Test",
        Description = "Deneme",
        Price = 10,
    };

    Course course1 = new Course()
    {
        Id = 2,
        Name = "C#",
        Description = "C# 2024",
        Price = 20
    };

    Course course2 = new Course()
    {
        Id = 3,
        Name = "C++",
        Description = "C++ 2024",
        Price = 30
    };

    public Course[] GetAll()
    {
        return courses;
    }
}
