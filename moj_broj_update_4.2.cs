using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");
        Console.WriteLine(@"   _____             __  __________                   __     _____     ________  
  /     \   ____    |__| \______   \_______  ____    |__|   /  |  |    \_____  \ 
 /  \ /  \ /  _ \   |  |  |    |  _/\_  __ \/  _ \   |  |  /   |  |_    /  ____/ 
/    Y    (  <_> )  |  |  |    |   \ |  | \(  <_> )  |  | /    ^   /   /       \ 
\____|__  /\____/\__|  |  |______  / |__|   \____/\__|  | \____   | /\ \_______ \
        \/      \______|         \/              \______|      |__| \/         \/");
        Console.WriteLine("\n");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("\n");
        Console.WriteLine("* Predmet: Informatika");
        Console.WriteLine("\n");
        Console.WriteLine("* Tema: Najbolje resenje za moj broj");
        Console.WriteLine("\n");
        Console.WriteLine("* Godina: 2024/2025");
        Console.WriteLine("\n");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("\n");

        Menu();
    }

    static void Cheat()
    {

        while (true)
        {
            try
            {
                Console.Write("\n* Unesite brojeve: ");

                var mbNumbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
                Console.Write("\n* Unesite resenje: ");
                int mbSol = int.Parse(Console.ReadLine());
                var mbOps = new List<string> { "+", "-", "*", "/" };

                BruteForce(mbNumbers, mbSol, mbOps);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\n* Samo brojevi mogu da se unose. ");
                Thread.Sleep(5000);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\n* Po pravilima igre morate uneti minimum 6 cifara. Unesite ponovo dovoljan broj cifara");
            }
        }
    }

    static void BruteForce(List<int> array, int mbSol, List<string> mbOps)
    {
        Random random = new Random();
        while (true)
        {
            var nums = array.OrderBy(x => random.Next()).ToList();
            int num1 = nums[0], num2 = nums[1], num3 = nums[2], num4 = nums[3], num5 = nums[4], num6 = nums[5];

            var patterns = new List<string>
            {
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4})",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} ({num3} {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} {num4}",
                $"(({num1} {mbOps[random.Next(mbOps.Count)]} {num2}) {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4}",
                $"(({num1} {mbOps[random.Next(mbOps.Count)]} {num2}) {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5})",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4})",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2}) {mbOps[random.Next(mbOps.Count)]} ({num3} {mbOps[random.Next(mbOps.Count)]} {num4} {mbOps[random.Next(mbOps.Count)]} {num5})",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} ({num3} {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} ({num5} {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} (({num4} {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2}) {mbOps[random.Next(mbOps.Count)]} ({num3} {mbOps[random.Next(mbOps.Count)]} {num4} {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} {num5}",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} ({num3} {mbOps[random.Next(mbOps.Count)]} {num4})) {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2}) {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4} {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} ({num4} - {num5})) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5})) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} ({num3} {mbOps[random.Next(mbOps.Count)]} {num4} {mbOps[random.Next(mbOps.Count)]} ({num5} {mbOps[random.Next(mbOps.Count)]} {num6}))",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} ({num2} {mbOps[random.Next(mbOps.Count)]} {num3}) {mbOps[random.Next(mbOps.Count)]} {num4} {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2}) {mbOps[random.Next(mbOps.Count)]} (({num3} {mbOps[random.Next(mbOps.Count)]} {num4} {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} (({num2} {mbOps[random.Next(mbOps.Count)]} {num3} {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6}",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} ({num3} {mbOps[random.Next(mbOps.Count)]} ({num4} {mbOps[random.Next(mbOps.Count)]} {num5}) {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"({num1} {mbOps[random.Next(mbOps.Count)]} {num2}) {mbOps[random.Next(mbOps.Count)]} (({num3} {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6})",
                $"{num1} {mbOps[random.Next(mbOps.Count)]} {num2} {mbOps[random.Next(mbOps.Count)]} (({num3} {mbOps[random.Next(mbOps.Count)]} {num4}) {mbOps[random.Next(mbOps.Count)]} {num5} {mbOps[random.Next(mbOps.Count)]} {num6})"
            };

            foreach (var pattern in patterns)
            {
                try
                {
                    if (Convert.ToInt32(new System.Data.DataTable().Compute(pattern, null)) == mbSol)
                    {
                        Console.WriteLine("\n* Rezultat: " + pattern + " = " + mbSol);
                        Console.WriteLine("\n* Vreme programa: " + (DateTime.Now - DateTime.Now) + " sec");
                        Thread.Sleep(20000);
                        Environment.Exit(0);
                    }
                }
                catch (DivideByZeroException) { continue; }
                catch (Exception) { break; }
            }
        }
    }

    static void Game()
    {
        Random random = new Random();
        var firstFour = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var firstTwo = new List<int> { 10, 25 };
        var lastTwo = new List<int> { 50, 100 };

        var mbList = new List<List<int>> { new List<int>(), new List<int>() };
        mbList[0].Add(firstFour[random.Next(firstFour.Count)]);
        mbList[0].Add(firstFour[random.Next(firstFour.Count)]);
        mbList[0].Add(firstFour[random.Next(firstFour.Count)]);
        mbList[0].Add(firstFour[random.Next(firstFour.Count)]);
        mbList[0].Add(firstTwo[random.Next(firstTwo.Count)]);
        mbList[0].Add(lastTwo[random.Next(lastTwo.Count)]);

        int mbSol = random.Next(50, 1000);
        var mbOps = new List<string> { "+", "-", "*", "/" };

        Console.WriteLine("\n* Pritisnite 'Space' taster da bi ste zapoceli igru: \n");

        while (true)
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine($"\n* Vasi brojevi su: {string.Join(", ", mbList[0])}");
                break;
            }
        }

        Console.WriteLine($"\n\n* Vase resenje je: [{mbSol}]");

        string user_solve = "";

        var countdownThread = new Thread(() =>
        {
            int my_timer = 60;
            for (int x = 0; x < 60; x++)
            {
                my_timer--;
                Thread.Sleep(1000);
            }
            if (my_timer == 0 && user_solve == "")
            {
                Console.WriteLine("\n\n* Vreme je isteklo");
                Environment.Exit(1);
            }
        });

        while (true)
        {
            Console.Write("\n* Zelite li da ukljucite timer? (da/ne): ");
            string timer_input = Console.ReadLine();

            if (timer_input == "da")
            {
                Console.WriteLine("\n* Imate 1 minut da unesete izraz!\n");
                countdownThread.Start();
                break;
            }
            else if (timer_input == "ne")
            {
                Console.WriteLine("\n* Vreme za ovaj izraz je neograniceno\n");
                break;
            }

            else
            {
                Console.WriteLine("\n* Mozete uneti samo da ili ne");
            }
        }

        user_solve = Console.ReadLine();

        try
        {
            var user_list = user_solve.Split(' ').Where(x => int.TryParse(x, out _)).Select(int.Parse).ToList();
            mbList[1] = user_list;

            CompareList(mbList[1], mbList[0]);

            Console.WriteLine("\n* Vas rezultat: " + user_solve + " = " + new System.Data.DataTable().Compute(user_solve, null));

            int result = Convert.ToInt32(new System.Data.DataTable().Compute(user_solve, null));
            if (result == mbSol)
            {
                Console.WriteLine("\n* Udaljenost 0 = +10 Poena");
                Thread.Sleep(7000);
            }
            else if (Math.Abs(result - mbSol) == 1)
            {
                Console.WriteLine("\n* Udaljenost 1 = +8 Poena");
                Thread.Sleep(7000);
            }
            else if (Math.Abs(result - mbSol) == 2)
            {
                Console.WriteLine("\n* Udaljenost 2 = +4 Poena");
                Thread.Sleep(7000);
            }
            else
            {
                Console.WriteLine("\n* Udaljenost veca od 2 = 0 Poena");
                Thread.Sleep(7000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(12000);
            Environment.Exit(1);
        }
    }

    static void CompareList(List<int> l1, List<int> l2)
    {
        l1.Sort();
        l2.Sort();

        foreach (var each in l1)
        {
            foreach (char c in each.ToString()) 
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Mozete uneti samo cifre");
                    Thread.Sleep(12000);
                    Environment.Exit(1);
                }
            }

            if (l1.Count(x => x == each) > l2.Count(x => x == each))
            {
                Console.WriteLine("Mozete uneti samo postojace brojeve");
                Thread.Sleep(12000);
                Environment.Exit(1);
            }
        }
    }

    static void Menu()
    {
        while (true)
        {
            try
            {
                Console.Write("\n1) Resenje Za Moj Broj \n2) Igra Moj Broj \n\n* Unesite broj:");
                int user_input = int.Parse(Console.ReadLine());

                if (user_input == 1)
                {
                    Cheat();
                    break;
                }
                else if (user_input == 2)
                {
                    Game();
                    break;
                }
                else
                {
                    Console.WriteLine("\n* Mozete uneti samo ponudjene brojeve");
                    Menu();
                }
            } catch (FormatException)
            {
                Console.WriteLine("\n* Mozete uneti samo ponudjene brojeve");
            }
        }
    }
}