/* LINKED LIST 
-- tek yönlü doğrusal
-- çift yönlü doğrusal
-- tek yönlü dairesel
-- çift yönlü dairesel 


Bu çalışmada olanlar
- başa ve sona eleman ekleme
- elemanları yazdirma
- baştan ve sondan eleman silme
- araya eleman ekleme ve aradan eleman silme

*/



/*
namespace App
{
    class Program
    {
        public static void Main()
        {
            ListTekYonluDogrusal liste1 = new ListTekYonluDogrusal();

            int secim = Menu();
            int sayi, index;
            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("sayi: ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        liste1.BasaEkle(sayi);
                        break;
                    case 2:
                        Console.Write("sayi: ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        liste1.SonaEkle(sayi);
                        break;
                    case 3:
                        liste1.BastanSil();
                        break;
                    case 4:
                        liste1.SondanSil();
                        break;
                    case 5:
                        Console.WriteLine("sayi:");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("hangi indexe ? : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        liste1.ArayaEkle(index,sayi);
                        break;
                    case 6:
                        Console.WriteLine("hangi indextekini silelim ? : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        liste1.AradanSil(index);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("geçersiz seçim");
                        break;
                }
                Console.Clear();
                liste1.EkranaYazdir();
                secim = Menu();
            }



        }

        private static int Menu()
        {
            int secim;
            Console.WriteLine("1- basa eleman ekle");
            Console.WriteLine("2- sona eleman ekle");
            Console.WriteLine("3- bastan eleman sil");
            Console.WriteLine("4- sondan eleman sil");
            Console.WriteLine("5- araya eleman ekle");
            Console.WriteLine("6- arada eleman sil");
            Console.WriteLine("0- cikis yap");
            Console.Write("seciminiz : ");
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

    class ListTekYonluDogrusal
    {
        public Node? Head { get; set; }

        public ListTekYonluDogrusal()
        {
            this.Head = null;
        }

        public void SonaEkle(int data)
        {
            Node eleman = new Node(data);
            if (Head == null)
            {
                Head = eleman;
                Console.WriteLine("liste oluşturuldu, ilk eleman eklendi");
            }
            else
            {
                Node temp;
                temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = eleman;
                Console.WriteLine($" {data} elemanı sona eklendi");
            }
        }

        public void BasaEkle(int data)
        {
            Node eleman = new Node(data);
            if (Head == null)
            {
                Head = eleman;
                Console.WriteLine("liste oluşturuldu, ilk eleman eklendi.");
            }
            else
            {
                eleman.Next = Head;
                Head = eleman;
                Console.WriteLine($"{data} elemanı başa eklendi");
            }

        }

        public void EkranaYazdir()
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş, yazdırılacak bir şey yok.");
            }
            else
            {
                Node temp;
                temp = Head;
                Console.Write("baş-> ");
                while (temp.Next != null)
                {
                    Console.Write(temp.Data + "-> ");
                    temp = temp.Next;
                }
                Console.Write(temp.Data + "-> Son");
                Console.WriteLine();
            }
        }

        public void BastanSil()
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş, silinecek eleman yok.");
            }
            else
            {
                Head = Head.Next; // baştaki eleman silindi
            }

        }

        public void SondanSil()
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş, silinecek eleman yok.");

            }
            else if (Head.Next == null)
            {
                Head = null;
                Console.WriteLine("son eleman da silindi");
            }
            else
            {
                Node? temp;
                Node? temp2;
                temp2 = null;
                temp = Head;

                while (temp.Next != null)
                {
                    temp2 = temp;
                    temp = temp.Next;
                }

                temp2.Next = null; // son eleman silindi.

            }
        }

        public void ArayaEkle(int index, int data)
        {
            if (index <= 0)
            {
                BasaEkle(data);
            }

            Node newNode = new Node(data);
            int i = 0;
            Node? temp = Head;
            while (temp.Next != null && i < index - 1)
            {
                temp = temp.Next;
                i++;
            }
            if (temp == null)
            {
                Console.WriteLine("index çok büyük");
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;

        }

        public void AradanSil(int index)
        {
            if (Head == null)
            {
                Console.WriteLine("liste boş, silinecek bir şey yok");
            }

            Node? temp = Head;
            int i = 0;

            while (temp.Next != null && i < index - 1)
            {
                temp = temp.Next;
                i++;
            }
            if (temp == null)
            {
                Console.WriteLine("index çok büyük.");
            }
            temp.Next = temp.Next.Next;
        }
    }

}
*/

