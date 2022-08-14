using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Maximum = 100;
            progressBar1.Value = progressBar1.Maximum;

            label1.Text = progressBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classe acao1 = new Classe();
            acao1.Ataque1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classe acao2 = new Classe();
            acao2.Ataque2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classe acao3 = new Classe();
            acao3.Curar();
        }
    }
}
