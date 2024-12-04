using System;
using System.Collections.Generic;
using System.Linq;

public class Student : Person
{

}

public class Instructor : Person
{

}

public class Repository<T> where T : Person
{
    private List<T> items;

    public Repository()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        item.Id = items.Count + 1;
        item.CreateDateTime = DateTime.Now;
        items.Add(item);
    }

    public void Remove(int id)
    {
        var itemToRemove = items.FirstOrDefault(x => x.Id == id);
        if (itemToRemove != null)
            items.Remove(itemToRemove);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public List<T> SortByName()
    {
        return items.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Repository<Student> studentRepository = new Repository<Student>();
        studentRepository.Add(new Student { FirstName = "gaganpreet", LastName = "singh" });
        studentRepository.Add(new Student { FirstName = "gurpreet", LastName = "Singh" });

        
        Console.WriteLine("Students:");
        foreach (var student in studentRepository.GetAll())
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}");
        }

        Console.WriteLine("\nStudents sorted by name:");
        foreach (var student in studentRepository.SortByName())
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}");
        }

       
        studentRepository.Remove(1);

        Console.WriteLine("\nStudents after removal:");
        foreach (var student in studentRepository.GetAll())
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}");
        }
    }
}