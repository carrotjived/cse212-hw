using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue with the two high priority number 
    // Expected Result: "second"
    // Defect(s) Found: The comparison operator for updating the highest priority number also accepts the same number. 
    // Fix: Changed the comparison operator ">=" to ">"
    public void TestPriorityQueue_1()
    {
        var exampleOne = new PriorityItem("first", 24);
        var exampleTwo = new PriorityItem("second", 55);
        var exampleThree = new PriorityItem("third", 55);

        String expectedResult = "second";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(exampleOne.Value, exampleOne.Priority);
        priorityQueue.Enqueue(exampleTwo.Value, exampleTwo.Priority);
        priorityQueue.Enqueue(exampleThree.Value, exampleThree.Priority);
        var value = priorityQueue.Dequeue();

        try
        {
            Assert.AreEqual(expectedResult, value);
        }
        catch
        {
            Assert.Fail("Implement the test case and then remove this.");
        }








    }

    [TestMethod]
    // Scenario: Test 10 Priority item with different priority number
    // Expected Result: "sixth"
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var exampleOne = new PriorityItem("first", 24);
        var exampleTwo = new PriorityItem("second", 55);
        var exampleThree = new PriorityItem("third", 25);
        var exampleFour = new PriorityItem("fourth", 96);
        var exampleFive = new PriorityItem("fifth", 45);
        var exampleSix = new PriorityItem("sixth", 102);
        var exampleSeven = new PriorityItem("seventh", 35);
        var exampleEight = new PriorityItem("eighth", 77);
        var exampleNine = new PriorityItem("ninth", 8);
        var exampleTen = new PriorityItem("tenth", 23);

        String expectedResult = "sixth";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(exampleOne.Value, exampleOne.Priority);
        priorityQueue.Enqueue(exampleTwo.Value, exampleTwo.Priority);
        priorityQueue.Enqueue(exampleThree.Value, exampleThree.Priority);
        priorityQueue.Enqueue(exampleFour.Value, exampleFour.Priority);
        priorityQueue.Enqueue(exampleFive.Value, exampleFive.Priority);
        priorityQueue.Enqueue(exampleSix.Value, exampleSix.Priority);
        priorityQueue.Enqueue(exampleSeven.Value, exampleSeven.Priority);
        priorityQueue.Enqueue(exampleEight.Value, exampleEight.Priority);
        priorityQueue.Enqueue(exampleNine.Value, exampleNine.Priority);
        priorityQueue.Enqueue(exampleTen.Value, exampleTen.Priority);
        var value = priorityQueue.Dequeue();

        try
        {
            Assert.AreEqual(expectedResult, value);
        }
        catch
        {
            Assert.Fail("Implement the test case and then remove this.");
        }

    }

    // Add more test cases as needed below.
}