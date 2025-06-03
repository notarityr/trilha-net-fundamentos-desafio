namespace DesafioFundamentos.Models //namespace DesafioFundamentos.Models que representa o namespace do projeto
{
    public class Estacionamento //classe Estacionamento que representa o estacionamento
    {
        private decimal precoInicial = 0; //preço inicial do estacionamento, do tipo decimal
        private decimal precoPorHora = 0; //preço por hora do estacionamento, do tipo decimal
        private List<string> veiculos = new List<string>(); //lista de veículos do tipo string, onde cada veículo é representado por sua placa

        public Estacionamento(decimal precoInicial, decimal precoPorHora) //construtor da classe Estacionamento
        {
            this.precoInicial = precoInicial; //inicializa o preço inicial do estacionamento
            this.precoPorHora = precoPorHora; //inicializa o preço por hora do estacionamento
        }

        public void AdicionarVeiculo() //método para adicionar veículo ao estacionamento
        {

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            //exibe mensagem de entrada para o usuário digitar a placa do veículo
            string placa = Console.ReadLine(); /*criando variável placa do tipo string (qualquer texto, ex: "ABC1234" ou "XYZ-5678")
            o Console.Readline espera o usuário digitar a placa no terminal*/
            veiculos.Add(placa); /*adicionando a placa digitada na lista de veículos
            usando o método .Add() que adiciona a placa na lista veiculos*/
            Console.WriteLine($"O veículo {placa} foi estacionado com sucesso!"); /*exibindo mensagem de saída
            que o veículo foi registrado com sucesso*/
        }

        public void RemoverVeiculo() //método para remover veículo do estacionamento
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            //exibe mensagem de entrada para o usuário digitar a placa do veículo
            string placa = Console.ReadLine().ToUpper(); /*o Console.Readline espera que o usuário digite a placa
            e o .ToUpper padroniza o que for digirato em letras maiúsculas*/
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) /*veículos.Any verifica se alguma placa da lista
            é igual à alguma placa digitada pelo usuário*/
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                //exibe mensagem de entrada para o usuário digitar a quantidade de horas
                int horas = int.Parse(Console.ReadLine()); /*o int.Parse converte para números inteiros
                e Console.Readline espera que o usuário digite a quantidade de horas*/
                decimal valorTotal = precoInicial + (precoPorHora * horas); /*calcula o preço total somando o preço inicial
                mais o preço por hora por a quantidade de horas*/
                veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper()); /*remove a placa digitada da lista de veículos usando o método .RemoveAll()
                x representa os veículos, o == compara dos dois valores, necessário usar ToUpper nos dois valores porque pode dar erro*/

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                //exibe mensagem de saída informando que o veículo foi removido e o preço total
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                //exibe mensagem de erro caso a placa digitada não esteja na lista de veículos
            }
        }

        public void ListarVeiculos() //método para listar os veículos estacionados
        {
            if (veiculos.Any()) /*verifica se a lista contém algum veúculo estacionado usan3do o método .Any()*/
            {
                Console.WriteLine("Os veículos estacionados são:");
                //exibe mensagem de saída informando que os veículos estacionados serão listados
                foreach (string veiculo in veiculos) /*o laço foreach percorre as placas da lista
                e exibe as placas na tela*/
                    Console.WriteLine(veiculo); /*exibe a placa do veículo*/
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                //exibe mensagem de saída informando que não há veículos estacionados
            }
        }
    }
}
