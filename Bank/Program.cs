using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteAce = new Gerente()
            {
                Nome = "Ace",
                CPF = "856.321.947-36",
                Salario = 6800,
                NumeroDeAgencias = 7,
            };

            Vendedor vendedorNami = new Vendedor()
            {
                Nome = "Nami",
                CPF = "549.325.878-21",
                Salario = 3000,
                NumeroClientesAtendidos = 4,
            };

            Vendedor vendedorSanji = new Vendedor()
            {
                Nome = "Sanji",
                CPF = "986.481.365-27",
                Salario = 3000,
                NumeroClientesAtendidos = 1,
            };

            Vendedor vendedorYamato = new Vendedor()
            {
                Nome = "Yamato",
                CPF = "033.007.077-04",
                Salario = 3000,
                NumeroClientesAtendidos = 8,
            };

            vendedorSanji.Bonificacao = vendedorSanji.Salario;
            vendedorNami.Bonificacao = vendedorNami.Salario;
            vendedorYamato.Bonificacao = vendedorYamato.Salario;
            gerenteAce.Bonificacao = gerenteAce.Salario;

            ContaCorrente contaDoBiancaRibeirodeSouza = new ContaCorrente("Bianca Ribeiro de Souza", 48, 4200, vendedorSanji);
            contaDoBiancaRibeirodeSouza.Conta = 369;
            ContaCorrente contaDoLuffy = new ContaCorrente("Luffy", 56, 3600, vendedorYamato);
            contaDoLuffy.Conta = 258;
            ContaCorrente contaDoZoro = new ContaCorrente("Zoro", 74, 4500, vendedorNami);
            contaDoZoro.Conta = 147;

            Console.WriteLine("\nBonificação Nami: " + vendedorNami.Bonificacao +
            "\nBonificação Yamato: " + vendedorYamato.Bonificacao + 
            "\nBonificação Sanji: " + vendedorSanji.Bonificacao +
            "\nBonificação Ace: " + gerenteAce.Bonificacao +
            "\nRemuneração total Nami: " + vendedorNami.RemuneracaoTotal(vendedorNami.Salario, vendedorNami.Bonificacao) +
            "\nRemuneração total Sanji: " + vendedorSanji.RemuneracaoTotal(vendedorSanji.Salario, vendedorSanji.Bonificacao) + 
            "\nRemuneração total Yamato: " + vendedorYamato.RemuneracaoTotal(vendedorYamato.Salario, vendedorYamato.Bonificacao) +
            "\nRemuneração total Ace: " + gerenteAce.RemuneracaoTotal(gerenteAce.Salario, gerenteAce.Bonificacao) +
            "\nDias de férias Nami: " + vendedorNami.CalcularFerias() +
            "\nDias de férias Sanji: " + vendedorSanji.CalcularFerias() +
            "\nDias de férias Yamato: " + vendedorYamato.CalcularFerias() +
            "\nDias de férias Ace: " + gerenteAce.CalcularFerias());

            Console.WriteLine("\nConta 1: " + contaDoBiancaRibeirodeSouza.Titular +
            "\nConta 2: " + contaDoZoro.Titular + 
            "\nConta 3: " + contaDoLuffy.Titular);

            Console.WriteLine("\nO número de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);

        }
    }
}