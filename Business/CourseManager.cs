using System.Diagnostics.SymbolStore;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities;

namespace Business;

public class CourseManager {

     //dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // business rules
       

        return _courseDal.GetAll();
    }
}