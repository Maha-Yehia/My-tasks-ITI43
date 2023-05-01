using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Day9
{
    class Employee
    {
        public event
        EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff
        (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }

        public int VacationStock { get; set; }


        public Employee(int _EmployeeID, DateTime _BirthDate, int _VacationStock)
        {
            EmployeeID = _EmployeeID;
            BirthDate = _BirthDate;
            VacationStock = _VacationStock;
        }

        public virtual void Resign()
        {
            LayOffCause Cause = LayOffCause.Resignation;
            OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
        }

        public virtual int AchievedTarget { get; set; }

        public virtual bool CheckTarget(int Quota)
        {
            return true;
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            DateTime period = new DateTime(To.Year, To.Month, To.Day - From.Day);
            int period_Days = period.Day;

            if (VacationStock - period_Days >= 0)
            {
                VacationStock = VacationStock - period_Days;
                return true;
            }
            else
            {
                LayOffCause Cause = LayOffCause.Vacation_Limit;
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
                return false;
            }
        }
        public void EndOfYearOperation()
        {
            DateTime date = new DateTime(2023, 1, 1);

            if (date.Year - this.BirthDate.Year >= 60)
            {
                LayOffCause Cause = LayOffCause.Retirement;
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
            }
        }

        public override string ToString()
        {
            return EmployeeID.ToString();
        }

       
    }
    public enum LayOffCause { Vacation_Limit = 0, Retirement = 1, Sales_Target = 2, Resignation = 3 }
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
        public EmployeeLayOffEventArgs(LayOffCause _Cause)
        {
            Cause = _Cause;
        }
    }

    class SalesPerson : Employee
    {
        public SalesPerson(int _EmployeeID, DateTime _BirthDate, int _VacationStock, int _AchievedTarget) : base(_EmployeeID, _BirthDate, _VacationStock)
        {
            AchievedTarget = _AchievedTarget;
        }

        public override int AchievedTarget { get; set; }
        public override bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                LayOffCause Cause = LayOffCause.Sales_Target;
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
                return false;
            }
            return true;
        }
    }

    class BoardMember : Employee
    {
        public new int VacationStock { get; }
        public BoardMember(int _EmployeeID, DateTime _BirthDate, int _VacationStock) : base(_EmployeeID, _BirthDate, _VacationStock)
        {
            VacationStock = int.MaxValue;
        }
        public override void Resign()
        {
            LayOffCause Cause = LayOffCause.Resignation;
            OnEmployeeLayOff(new EmployeeLayOffEventArgs(Cause));
        }
    }

}






