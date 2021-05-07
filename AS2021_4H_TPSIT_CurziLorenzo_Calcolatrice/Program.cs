using System;

namespace AS2021_4H_TPSIT_CurziLorenzo_Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calcolatrice c = new();

            double res = c.Operazione(7, "!");

            Console.WriteLine($"Il risultato è: {res}");
        }
    }

    /// <summary>
    /// Classe per gestire operazioni
    /// </summary>
    public class Calcolatrice
    {
        /// <summary>
        /// Metodo che consente di eseguire le operazioni +, -, *, /
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operatore"></param>
        /// <param name="operando2"></param>
        /// <returns>il risultato</returns>
        public double Operazione(double operando1, string operatore, double operando2)
        {
            double retVal = 0;
            switch (operatore)
            {
                case "+":
                    retVal = operando1 + operando2;
                    break;
                case "-":
                    retVal = operando1 - operando2;
                    break;
                case "*":
                    retVal = operando1 * operando2;
                    break;
                case "/":
                    if (operando2 != 0)
                        retVal = operando1 / operando2;
                    break;
                case "^":
                    retVal = Math.Pow(operando1, operando2);
                    break;
            }
            return retVal;
        }

        /// <summary>
        /// Metodo che esegue il fattoriale
        /// </summary>
        /// <param name="operando"></param>
        /// <param name="operatore"></param>
        /// <returns>il risultato</returns>
        public double Operazione(double operando, string operatore)
        {
            double retVal = 0;
            switch (operatore)
            {
                case "!":
                    retVal = Fattoriale(operando);
                    break;
            }

            return retVal;
        }

        /// <summary>
        /// Metodo privato che esegue il fattoriale
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>il risultato</returns>
        double Fattoriale(double numero)
        {
            if (numero == 1)
                return 1;
            else
                return numero * Fattoriale(numero - 1);
        }
    }
}