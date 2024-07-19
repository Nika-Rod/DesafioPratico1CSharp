using System.Text.RegularExpressions;

namespace DesafioPratico1C_
{
    public class ExCinco
    {
        public void ValidarPlaca()
        {
            Console.WriteLine("Digite sua placa: ");
            var placa = Console.ReadLine();

            var regexLetras = "^[A-Za-z]{3}$";
            var regexNumeros = "[0-9]{4}$";


            if (placa.Length != 7) 
                Console.WriteLine("Número inválido de caracteres. A placa deve ter 7 caracteres");

            if (Regex.IsMatch(placa.Substring(0, 3), regexLetras) && Regex.IsMatch(placa.Substring(3, 4), regexNumeros))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }


        }
    }
}
