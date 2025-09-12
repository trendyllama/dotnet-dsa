
namespace dotnet_dsa.DataStructures;


public class TreeNode<T>(T? value)
{

    public List<TreeNode<T>>? Children { get; set; } = [];
    public TreeNode<T>? Parent { get; set; } = null;

    public T? Value { get; set; } = value;

    public void AddChild(TreeNode<T> child)
    {
        if (child == null)
        {
            throw new ArgumentNullException(nameof(child), "Child cannot be null.");
        }

        if (Children == null)
        {
            throw new InvalidOperationException("Children list is not initialized.");
        }


        Children.Add(child);
    }

    public void RemoveChild(TreeNode<T> child)
    {
        if (child == null)
        {
            throw new ArgumentNullException(nameof(child), "Child cannot be null.");
        }

        if (Children == null || !Children.Contains(child))
        {
            throw new InvalidOperationException("Child not found in the children list.");
        }

        Children.Remove(child);
    }

    public void Traverse(Action<TreeNode<T>> action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action), "Action cannot be null.");
        }

        action(this);

        if (Children != null)
        {
            foreach (var child in Children)
            {
                child.Traverse(action);
            }
        }
    }
}

public class Tree<T>
{
    private readonly TreeNode<T>? _root;

    Tree()
    {
        _root = null;

    }

    public void Traverse()
    {
        if (_root == null)
        {
            throw new ArgumentNullException(nameof(_root), "Root cannot be null.");
        }


        if (_root.Children != null)
        {
            foreach (var child in _root.Children)
            {
                Traverse();
            }
        }
        else
        {
            Console.WriteLine(_root.Value);
            return;
        }
    }


}