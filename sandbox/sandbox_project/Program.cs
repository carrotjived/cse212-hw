// using System;

// public class Program
// {
//     static void Main(string[] args)
//     {
//         // This project is here for you to use as a "Sandbox" to play around
//         // with any code or ideas you have that do not directly apply to
//         // one of your projects.

//         Console.WriteLine("Hello Sandbox World!");



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
        // True (stack was empty at the end)
        // Console.WriteLine(Function.CheckBraces("(a == 3 or (b == 5 and c == 6))"));
        // // False ...wrong opening square bracket (stack had only '(' in it before it was popped and compared with ']')
        // //                          here -------\/
        // Console.WriteLine(Function.CheckBraces("(students]i].Grade > 80 and students[i].Grade < 90"));
        // // False ....missing closing ')' (stack had an extra '(' in it at the end when it was supposed to be empty
        // //                 here -------\/
        // Console.WriteLine(Function.CheckBraces("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));

        // Console.WriteLine(Function.Run("a nut for a jar of tuna"));
        Console.WriteLine(Function.Run2("5 3 7 + *"));

    }

}
