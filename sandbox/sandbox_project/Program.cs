// using System;
// using System.Diagnostics;
// using System.Text.Json;
// using System.Collections.Generic;
// using System.Numerics;

// public class Program
// {
//     static void Main(string[] args)
//     {
//         // This project is here for you to use as a "Sandbox" to play around
//         // with any code or ideas you have that do not directly apply to
//         // one of your projects.
//         // Stopwatch stopwatch = new Stopwatch();
//         // stopwatch.Start();

//         // Console.WriteLine(Function.IsAnagram("ACT", "TAC"));
//         // stopwatch.Stop();

//         // TimeSpan elapsed = stopwatch.Elapsed;

//         // Console.WriteLine($"Elapsed time: {elapsed.TotalMilliseconds} ms");



//     }
// }

// C# program to illustrate the 
// List.AddRange Method 
using System;
using System.Collections.Generic;
using System.Numerics;

class Geeks
{

    public static void Main()
    {

        // Console.WriteLine(Function.CheckBraces("(a == 3 or (b == 5 and c == 6))"));
        // // False ...wrong opening square bracket (stack had only '(' in it before it was popped and compared with ']')
        // //                          here -------\/
        // Console.WriteLine(Function.CheckBraces("(students]i].Grade > 80 and students[i].Grade < 90"));
        // // False ....missing closing ')' (stack had an extra '(' in it at the end when it was supposed to be empty
        // //                 here -------\/
        // Console.WriteLine(Function.CheckBraces("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));

        // Console.WriteLine(Function.Run("a nut for a jar of tuna"));
        // Console.WriteLine(Function.Run2("5 3 7 + *"));

        // SeedQueue.Run();

        // string original = "Stack Overflow";
        // string reversed = new string(original.Reverse().ToArray());

        // Console.WriteLine(reversed);


        // var set1 = new HashSet<int>() { 1, 2, 34, 4, 5 };
        // var set2 = new HashSet<int>() { 4, 5, 6, 77, 8 };
        // var set3 = Function.OwnIntersect(set1,set2);
        // foreach(int number in set3){
        //     Console.WriteLine(number);
        //     Console.WriteLine();
        // }

        // var set4 = Function.OwnUnion(set1, set2);
        // foreach(int number in set4){
        //     Console.WriteLine(number);

        // }

        // Console.WriteLine();

        // var set5 = set1.Union(set2);
        // foreach(int number in set5){

        //     Console.WriteLine(number);
        // }

        // Function.Permutations("ABC");

        // var people = new string[] { "Jane", "Jean", "Grey", "Marcus", "Theophilus", "Keje" };
        // var firstFour = people[0..4];

        var numbers = new int[]{10, 20, 30, 40, 50, 60};
        var firstFour = numbers[0..5];
        var midIndex = firstFour.Length/2;
        var middle = firstFour[firstFour.Length / 2];

        Console.WriteLine(middle);
        Console.WriteLine(midIndex);
        



        







    }

}

// using System;
// namespace ConsoleApplication1 {

// class Geeks {

//     // Main Method
//     static void Main(string[] args)
//     {

//         string str = "GeeksForGeeks";

//         // Finding the index of character 
//         // which is present in string and
//         // this will show the value 5
//         int index1 = str.IndexOf('e');

//         str.Replace()

//         Console.WriteLine("The Index Value of character 'F' is " + index1);

//         // Now finding the index of that character which
//         //  is not even present with the string
//         int index2 = str.IndexOf('C');

//         // As expected, this will output value -1
//         Console.WriteLine("The Index Value of character 'C' is " + index2);
//     }
// }
// }