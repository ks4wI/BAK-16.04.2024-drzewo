using System;

public class BinaryTree
{
    public TreeNode Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Add(int value)
    {
        if (Root == null)
        {
            Root = new TreeNode(value);
        }
        else
        {
            AddRecursive(Root, value);
        }
    }

    private void AddRecursive(TreeNode current, int value)
    {
        if (value % 2 == 0)
        {
            if (current.Left == null)
            {
                current.Left = new TreeNode(value);
            }
            else
            {
                AddRecursive(current.Left, value);
            }
        }
        else
        {
            if (current.Right == null)
            {
                current.Right = new TreeNode(value);
            }
            else
            {
                AddRecursive(current.Right, value);
            }
        }
    }

    public bool Contains(int value)
    {
        return ContainsRecursive(Root, value);
    }

    private bool ContainsRecursive(TreeNode current, int value)
    {
        if (current == null)
        {
            return false;
        }

        if (current.Value == value)
        {
            return true;
        }

        return value % 2 == 0 ? ContainsRecursive(current.Left, value) : ContainsRecursive(current.Right, value);
    }
}

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}
