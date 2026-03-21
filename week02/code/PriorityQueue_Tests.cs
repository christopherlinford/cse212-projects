using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorites and removed 1 item
    // Expected Result: The item with the highest priority (largest number) should be returned
    // Example: A(1), B(5), C(10) → Dequeue() should return "C"
    // Defect(s) Found:
    // The loop in Dequeue() does not check the last item in the list (index < Count - 1)
    //  This can cause the actual highest priority item to be ignored
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 10);

        // Expected: "C"
        var result = priorityQueue.Dequeue();
        //Assert.Fail("Expected 'C' to be returned as the highest priority item.");
        Assert.AreEqual("C", result);
    }

    [TestMethod]
    // Scenario: Multiple items have the same highest priority
    // Expected Result: The FIRST item with that priority (FIFO order) should be returned
    // Example: A(5), B(10), C(10) → Dequeue() should return "B"
    // Defect(s) Found:
    // - The code uses >= when comparing priorities
    // - This causes the LAST matching highest priority item to be selected instead of the FIRST
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 10);

        // Expected: "B"
        var result = priorityQueue.Dequeue();

        //Assert.Fail("Expected 'B' (first highest priority item) due to FIFO behavior.");
        Assert.AreEqual("B", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Ensure that Dequeue removes the item from the queue
    // Expected Result: After removing the highest priority item, the next Dequeue()
    // should return the next correct item
    // Example: A(1), B(5) → Dequeue() removes B → Next Dequeue() should return A
    // Defect(s) Found:
    // - The Dequeue() method returns the value but does NOT remove it from the list
    // - This causes repeated returns of the same item
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);

        priorityQueue.Dequeue(); // should remove "B"

        var result = priorityQueue.Dequeue(); // should now return "A"

        //Assert.Fail("Expected 'A' after the highest priority item was removed.");
        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: An InvalidOperationException should be thrown
    // with the message "The queue is empty."
    // Defect(s) Found:
    // - No defect expected; behavior appears correctly implemented
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        // Expected: exception thrown
        // Assert.Fail("Expected InvalidOperationException when dequeuing from an empty queue.");
        var ex = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
    [TestMethod]
    // Scenario: Add multiple items to the queue
    // Expected Result: Items are stored in the order they were added (back of queue)
    // Example: A(1), B(2), C(3) → ToString() should reflect correct order
    // Defect(s) Found:
    // - No defect found (Enqueue works correctly)
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.ToString();

        // Assert.Fail("Expected items to be added in correct order: [A (Pri:1), B (Pri:2), C (Pri:3)]");
        Assert.AreEqual("[A (Pri:1), B (Pri:2), C (Pri:3)]", result);
    }
}