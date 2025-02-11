using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCourseDal : ICourseDal
{
    List<Course> _courses;
    public InMemoryCourseDal()
    {
        _courses = new List<Course> {
            new Course{Id=1, CategoryId=2, InstructorId=1, Name="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", Price=0},
            new Course{Id=2, CategoryId=3, InstructorId=1, Name="Yazılım Geliştirici Yetiştirme Kampı (JAVA+REACT)", Price=0},
            new Course{Id=3, CategoryId=1, InstructorId=1, Name="Front End Geliştirici Yetiştirme Kampı (REACT", Price=0},
            new Course{Id=4, CategoryId=2, InstructorId=1, Name="Senior Yazılım Geliştirici Yetiştirme Kampı(.Net)",Description="Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, doküman ve duyurularını buradan yapacağız.", Price=0}
        };
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        Course courseToDelete = _courses.SingleOrDefault(c => c.Id == course.Id);
        _courses.Remove(courseToDelete);
    }

    public Course GetById(int id)
    {
        return _courses.SingleOrDefault(c => c.Id == id);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Update(Course course)
    {
        Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
        courseToUpdate.Name = course.Name;
        courseToUpdate.Description = course.Description;
        courseToUpdate.Price = course.Price;
    }
}
