using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCategoryDal : ICategoryDal
{
    List<Category> _categories;
    public InMemoryCategoryDal()
    {
        _categories = new List<Category> {
            new Category{Id=1, Name="FrontEnd Geliştirici"},
            new Category{Id=2, Name="BackEnd Geliştirici"},
            new Category{Id=3,Name="FullStack Geliştirici"}
        };

    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        Category categoryToDelete = _categories.SingleOrDefault(c => c.Id == category.Id);
        _categories.Remove(categoryToDelete);
    }

    public Category GetById(int id)
    {
        return _categories.SingleOrDefault(c => c.Id == id);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = _categories.SingleOrDefault(c => c.Id == category.Id);
        categoryToUpdate.Name = category.Name;
    }
}
