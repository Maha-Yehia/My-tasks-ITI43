using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Models
{
    public class DefendStrategy : ITeamStrategy
    {
        public void play(string name)
        {
            Console.WriteLine($"{name} plays with Defend Strategy");
        }
    }
}
