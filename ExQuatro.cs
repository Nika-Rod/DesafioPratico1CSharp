namespace DesafioPratico1C_
{
    public class ExQuatro
    {
        public void ContadorDeCaracteres()
        {
            Console.WriteLine("Escreva uma ou mais palavras: ");
            var palavras = Console.ReadLine().Trim();

            if (palavras is null)
            {
                Console.WriteLine("Não existe palavras para contar os caracteres.");
            }
            else
            {
                var caracteres = palavras.Length;
                Console.WriteLine($"A quantidade de caracteres é: {caracteres}");
            }
        }
    }
}
