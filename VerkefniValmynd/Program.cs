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
                    Console.Clear();
                    verkefni1();
                }

                else if (menu == "2a")
                {
                    Console.Clear();
                    verkefni2a();
                }

                else if (menu == "2b")
                {
                    Console.Clear();
                    verkefni2b();
                }
                else if (menu == "2c")
                {
                    Console.Clear();
                    verkefni2c();
                }

                else if (menu == "3a")
                {
                    Console.Clear();
                    verkefni3a();
                }

                else if (menu == "3b")
                {
                    Console.Clear();
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
            Console.Clear();
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

            bool key = false;
            bool sword = false;
            bool monster = true;
            bool[] room = new bool[9];
            string input;
            int roomNumber = rnd.Next(1, 9);
            while (roomNumber == 6 || roomNumber == 3)
            {
                roomNumber = rnd.Next(1, 9);
            }
            room[roomNumber - 1] = true;
            do
            {
                if (room[0])
                {
                    Console.SetCursorPosition(45, 15);
                    Console.Write("╠══════╬");
                    Console.SetCursorPosition(45, 16);
                    Console.Write("║  ");
                    if (roomNumber == 1)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ╨");

                    Console.SetCursorPosition(45, 17);
                    Console.Write("║      ╥");
                    Console.SetCursorPosition(45, 18);
                    Console.Write("╚══╡╞══╩");
                    Console.SetCursorPosition(1, 0);

                }

                if (room[1])
                {
                    Console.SetCursorPosition(52, 15);
                    Console.Write("╬══╡╞══╬");
                    Console.SetCursorPosition(52, 16);
                    Console.Write("╨  ");
                    if (roomNumber == 2)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ║");
                    Console.SetCursorPosition(52, 17);
                    Console.Write("╥      ║");
                    Console.SetCursorPosition(52, 18);
                    Console.Write("╩══════╩");
                    Console.SetCursorPosition(1, 0);
                }

                if (room[2])
                {
                    Console.SetCursorPosition(59, 15);
                    Console.Write("╬══╡╞══╣");
                    Console.SetCursorPosition(59, 16);
                    Console.Write("║  ");
                    if (roomNumber == 3)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ║");
                    Console.SetCursorPosition(59, 17);
                    Console.Write("║      ║");
                    Console.SetCursorPosition(59, 18);
                    Console.Write("╩══════╝");
                    Console.SetCursorPosition(1, 0);
                }

                if (room[3])
                {
                    Console.SetCursorPosition(45, 12);
                    Console.Write("╠══╡╞══╬");
                    Console.SetCursorPosition(45, 13);
                    Console.Write("║  ");
                    if (roomNumber == 4)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ╨");
                    Console.SetCursorPosition(45, 14);
                    Console.Write("║      ╥");
                    Console.SetCursorPosition(45, 15);
                    Console.Write("╠══════╬");
                    Console.SetCursorPosition(1, 0);
                }

                if (room[4])
                {
                    Console.SetCursorPosition(52, 12);
                    Console.Write("╬══════╬");
                    Console.SetCursorPosition(52, 13);
                    Console.Write("╨  ");
                    if (roomNumber == 5)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ╨");
                    Console.SetCursorPosition(52, 14);
                    Console.Write("╥      ╥");
                    Console.SetCursorPosition(52, 15);
                    Console.Write("╬══╡╞══╬");
                    Console.SetCursorPosition(1, 0);
                }

                if (room[5])
                {
                    Console.SetCursorPosition(59, 12);
                    Console.Write("╬══════╣");
                    Console.SetCursorPosition(59, 13);
                    Console.Write("╨  ");
                    if (roomNumber == 6)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ║");
                    Console.SetCursorPosition(59, 14);
                    Console.Write("╥      ║");
                    Console.SetCursorPosition(59, 15);
                    Console.Write("╬══╡╞══╣");
                    Console.SetCursorPosition(1, 0);
                }

                if (room[6])
                {
                    Console.SetCursorPosition(45, 9);
                    Console.Write("╔══════╦");
                    Console.SetCursorPosition(45, 10);
                    Console.Write("║  ");
                    if (roomNumber == 7)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ╨");
                    Console.SetCursorPosition(45, 11);
                    Console.Write("║      ╥");
                    Console.SetCursorPosition(45, 12);
                    Console.Write("╠══╡╞══╬");
                    Console.SetCursorPosition(1, 0);
                }

                if (room[7])
                {
                    Console.SetCursorPosition(52, 9);
                    Console.Write("╦══════╦");
                    Console.SetCursorPosition(52, 10);
                    Console.Write("╨  ");
                    if (roomNumber == 8)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ╨");
                    Console.SetCursorPosition(52, 11);
                    Console.Write("╥      ╥");
                    Console.SetCursorPosition(52, 12);
                    Console.Write("╬══════╬");
                    Console.SetCursorPosition(1, 0);
                }

                if (room[8])
                {
                    Console.SetCursorPosition(59, 9);
                    Console.Write("╦══════╗");
                    Console.SetCursorPosition(59, 10);
                    Console.Write("╨  ");
                    if (roomNumber == 9)
                    {
                        Console.Write("@");
                    }
                    else
                    {

                        Console.Write(" ");

                    }
                    Console.Write("   ╨");
                    Console.SetCursorPosition(59, 11);
                    Console.Write("╥      ╥");
                    Console.SetCursorPosition(59, 12);
                    Console.Write("╠══════╬");
                    Console.SetCursorPosition(1, 0);
                }


                if (roomNumber == 1)
                {
                    Console.SetCursorPosition(1, 0);
                    Console.WriteLine("You find yourself in an empty room with a sturdy door to the [south] and an opening to your [east]");

                    Console.SetCursorPosition(1, 2);
                    input = Console.ReadLine();


                    if (input.ToLower() == "south")
                    {

                        if (key == true)
                        {
                            roomNumber = 10;
                            Console.Clear();
                        }

                        else
                        {
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("The Door is locked");

                        }
                    }


                    else if (input.ToLower() == "east")
                    {
                        roomNumber = 2;
                        room[1] = true;
                        Console.Clear();
                    }

                    else
                    {
                        Console.SetCursorPosition(1, 1);
                    }

                }

                else if (roomNumber == 2)
                {
                    room[1] = true;
                    Console.WriteLine("You see Two doorways one going [west] and the other [north]");
                    input = Console.ReadLine();


                    if (input.ToLower() == "north")
                    {
                        roomNumber = 5;
                        room[4] = true;
                    }


                    else if (input.ToLower() == "west")
                    {
                        roomNumber = 1;
                        room[0] = true;
                    }

                    Console.Clear();
                }

                else if (roomNumber == 3)
                {


                    if (key == false)
                    {
                        Console.WriteLine("You see a [key] on the floor and a door to the [north]");
                    }
                    else
                    {
                        Console.WriteLine("You see a door to the north");
                    }
                    input = Console.ReadLine();

                    if (input.ToLower() == "key")
                    {
                        Console.WriteLine("You picked up the key");
                        key = true;
                        Console.ReadLine();
                        Console.Clear();
                    }


                    else if (input.ToLower() == "north")
                    {
                        roomNumber = 6;
                        room[5] = true;
                        Console.Clear();
                    }



                }

                else if (roomNumber == 4)
                {

                    Console.WriteLine("You can go [east] or [north]");
                    input = Console.ReadLine();


                    if (input.ToLower() == "north")
                    {
                        roomNumber = 7;
                        room[6] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "east")
                    {
                        roomNumber = 5;
                        room[4] = true;
                        Console.Clear();
                    }
                }

                else if (roomNumber == 5)
                {

                    Console.WriteLine("You see three doors, one to the [south] showing some light,");
                    Console.WriteLine("one to the [west] and a blood trail from the door to the [east]");
                    input = Console.ReadLine();

                    if (input.ToLower() == "south")
                    {
                        roomNumber = 2;
                        room[1] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "west")
                    {
                        roomNumber = 4;
                        room[3] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "east")
                    {
                        roomNumber = 6;
                        room[5] = true;
                        Console.Clear();
                    }
                }

                else if (roomNumber == 6)
                {



                    if (monster == false)
                    {
                        Console.WriteLine("There is a door to the [west] and to the [south]");
                    }

                    else
                    {
                        Console.WriteLine("A large monster is blocking your path do you run or fight?");
                    }

                    input = Console.ReadLine();

                    if (input.ToLower() == "fight" && monster == true)
                    {
                        if (sword)
                        {
                            Console.WriteLine("You killed the monster");
                            monster = false;
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("without a weapon you lost to the monster");
                            roomNumber = 0;
                        }
                    }

                    else if (input.ToLower() == "run" && monster == true)
                    {
                        roomNumber = 5;
                        room[4] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "south" && monster == false)
                    {
                        roomNumber = 3;
                        room[2] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "west" && monster == false)
                    {
                        roomNumber = 5;
                        room[4] = true;
                        Console.Clear();
                    }

                }



                else if (roomNumber == 7)
                {

                    Console.WriteLine("you can go [south] and [east]");
                    input = Console.ReadLine();


                    if (input.ToLower() == "south")
                    {
                        roomNumber = 4;
                        room[3] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "east")
                    {
                        roomNumber = 8;
                        room[7] = true;
                        Console.Clear();
                    }
                }

                else if (roomNumber == 8)
                {
                    if (sword == false)
                    {
                        Console.WriteLine("You see doors to the [east] and to the [west], and a [sword] up against the wall");

                    }
                    else
                    {
                        Console.WriteLine("You see doors to the [east] and to the [west]");
                    }
                    input = Console.ReadLine();

                    if (input.ToLower() == "west")
                    {
                        roomNumber = 7;
                        room[6] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "east")
                    {
                        roomNumber = 9;
                        room[8] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "sword" && sword == false)
                    {
                        Console.WriteLine("you took the sword");
                        sword = true;
                        Console.ReadLine();
                        Console.Clear();
                    }


                }

                else if (roomNumber == 9)
                {
                    Console.WriteLine("You see a door to the [west] and a [window] overlooking a forest on the east wall");
                    input = Console.ReadLine();


                    if (input.ToLower() == "west")
                    {
                        roomNumber = 8;
                        room[7] = true;
                        Console.Clear();
                    }

                    else if (input.ToLower() == "window")
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
            // Breytur skilgreindar + staðsetningarhnit sett á leikmann og skrímsli
            char[,] map = new char[22, 78];
            bool alive = true;
            int charx = 2;
            int chary = 15;
            int level = 1;
            int items = 0;
            int health = 0;
            int monsterx = 20;
            int monstery = 70;
            int timelimit = 0;
            Random rnd = new Random();
            Console.Clear();
            //Console.BackgroundColor = ConsoleColor.White;


            // Glugginn skilgreindur með ramma sem og hvernig á að lesa staðsetningu á leikmanni
            for (int x = 0; x <= map.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= map.GetUpperBound(1); y++)
                {
                    if (x == 0 || x == 21 || y == 0 || y == 77 || y == 14)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Red;
                        map[x, y] = '░';
                        Console.Write(map[x, y]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.White;
                    }

                    else if (x == charx && y == chary)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        map[x, y] = '@';
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(map[x, y]);
                    }

                    else if (y > 14)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        map[x, y] = '.';
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(map[x, y]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        map[x, y] = ' ';
                        Console.Write(map[x, y]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }





                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(1, 2);
            Console.Write("Level:" + level);
            Console.SetCursorPosition(1, 3);
            Console.Write($"  {health}/{level}");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {


                // Kortið uppfært m.t.t. mögulegar staðsetningu fyrir leikmann, skrímsli og verðlauna
                for (int x = 1; x <= map.GetUpperBound(0) - 1; x++)
                {
                    for (int y = 15; y <= map.GetUpperBound(1) - 1; y++)
                    {
                        // Staðsetning sett á verðlaun, með því að ná öllum verðlaunum sem spawna þá hækkar þú upp um level (borð), 
                        // verðlaunum fjölgar svo til samræmis við það level sem þú ert í 

                        while (items < level)
                        {
                            int Healthx = 0;

                            Healthx = rnd.Next(1, 21);


                            int Healthy = 0;

                            Healthy = rnd.Next(15, 76);
                            if (map[Healthx, Healthy] == '#' || map[Healthx, Healthy] == '@' || map[Healthx, Healthy] == '!')
                            {

                            }

                            else
                            {
                                map[Healthx, Healthy] = '#';
                                items++;
                            }
                        }


                        // Staðsetning leikmanns uppfærð
                        if (x == charx && y == chary)
                        {
                            map[x, y] = '@';
                            Console.SetCursorPosition(y, x);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(map[x, y]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        // Staðsetning skrímslis uppfærð
                        else if (x == monsterx && y == monstery)
                        {
                            if (map[x, y] == '#')
                            {

                            }

                            else
                            {
                                map[x, y] = '!';
                                Console.SetCursorPosition(y, x);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(map[x, y]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }

                        // ef það þarf ekki að uppfæra staðsetninguna þá er ekkert keyrt
                        else if (map[x, y] == '.')
                        {

                        }

                        // ef leikmaður/skrímsli var á staðsetningu og var að færa sig þá kemur aftur upp punktur í það hnit
                        else
                        {
                            if (map[x, y] == '#')
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                map[x, y] = '.';
                            }
                            Console.SetCursorPosition(y, x);
                            Console.Write(map[x, y]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }

                // Skilgreint hvernig leikmaður færist til á borði með notkun örvatakka
                Console.SetCursorPosition(1, 22);

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (map[charx + 1, chary] == '.')
                    {

                        charx++;
                    }
                    else if (map[charx + 1, chary] == '#')
                    {
                        // ef hann tekur upp verðlaun þá er talið hversu mörg verðlaun hann er komin með 
                        health++;
                        charx++;
                    }

                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (map[charx - 1, chary] == '.')
                    {

                        charx--;
                    }

                    else if (map[charx - 1, chary] == '#')
                    {
                        health++;
                        charx--;
                    }
                }

                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (map[charx, chary - 1] == '.')
                    {

                        chary--;
                    }

                    else if (map[charx, chary - 1] == '#')
                    {
                        health++;
                        chary--;
                    }
                }

                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (map[charx, chary + 1] == '.')
                    {

                        chary++;
                    }

                    else if (map[charx, chary + 1] == '#')
                    {
                        health++;
                        chary++;
                    }
                }

                // Ef skrímlið hreyfist 50% í hverri umferð þá hefur þú möguleika að komast undan því
                int move = rnd.Next(2);
                if (move == 1)
                {

                    // hér er skrímslinu sagt að hreyfa sig í áttina að leikmanni
                    if (monsterx < charx)
                    {
                        monsterx++;
                    }

                    else if (monsterx > charx)
                    {
                        monsterx--;
                    }

                    else if (monstery < chary)
                    {
                        monstery++;
                    }

                    else if (monstery > chary)
                    {
                        monstery--;
                    }

                    // ef leikmaður er í sama reit og skrímsli þá deyr leikmaður 
                    if (monstery == chary && monsterx == charx)
                    {
                        alive = false;
                    }

                    if (health >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(1, 3);
                        Console.Write($"  {health}/{level}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                // hér er skilgreint að leikmaður fari upp um level með því að ná öllum þeim hlutum sem spawna á hverju leveli
                if (health == level)
                {
                    items = 0;
                    health = 0;
                    level++;
                    Console.SetCursorPosition(1, 2);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Level:" + level);
                    Console.SetCursorPosition(1, 3);
                    Console.Write($"  {health}/{level}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                timelimit++;
                if (timelimit % 60 == 0)
                {
                    items--;
                    health--;
                }



                // Leikurinn heldur áfram svo lengi sem leikmaður er á lífi
            } while (alive);
            Console.Clear();
            string text = "You Died";
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
    }
}
