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
                Console.WriteLine("1.  Miðjaður Texti");
                Console.WriteLine("2a. Einkunnir vitaður fjöldi");
                Console.WriteLine("2b. Einkunnir Óviss Fjöldi");
                Console.WriteLine("2c. Einkunnir Súlurit");
                Console.WriteLine("3a. MUD leikur");
                Console.WriteLine("3b. AngBand leikur");
                Console.WriteLine("4.  Hætta");
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
                else if (menu == "2c")
                {
                    verkefni2c();
                }

                else if (menu == "3a")
                {
                    verkefni3a();
                }

                else if (menu == "3b")
                {
                    verkefni3b();
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
            int i = 0;
            List<double> einkunn = new List<double>();
            bool menu = true;
            do
            {
                Console.SetCursorPosition(1, i);
                Console.Write($"Einkunn {i + 1}   ");
                Console.SetCursorPosition(11, i);
                Console.Write(":                                             ");
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
                    else if (input == "")
                    {
                        run = false;
                        menu = false;
                    }

                } while (run);
                i++;
                Console.WriteLine();
            } while (menu);


            Console.Clear();
            Console.WriteLine($"Hæsta Einkunn: {einkunn.Max()}");
            Console.WriteLine($"Lægsta Einkunn: {einkunn.Min()}");
            Console.WriteLine($"Meðaleinkunn: {einkunn.Average():n2}");

            Console.ReadLine();
        }

        public static void verkefni2c()
        {
            int i = 0;
            List<double> einkunn = new List<double>();
            bool menu = true;
            do
            {
                Console.SetCursorPosition(1, i);
                Console.Write($"Einkunn {i + 1}   ");
                Console.SetCursorPosition(11, i);
                Console.Write(":                                             ");
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
                    else if (input == "")
                    {
                        run = false;
                        menu = false;
                    }

                } while (run);
                i++;
                Console.WriteLine();
            } while (menu);


            Console.Clear();
            Console.WriteLine($"Hæsta Einkunn: {einkunn.Max()}");
            Console.WriteLine($"Lægsta Einkunn: {einkunn.Min()}");
            Console.WriteLine($"Meðaleinkunn: {einkunn.Average():n2}");


            for (Double d = 0; d < 10.5; d = d + 0.5)
            {
                Console.Write($"{d:n1}");
                if (d < 10)
                {
                    Console.Write(" :");
                }
                else
                {
                    Console.Write(":");
                }
                foreach (Double e in einkunn)
                {

                    if (e == d)
                    {
                        Console.Write("#");
                    }

                }

                Console.WriteLine();
            }




            Console.ReadLine();
        }

        public static void verkefni3a()
        {
            Random rnd = new Random();
            int roomNumber = rnd.Next(1, 9);
            while (roomNumber == 6 || roomNumber == 3)
            {
                roomNumber = rnd.Next(1, 9);
            }
            bool key = false;
            bool sword = false;
            bool monster = true;
            do
            {


                if (roomNumber == 1)
                {
                    Console.WriteLine("You can go south or east");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();

                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {

                        if (key == true)
                        {
                            roomNumber = 10;
                        }

                        else
                        {
                            Console.WriteLine("The Door is locked");
                        }
                    }


                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        roomNumber = 2;
                    }
                }

                else if (roomNumber == 2)
                {
                    Console.WriteLine("You can go west or north");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();

                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        roomNumber = 5;
                    }


                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        roomNumber = 1;
                    }


                }

                else if (roomNumber == 3)
                {


                    if (key == false)
                    {
                        Console.WriteLine("you see a key lying on the floor, do you want to pick it up?(Y/N)");
                        ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                        Console.Clear();
                        if (keyInfo2.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine("You picked up the key");
                            key = true;
                        }

                        else
                        {
                            Console.WriteLine("you left the key on the floor");
                        }

                    }

                    else
                    {
                        Console.WriteLine("You can go north");
                    }
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        roomNumber = 6;
                    }


                }

                else if (roomNumber == 4)
                {
                    Console.WriteLine("You can go east or north");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();

                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        roomNumber = 7;
                    }

                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        roomNumber = 5;
                    }
                }

                else if (roomNumber == 5)
                {
                    Console.WriteLine("You can go west, east or south");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();

                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        roomNumber = 2;
                    }

                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        roomNumber = 4;
                    }

                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        roomNumber = 6;
                    }
                }

                else if (roomNumber == 6)
                {



                    if (monster == false)
                    {
                        Console.WriteLine("you can go south and west");
                    }


                    else if (sword == true)
                    {

                        Console.WriteLine("A monster appeared but you slew it with your sword");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("you can go south and west");
                        monster = false;
                    }

                    else
                    {

                        roomNumber = 0;
                        Console.WriteLine("A monster appeared and with you being defenceless ");
                    }
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        roomNumber = 3;
                    }

                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        roomNumber = 5;
                    }


                }

                else if (roomNumber == 7)
                {
                    Console.WriteLine("you can go south and east");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();

                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        roomNumber = 4;
                    }

                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        roomNumber = 8;
                    }
                }

                else if (roomNumber == 8)
                {




                    if (sword == false)
                    {
                        Console.WriteLine("You see a sword lying on the floor, pick it up? (Y/N)");
                        ConsoleKeyInfo keyInfo2 = Console.ReadKey();
                        Console.Clear();
                        if (keyInfo2.Key == ConsoleKey.Y)
                        {
                            sword = true; ;
                            Console.WriteLine("you took the Sword!");
                        }

                        else if (keyInfo2.Key == ConsoleKey.N)
                        {
                            Console.WriteLine("you left the Sword on the floor");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You can go east or west");
                    }
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        roomNumber = 7;
                    }

                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        roomNumber = 9;
                    }
                    Console.Clear();

                }

                else if (roomNumber == 9)
                {

                    Console.WriteLine("You can go west");
                    Console.WriteLine("You also see a window on the east side of the house overlooking a forest you can try climbing out");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();

                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        roomNumber = 8;
                    }

                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        Console.WriteLine("you climb out the window but slipped and fell down, breaking your neck and ");
                        roomNumber = 0;
                    }
                }




            } while (roomNumber > 0 && roomNumber < 10);

            if (roomNumber == 0)
            {
                Console.WriteLine("You Died");
            }

            else if (roomNumber == 10)
            {
                Console.WriteLine("you managed to escape");
            }

            Console.ReadLine();
        }

        public static void verkefni3b()
        {
            Console.WriteLine("er í vinslu");
        }
    }
}
