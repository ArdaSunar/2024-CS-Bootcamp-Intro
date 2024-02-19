// See https://aka.ms/new-console-template for more information
using Intro.Entities;
using Intro.Business;

Console.WriteLine("Hello, World!");

string[] loans = new string[6];

for (int i = 0; i < loans.Length; i++)
{
    loans[i] = "kredi " + (i+1);
    Console.WriteLine(loans[i]);
}

Console.WriteLine("////////////////Kredi Kodları Bitti////////////////");

CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}
