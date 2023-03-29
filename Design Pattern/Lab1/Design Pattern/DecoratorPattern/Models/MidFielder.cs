using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    public class MidFielder :PlayerRole
    {
        public void Dribble()
        {
            this.passBall();
        }
        public override void passBall()
        {
            base.passBall();
            Console.WriteLine("Player should Dribble");
        }
    }
}
