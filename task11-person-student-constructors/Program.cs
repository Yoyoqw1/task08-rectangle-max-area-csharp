using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Student : Person
{
    public string Faculty;
    public int Course;

    public Student(string name, int age, string faculty, int course) : base(name, age)
    {
        Faculty = faculty;
        Course = course;
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Марія", 40);
        Student s = new Student("Іван", 19, "Інформатика", 2);
        Console.WriteLine($"Особа: {p.Name}, {p.Age} р.");
        Console.WriteLine($"Студент: {s.Name}, {s.Age} р., факультет {s.Faculty}, курс {s.Course}");
    }
}
