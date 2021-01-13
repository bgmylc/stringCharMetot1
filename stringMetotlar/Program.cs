using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üyelik kayıt ekranına hoşgeldiniz!");
            Console.WriteLine("Adınız: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("Doğum tarihiniz (GG/AA/YYYY): ");
            string dogumTarih = Console.ReadLine();
            Console.WriteLine("Şifreniz: ");
            string sifre = Console.ReadLine();
            Console.WriteLine("Şifreniz (tekrar): ");
            string sifre2 = Console.ReadLine();
            
            if (sifre != sifre2)
            {
                Console.WriteLine("Girdiğiniz şifre tekrarı ile uyuşmamaktadır! Tekrar deneyin. ");
            }
            else
            {
                
               
               
                bool[] harfler = new bool[sifre.Length];
               
                for (int i = 0; i < sifre.Length; i++)
                {
                    harfler[i] = Char.IsLetter(sifre, i);
                }

                int falseSayac = 0;
                for (int k = 0; k < sifre.Length; k++)
                {
                  
                    if (harfler[k] != true)
                    {
                        falseSayac++;
                    }
                }

                if (falseSayac == sifre.Length)
                {
                    Console.WriteLine("Lütfen şifrenizde harf kullanın!");
                }
                else
                {
                   
                    string yil = dogumTarih.Substring(6);
                    bool yilVarMi = sifre.Contains(yil);

                    if (yilVarMi == true)
                    {
                        Console.WriteLine("Lütfen şifrenizde doğum yılınızı kullanmayın!");
                    }
                    else
                    {
                        Console.WriteLine("Sitemize hoşgeldiniz!");

                    }
                }
                                

            }






            
            Console.ReadKey();
        }
    }
}
