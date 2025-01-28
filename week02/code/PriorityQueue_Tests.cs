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
        var exampleOne = new PriorityItem("first", 6);
        var exampleTwo = new PriorityItem("second", 3);
        var exampleThree = new PriorityItem("third", 1);
        var exampleFour = new PriorityItem("fourth", 4);
        var exampleFive = new PriorityItem("fifth", 2);
        var exampleSix = new PriorityItem("sixth", 0);
        // var exampleSeven = new PriorityItem("seventh", 35);
        // var exampleEight = new PriorityItem("eighth", 102);
        // var exampleNine = new PriorityItem("ninth", 8);
        // var exampleTen = new PriorityItem("tenth", 23);

        String expectedResult = "first";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(exampleOne.Value, exampleOne.Priority);
        priorityQueue.Enqueue(exampleTwo.Value, exampleTwo.Priority);
        priorityQueue.Enqueue(exampleThree.Value, exampleThree.Priority);
        priorityQueue.Enqueue(exampleFour.Value, exampleFour.Priority);
        priorityQueue.Enqueue(exampleFive.Value, exampleFive.Priority);
        priorityQueue.Enqueue(exampleSix.Value, exampleSix.Priority);
        // priorityQueue.Enqueue(exampleSeven.Value, exampleSeven.Priority);
        // priorityQueue.Enqueue(exampleEight.Value, exampleEight.Priority);
        // priorityQueue.Enqueue(exampleNine.Value, exampleNine.Priority);
        // priorityQueue.Enqueue(exampleTen.Value, exampleTen.Priority);
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

    [TestMethod]

    public void TestPriorityQueue_DequeueHighestPriortityAtFront()
    {
        var exampleOne = new PriorityItem("B", 6);
        var exampleTwo = new PriorityItem("Z", 3);
        var exampleThree = new PriorityItem("F", 1);
        var exampleFour = new PriorityItem("A", 4);
        var exampleFive = new PriorityItem("Q", 2);
        var exampleSix = new PriorityItem("M", 0);



        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(exampleOne.Value, exampleOne.Priority);
        priorityQueue.Enqueue(exampleTwo.Value, exampleTwo.Priority);
        priorityQueue.Enqueue(exampleThree.Value, exampleThree.Priority);
        priorityQueue.Enqueue(exampleFour.Value, exampleFour.Priority);
        priorityQueue.Enqueue(exampleFive.Value, exampleFive.Priority);
        priorityQueue.Enqueue(exampleSix.Value, exampleSix.Priority);
        var value1 = priorityQueue.Dequeue();
        var value2 = priorityQueue.Dequeue();
        var value3 = priorityQueue.Dequeue();
        var value4 = priorityQueue.Dequeue();
        var value5 = priorityQueue.Dequeue();
        var value6 = priorityQueue.Dequeue();

        try
        {

            Assert.AreEqual("B", value1);
            Assert.AreEqual("A", value2);
            Assert.AreEqual("Z", value3);
            Assert.AreEqual("Q", value4);
            Assert.AreEqual("F", value5);
            Assert.AreEqual("M", value6); 
        }
        catch
        {
            Assert.Fail("Implement the test case and then remove this.");
        }

    }

    [TestMethod]

    public void TestPriorityQueue_DequeueHighestPriortityAtMiddle()
    {
        var exampleOne = new PriorityItem("Z", 3);
        var exampleTwo = new PriorityItem("F", 1);
        var exampleThree = new PriorityItem("A", 4);
        var exampleFour = new PriorityItem("B", 6);
        var exampleFive = new PriorityItem("Q", 2);
        var exampleSix = new PriorityItem("M", 0);



        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(exampleOne.Value, exampleOne.Priority);
        priorityQueue.Enqueue(exampleTwo.Value, exampleTwo.Priority);
        priorityQueue.Enqueue(exampleThree.Value, exampleThree.Priority);
        priorityQueue.Enqueue(exampleFour.Value, exampleFour.Priority);
        priorityQueue.Enqueue(exampleFive.Value, exampleFive.Priority);
        priorityQueue.Enqueue(exampleSix.Value, exampleSix.Priority);
        var value1 = priorityQueue.Dequeue();
        var value2 = priorityQueue.Dequeue();
        var value3 = priorityQueue.Dequeue();
        var value4 = priorityQueue.Dequeue();
        var value5 = priorityQueue.Dequeue();
        var value6 = priorityQueue.Dequeue();


        try
        {
            Assert.AreEqual("B", value1);
            Assert.AreEqual("A", value2);
            Assert.AreEqual("Z", value3);
            Assert.AreEqual("Q", value4);
            Assert.AreEqual("F", value5);
            Assert.AreEqual("M", value6);

        }
        catch
        {
            Assert.Fail("Implement the test case and then remove this.");
        }

    }

    [TestMethod]

    
public void TestPriorityQueue_DequeueEqualPriority()
    {
        var exampleOne = new PriorityItem("Z", 3);
        var exampleTwo = new PriorityItem("F", 1);
        var exampleThree = new PriorityItem("A", 4);
        var exampleFour = new PriorityItem("Q", 2);
        var exampleFive = new PriorityItem("B", 4);
        var exampleSix = new PriorityItem("M", 0);



        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(exampleOne.Value, exampleOne.Priority);
        priorityQueue.Enqueue(exampleTwo.Value, exampleTwo.Priority);
        priorityQueue.Enqueue(exampleThree.Value, exampleThree.Priority);
        priorityQueue.Enqueue(exampleFour.Value, exampleFour.Priority);
        priorityQueue.Enqueue(exampleFive.Value, exampleFive.Priority);
        priorityQueue.Enqueue(exampleSix.Value, exampleSix.Priority);
        var value1 = priorityQueue.Dequeue();
        var value2 = priorityQueue.Dequeue();
        var value3 = priorityQueue.Dequeue();
        var value4 = priorityQueue.Dequeue();
        var value5 = priorityQueue.Dequeue();
        var value6 = priorityQueue.Dequeue();


        try
        {
            Assert.AreEqual("A", value1);
            Assert.AreEqual("B", value2);
            Assert.AreEqual("Z", value3);
            Assert.AreEqual("Q", value4);
            Assert.AreEqual("F", value5);
            Assert.AreEqual("M", value6);

        }
        catch
        {
            Assert.Fail("Implement the test case and then remove this.");
        }

    }
}