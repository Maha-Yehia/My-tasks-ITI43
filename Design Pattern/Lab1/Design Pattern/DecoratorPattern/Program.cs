using DecoratorPattern.Interfaces;
using DecoratorPattern.Models;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FieldPlayer fieldPlayer = new FieldPlayer(); //component
            Forward forward = new Forward(); //decorator1
            MidFielder midFielder = new MidFielder(); //decorator2

            forward.assignPlayer(fieldPlayer);
            midFielder.assignPlayer(forward);

            midFielder.Dribble();
        }
    }
}