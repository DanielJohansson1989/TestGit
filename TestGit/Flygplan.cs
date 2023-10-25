using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    internal class Flygplan : Fordon
    {
        public string Name { get; set; }
        public string Type { get; set; }


        public override void Go()
        {
            Console.WriteLine("Flygplanet flyger fort så fort. ");
        }
    }
}
