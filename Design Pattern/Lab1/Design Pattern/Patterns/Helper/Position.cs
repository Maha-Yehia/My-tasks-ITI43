using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Helper
{
    public class Position
    {
        //int x;
        //int y;
        //int z;
        public Position(int x, int y, int z)
        {
            this.X = x; 
            this.Y = y;
            this.Z = z;
        }
        //prop + double tab : to create a property
        public int X { set; get;}
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString()
        {
            return $"x = {X} , y ={Y} , z = {Z} ";
        }
    }
}
