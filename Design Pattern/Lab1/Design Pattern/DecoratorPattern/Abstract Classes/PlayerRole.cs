using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Interfaces
{
    //Decorator
    public abstract class PlayerRole : Player
    {
        public Player player;
        public void assignPlayer(Player _player)
        {
            this.player= _player;
        }
        public override void passBall()
        {
            if(player != null)
            {
                player.passBall(); //component.operation();
            }
        }
    }
}
