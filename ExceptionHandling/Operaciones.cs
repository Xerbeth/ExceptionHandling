using System;

namespace ExceptionHandling
{
    public class Operaciones
    {
        static void Main(string[] args)
        {
            try
            {
                OperacionesBasicas oB = new OperacionesBasicas();
                Console.WriteLine(oB.Suma("12", "1,4"));
                Console.WriteLine(oB.Resta("12y", "1,4"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

    }
}
