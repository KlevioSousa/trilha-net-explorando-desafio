using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "João");
Pessoa p2 = new Pessoa(nome: "Gabriela");
Pessoa p3 = new Pessoa(nome: "Junior");
Pessoa p4 = new Pessoa(nome: "Luana");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 80);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 20);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

// Explicação das modificações:
// Cadastro de hóspedes: Agora o código verifica se o número de hóspedes é menor ou igual à capacidade da suíte antes de atribuí-los.
// Exceção: Se o número de hóspedes exceder a capacidade da suíte, lança-se uma exceção apropriada.
// Método ObterQuantidadeHospedes: Retorna o número de hóspedes cadastrados.
// Cálculo da diária: O cálculo da diária aplica o desconto de 10% se o número de dias reservados for maior ou igual a 10.