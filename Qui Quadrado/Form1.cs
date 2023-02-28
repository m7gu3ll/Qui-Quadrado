using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qui_Quadrado
{
    public partial class Form1 : Form
    {
        //Objeto "x" vai executar todas as funções da classe "TesteQuiQuadrado"
        private static TesteQuiQuadrado x;
        public Form1()
        {
            InitializeComponent();
            //Objeto "x" inicializado
            x = new TesteQuiQuadrado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(x.QuiQuadrado(80, 90));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
