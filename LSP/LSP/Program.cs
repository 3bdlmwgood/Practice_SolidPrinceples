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

            Car vehicle1 = new Car();
            vehicle1.StartEngine();
            vehicle1.Drive();

            Bicycle vehicle2 = new Bicycle();
            //vehicle2.StartEngine();
            vehicle2.Drive();

            Console.WriteLine("---------------------------------");

            Person person1 = new Employee();
            person1.PaySalary();
            person1.SendEmail();

            Person person2 = new Manager();
            person2.PaySalary();
            person2.SendEmail();

            Person person3 = new Student();
            //person3.PaySalary();
            person3.SendEmail();

            Person person4 = new User();
            person4.PaySalary();
            person4.SendEmail();
        }
    }
}