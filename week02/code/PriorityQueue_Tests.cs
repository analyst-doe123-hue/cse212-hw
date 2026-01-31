 using Microsoft.VisualStudio.TestTools.UnitTesting;

// // TODO Problem 2 - Write and run test cases and fix the code to match requirements.

// [TestClass]
// public class PriorityQueueTests
// {
//     [TestMethod]
//     // Scenario: 
//     // Expected Result: 
//     // Defect(s) Found: 
//     public void TestPriorityQueue_1()
//     {
//         var priorityQueue = new PriorityQueue();
//         Assert.Fail("Implement the test case and then remove this.");
//     }

//     [TestMethod]
//     // Scenario: 
//     // Expected Result: 
//     // Defect(s) Found: 
//     public void TestPriorityQueue_2()
//     {
//         var priorityQueue = new PriorityQueue();
//         Assert.Fail("Implement the test case and then remove this.");
//     }

//     // Add more test cases as needed below.
// }\
[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities
    // Expected Result: Item with highest priority is dequeued first
    // Defect(s) Found:
    // Original code failed to remove the dequeued item and skipped
    // checking the last element in the queue.
    public void TestPriorityQueue_HighestPriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("High", 5);
        queue.Enqueue("Medium", 3);

        var result = queue.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with same highest priority
    // Expected Result: FIFO order is preserved
    // Defect(s) Found:
    // Original code used >= which caused later items with same
    // priority to be dequeued first instead of FIFO behavior.
    public void TestPriorityQueue_FIFOWithSamePriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("First", 5);
        queue.Enqueue("Second", 5);
        queue.Enqueue("Third", 3);

        Assert.AreEqual("First", queue.Dequeue());
        Assert.AreEqual("Second", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: InvalidOperationException with correct message
    // Defect(s) Found:
    // No defect after fix; exception thrown correctly.
    public void TestPriorityQueue_Empty()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
