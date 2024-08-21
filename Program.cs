namespace prjTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() { Data = 100};
            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() {Data = 100, Parent = tree.Root},
                new TreeNode<int>() {Data = 1, Parent = tree.Root},
                new TreeNode<int>() {Data = 150, Parent = tree.Root}
            };
            tree.Root.Children[2].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>{Data = 30, Parent = tree.Root.Children[2]}
            };
            tree.Root.Children[0].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>{Data = 8, Parent = tree.Root.Children[0]},
                new TreeNode<int>{Data = 11, Parent = tree.Root.Children[0]}
            };
            tree.Root.Children.Add(new TreeNode<int>() {Data = 70, Parent = tree.Root});

            Console.WriteLine("Data of child " + tree.Root.Children[0].Children[1].Data.ToString());

            for (int i = 0; i < tree.Root.Children.Count; i++)
            {
                string parentAndChild = "Parent = " + tree.Root.Children[i].Data;
                if (tree.Root.Children[i].Children != null)
                {
                    for (int j = 0; j < tree.Root.Children[i].Children.Count; j++)
                    {
                        parentAndChild += " Child = " + tree.Root.Children[i].Children[j].Data;
                    }
                }
                
                Console.WriteLine(parentAndChild);
            }
        }
    }
}
