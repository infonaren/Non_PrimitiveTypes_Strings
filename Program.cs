using System;

namespace Non_PrimitiveTypes_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastname = "Hamedani";

            var fullname = firstName + " " + lastname;
            Console.WriteLine(fullname);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastname);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Mary", "Vivek" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths:\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            //Verbatim String 
            var textVerbatim = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(textVerbatim);
        }
    }
}
