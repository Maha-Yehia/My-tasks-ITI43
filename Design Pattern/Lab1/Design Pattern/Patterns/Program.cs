using Patterns.Helper;
using Patterns.Models;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Position posBall1 = new Position(1, 2, 3);
            Position posBall2 = new Position(3, 2, 3);
            Position posPlayer = new Position(2, 2, 3);
            FootBall bal = new FootBall(posBall1); //position
            Player p = new Player("Mo Salah" , posPlayer ,bal);
            bal.Attach(p);
            //Player p = new Player("Hager", new Helper.Position(1, 2, 3), bal);
            bal.Notify();
            bal.Bposition = posBall2;
            bal.Notify();

        }
    }
}