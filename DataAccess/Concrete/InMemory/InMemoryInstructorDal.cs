using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory;

public class InMemoryInstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InMemoryInstructorDal()
    {
        _instructors = new List<Instructor> {
            new Instructor{Id=1, FirstName="Engin", LastName="Demiroğ"},
            new Instructor{Id=2, FirstName="Esra", LastName="Eren"}
        };
    }
    public void Add(Instructor ınstructor)
    {
        _instructors.Add(ınstructor);
    }

    public void Delete(Instructor ınstructor)
    {
        Instructor instructerToDelete = _instructors.SingleOrDefault(i => i.Id == ınstructor.Id);
        _instructors.Remove(instructerToDelete);
    }

    public Instructor GetById(int id)
    {
        return _instructors.SingleOrDefault(i => i.Id == id);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor ınstructor)
    {
        Instructor instructorToUpdate = _instructors.SingleOrDefault(i => i.Id == ınstructor.Id);
        instructorToUpdate.FirstName = ınstructor.FirstName;
        instructorToUpdate.LastName = ınstructor.LastName;
    }
}
