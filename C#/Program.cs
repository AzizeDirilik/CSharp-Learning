
Course course1 = new Course();
course1.CourseName = "C#";
course1.CourseTrainer = "Engin Demirog";
course1.Ratings = 35;

Course course2 = new Course();
course2.CourseName = "Java";
course2.CourseTrainer = "Azize";
course2.Ratings = 45;

//Console.WriteLine(course1.CourseName + " " + course1.CourseTrainer);

Course[] course = new Course[] { course1, course2 };

foreach (var courses in course)
{
    Console.WriteLine(courses.CourseName + " : " + courses.CourseTrainer);

}

class Course
{
    public string CourseName { get; set; }
    public string CourseTrainer { get; set; }

    public int Ratings { get; set; }


}