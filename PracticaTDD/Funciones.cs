using System;

namespace PracticaTDD
{
    public class Funciones
    {
        public long CalcularFactorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0 || n == 1) return 1;

            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public bool EsContrasenyaValida(string contrasenya)
        {
            if (string.IsNullOrEmpty(contrasenya)) return false;
            if (contrasenya.Length < 8) return false;
            if (!contrasenya.Contains("#")) return false;

            return true;
        }
    }
}
