using System;
using System.Collections.Generic;

namespace oyun_staj_uygulama
{

    class Program
    {
        static void Main(string[] args)
        {
            //yorum satırlarının çözümünü yapamadım, enum ile ulaşmaya çalıştım ama gerçekleştirme sorunu aldım.
            //yardımcı olursanız 'bonuslu' şekilde yapmaya çalışırım.

            List<Object> masa_list = new List<Object>();
            masa_list.Add(new Masa(1, 1000, (Masa.masaTip)2));
            masa_list.Add(new Masa(2, 520, (Masa.masaTip)5));
            masa_list.Add(new Masa(3, 300, (Masa.masaTip)1));
            masa_list.Add(new Masa(4, 4400, (Masa.masaTip)7));
            masa_list.Add(new Masa(5, 4300, (Masa.masaTip)0));
            masa_list.Add(new Masa(6, 1400, (Masa.masaTip)6));
            masa_list.Add(new Masa(7, 3400, (Masa.masaTip)2));
            masa_list.Add(new Masa(8, 400, (Masa.masaTip)6));
            masa_list.Add(new Masa(9, 1450, (Masa.masaTip)5));
            masa_list.Add(new Masa(10, 2250, (Masa.masaTip)5));

            //{
            //new Masa(){ masa_Id=4, bahisMik = 1000, _tip=(Masa.masaTip)2},
            //new Masa(){ masa_Id=1, bahisMik = 520, _tip=(Masa.masaTip)5},
            //new Masa(){ masa_Id=3, bahisMik = 300, _tip=(Masa.masaTip)1},
            //new Masa(){ masa_Id=2, bahisMik = 400, _tip=(Masa.masaTip)6}
            //};

            Console.WriteLine("Bahis miktarini giriniz:");
            int girilen_BahisMik = Convert.ToInt32(Console.ReadLine());
            while (girilen_BahisMik < 200 || girilen_BahisMik > 5000)
            {
                Console.WriteLine("İzin verilen sinir asildi, lutfen bahis miktarini 200 ile 5000 arasinda giriniz:");
                girilen_BahisMik = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Masa tipini/tiplerini seciniz...(Evet ise 'Evet', Hayir ise 'Hayir' yaziniz)");
            Console.WriteLine("Hizli?");
            string Hizli = Console.ReadLine();

            int sayac = 0;
            //Masa.masaTip masa_enum = (Masa.masaTip)Enum.Parse(typeof(Masa.masaTip);

            if (Hizli.Equals("Evet"))
            {
                //masa_enum = (Masa.masaTip)Enum.Parse(typeof(Masa.masaTip), Hizli);
                sayac += 1;
            }

            Console.WriteLine("Teke tek?");
            string Teketek = Console.ReadLine();
            if (Teketek.Equals("Evet"))
            {
                //masa_enum = (Masa.masaTip)Enum.Parse(typeof(Masa.masaTip), Teketek);
                sayac += 2;
            }

            Console.WriteLine("Rovans?");
            string Rovans = Console.ReadLine();
            if (Rovans.Equals("Evet"))
            {
                //masa_enum = (Masa.masaTip)Enum.Parse(typeof(Masa.masaTip), Rovans);
                sayac += 4;
            }

            foreach (Masa masa in masa_list)
            {
                if (girilen_BahisMik == masa.bahisMik)
                {
                    switch (sayac)
                    {
                        case 0:
                            Console.WriteLine("Bulunan masa numarasi: {0}", masa.masa_Id);
                            break;
                        case 1:
                            Console.WriteLine("Bulunan masa numarasi: {0}", masa.masa_Id);
                            break;
                        case 2:
                            Console.WriteLine("Bulunan masa numarasi: {0}", masa.masa_Id);
                            break;
                        case 3:
                            Console.WriteLine("Bulunan masa numarasi: {0}", masa.masa_Id);
                            break;
                        case 5:
                            Console.WriteLine("Bulunan masa numarasi: {0}", masa.masa_Id);
                            break;
                        case 6:
                            Console.WriteLine("Bulunan masa numarasi: {0}", masa.masa_Id);
                            break;
                        case 7:
                            Console.WriteLine("Bulunan masa numarasi: {0}", masa.masa_Id);
                            break;

                    }
                }
                //if (girilen_BahisMik == masa.bahisMik & _tip.HasFlag(masa_enum))
                //{
                //Console.WriteLine("Bulunan masa numarası: ", masa.masa_Id);
                //}
            }

        }
    }


    public class Masa
    {
        [Flags]
        public enum masaTip
        {
            Hizli = 1,
            Teketek = 2,
            Rovans = 4
        }

        public int masa_Id;
        public int bahisMik;

        public masaTip _tip;

        string[] masaTipleri = Enum.GetNames(typeof(masaTip));
        public Masa(int masa_Id, int bahisMik, masaTip tip)
        {
            this.masa_Id = masa_Id;
            this.bahisMik = bahisMik;
            _tip = tip;
        }
    }
}
