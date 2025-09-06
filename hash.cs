/*  HASH TABLE
dizi ve bağlı listeleri kulllanıyoruz. keyin size'a göre modunu alıyoruz.
çıkan sonuca göre dizinin hangi indisine eklenecekse oradaki bağlı listeye ekliyoruz.


bu çalışmada 
-- table'a eleman ekleme
-- table'ı yazdırma
-- table'dan eleman silme
-- table'da eleman arama işlemleri bulunuyor. 
*/


namespace HashTable
{
    class Program
    {
        public static void Main()
        {
            Table table = new Table(5);
            int secim = Menu();
            int key;
            string? isim;

            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("eklenecek isim: ");
                        isim = Console.ReadLine();
                        Console.Write("key: ");
                        key = Convert.ToInt32(Console.ReadLine());
                        table.Ekle(key, isim);
                        table.Yazdir();
                        break;
                    case 2:
                        table.Sil();
                        table.Yazdir();
                        break;
                    case 3:
                        Console.Write("aranacak eleman: ");
                        isim = Console.ReadLine();
                        table.Ara(isim);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("hatalı giriş !!");
                        secim = Menu();
                        break;
                }
                secim = Menu();
            }
            

            

        }

        private static int Menu()
        {
            int secim;
            Console.WriteLine("1- eleman ekle");
            Console.WriteLine("2- eleman sil");
            Console.WriteLine("3- eleman ara");
            Console.WriteLine("0- cikis");
            Console.Write("seçiminiz : ");
            return secim = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Node
    {
        public int Key { get; set; }
        public string? Name { get; set; }
        public Node? Next { get; set; }

        public Node()
        {
            this.Next = null;
        }
        public Node(int key, string? name)
        {
            this.Key = key;
            this.Name = name;
            this.Next = null;
        }
    }

    class Table
    {
        public int Size { get; set; }
        Node[] dizi;

        public Table(int size)
        {
            this.Size = size;
            dizi = new Node[size];
            for (int i = 0; i < size; i++)
            {
                dizi[i] = new Node();
            }
        }

        public void Ekle(int key, string? name)
        {
            Node eleman = new Node(key, name);
            int indis = key % Size;
            Node? temp = dizi[indis];

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = eleman;
        }

        public void Yazdir()
        {
            for (int indis = 0; indis < Size; indis++)
            {
                Console.Write(indis + ". sütun -> ");
                Node? temp = dizi[indis];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                    Console.Write(temp.Name + " ");
                }
                Console.WriteLine();
            }
                Console.WriteLine();


        }

        public void Sil()
        {
            Console.Write("silmek istediğiniz isim :");
            string? silinecek = Console.ReadLine();
            bool silindiMi = false;
            bool mevcutMu = false;

            for (int i = 0; i < Size; i++)
            {
                if (silindiMi == true)
                {
                    break;
                }
                Node? temp = dizi[i];
                Node? temp2 = dizi[i];
                while (temp.Next != null)
                {
                    temp2 = temp;
                    temp = temp.Next;
                    if (temp.Name == silinecek)
                    {
                        temp2.Next = temp.Next;
                        Console.WriteLine("eleman silindi");
                        silindiMi = true;
                        mevcutMu = true;
                        break;
                    }
                }
            }
            if (mevcutMu == false)
            {
                Console.WriteLine("eleman table'da yok");
            }
        }
        public void Ara(string? isim)
        {
            bool varMi = false;
            for (int i = 0; i < Size; i++)
            {
                Node? temp = dizi[i];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                    if (temp.Name == isim)
                    {
                        varMi = true;
                        Console.WriteLine("evet var");
                        break;
                    }
                }
            }
            if (varMi == false)
            {
                        Console.WriteLine("hayır yok");
                
            }
        }
    }
}