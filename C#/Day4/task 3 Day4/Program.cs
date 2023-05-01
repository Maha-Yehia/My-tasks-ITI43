namespace task_3_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
        }


        public class EmployeeSearch
        {
            Employee[] empArr;
            int[] NationalIDs;
            string[] empDate;
            string[] Names;
            List<string> empReturn;

            public EmployeeSearch(Employee[] empAr)
            {
                this.empArr = empAr;
                NationalIDs = new int[empAr.Length];
                Names = new string[empAr.Length];
                empDate = new string[empAr.Length];
                for (int i = 0; i < empArr.Length; i++)
                {
                    NationalIDs[i] = empArr[i].ID;
                }
                for (int i = 0; i < empArr?.Length; i++)
                {
                    Names[i] = empArr[i].Name;
                }
                for (int i = 0; i < empArr.Length; i++)
                {
                    empDate[i] = empArr[i].getDate;
                }
            }
            //public EmployeeSearch(int[] id)
            //{
            //    this.NationalIDs = id;
            //}
            //public EmployeeSearch(HireDate[] empDate)
            //{
            //    this.empDate = empDate;
            //}
            //public EmployeeSearch(string[] Names)
            //{
            //    this.Names = Names;
            //}

            public string searchName(string nam)
            {
                for (int i = 0; i < empArr.Length; i++)
                {
                    if (nam == Names[i])
                    {
                        return empArr[i].ToString();
                    }
                }
                return "Not Found";
            }

            public string searchID(int num)
            {
                for (int i = 0; i < empArr.Length; i++)
                {
                    if (num == NationalIDs[i])
                    {
                        return empArr[i].ToString();
                    }
                }
                return "Not Found";
            }

            public List<string> searchDate(string date)
            {
                empReturn = new List<string>();
                for (int i = 0; i < empDate.Length; i++)
                {
                    if (date == empDate[i])
                    {
                        empReturn.Add(empArr[i].ToString());
                    }
                }
                return empReturn;
            }
        }
    }
}