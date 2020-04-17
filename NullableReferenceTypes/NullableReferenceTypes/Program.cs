using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable enable
namespace NullableReferenceTypes
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
         return people.Select(person => GetName(person));
      }

      public string GetName(Person person)
      {
            return $"{person.FirstName} {person.MiddleName[0]} {person.LastName}";

            //return (person.MiddleName != null)
            //   ? $"{person.FirstName} {person.MiddleName[0]} {person.LastName}"
            //   : $"{person.FirstName}  {person.LastName}";
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
      public string MiddleName { get; set; }
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
            new Person("Miguel", "de Icaza"),
            new Person("Mads", "Torgenson")
         };


         foreach (var person in people)
         { yield return person;}

      }
   }


}
