/*
-- AĞAÇ ÜZERİNDE DOLAŞMA
---- preorder -> önce köke git sonra soldakini bitir sonra sağdaki
---- inorder -> önce sol -> kök -> sağ      küçükten büyüğe
---- postorder -> en son köke git  -> önce sol sonra sağ sonra kök 


*/

/*
namespace Tree
{
    class Program
    {
        public static void Main()
        {
            Tree bst = new Tree();

            bst.Root = bst.Ekle(bst.Root, 10);
            bst.Root = bst.Ekle(bst.Root, 5);
            bst.Root = bst.Ekle(bst.Root, 15);
            bst.Root = bst.Ekle(bst.Root, 20);
            bst.Root = bst.Ekle(bst.Root, 3);
            bst.Root = bst.Ekle(bst.Root, 12);
            bst.Root = bst.Ekle(bst.Root, 9);

            bst.PreOrder(bst.Root);
            Console.WriteLine();
            bst.InOrder(bst.Root);
            Console.WriteLine();
            bst.PostOrder(bst.Root);
            Console.WriteLine();
            Console.WriteLine(bst.ElemanSayisi(bst.Root));
            Console.WriteLine();
            Console.WriteLine(bst.Yukseklik(bst.Root));


        }
    }

    class Node
    {
        public int Data { get; set; }
        public Node? Right { get; set; }
        public Node? Left { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Right = null;
            this.Left = null;
        }
    }

    class Tree
    {
        public Node? Root { get; set; }
        public Tree()
        {
            this.Root = null;
        }

        // ağaca eleman ekleme recursive
        public Node Ekle(Node? root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                if (data < root.Data)
                {
                    root.Left = Ekle(root.Left, data);
                }
                else if (data > root.Data)
                {
                    root.Right = Ekle(root.Right, data);
                }
            }
            return root;
        }

        // preorder önce kök sonra sol sonra sağ
        public void PreOrder(Node? root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        //inorder ortada kök yani sol kök sağ 
        public void InOrder(Node? root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.Write(root.Data + " ");
                InOrder(root.Right);
            }
        }

        //postorder en son kök
        public void PostOrder(Node? root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        public int ElemanSayisi(Node? root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return ElemanSayisi(root.Left) + ElemanSayisi(root.Right) + 1;
            }
        }

        public int Yukseklik(Node? root)
        {
            if (root == null)
            {
                return -1;
            }
            else
            {
                int l, r;
                l = Yukseklik(root.Left) + 1;
                r = Yukseklik(root.Right) + 1;

                if (l > r)
                {
                    return l + 1;
                }
                else
                {
                    return r + 1;
                }
            }
        }

    }
}

*/

