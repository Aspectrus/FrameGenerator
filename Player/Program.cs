using FrameGenerator;
using System;
using System.Threading.Tasks;


namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {          

            MainGenerator generator = new MainGenerator();
            Console.WriteLine("Hello World!");

            Task.Run(() => generator.GenerateImage()   .ContinueWith((_) => { Console.WriteLine("Async magic"); return; }));


            Console.WriteLine("it just works");
            System.Console.Read();
        }
    }

  
}
