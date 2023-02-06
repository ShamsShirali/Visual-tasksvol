using System;
using System.ComponentModel;
using System.Linq;
using System.Xml;

namespace _04._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secin;

            string[] fullname = { "Elisafa Hacizade", "Ayten Eliyeva", "Mubariz Agayev", "Zehra Sireli" };



            do
            {
                

                Console.WriteLine("\n1.Butun telebelere baxin.");
                Console.WriteLine("2.Yeni telebe elave edin.");
                Console.WriteLine("3.Telebeler uzre axtaris edin.");
                Console.WriteLine("4.Telebelerin adlarina baxin.");
                Console.WriteLine("5.Siyahida adin olub-olmadigina baxin.");
                Console.WriteLine("0.Menudan cixin.");

                Console.WriteLine("\n Secim edin:");

                secin = Console.ReadLine();

                switch (secin)
                {
                        case "1":
                        for (int i = 0; i < fullname.Length; i++)
                        {
                            Console.WriteLine(fullname[i]);
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine("Elave edeceyiniz telebeni daxil edin:");

                        string addstudent;

                        Array.Resize(ref fullname, fullname.Length+1);

                        do
                        {

                           addstudent= Console.ReadLine();
                            var war = (addstudent.Split(" "));
                            for (int i = 0; i < war.Length; i++)
                            {
                                var first = (war[0].ToUpper());

                                var little = (war[0].Substring(1));
                                string finish = (little.ToLower());
                                string bign = (first.Substring(0, 1));

                                var namee = (string.Concat(bign, finish));


                                var firstt = (war[1].ToUpper());

                                var littlee = (war[1].Substring(1));
                                string finishh = (littlee.ToLower());
                                string bignn = (firstt.Substring(0, 1));

                                var surname = (string.Concat(bignn, finishh));


                                var babe=(string.Concat(namee," ",surname));

                                fullname[fullname.Length - 1] = babe;
                            }
                        }

                        while (addstudent.Length !< 3);

                       

                        break;
                        case "3":
                        Console.WriteLine("Axtarisi daxil edin:");

                        string sign = Console.ReadLine();

                        bool symbol = false;

                        for(int i = 0; i < fullname.Length; i++)
                        {
                            if (fullname[i].ToLower().Contains(sign) || fullname[i].ToUpper().Contains(sign))
                            {
                                Console.WriteLine(fullname[i]);
                                symbol = true;
                            }
                        }

                        if (symbol=false)
                        {
                            Console.WriteLine("Siyahida daxil etdiyiniz sexs tapilmamaqdadir!");
                        }

                        break; 
                        case "4":
                        Console.WriteLine("Siyahidaki adlar:");
                        for (int i = 0; i < fullname.Length; i++)
                        {
                          var index = (fullname[i].IndexOf(' '));
                            Console.WriteLine(fullname[i].Remove(index));
                        }
                       
                        break;
                        case "5":
                        Console.WriteLine("Axtaris ucun daxil edin:");

                        var result = Yno();

                        if (result == 0)
                        {
                            
                            Console.WriteLine("var)");
                        }
                        else
                        {
                            Console.WriteLine("yoxdur!");
                        }
                        
                        break;
                        case "0":
                        Console.WriteLine("Menu-dan cixin)");
                        break;
                        default: 
                        Console.WriteLine("Bele bir secim movcud deyil,zehmete olmasa bir daha secim edin:");
                        break;
                }
            }
            while (secin!="0");

            Console.WriteLine("Proses bitdi.");
        }

       static int Yno()
        {
            string[] fullname = { "Elisafa Hacizade", "Ayten Eliyeva", "Mubariz Agayev", "Zehra Sireli" };

            string search = Console.ReadLine();

            for (int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i].Contains(search))
                {

                    return 0;
                }

            }
            return -1;
        }

        
    }
}
