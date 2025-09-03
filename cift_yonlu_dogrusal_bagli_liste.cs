/* LINKED LIST 
-- tek yönlü doğrusal
-- çift yönlü doğrusal ( bu cs dosyasında bununla alakalı çalışmalar var.)
-- tek yönlü dairesel
-- çift yönlü dairesel 


Bu çalışmada olanlar
-- çift yonlude basa ve sona ekleme
-- cift yonlude ekrana yazdirma
-- cift yonlude tersten ekrana yazdirma
-- cift yonlude araya ekleme ve aradan silme

*/





/*

namespace Program
{
    class Program
    {
        public static void Main()
        {
            ListCiftYonluDogrusal list1 = new ListCiftYonluDogrusal();
            int secim = Menu();
            int data;
            int index;
            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("sayi :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list1.BasaEkle(data);
                        list1.EkranaYazdir();
                        break;
                    case 2:
                        Console.Write("sayi :");
                        data = Convert.ToInt32(Console.ReadLine());
                        list1.SonaEkle(data);
                        list1.EkranaYazdir();
                        break;
                    case 3:
                        list1.BastanSil();
                        list1.EkranaYazdir();
                        break;
                    case 4:
                        list1.SondanSil();
                        list1.EkranaYazdir();
                        break;
                    case 5:
                        list1.TerstenEkranaYazdir();
                        break;
                    case 6:
                        Console.Write("sayi :");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("hangi indexe ekleyelim ? : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        list1.ArayaEkle(index, data);
                        list1.EkranaYazdir();
                        break;
                    case 7:
                        Console.Write("hangi indexi silelim ? : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        list1.AradanSil(index);
                        list1.EkranaYazdir();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("hatalı secim.");
                        secim = Menu();
                        break;
                }
                // Console.Clear();
                secim = Menu();
            }
            Console.WriteLine("program bitti");
        }

        public static int Menu()
        {
            int secim;
            Console.WriteLine("1- basa ekle");
            Console.WriteLine("2- sona ekle");
            Console.WriteLine("3- bastan sil");
            Console.WriteLine("4- sondan sil");
            Console.WriteLine("5- tersten yazdir");
            Console.WriteLine("6- araya ekle");
            Console.WriteLine("7- aradan sil");
            Console.WriteLine("0- programı kapat");
            Console.Write("seciminiz : ");
            secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }
    }

    class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public Node? Prev { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
            this.Prev = null;
        }
    }

    class ListCiftYonluDogrusal
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set; }

        public ListCiftYonluDogrusal()
        {
            this.Head = null;
            this.Tail = null;
        }

        public void BasaEkle(int data)
        {
            Node eleman = new Node(data);

            if (Head == null)
            {
                Head = eleman;
                Tail = eleman;
            }
            else
            {
                eleman.Next = Head;
                Head.Prev = eleman;
                Head = eleman;
            }
        }

        public void SonaEkle(int data)
        {
            if (Head == null)
            {
                BasaEkle(data);
            }
            else
            {
                Node? eleman = new Node(data);
                Tail!.Next = eleman;
                eleman.Prev = Tail;
                Tail = eleman;
            }
        }

        public void EkranaYazdir()
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş, yazdırılacak bir şey yok");
            }
            Node? temp = Head;
            Console.Write("baş -> ");
            while (temp!.Next != null)
            {
                Console.Write($"{temp.Data} -> ");
                temp = temp.Next;
            }
            Console.WriteLine(temp.Data + " -> son");
        }

        public void TerstenEkranaYazdir()
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş");
            }
            else
            {
                Node? temp = Tail;
                Console.Write("son -> ");
                while (temp!.Prev != null)
                {
                    Console.Write($"{temp.Data} -> ");
                    temp = temp.Prev;
                }
                Console.WriteLine($"{temp.Data} -> baş");
            }
        }

        public void BastanSil()
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş silinecek bir şey yok.");
            }
            else
            {
                Head.Next!.Prev = null;
                Head = Head.Next;
            }
        }
        public void SondanSil()
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş silinecek bir şey yok.");
            }
            else
            {
                Tail!.Prev!.Next = null;
                Tail = Tail.Prev;
            }
        }

        public void ArayaEkle(int index, int data)
        {
            if (Head == null)
            {
                BasaEkle(data);
            }
            else
            {
                Node yeni = new Node(data);
                int i = 0;
                Node? temp = Head;
                while (temp.Next != null && i < index - 1)
                {
                    temp = temp.Next;
                    i++;
                }
                yeni.Next = temp.Next;
                temp.Next!.Prev = yeni;
                temp.Next = yeni;
                yeni.Prev = temp;
            }

        }

        public void AradanSil(int index)
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş silinecek bir şey yok.");
            }
            else
            {
                int i = 0;
                Node? temp = Head;
                while (temp.Next != null && i < index - 1)
                {
                    temp = temp.Next;
                    i++;
                }
                temp.Next = temp.Next!.Next;
                temp.Next!.Prev = temp;
            }
        }


    }
}

*/