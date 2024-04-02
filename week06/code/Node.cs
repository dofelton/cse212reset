public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                if (Left != value)
                    Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                if (Right != value)
                    Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) {
            return true;
        }
        else {
            if (Left.Contains(value))
                return true;
            else if (Right.Contains(value))
                return true;
            else 
                return false;
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (Data == null)
            return 0;
        
        int leftHeight = GetHeight(Node.Left);
        int rightHeight = GetHeight(Node.Right);
        
        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}