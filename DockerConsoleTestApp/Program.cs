namespace DockerConsoleTestApp
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    class Program
    {
        static void Main(string[] args)
        {
            var content = JsonConvert.DeserializeObject<Content>(File.ReadAllText("quotes.json"));

            var r = new Random().Next(content.Quotes.Length);

            Console.WriteLine(content.Quotes[r]);
        }

        private class Content
        {
            public string[] Quotes { get; set; }
        }
    }
}
