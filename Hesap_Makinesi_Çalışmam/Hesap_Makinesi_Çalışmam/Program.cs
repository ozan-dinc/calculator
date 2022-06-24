namespace Hesap_Makinesi_Çalışmam
{
    internal class Program
    {
        static int Toplam(int s1,int s2)
        {
            int Topla = s1 + s2;
            return Topla;
        }
         static int Cıkarım(int s12,int s22)
        {
            int Cıkar= s12 - s22;
            return Cıkar;
        }
        static int Carpım(int s12, int s22)
        {
            int Carp = s12 * s22;
            return Carp;
        }
        static int Bolum(int s12, int s22) 
        {
            int Bol = s12 / s22;
            return Bol;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("*******Girdiğiniz Sayıların 4 İşlemini Gösterir*******");
           
            Console.WriteLine("Toplam Değeri İçin Lütfen 1'e Basınız ");
            Console.WriteLine("Çıkarma Değeri İçin Lütfen 2'e Basınız ");
            Console.WriteLine("Çarpma Değeri İçin Lütfen 3'e Basınız ");
            Console.WriteLine("Bölme Değeri İçin Lütfen 4'e Basınız ");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Lütfen Yapmak İstediğiniz İşlemin Numarasını Giriniz :");
            int sayi = Int32.Parse(Console.ReadLine());
            Console.Write("1.sayıyı giriniz :");
            int Sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz :");
            int Sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------");
            

            switch (sayi)
            {

                case 1: Console.WriteLine("Toplam Değeri :" + Toplam(Sayi1, Sayi2));break;
                case 2: Console.WriteLine("Fark Değeri :" + Cıkarım(Sayi1, Sayi2)); break;
                case 3: Console.WriteLine("Çarpım Değeri :" + Carpım(Sayi1, Sayi2)); break;
                case 4:Console.WriteLine("Bölüm Değeri :" + Bolum(Sayi1, Sayi2)); break;
                default: Console.WriteLine("Hatalı Giriş Yaptınız!"); break;

            }

            Console.Read();
        }
    }
}