using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Ranges
{

   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }

   public class Runner
   {
      public void Run()
      {
         var subscribers = Service.GetSubscribers();
         var names = GetNames(subscribers);
         foreach (var name in names)
         {
            Console.WriteLine($"{name} has subscribed!");
         }
      }

      public IEnumerable<string> GetNames(IEnumerable<Person> people)
      {
         foreach (var person in people)
         {
             yield return GetName(person);
         }
      }

      public string GetName(Person person)
      {
         return (person.MiddleName != null)
            ? $"{person.FirstName} {person.MiddleName[0]} {person.LastName}"
            : $"{person.FirstName}  {person.LastName}";
      }
   }

   public class Person
   {
      public Person(string first, string middle, string last)
      {
         FirstName = first;
         MiddleName = middle;
         LastName = last;
      }

      public Person(string first, string last)
      {
         FirstName = first;
         MiddleName = null;
         LastName = last;
      }



      public string FirstName { get; set; }
      public string? MiddleName { get; set; }
      public string LastName { get; set; }
   }

   public static class Service
   {
      public static IEnumerable<Person> GetSubscribers()
      {
         Person[] people =
         {
            new Person("Martin", "Luther", "King"),
            new Person("John", "F", "Kennedy"),
            new Person( "Franklin","D.","Roosevelt"),
            new Person("Miguel", "de Icaza"),
            new Person("Mads", "Torgenson"),
            new Person("George", "Washington"),
            new Person("Sam", "Adams")
         };


             foreach (var person in people) yield return person;
            //foreach (var person in people[1..4]) yield return person;
            //foreach (var person in people[..^2]) yield return person;


        }
   }



}
