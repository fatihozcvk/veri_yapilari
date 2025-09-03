/*
Bu bölümde tek yönlü bağlı liste kullanarak stack konusunu kodladım. 
push komutuyla oluşan node bağlı listenin en başına eklenir ve top güncellenir.
pop komutuyla bağlı listenin en başındaki eleman döndürülür ve top güncellenir. 
*/

/*
namespace Stack
{
    class Program
    {
        public static void Main()
        {
            Stack stack = new Stack();
            int data;
            int secim = Menu();
            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("eklenecek sayi = ");
                        data = Convert.ToInt32(Console.ReadLine());
                        stack.Push(data);
                        stack.StackYazdir();
                        break;
                    case 2:
                        int cikan = stack.Pop();
                        Console.WriteLine($"stackten cikan eleman = {cikan}");
                        stack.StackYazdir();
                        break;
                    case 0:
                        break;
                }
                Console.WriteLine();
                secim = Menu();
            }
            Console.WriteLine("program sonlandı.");
        }

        private static int Menu()
        {
            int secim;
            Console.WriteLine("1- stack'e push yap");
            Console.WriteLine("2- stack'e pop yap");
            Console.WriteLine("0- cikis yap");
            Console.Write("seciminiz: ");
            secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }
    }

    class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    class Stack
    {
        // stack'in en üstündeki elemanı işaret eden
        public Node? Top { get; set; }

        public Stack()
        {
            this.Top = null;
        }

        public void Push(int data)
        {
            Node eleman = new Node(data);
            if (Top == null)
            {
                Top = eleman;
            }
            else
            {
                eleman.Next = Top;
                Top = eleman;
            }
        }

        public int Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("stack boş");
                return -1;
            }
            else
            {
                int sayi = Top.Data;
                Top = Top.Next;
                return sayi;
            }
        }

        public void StackYazdir()
        {
            Node? temp = Top;
            Console.WriteLine("--en üst--");
            while (temp!.Next != null)
            {
                Console.WriteLine($"{temp.Data}");
                temp = temp.Next;
            }
            Console.WriteLine($"{temp.Data}");
            Console.WriteLine("--en alt --");
        }

    }
}
*/