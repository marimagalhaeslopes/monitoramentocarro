using System;

class CarroMonitoramento
{
    // TODO: Crie o método estático que verifica se o carro está apto
    static string VerificarApto(string modelo, int anoFabricacao, int anoAtual)
    {
        int idadeCarro = anoAtual - anoFabricacao;
        if (idadeCarro <= 10)
        {
            return $"{modelo}: Apto";
        }
        else
        {
            return $"{modelo}: Nao apto";
        }
    }



        static void Main()
    {
        // Lendo os dados de entrada
        string modelo = Console.ReadLine();
        int anoFabricacao = int.Parse(Console.ReadLine());
        int anoAtual = int.Parse(Console.ReadLine());

        //  TODO: Implemente a chamada do método para verificar se o carro está apto

        string resultado = VerificarApto(modelo, anoFabricacao, anoAtual);

        // Exibindo o resultado
        Console.WriteLine(resultado);
    }
}