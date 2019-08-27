using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab7
{
    class RubberDuck : Duck, Quackable
    {
        public override void display()
        {
            Console.WriteLine(" I'm Rubber Duck ! ");
        }
        public void quack()
        {
            Console.WriteLine(" quack!! (Rubber Duck) ! ");
        }
    }
}
