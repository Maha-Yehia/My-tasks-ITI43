using Patterns.Helper;
using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Models
{
    internal class Player : IObserver
    {
        string name;
        Position playerPosition;
        FootBall ball;
        public Player(string _name , Position _playerPosition , FootBall _ball) { 
            this.name = _name;
            this.playerPosition = _playerPosition;
            this.ball = _ball;
        }
        public void update()
        {
            playerPosition = ball.Bposition;
            Console.WriteLine($"Player {name}'s new state is {playerPosition?.ToString()}");
        }

        //public Position PlayerPosition { get; set; }
        //public string Name { get; set; }
    }
}
