using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ca1
{
    public abstract class Bird
    {
        public string Name { get; set; }

        public virtual void Sing()
        {
            Console.WriteLine("Bird singing ...");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Bird frying ...");
        }

        public abstract void WhoAreYou();
    }
}