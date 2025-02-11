using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    IInstructorDal _instructorDal;
    public InstructorManager(IInstructorDal ınstructorDal)
    {
        _instructorDal = ınstructorDal;
    }
    public void Add(Instructor ınstructor)
    {
        _instructorDal.Add(ınstructor);
    }

    public void Delete(Instructor ınstructor)
    {
        _instructorDal.Delete(ınstructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public Instructor GetById(int id)
    {
        return _instructorDal.GetById(id);
    }

    public void Update(Instructor ınstructor)
    {
        _instructorDal.Update(ınstructor);
    }
}
