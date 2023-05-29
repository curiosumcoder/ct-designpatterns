using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1.Alternativa
{
    public class OrigamiBird : Bird
    {
        public override void WhoAreYou()
        {
            Console.WriteLine($"I am a origami bird {Name}...");
        }
    }
}
