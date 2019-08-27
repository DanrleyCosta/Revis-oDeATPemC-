using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Informe Qual exercicio deseja executar : ");
            char whose = char.Parse(Console.ReadLine());
            switch (whose)
            {
                case '1':
                    Console.Clear();
                    Atividades.Exercicio2();
                    break;
            }
            Console.ReadKey();
        }
    }
}
