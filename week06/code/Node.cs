using System.Diagnostics;

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

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
            {
                if (value == Left.Data)
                {
                    return;
                }
                else
                {
                    Left.Insert(value);
                }
            }

        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
            {
                if (value == Right.Data)
                {
                    return;
                }
                else
                {
                    Right.Insert(value);
                }
            }

        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }

        if (value < Data)
        {
            if (Left == null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        if (value > Data)
        {
            if (Right == null)
            {
                return false;
            }
            else
            {
                return Right.Contains(value);
            }
        }

        else
        {
            return false;
        }
    }

    public int GetHeight()

    {
        int result = 1;
        if (Left != null && Right != null)
        {
            int left = Left.GetHeight();
            int right = Right.GetHeight();

            result += left > right ? left: right;

        }

        if (Left!=null && Right == null){
            result+=Left.GetHeight();
        }
        if (Left == null && Right != null){
            result+=Right.GetHeight();
        }

        return result;



    }
}