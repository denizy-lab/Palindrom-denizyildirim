using System;

namespace Palindrom
{
    class Program
    {
        // SADECE HARFLER İÇİN YAPILDI.
        private static string cikis;
        private static bool cikis2 = true;
        private static int index = 0;
        private static bool palindromMu = false;
        private static string metin;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Bir Metin Girin. (Min. 2 harf): ");
                string metin = Console.ReadLine();
               
                char[] text = new char[metin.Length];
                if (metin.Length > 2)
                {         
                    for (int i = metin.Length - 1; i >= 0; i--)
                    {   
                        text[index] = metin[i];
                        index++;
                    }
                    
                    for (int i = 0; i < metin.Length; i++)
                    {
                        if (text[i] == metin[i])
                        {
                            palindromMu = true;

                        }
                        else
                            palindromMu = false;
                          
                    }     
                    if(palindromMu)
                        Console.WriteLine("Bu Kelime Palindrom.");
                    else
                        Console.WriteLine("Bu kelime Palindrom Değildir.");
                    index = 0; ;
                    Console.WriteLine("Devam için Enter...");
                    Console.WriteLine("Çıkış için 'q' harfine bas...");
                    cikis = Console.ReadLine();
                    if (cikis == "q")
                        cikis2 = false;



                }
                else
                {
                    Console.WriteLine("Metin 2 Haften Fazla Olmalı.");
                }
              
            }
            while (cikis2);


        }
    }
}
