namespace task1_finallll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of employees");
            int size = int.Parse(Console.ReadLine());

            Employee[] arr = new Employee[size]; 

            for(int i=0 ; i<arr.Length; i++)
            {
               
                Console.WriteLine("Please enter the data of employee " + (i+1));    

                Console.WriteLine("ID= ");
                int myId = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the security level to be guest, Developer, secretary , DBA or securityOfficer");
                securityPrivilege myLevel;
                checked {
                  myLevel = (securityPrivilege)Enum.Parse(typeof(securityPrivilege), Console.ReadLine());
                    Console.WriteLine("error"); 
                }
                //  if (level == "guest")
                //  {
                //      myLevel = securityPrivilege.guest; 
                //  }
                //else  if (level == "Developer")
                //  {
                //      myLevel = securityPrivilege.Developer;
                //  }
                //  else if (level == "secretary")
                //  {
                //      myLevel = securityPrivilege.secretary;
                //  }
                //  else if (level == "DBA")
                //  {
                //      myLevel = securityPrivilege.DBA;
                //  }
                //  else if (level == "securityOfficer")
                //  {
                //      myLevel = securityPrivilege.securityOfficer;
                //  }
                //  else Console.WriteLine("Please enter valid data");

                Console.WriteLine("Salary = ");
                double mySalary = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the day of hiring");
                int myDay = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the month of hiring");
                int myMonth = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the year of hiring");
                int myYear = int.Parse(Console.ReadLine());

                HiringDate myDate = new HiringDate(myDay, myMonth, myYear);

                Console.WriteLine("Please enter the gender of employee to be 'Male' or 'Female' ");

               Gender myGender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

                //    string text = Console.ReadLine(); 
                //    Gender myGender = new Gender(); ;

                //    if (text == "Male")
                //    {
                //        myGender = Gender.Male;
                //    }
                //    else if (text == "Female")
                //    {
                //        myGender = Gender.Female;
                //    }
                //    else Console.WriteLine("Please enter valid data"); 

                arr[i] = new Employee(myId, myLevel , mySalary, myDate, myGender);
               }


            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i].Id);
            //    Console.WriteLine(arr[i].securityLevel);
            //    Console.WriteLine(arr[i].salary);
            //    Console.Write(arr[i].hireDate.day);
            //    Console.Write(arr[i].hireDate.month);
            //    Console.Write(arr[i].hireDate.year);
            //    Console.WriteLine(" ");
            //    Console.WriteLine(arr[i].gender);

            //}


        }
    }

    struct Employee 
    {
        public int Id { get; set; }
        public securityPrivilege securityLevel { get; set; }
        public double salary { get; set; }
        public HiringDate hireDate { get; set; }
        public Gender gender { get; set; }

        public Employee(int id, securityPrivilege securityLevel, double salary, HiringDate hireDate, Gender gender)
        {
            Id = id;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Employee id: {Id} , security Level: {securityLevel} , Salary: {salary:c} , Hiring date:{hireDate} , Gender: {gender}"; 
        }
    }

    enum Gender
    {
        Male = 1,
        Female = 2,
    }


    ///// bit flag array enum 

    [Flags]

    enum securityPrivilege : byte
    {
        guest = 0b_0000_1000, Developer = 0b_0000_0100, secretary = 0b_0000_0010, DBA = 0b_0000_0001, securityOfficer = 0b_0000_1111 , 
    }



    struct HiringDate
    {

        public int day;
        public int month;
        public int year;

        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}"; 
        }
    }





}