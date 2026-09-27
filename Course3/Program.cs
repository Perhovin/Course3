class Course
{
    public string Name;
    public int Room;

    public Course(string name, int room)
    {
        Name = name;
        Room = room;
    }
}

class Program
{
    static void Main()
    {
        List<Course> Courses = [];
        Courses.Add(new Course("Math", 220));
        Courses.Add(new Course("Physics", 430));
        Courses.Add(new Course("Automation", 145));
        foreach (Course course in Courses)
        {
            if (course.Room > 400)
            {
                Console.WriteLine($"Error");
            }
            else
            {
                Console.WriteLine($"Name {course.Name}, Room {course.Room}");
            }
        }
    }
}