/*
    Bu bölümde tek yönlü bağlı liste kullanarak queue kodladım. 
    mantık olarak ilk giren ilk çıkar. banka sırası gibi. 
    ön ve arka olmak üzere listenin 2 tane Node türünde değişkeni var.
    eklemeler arkadan yapılır. 
    çıkarmalar önden yapılır. her işlem sonunda ( ekleme ve cikarma ) ön ve arka güncellenir. 

    stack yapısında kutu gibi bir mantık vardı yani son giren ilk çıkar gibi. Orada sadece Top var.
    eklemeler de top'a çıkarmalar da toptan yani başa elaman ekle ve baştan eleman silme gibi. 
*/

/*
namespace Queue
{
    class Program
    {
        public static void Main()
        {
            Queue kuyruk = new Queue();
            int secim = Menu();
            int sayi;
            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("eklenecek sayi: ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        kuyruk.Ekle(sayi);
                        Console.WriteLine();
                        kuyruk.QueueYazdir();
                        break;
                    case 2:
                        kuyruk.Cikar();
                        Console.WriteLine();
                        kuyruk.QueueYazdir();
                        break;
                    case 0:
                        break;
                    default:
                        throw new Exception("gecersiz secim");

                }
                secim = Menu();
            }
        }

        private static int Menu()
        {
            int secim;
            Console.WriteLine("1- kuyruğa eleman ekle");
            Console.WriteLine("2- kuyruktan eleman sil");
            Console.WriteLine("0- programı kapat");
            Console.Write("Seciminiz : ");
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

    class Queue
    {
        public Node? On { get; set; }
        public Node? Arka { get; set; }

        public Queue()
        {
            this.On = null;
            this.Arka = null;
        }

        public void Ekle(int data)
        {
            Node eleman = new Node(data);
            if (On == null)
            {
                On = Arka = eleman;
            }
            else
            {
                Arka!.Next = eleman;
                Arka = eleman;
            }
        }

        public void Cikar()
        {
            if (On == null)
            {
                Console.WriteLine("kuyruk boş");
            }
            else
            {
                On = On.Next;
            }
        }

        public void QueueYazdir()
        {
            if (On == null)
            {
                Console.WriteLine("kuyruk boş");
            }
            else
            {
                Console.Write("ön -> ");
                Node? temp = On;
                while (temp.Next != null)
                {
                    Console.Write($"{temp.Data} -> ");
                    temp = temp.Next;
                }
                Console.WriteLine($"{temp.Data} -> son");
            }
        }
    }

}

*/