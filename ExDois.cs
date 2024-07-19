namespace DesafioPratico1C_
{
    public class ExDois
    {
        public void NomeSobrenome()
        {
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"Seu nome é: {name} {sobrenome}");
        }
    }
}
