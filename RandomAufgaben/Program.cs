using System;
using System.Diagnostics;

namespace RandomAufgaben
{
    internal class Program
    {

        static void Schleife()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}. Aufgabe:", i);
                Überprüfung();
            }
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine(ts.ToString());

        }

        static void Überprüfung()
        {
            string[] werte = Aufgabe();
            Console.Write("Lösen Sie folgende Aufgabe: {0}", werte[0]);
            while (true)
            {
                if (Convert.ToInt32(Console.ReadLine()) == Convert.ToInt32(werte[werte.Length - 1]))
                {
                    Console.WriteLine("Richtig!");
                    break;
                }
                Console.WriteLine("Das Ergebnis ist falsch!");
            }
        }

        static string[] Aufgabe()
        {
            Random random = new();

            int a = random.Next(1, 11);
            int b = random.Next(1, 11);

            string[] s = new string[2];

            switch (random.Next(1, 4))
            {
                case 1:
                    s[0] = String.Format("{0} + {1} = ", a, b);
                    s[1] = Convert.ToString(a + b);
                    break;

                case 2:
                    s[0] = String.Format("{0} - {1} = ", a, b);
                    s[1] = Convert.ToString(a - b);
                    break;

                case 3:
                    s[0] = String.Format("{0} * {1} = ", a, b);
                    s[1] = Convert.ToString(a * b);
                    break;
            }
            return s;
        }

        static void Main(string[] args)
        {
            Schleife();

            Console.Read();
        }
    }
}
