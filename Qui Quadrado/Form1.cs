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
         * A função QuiQuadrado() vai retornar o valor do QuiQuadrado de duas listas
         */
        public float QuiQuadrado(float[] Oj, float[] Ej)
        {
            int EjLength = 0;

            for (int i = 0; i < Ej.Length; i++)
            {
                if (Ej[i] != 0)
                {
                    EjLength++;
                }
                else
                {
                    break;
                }
            }

            float totalOj = 0;
            float totalEj = 0;

            for (int i = 0; i < EjLength; i++)
            {
                totalOj += Oj[i];
                totalEj += Ej[i];
            }

            if (totalOj != totalEj)
            {
                throw new IndexOutOfRangeException();
            }

            float XQuadrado = 0;

            for (int i = 0; i < EjLength; i++)
            {
                XQuadrado += QuiQuadrado(Oj[i], Ej[i]);
            }
            return XQuadrado;
        }

        /*
         * A segunda função QuiQuadrado() vai retornar o valor apenas dois valores individuais
         */
        public float QuiQuadrado(float Oj, float Ej)
        {
            if (Oj < 0 || Ej <= 0)
            {
                throw new ArithmeticException();
            }

            return ((Oj - Ej) * (Oj - Ej)) / Ej;
        }


        public float FloatSafeConversion(string a)
        {
            if (a.Length == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToSingle(String.Concat(a.Where(c => !Char.IsWhiteSpace(c))));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorText.Visible = false;

            textBox45.Text = "";
            textBox44.Text = "";
            textBox43.Text = "";
            textBox42.Text = "";
            textBox41.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
            textBox37.Text = "";
            textBox36.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            textBox33.Text = "";
            textBox32.Text = "";
            textBox31.Text = "";

            float[] fObservada = new float[15];
            float[] fEsperada = new float[15];

            try
            {
                fObservada[0] = FloatSafeConversion(textBox15.Text);
                fObservada[1] = FloatSafeConversion(textBox14.Text);
                fObservada[2] = FloatSafeConversion(textBox13.Text);
                fObservada[3] = FloatSafeConversion(textBox12.Text);
                fObservada[4] = FloatSafeConversion(textBox11.Text);
                fObservada[5] = FloatSafeConversion(textBox10.Text);
                fObservada[6] = FloatSafeConversion(textBox9.Text);
                fObservada[7] = FloatSafeConversion(textBox8.Text);
                fObservada[8] = FloatSafeConversion(textBox7.Text);
                fObservada[9] = FloatSafeConversion(textBox6.Text);
                fObservada[10] = FloatSafeConversion(textBox5.Text);
                fObservada[11] = FloatSafeConversion(textBox4.Text);
                fObservada[12] = FloatSafeConversion(textBox3.Text);
                fObservada[13] = FloatSafeConversion(textBox2.Text);
                fObservada[14] = FloatSafeConversion(textBox1.Text);
            }
            catch
            {
                ErrorText.Text = "Erro: não é possivel converter Oj";
                ErrorText.Visible = true;
            }

            try
            {
                fEsperada[0] = FloatSafeConversion(textBox30.Text);
                fEsperada[1] = FloatSafeConversion(textBox29.Text);
                fEsperada[2] = FloatSafeConversion(textBox28.Text);
                fEsperada[3] = FloatSafeConversion(textBox27.Text);
                fEsperada[4] = FloatSafeConversion(textBox26.Text);
                fEsperada[5] = FloatSafeConversion(textBox25.Text);
                fEsperada[6] = FloatSafeConversion(textBox24.Text);
                fEsperada[7] = FloatSafeConversion(textBox23.Text);
                fEsperada[8] = FloatSafeConversion(textBox22.Text);
                fEsperada[9] = FloatSafeConversion(textBox21.Text);
                fEsperada[10] = FloatSafeConversion(textBox20.Text);
                fEsperada[11] = FloatSafeConversion(textBox19.Text);
                fEsperada[12] = FloatSafeConversion(textBox18.Text);
                fEsperada[13] = FloatSafeConversion(textBox17.Text);
                fEsperada[14] = FloatSafeConversion(textBox16.Text);
            }
            catch
            {
                ErrorText.Text = "Erro: não é possivel converter Ej";
                ErrorText.Visible = true;
            }

            try
            {
                QuiQuadradoLabel.Text = "X^2 = " + QuiQuadrado(fObservada, fEsperada);
                textBox45.Text = Convert.ToString(QuiQuadrado(fObservada[0], fEsperada[0]));
                textBox44.Text = Convert.ToString(QuiQuadrado(fObservada[1], fEsperada[1]));
                textBox43.Text = Convert.ToString(QuiQuadrado(fObservada[2], fEsperada[2]));
                textBox42.Text = Convert.ToString(QuiQuadrado(fObservada[3], fEsperada[3]));
                textBox41.Text = Convert.ToString(QuiQuadrado(fObservada[4], fEsperada[4]));
                textBox40.Text = Convert.ToString(QuiQuadrado(fObservada[5], fEsperada[5]));
                textBox39.Text = Convert.ToString(QuiQuadrado(fObservada[6], fEsperada[6]));
                textBox38.Text = Convert.ToString(QuiQuadrado(fObservada[7], fEsperada[7]));
                textBox37.Text = Convert.ToString(QuiQuadrado(fObservada[8], fEsperada[8]));
                textBox36.Text = Convert.ToString(QuiQuadrado(fObservada[9], fEsperada[9]));
                textBox35.Text = Convert.ToString(QuiQuadrado(fObservada[10], fEsperada[10]));
                textBox34.Text = Convert.ToString(QuiQuadrado(fObservada[11], fEsperada[11]));
                textBox33.Text = Convert.ToString(QuiQuadrado(fObservada[12], fEsperada[12]));
                textBox32.Text = Convert.ToString(QuiQuadrado(fObservada[13], fEsperada[13]));
                textBox31.Text = Convert.ToString(QuiQuadrado(fObservada[14], fEsperada[14]));
            }
            catch (IndexOutOfRangeException)
            {
                ErrorText.Text = "Erro: a soma dos valores de Oj e Ej não são iguais";
                ErrorText.Visible = true;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            QuiQuadradoLabel.Text = "X^2";
            ErrorText.Text = "";
            ErrorText.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
        }
    }
}
