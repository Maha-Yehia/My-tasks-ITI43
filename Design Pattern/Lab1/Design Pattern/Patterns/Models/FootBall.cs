using Patterns.Helper;
using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Models
{
    public class FootBall : Interfaces.Ball
    {
        //private Position position;
        //public int X { set; get; }
        //public int Y { get; set; }
        //public int Z { get; set; }

        public FootBall(Position _position) {
            Bposition = _position;
        }
        public Position Bposition { get; set; }

        
    }
}
