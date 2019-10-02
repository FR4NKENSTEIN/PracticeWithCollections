using System;
using System.Collections.Generic;

namespace PracticeCLT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //an array with numbers 0 to 9
            int[] Deca = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in Deca)
            {// show the numbers
                Console.Write($"{num}... ");
            }
            Console.WriteLine("");
            //an array with some names
            string[] People = {"Tim", "Martin", "Nikki", "Sara"};
            foreach (string name in People)
            {//show the names
                Console.Write($"{name}... ");
            }
            Console.WriteLine("");
            //an array that will hold 10 boolean values
            bool[] YesAndNo = new bool[10];
            for (int i = 0; i < YesAndNo.Length; i++)
            {//add specific bool's to an appropriate index
                if(i%2==0)
                {
                    YesAndNo[i] = true;
                }
                else
                {
                    YesAndNo[i] = false;
                }
            }
            foreach (bool yn in YesAndNo)
            {//show the bool's
                Console.Write($"{yn} ");
            }
            Console.WriteLine("");
            //an array with some ice cream flavors
            string[] input = {"Vanilla Bean","Cookies'n'Creme","Chocolate","Root Beer","Mint"};
            //instantiate a List and put all the ice cream in it
            List<string> Flavors = new List<string>(input);
            //show how many flavors there are
            Console.WriteLine($"{Flavors.Count} flavors");
            //show a specific flavor
            Console.WriteLine($"Be gone {Flavors[2]}!");
            Flavors.Remove(Flavors[2]);//get rid of that flavor
            foreach (string f in Flavors)
            {//show which flavors are left
            Console.Write($"{f}... ");
            }//and a number for how many there are
            Console.WriteLine("Total:" + Flavors.Count);
            //instaiate a Dictionary Keys and Values of strings
            Dictionary<string, string> UserInfo = new Dictionary<string, string>();
            for (int i = 0; i < People.Length; i++)
            {//then add a name from the array of People as the Keys
                UserInfo.Add(People[i], Flavors[rand.Next(Flavors.Count)]);
            }//and make the Value for them a random flavor from the available flavors
            foreach (KeyValuePair<string,string> entry in UserInfo)
            {//show me who like what
                Console.WriteLine($"{entry.Key} likes {entry.Value}");
            }

            // Console.WriteLine("It's alive!");
        }

    }
}
