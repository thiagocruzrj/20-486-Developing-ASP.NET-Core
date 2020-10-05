using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TUnidade.Test
{
    [TestClass]
    public class TUnidadeUtil
    {
        [TestMethod]
        public void TesteIniciaComMaiusculo()
        {
            string[] palavras = { "Cachorro", "Gato", "Macaco", "Coelho" };
            foreach (var palavra in palavras)
            {
                bool resultado = Util.PrimeiraLetraMaiuscula(palavra);
                Assert.IsTrue(resultado, string.Format($"Esperando para : {palavra} : true, Atual {resultado}"));
            }
        }

        [TestMethod]
        public void TesteIniciaComMinuscula()
        {
            string[] palavras = { "cachorro", "gato", "macaco", "coelho" };
            foreach (var palavra in palavras)
            {
                bool resultado = Util.PrimeiraLetraMaiuscula(palavra);
                Assert.IsFalse(resultado, string.Format($"Esperando para : {palavra} : true, Atual {resultado}"));
            }
        }
    }
}
