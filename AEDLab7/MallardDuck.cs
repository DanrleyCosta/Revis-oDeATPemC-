using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab7
{
    class MallardDuck : Duck, IFlyable, Quackable
    {
        public override void display()
        {
            Console.WriteLine(" I'm very bad Duck ! ");
        }
        public void fly()
        {
            Console.WriteLine(" I'm fly (Mallard Duck) ! ");
        }
        public void quack()
        {
            Console.WriteLine(" quack!! (Mallard Duck) ! ");
        }
    }
}
