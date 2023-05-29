using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1.Alternativa
{
    public class Falcon : Bird
    {
        public Falcon()
        {
            SingBehavior = new FalconSing();
        }

        public override void WhoAreYou()
        {
            Console.WriteLine($"I am a falcon {Name}...");
        }
    }
}
