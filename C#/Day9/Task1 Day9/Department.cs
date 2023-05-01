using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Day9
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;

        public Department(int deptID, string deptName)
        {
            DeptID = deptID;
            DeptName = deptName;
            Staff = new List<Employee>();
        }

        public void AddStaff(Employee E)
        {
            ///Try Register for EmployeeLayOff Event Here
            Staff.Add(E);
            E.EmployeeLayOff += this.RemoveStaff;
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,
        EmployeeLayOffEventArgs e)
        {

            List<Employee> new_list = Staff;

            if ((sender is Employee emp) && (sender != null))
            {
                if (e.Cause == LayOffCause.Vacation_Limit)
                {
                    if (emp.GetType().Name == "Employee")
                    {
                        Staff.Remove(emp);
                        Console.WriteLine($"Deleting Employee: {emp}\n");
                    }
                }
                else if (e.Cause == LayOffCause.Sales_Target)
                {
                    if (emp.GetType().Name == "SalesPerson")
                    {
                        Staff.Remove(emp);
                        Console.WriteLine($"Deleting Employee: {emp}\n");
                    }
                }
                else if (e.Cause == LayOffCause.Retirement)
                {
                    if (emp.GetType().Name != "BoardMember")
                    {
                        Staff.Remove(emp);
                        Console.WriteLine($"Deleting Employee: {emp}\n");
                    }
                }
                else
                {
                    Staff.Remove(emp);
                    Console.WriteLine($"Deleting Employee: {emp}\n");
                }


            }
        }
        public override string ToString()
        {
            StringBuilder Employees_Staff = new StringBuilder();

            foreach (var employee in Staff)
            {
                Employees_Staff.Append(employee.EmployeeID).Append(" , ");
            }

            return Employees_Staff.ToString();
        }
    }
}
