using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkefniValmynd
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "0";
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Clear();
                Console.WriteLine("Veldu Forrit:");
                Console.WriteLine("1. Miðjaður Texti");
                Console.WriteLine("2a. Einkunnir vitaður fjöldi");
                Console.WriteLine("2b. Einkunnir Óviss Fjöldi");
                Console.WriteLine("2c. Einkunnir Súlurit");
                Console.WriteLine("3a. MUD leikur");
                Console.WriteLine("3b. AngBand leikur");
                menu = Console.ReadLine();
                if (menu == "1")
                {
                    verkefni1();
                }

                else if (menu == "2a")
                {
                    verkefni2a();
                }

                else if (menu == "2b")
                {
                    verkefni2b();
                }

            } while (menu != "4");
        }



        public static void verkefni1()
        {
            Console.WriteLine("Sláðu inn texta?");
            string text = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition((60 - (text.Length / 2) - 2), 12);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("╔");
            for (int i = 0; i < text.Length + 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");


            Console.SetCursorPosition((60 - (text.Length / 2) - 2), 13);
            Console.Write("║ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ║");


            Console.SetCursorPosition((60 - (text.Length / 2) - 2), 14);
            Console.Write("╚");
            for (int i = 0; i < text.Length + 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");


            Console.ReadLine();
        }

        public static void verkefni2a()
        {
            List<double> einkunn = new List<double>();

            Console.WriteLine("Hver er fjöldi einkunna? ");
            int count = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Einkunn {i + 1}   ");
                Console.SetCursorPosition(11, i);
                Console.Write(":                                             ");

                Console.WriteLine();
            }

            for (int i = 0; i < count; i++)
            {
                bool run = true;
                do
                {
                    Console.SetCursorPosition(11, i);
                    Console.Write(":                                               ");
                    Console.SetCursorPosition(13, i);
                    string input = Console.ReadLine();
                    if (input == "0" ||
                        input == "0,0" ||
                        input == "0,5" ||
                        input == "1" ||
                        input == "1,0" ||
                        input == "1,5" ||
                        input == "2" ||
                        input == "2,0" ||
                        input == "2,5" ||
                        input == "3" ||
                        input == "3,0" ||
                        input == "3,5" ||
                        input == "4" ||
                        input == "4,0" ||
                        input == "4,5" ||
                        input == "5" ||
                        input == "5,0" ||
                        input == "5,5" ||
                        input == "6" ||
                        input == "6,0" ||
                        input == "6,5" ||
                        input == "7" ||
                        input == "7,0" ||
                        input == "7,5" ||
                        input == "8" ||
                        input == "8,0" ||
                        input == "8,5" ||
                        input == "9" ||
                        input == "9,0" ||
                        input == "9,5" ||
                        input == "10" ||
                        input == "10,0"
                        )
                    {
                        einkunn.Add(double.Parse(input));
                        run = false;
                    }

                } while (run);
            }

            Console.WriteLine($"Hæsta Einkunn: {einkunn.Max()}");
            Console.WriteLine($"Lægsta Einkunn: {einkunn.Min()}");
            Console.WriteLine($"Meðaleinkunn: {einkunn.Average():n2}");

            Console.ReadLine();
        }

        public static void verkefni2b()
        {
            Console.WriteLine("er í vinslu");
        }

        public static void verkefni2c()
        {
            Console.WriteLine("er í vinslu");
        }

        public static void verkefni3a()
        {
            Console.WriteLine("er í vinslu");
        }

        public static void verkefni3b()
        {
            Console.WriteLine("er í vinslu");
        }
    }
}
