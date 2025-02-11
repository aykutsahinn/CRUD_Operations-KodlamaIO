using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IInstructorService
{
    void Add(Instructor ınstructor);
    void Update(Instructor ınstructor);
    void Delete(Instructor ınstructor);
    List<Instructor> GetAll();
    Instructor GetById(int id);
}
