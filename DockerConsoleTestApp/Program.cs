namespace DockerConsoleTestApp
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i < 10)
            {
                Thread.Sleep(2000);
                Console.WriteLine(GetLetter());
                i++;
            }
        }

        private static char GetLetter()
        {
            const string chars = @"$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:
                                    ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            var rand = new Random();
            var num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }
    }
}