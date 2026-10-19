namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle bird1 = new Eagle();

            bird1.Eat();
            bird1.Fly();

            Ostrich bird2 = new Ostrich();
            bird2.Eat();
            //bird2.Fly();

            Console.WriteLine("---------------------------------");

            Vehicle vehicle1 = new Car();
            vehicle1.StartEngine();
            vehicle1.Drive();

            Vehicle vehicle2 = new Bicycle();
            vehicle2.StartEngine();
            vehicle2.Drive();

        }
    }
}