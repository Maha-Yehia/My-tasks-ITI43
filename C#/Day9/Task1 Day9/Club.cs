using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Day9
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;

        public Club(int _ClubID, string _ClubName)
        {
            ClubID = _ClubID;
            ClubName = _ClubName;
            Members = new List<Employee>();
        }

        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember
        (object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee emp) && (sender != null))
            {
                if (e.Cause == LayOffCause.Vacation_Limit)
                {
                    if (emp.GetType().Name == "Employee")
                    {
                        Members.Remove(emp);
                        Console.WriteLine($"Deleting Employee: {emp}\n");
                    }
                }
                else if (e.Cause == LayOffCause.Sales_Target)
                {
                    if (emp.GetType().Name == "SalesPerson")
                    {
                        Members.Remove(emp);
                        Console.WriteLine($"Deleting Employee: {emp}\n");
                    }
                }
                else if (e.Cause == LayOffCause.Resignation)
                {
                    if (emp.GetType().Name != "BoardMember")
                    {
                        Members.Remove(emp);
                        Console.WriteLine($"Deleting Employee: {emp}\n");
                    }
                }
            }
        }
        ///Employee Will not be removed from the Club if Age>60
        ///Employee will be removed from Club if Vacation Stock < 0
        public override string ToString()
        {
            StringBuilder Club_Members = new StringBuilder();

            foreach (var employee in Members)
            {
                Club_Members.Append(employee.EmployeeID).Append(" , ");
            }

            return Club_Members.ToString();

        }
    }
}
