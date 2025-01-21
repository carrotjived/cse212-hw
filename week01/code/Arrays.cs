using System.Globalization;
using System.Runtime.ExceptionServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create an empty array to store the result
        // 2. Add the first number to the array
        // 3. Loop with the range of the length of the multiples starting with index=1 to start storing from second up to the max length
        // 4. Add the previous number to the initial number to create multiples
        // 5. Append the number to the array
        // 6. Return the result array


        var result = new double[length];
        result[0] = number;

        for (int index = 1; index < length; index++)
        {
            number = number += result[0];
            result[index] = number;
        }



        return result;  // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create a new List as resultList
        // 2. Use GetRange function to get the first series: first value is the count of the list minus the amount variable to get the index, second value is the amount variable for the range, then add them using AddRange function to the result list.
        // 3. Use GetRange function to get the rest of the series: first value is index 0, then second value is the count of the list minus the amount as range, then append them with AddRange function to the result list.
        // 4. Clear the passed data list using CLear function.
        // 5. Append the result list to the data list. 



        List<int> resultList = new List<int>();
        resultList.AddRange(data.GetRange(data.Count - amount, amount));
        resultList.AddRange(data.GetRange(0, data.Count - amount));
        data.Clear();
        data.AddRange(resultList);

        

    }
}
