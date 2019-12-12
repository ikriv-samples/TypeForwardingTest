using MyLibrary;

namespace TypeForwardingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var red = new RedClass();
            var black = new BlackClass();

            red.RedStuff();
            black.BlackStuff();
        }
    }
}
