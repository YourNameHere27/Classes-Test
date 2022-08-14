using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace class_teste
{
    internal class Classe
    {
        public void Ataque1()
        {
            if (progressBar1.Value - 25 <= 0)
            {
                progressBar1.Value = progressBar1.Value - 25;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        public void Ataque2()
        {
            if (progressBar1.Value - 50 <= 0)
            {
                progressBar1.Value = progressBar1.Value - 50;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        public void Curar()
        {
            progressBar1.Value = progressBar1.Maximum;
        }
    }
}
