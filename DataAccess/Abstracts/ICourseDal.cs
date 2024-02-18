using Entities;

namespace DataAccess.Abstracts;

public interface ICourseDal {
    List<Course> GetAll();
    void Add(Course course);
}