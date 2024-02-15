using Business;
using Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 1000;

bool isAuthenticated = false;
Console.WriteLine(message1);

if(isAuthenticated) {
    Console.WriteLine("Welcome");
}
else {
    Console.WriteLine("Please Login");
}

string[] loans = {"kredi1", "kredi2", "kredi3", "kredi4", "kredi5"};

for(int i = 0; i < loans.Length; i++) {
    Console.WriteLine(loans[i]);
}

Course course = new Course();

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

Course[] courses = {course1, course2, course3};

for(int i = 0; i < courses.Length; i++) {
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new CourseManager();
courseManager.GetAll();