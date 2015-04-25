using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Trololololo");
            Kubelek kubel = new Kubelek(5, 3);
            List<int> wyniki = kubel.rzut();
        }
    }
}
