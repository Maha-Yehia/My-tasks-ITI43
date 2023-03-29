
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //product
    public class PlayGround
    {
        private List<string> _parts = new List<string>();
        public void Add(string _part)
        {
            _parts.Add(_part);
        }
        public void Show(string name)
        {
            Console.WriteLine($"\n{name} Product Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}
