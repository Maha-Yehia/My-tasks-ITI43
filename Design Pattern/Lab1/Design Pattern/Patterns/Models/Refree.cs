using Patterns.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Models
{
    public class Refree
    {
        string name;
        Position refreePosition;
        FootBall ball;
        public Refree(string _name, Position _refreePosition, FootBall _ball)
        {
            this.name = _name;
            this.refreePosition = _refreePosition;
            this.ball = _ball;
        }
        public void update()
        {
            refreePosition = ball.Bposition;
        }
    }
}
