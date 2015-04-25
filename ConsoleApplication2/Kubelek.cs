using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Kubelek 
    {
        int IleKostek;
        int IleScian;

        Random rand = new Random();

        public Kubelek(int ileKostek, int ileScian) 
        {
            this.IleKostek = ileKostek;
            this.IleScian = ileScian;
        }
        public List<int> rzut() 
        {
            List<int> lista = new List<int>();
            for (int i = 1; i < this.IleKostek; i++) 
            {
                lista.Add(rand.Next(0, IleScian));
            }
           return lista;
        }
    }
}
