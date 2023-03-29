using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Models
{
    public class Team
    {
        private ITeamStrategy strategy;
        private string name;
        public Team(string _name , ITeamStrategy _strategy)
        {
            this.strategy = _strategy;
            this.name = _name;
        }
        public void setStrategy(ITeamStrategy _strategy)
        {
            this.strategy = _strategy;
        }
        public void playGame()
        {
            strategy.play(name);
        }
    }
}
