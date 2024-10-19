

string[] courses = { "Java", "C#", "Python" };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i]);
}

Console.WriteLine("For bitti");
foreach (string course in courses)
{
    Console.WriteLine(course);
}
