using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ca1
{
    public class Falcon : Bird
    {
        public override void WhoAreYou()
        {
            Console.WriteLine($"I am a falcon {Name}...");
        }
    }
}