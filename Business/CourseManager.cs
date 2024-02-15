using Entities;

namespace Business;

public class CourseManager {

    Course[] courses = new Course[3];
    public CourseManager() {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8";
        course1.Price = 5;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "JAVA 17";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12";
        course3.Price = 20;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Course[] GetAll() {
        Console.WriteLine("Kurslar Listelendi");
        return courses;
        
    }
}