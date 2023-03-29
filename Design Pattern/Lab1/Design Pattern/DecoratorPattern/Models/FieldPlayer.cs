using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models
{
    //concrete component
    public class FieldPlayer : Player 
    {
        public override void passBall()
        {
            Console.WriteLine("Field Player passes ball");
        }
    }
}
