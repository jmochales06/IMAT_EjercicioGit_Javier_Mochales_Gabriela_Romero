namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 1;
            Console.WriteLine($"{Add(x,y)}");
        }

        static int Add(int x, int y) { return x + y; }
    }
}