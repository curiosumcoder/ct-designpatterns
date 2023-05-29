using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1.Alternativa
{
    public class Tucan : Bird
    {
        public Tucan() 
        {
            SingBehavior = new TucanSing();
        }
        public override void WhoAreYou()
        {
            Console.WriteLine($"I am a tucan {Name}...");
        }
    }
}
