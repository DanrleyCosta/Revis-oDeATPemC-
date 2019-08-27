using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab7
{
    class RedHeadDuck : Duck, IFlyable, Quackable
    {
        public override void display()
        {
            Console.WriteLine(" I'm Red head Duck ! ");
        }
        public void fly()
        {
            Console.WriteLine(" I'm fly (red Duck) ! ");
        }
        public void quack()
        {
            Console.WriteLine(" quack!! (red Duck) ! ");
        }
    }
}
