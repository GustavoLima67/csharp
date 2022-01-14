namespace application
{
    class Program
    {
        static void Main(string [] args)
        {
            List<Employee> list = new ArrayList<Employee>();

            Console.Write("Enter with name: ");
            string name = Console.ReadLine();
            Console.Write("Enter with salary: ");
            double salary = Console.ReadLine();

            list.Add(new Employee(name, salary));

            foreach (Employee list in List)
            {
                Console.WriteLine(list);
            }
        }
    }
}