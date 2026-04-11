using System.ComponentModel;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
            return true;
        if (value < Data)
        {
            return Left != null && Left.Contains(value);
        }
        else
        {
            return Right != null && Right.Contains(value);
        }

    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // get height left sub tree
        int leftHeight;
        if (Left == null)
            leftHeight = 0;
        else
            leftHeight = Left.GetHeight(); // recusive call
        //find height right sub tree
        int rightHeight;
        if (Right == null)
            rightHeight = 0;
        else
            rightHeight = Right.GetHeight(); // recursive call
        // return height current node
        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}