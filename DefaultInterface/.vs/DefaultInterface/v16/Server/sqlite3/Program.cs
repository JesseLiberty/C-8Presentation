#nullable enable
using System;

//nullable  enable
namespace NullableReferenceTypes
{

    public static class Program
    {
        static void Main(string[] args)
        {
            string s = (args.Length > 0) ? args[0] : null;
            Display(s);
        }

        static void Display(string s)
        {
            Console.WriteLine(s.Length);
        }

   }

}




