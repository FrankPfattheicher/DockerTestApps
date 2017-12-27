namespace DockerConsoleTestApp
{
    using System;
    using System.IO;
    using System.Threading;
    using Newtonsoft.Json;

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(2000);
                var content = JsonConvert.DeserializeObject<Content>(File.ReadAllText("quotes.json"));
                var r = new Random().Next(content.Quotes.Length);
                Console.WriteLine(content.Quotes[r]);
            }
        }

        private class Content
        {
            public string[] Quotes { get; set; }
        }
    }
}
