using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ca1
{
    public class Tucan : Bird
    {
        public override void WhoAreYou()
        {
            Console.WriteLine($"I am a tucan {Name}...");
        }
    }
}