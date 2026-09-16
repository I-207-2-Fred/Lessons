using System;
using Lessons;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();
            Employe employe = new Employe();

            Console.WriteLine($"Firstname = {person.firstname}\n" + $"Lastname = {person.lastname}\n" + $"Age = {DateTime.Now.Year - person.birthday.Year}\n" + $"City = {person.city}\n" + $"Height = {person.height}\n" + $"Birthday = {person.birthday.ToString("dd.MM.yyyy")}\n" + $"Gender = {(person.gender ? "Male" : "Female")}\n" + $"Email = {person.email}\n");
            Console.WriteLine("Student");
            Console.WriteLine($"ID = {student.id}\n" + $"Univercity = {student.univercity}\n" + $"Study = {student.study}\n");
            Console.WriteLine("Employe");
            Console.WriteLine($"Company = {employe.company}\n" + $"Job = {employe.job}\n" + $"Study = {employe.datejob.ToString("dd, MM, yyyy")}\n");
        }
    }

}