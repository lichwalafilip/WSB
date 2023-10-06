namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wbisz dlugosc boku a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("wbisz dlugosc boku b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("wbisz dlugosc boku c");
            int c = int.Parse(Console.ReadLine());

            float p = (a + b + c) / 2;

            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));


            Console.WriteLine(s);

        }
    }
}