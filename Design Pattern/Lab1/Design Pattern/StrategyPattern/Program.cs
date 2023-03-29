using StrategyPattern.Models;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefendStrategy strategy1 = new DefendStrategy();
            Team team1 = new Team("Team 1" ,strategy1);
            team1.playGame();
            team1.setStrategy(new AttackStrategy());
            team1.playGame();
        }
    }
}