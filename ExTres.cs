namespace DesafioPratico1C_
{
    public class ExTres
    {
        public double PrimeiroNum { get; set; }
        public double SegundoNum { get; set; }

        public void Numbers()
        {
            Console.WriteLine("Digite o primeiro número: ");
            this.PrimeiroNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            this.SegundoNum = Convert.ToDouble(Console.ReadLine());

            Soma(PrimeiroNum, SegundoNum);
            Subtracao(PrimeiroNum, SegundoNum);
            Multiplicacao(PrimeiroNum, SegundoNum);
            Div(PrimeiroNum, SegundoNum);
            Med(PrimeiroNum, SegundoNum);
        }

        public void Soma(double primeiroNumero, double segundoNumero)
        {
            var soma = primeiroNumero + segundoNumero;

            Console.WriteLine($"A soma dos números é: {soma}");
        }

        public void Subtracao(double primeiroNumero, double segundoNumero)
        {

            var sub = primeiroNumero - segundoNumero;

            Console.WriteLine($"A subtração dos números é: {sub}");
        }

        public void Multiplicacao(double primeiroNumero, double segundoNumero)
        {

            var mult = primeiroNumero * segundoNumero;

            Console.WriteLine($"A multiplicação dos dois números é: {mult}");
        }

        public void Div(double primeiroNumero, double segundoNumero)
        {
            if (primeiroNumero <= 0 && segundoNumero <= 0)
            {
                Console.WriteLine("ERRO: Número menor ou igual a zero!");
            }
            else 
            {
                var div = primeiroNumero / segundoNumero;

                Console.WriteLine($"A divisão dois números é: {div}");
            }
        }

        public void Med(double primeiroNumero, double segundoNumero)
        {
            var med = (primeiroNumero + segundoNumero) / 2;
            Console.WriteLine($"A média dois números é: {med}");
        }
    }
}
