namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Eagle();

            bird1.Eat();
            bird1.Fly();

            Bird bird2 = new Ostrich();
            bird2.Eat();
            bird2.Fly();
        }
    }
}