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
            int count1 = 0;
            int count2 = 0;
            bool parent = false;
            bool child = false;
            string values = "";
            while (parent == false)
            {
                string parentAndChild = "";
                try
                {
                    Console.WriteLine(tree.Root.Children[count1].Data);
                    parentAndChild += "Parent= " + tree.Root.Children[count1].Data;
                    child = false;
                }
                catch 
                {
                    parent = true;
                }
                while (child == false)
                {
                    try
                    {
                        Console.WriteLine(tree.Root.Children[count1].Children[count2].Data);
                        parentAndChild += " Child of " + tree.Root.Children[count1].Data + "= " + tree.Root.Children[count1].Children[count2].Data;
                        count2++;
                    }
                    catch
                    {
                        child = true;
                    }
                }
                Console.WriteLine(parentAndChild);
                count1++;
            }
            Console.WriteLine(values);

            for (int i = 0; i < tree.Root.Children.Count; i++)
            {
                string parentAndChild = "Parent = " + tree.Root.Children[i].Data;
                for (int j = 0; j < tree.Root.Children[i].Children.Count; j++)
                {
                    parentAndChild += "Child of " + tree.Root.Children[i].Data + " = " + tree.Root.Children[i].Children[j].Data;
                }
                Console.WriteLine(parentAndChild);
            }
        }
    }
}
