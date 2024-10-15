namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {                
                // *Implementado
                throw new ArgumentException("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {            
            // *Implementado
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            // Implementado
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90m; // Aplica o desconto de 10%
            }

            return valorTotal;
        }
    }
}