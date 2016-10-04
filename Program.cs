using System;
using System.Collections.Generic;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
// _________________________list____________________________

            // Three Basic Arrays
            // Create an empty array to hold integer values 0 through 9
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            // Create an array with space 10 that alternates between true and false values, starting with true

            int[] myArr1 = new int[8];
            Console.WriteLine(myArr1);
            string[] myArr2 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] myArr3 = {true, false, true, false, true, false, true, false, true, false};
            Console.WriteLine(myArr2);

// _________________________multidimensional array____________________________

            // With the values 1-10, use code to generate a multiplication table.

            int row = 9;
            int col = 9;
            for ( row = 1; row <= 9; row++)
            {
                for ( col = 1; col <= 9; col++)
                {
                    Console.WriteLine(row*col);
                }
            }
                

  

// _________________________dictionary____________________________

            // Create a Dictionary for storing Name, Favorite Sport, Num of Pets, and True/False for whether or not a user like Ice Cream

            Dictionary<string, string> profile1 = new Dictionary<string, string>();
            profile1.Add("Name", "Tim");
            profile1.Add("Sport", "Soccer");
            profile1.Add("Pets", "2");
            profile1.Add("Ice Cream", "True");
            foreach(var entry in profile1)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }

            Dictionary<string, string> profile2 = new Dictionary<string, string>();
            profile2.Add("Name", "Martin");
            profile2.Add("Sport", "Swimming");
            profile2.Add("Pets", "2");
            profile2.Add("Ice Cream", "False");
            foreach(var entry in profile2)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }

            Dictionary<string, string> profile3 = new Dictionary<string, string>();
            profile3.Add("Name", "Nikki");
            profile3.Add("Sport", "Wrestling");
            profile3.Add("Pets", "3");
            profile3.Add("Ice Cream", "True");
            foreach(var entry in profile3)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }

            Dictionary<string, string> profile4 = new Dictionary<string, string>();
            profile4.Add("Name", "Sara");
            profile4.Add("Sport", "Crossfit");
            profile4.Add("Pets", "4");
            profile4.Add("Ice Cream", "False");
            foreach(var entry in profile4)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
            

            

        }
    }
}
