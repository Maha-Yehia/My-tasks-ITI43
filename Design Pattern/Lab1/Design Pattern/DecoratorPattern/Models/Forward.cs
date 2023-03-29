using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    public class Forward : PlayerRole
    {
        public void ShootGoal()
        {
            this.passBall();
        }
        public override void passBall()
        {
            base.passBall();
            Console.WriteLine("Player should Shoot Goal");
        }
    }
}
