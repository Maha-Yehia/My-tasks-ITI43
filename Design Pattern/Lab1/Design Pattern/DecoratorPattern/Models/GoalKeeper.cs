using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    //concrete component
    public class GoalKeeper :Player
    {
        public override void passBall()
        {
            Console.WriteLine("Goal Keeper passes ball");
        }
    }
}
