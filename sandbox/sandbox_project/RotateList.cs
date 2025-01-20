
/// <summary>
/// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
/// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
/// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
///
/// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
/// </summary>
public static class RotateList
{
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        List<int> resultList = new List<int>();
        resultList.AddRange(data.GetRange(data.Count - amount, amount));
        resultList.AddRange(data.GetRange(0, data.Count - amount));

        return resultList;


    }
}
