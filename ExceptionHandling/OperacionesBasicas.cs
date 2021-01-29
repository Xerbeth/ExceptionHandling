using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class OperacionesBasicas
    {
        public float a { get; set; }
        public float b { get; set; }

        public OperacionesBasicas()
        {
            a = b = 0;
        }

        public float Suma(string a, string b)
        {
            try
            {
                this.a = TryParseNumber(a);
                this.b = TryParseNumber(b);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message.ToString());
            }            

            return (this.a + this.b);
        }

        private float TryParseNumber(string number)
        {
            bool flag = float.TryParse(number, out float numberParse);
            if (!flag)
            {
                GenerateException(number);
            }
            return numberParse;
        }

        public float Resta(string a, string b)
        {
            bool flag = float.TryParse(a, out float parseA);
            if (!flag)
            {
                GenerateException(a);
            }

            this.a = parseA;

            flag = float.TryParse(b, out float parseB);
            if (!flag)
            {
                GenerateException(b);
            }

            this.b = parseB;

            return (this.a + this.b);
        }

        /// <summary>
        /// Método para generar las excepciones genericas 
        /// </summary>
        /// <param name="number"> Parametro no valida para convertir a float </param>
        private void GenerateException(string number)
        {
            throw new ArgumentException("No es posible convertir el parametro con valor -> " + number);
        }
    }
}
