
namespace dotnet_dsa;


public class TreeNode<T>
{

    public List<TreeNode<T>>? Children { get; set; }

    TreeNode()
    {
        Children = [];
    }

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
    private TreeNode<T>? root;

    Tree()
    {
        root = null;

    }

    public void Traverse()
    {
        if (root == null)
        {
            throw new ArgumentNullException(nameof(root), "Root cannot be null.");
        }


        if (root.Children != null)
        {
            foreach (var child in root.Children)
            {
                Traverse();
            }
        }
    }


}
