using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
InstructorManager ınstructorManager = new InstructorManager(new InMemoryInstructorDal());

Category newCategory = new Category
{
    Id = 4,
    Name = "Web Uygulamaları"
};

Category updatedCategory = new Category
{
    Id = 1,
    Name = "FrontEnd Geliştirici Updated!"
};

Course newCourse = new Course
{
    Id = 5,
    CategoryId = 4,
    InstructorId = 1,
    Name = "Web Geliştirici",
    Description = "Web Otomasyon Eğitimi",
    Price = 0
};

Course updatedCourse = new Course
{
    Id = 2,
    CategoryId = 3,
    InstructorId = 1,
    Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVASCRİPT+HTML)",
    Price = 55555
};

Instructor newInstructor = new Instructor
{
    Id = 3,
    FirstName = "Aykut",
    LastName = "Şahin"
};

Instructor updatedInstructor = new Instructor
{
    Id = 2,
    FirstName = "Esra Updated name",
    LastName = "Eren updated last name"
};


Console.WriteLine("**********   CRUD Operation in Category  **********");

Console.WriteLine("List of all categoires:  ");
GetAllCategories(categoryManager);

Console.WriteLine("Adding new category: ");
categoryManager.Add(newCategory);
GetAllCategories(categoryManager);

Console.WriteLine("Updating category:   ");
categoryManager.Update(updatedCategory);
Console.WriteLine(categoryManager.GetById(1).Name);

Console.WriteLine("Deleting category:   ");
categoryManager.Delete(updatedCategory);
GetAllCategories(categoryManager);


Console.WriteLine("**********   CRUD Operation in Course    **********");

Console.WriteLine("List of all courses: ");
GetAllCourses(courseManager);

Console.WriteLine("Adding new course: ");
courseManager.Add(newCourse);
GetAllCourses(courseManager);

Console.WriteLine("Updating course:   ");
courseManager.Update(updatedCourse);
Console.WriteLine(courseManager.GetById(2).Name + " Price updated: " + courseManager.GetById(2).Price);

Console.WriteLine("Deleting course:   ");
courseManager.Delete(updatedCourse);
GetAllCourses(courseManager);


Console.WriteLine("**********   CRUD Operation in Instructor    **********");

Console.WriteLine("List of all instructors: ");
GetAllInstructors(ınstructorManager);

Console.WriteLine("Adding new instructor: ");
ınstructorManager.Add(newInstructor);
GetAllInstructors(ınstructorManager);

Console.WriteLine("Updating instructor:   ");
ınstructorManager.Update(updatedInstructor);
Console.WriteLine(ınstructorManager.GetById(2).FirstName);

Console.WriteLine("Deleting instructor:   ");
ınstructorManager.Delete(updatedInstructor);
GetAllInstructors(ınstructorManager);


static void GetAllCategories(CategoryManager categoryManager)
{
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.Name);
    }
}
static void GetAllCourses(CourseManager courseManager)
{
    foreach (var course in courseManager.GetAll())
    {
        Console.WriteLine(course.Name);
    }
}
static void GetAllInstructors(InstructorManager ınstructorManager)
{
    foreach (var instructor in ınstructorManager.GetAll())
    {
        Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
    }
}


