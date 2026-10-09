using PracticaTDD;

namespace TestPracticaTDD
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-5, -1L)]
        [DataRow(0, 1L)]
        [DataRow(1, 1L)]
        [DataRow(5, 120L)]
        public void CalcularFactorial_VariosCasos(int n, long resultadoEsperado)
        {
            Funciones funciones = new Funciones();
            long resultado = funciones.CalcularFactorial(n);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("123456#", false)]
        [DataRow("ContrasenyaLarga", false)]
        [DataRow("PasswordValida#1", true)]
        public void EsContrasenyaValida_VariosCasos(string contrasenya, bool resultadoEsperado)
        {
            Funciones funciones = new Funciones();
            bool resultado = funciones.EsContrasenyaValida(contrasenya);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}