public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
            {
                Left = new Node(value);
            }
            else 
            {
                Left.Insert(value);
            }
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
            {
                Right = new Node(value);
            }
            else
            {
                Right.Insert(value);
            }
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (Data == value) {
            return true;
        }
        else if (value < Data)
        {
            if (Left == null)
                return false;
            else
                return Left.Contains(value);
        }
        else 
        {
            if (Right == null)
                return false;
            else 
                return Right.Contains(value);
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (this == null)
            return 0;
        
        int leftHeight = (Left == null) ? 0 : Left.GetHeight();
        int rightHeight = (Right == null) ? 0 : Right.GetHeight();
        
        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}