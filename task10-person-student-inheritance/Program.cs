using System;

class Person
{
    public string Name;
    public int Age;
}

class Student : Person
{
    public string Faculty;
    public int Course;
}

class Program
{
    static void Main()
    {
        Person p = new Person { Name = "Марія", Age = 40 };
        Student s = new Student { Name = "Іван", Age = 19, Faculty = "Інформатика", Course = 2 };
        Console.WriteLine($"Особа: {p.Name}, {p.Age} р.");
        Console.WriteLine($"Студент: {s.Name}, {s.Age} р., факультет {s.Faculty}, курс {s.Course}");
    }
}
