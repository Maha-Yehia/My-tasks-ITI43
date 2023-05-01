namespace Task1_Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime BD1 = new(1990, 1, 1);
            DateTime BD2 = new(1991, 12, 12);
            DateTime BD3 = new(1992, 10, 10);
            DateTime BD4 = new(1950, 10, 10);


            Employee employee1 = new Employee(1, BD4, 3);
            Employee employee2 = new Employee(2, BD3, 3);
            Employee employee3 = new SalesPerson(3, BD2, 3, 1000);
            Employee employee4 = new SalesPerson(4, BD1, 3, 2000);
            Employee employee5 = new BoardMember(5, BD1, 3);
            Employee employee6 = new BoardMember(6, BD4, 3);


            Department department1 = new Department(10, "Finance");
            Club Club1 = new Club(20, "Zahraa");

            department1.AddStaff(employee1);
            department1.AddStaff(employee2);
            department1.AddStaff(employee3);
            department1.AddStaff(employee4);
            department1.AddStaff(employee5);
            department1.AddStaff(employee6);

            Club1.AddMember(employee1);
            Club1.AddMember(employee2);
            Club1.AddMember(employee3);
            Club1.AddMember(employee4);
            Club1.AddMember(employee5);
            Club1.AddMember(employee6);


            Console.WriteLine("Department at the beginning: ");
            Console.WriteLine(department1.ToString());
            Console.WriteLine("----------------------------");


            Console.WriteLine("Club at the beginning: ");
            Console.WriteLine(Club1.ToString());
            Console.WriteLine("----------------------------");

            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            employee3.EndOfYearOperation();
            employee4.EndOfYearOperation();
            employee5.EndOfYearOperation();
            employee6.EndOfYearOperation();

            Console.WriteLine("Department After the end of the year: ");
            Console.WriteLine(department1.ToString());
            Console.WriteLine("----------------------------");


            Console.WriteLine("Club After the end of the year: ");
            Console.WriteLine(Club1.ToString());
            Console.WriteLine("----------------------------");


            employee2.RequestVacation(new DateTime(2023, 2, 1), new DateTime(2023, 2, 7));
            employee3.RequestVacation(new DateTime(2023, 2, 1), new DateTime(2023, 2, 2));
            employee4.RequestVacation(new DateTime(2023, 2, 1), new DateTime(2023, 2, 7));
            employee5.RequestVacation(new DateTime(2023, 2, 1), new DateTime(2023, 2, 8));
            employee6.RequestVacation(new DateTime(2023, 2, 1), new DateTime(2023, 2, 3));


            Console.WriteLine("Employees After passing vacation limit for all employees: ");
            Console.WriteLine(department1.ToString());
            Console.WriteLine("----------------------------");


            Console.WriteLine("Club After passing vacation limit for all employees: ");
            Console.WriteLine(Club1.ToString());
            Console.WriteLine("----------------------------");

            employee3.CheckTarget(2000);
            employee4.CheckTarget(2000);


            Console.WriteLine($"Department After Target checking for {employee3} & {employee4}: ");
            Console.WriteLine(department1.ToString());
            Console.WriteLine("----------------------------");



            Console.WriteLine($"Club After Target checking for {employee3} & {employee4}: ");
            Console.WriteLine(Club1.ToString());
            Console.WriteLine("----------------------------");



            employee5.Resign();

            Console.WriteLine($"Department After Resgning {employee5}: ");
            Console.WriteLine(department1.ToString());
            Console.WriteLine("----------------------------");


            Console.WriteLine($"Club After Resgning {employee5}: ");
            Console.WriteLine(Club1.ToString());
            Console.WriteLine("----------------------------");

        }
    }
}