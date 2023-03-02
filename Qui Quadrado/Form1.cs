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
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * A variavel booleana quiQuadradoExeCSucesso terá como valor "true" se a função QuiQuadrado()
         * for executado com êxito e terá como valor "false" se não for
         */
        public bool quiQuadradoExeCSucesso;

        /* 
         * A função QuiQuadrado() vai retornar o valor do QuiQuadrado de duas listas
         */
        public float QuiQuadrado(float[] Oj, float[] Ej)
        {
            float XQuadrado;
            XQuadrado = 0;

            int NumeroDeElementos = Oj.Length;
            for (int i = 0; i < NumeroDeElementos; i++)
            {
                XQuadrado += QuiQuadrado(Oj[i], Ej[i]);
            }
            quiQuadradoExeCSucesso = true;
            return XQuadrado;
        }

        /*
         * A segunda função QuiQuadrado() vai retornar o valor apenas dois valores individuais
         */
        public float QuiQuadrado(float Oj, float Ej)
        {
            return ((Oj - Ej) * (Oj - Ej)) / Ej;
        }

        /*
         * A forPossivelExecutarTeste() vai retornar "true" se for possivel executar o teste
         * com as listas fornecidas e vai retornar "false" se não for possivel
         */
        public bool forPossivelExecutarTeste(float[] Oj, float[] Ej)
        {
            return (Oj.Length == Ej.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(QuiQuadrado(80, 90));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
