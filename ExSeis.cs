using System.Globalization;

namespace DesafioPratico1C_
{
    public class ExSeis
    {
        public void Datas()
        {
            var dataAtualCompleta = DateTime.Now; 
            var dataAtual = DateTime.Now; 
            var horaAtual = DateTime.Now; 
            var dataAtualNomeMes = DateTime.Now;

            Console.WriteLine($"Data completa: {dataAtualCompleta.ToString("dddd dd MMMM yyyy, HH:mm:ss", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Formato dia/mês/ano: {dataAtual.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Formato 24H: {horaAtual.ToString("HH:mm", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Data com mês por extenso: {dataAtualNomeMes.ToString("dd MMMM yyyy", new CultureInfo("pt-BR"))}");

        }
    }
}
