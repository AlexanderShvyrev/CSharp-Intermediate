using System;

namespace CSharpIntermediate
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("I copied you");
        }

        public void Dublicate()
        {
            Console.WriteLine("I duplicated you");
        }
    }
}
