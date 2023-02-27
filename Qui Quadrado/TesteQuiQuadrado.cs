namespace Qui_Quadrado
{
    internal class TesteQuiQuadrado
    {
        /*
         * A variavel booleana quiQuadradoExeCSucesso terá como valor "true" se a função QuiQuadrado()
         * for executado com êxito e terá como valor "false" se não for
         */
        public bool quiQuadradoExeCSucesso;

        /* 
         * A função QuiQuadrado() vai retornar o valor do QuiQuadrado de duas listas
         */
        public float QuiQuadrado(float[] Fobs, float[] Fesp)
        {
            float XQuadrado;
            XQuadrado = 0;

            int NumeroDeElementos = Fobs.Length;
            for (int i = 0; i < NumeroDeElementos; i++)
            {
                XQuadrado += QuiQuadrado(Fobs[i], Fesp[i]);
            }
            quiQuadradoExeCSucesso = true;
            return XQuadrado;
        }

        /*
         * A segunda função QuiQuadrado() vai retornar o valor apenas dois valores individuais
         */
        public float QuiQuadrado(float Fobs, float Fesp)
        {
            return ((Fobs - Fesp) * (Fobs - Fesp)) / Fesp;
        }

        /*
         * A forPossivelExecutarTeste() vai retornar "true" se for possivel executar o teste
         * com as listas fornecidas e vai retornar "false" se não for possivel
         */
        public bool forPossivelExecutarTeste(float[] Fobs, float[] Fesp)
        {
            return (Fobs.Length == Fesp.Length);
        }
    }
}
