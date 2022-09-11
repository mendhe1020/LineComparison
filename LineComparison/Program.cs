namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program");

            Line_Comparison obj = new Line_Comparison();

            Console.WriteLine("x1");
            obj.x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1");
            obj.y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2");
            obj.x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2");
            obj.y2 = Convert.ToInt32(Console.ReadLine());

            obj.LineComparison();
        }
    }
}