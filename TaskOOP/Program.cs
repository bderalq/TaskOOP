
using TaskOOP.Models;

Students stud = new Students();
string name, major, dissertation, award;
double gpa;

// ask for name of the student
Console.WriteLine("Enter name : ");
name = Console.ReadLine();

// ask for the major 
Console.WriteLine("Enter Major : ");
major = Console.ReadLine();

// ask for gpa and convert input from string to double 
Console.WriteLine("Enter GPA : ");
gpa = Convert.ToDouble((Console.ReadLine()));

// print student details inclding name, major and gpa.
Console.WriteLine(stud.Student(name, major, gpa));

// ask for title of dissertation 
Console.WriteLine("Enter dissertation title : ");
dissertation = Console.ReadLine();

// ask for award tite 
Console.WriteLine("Enter Award title : ");
award = Console.ReadLine();

// print graduate student function using info from student function (inheritance)
Console.WriteLine(stud.GraduateStudent(name, major, gpa, dissertation, award));
