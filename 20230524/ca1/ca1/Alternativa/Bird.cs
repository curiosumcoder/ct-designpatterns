using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1.Alternativa
{
    public abstract class Bird
    {
		private string name;

		public string Name
		{
			get { return name; }
			set {
				int n;
				if (int.TryParse(value, out n))
				{
					throw new ApplicationException("No se permite números.");
				}

				name = value; 
			}
		}

		// Composition
        public ISing? SingBehavior { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Bird frying ...");
        }

        public abstract void WhoAreYou();
    }
}
