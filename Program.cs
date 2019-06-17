using System;

namespace Uri_1018_valor_em_cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorTotal, resultado, resto, nota;

            Console.WriteLine("DIGITE O VALOR TOTAL");
            valorTotal = int.Parse(Console.ReadLine()); // EXEMPLO 576


            // a variavael resto recebe o valor  TOTAL digitado NO EXEMPLO 576
            resto = valorTotal;
            //576
            nota = 100; // nota=100 (notas de 100)
            resultado = resto / nota;
            // Variavel RESULTADO recebe 576 / 100 

            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");
            // imprime a quantidade

            resto = resto % nota;
            //variavel resto recebe o valor restante da divisão 576/100 ou sejá 76

            nota = 50;
            resultado = resto / nota;
            // variavel resultado recebe 76 e / 50

            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");

            resto = resto % nota;
            // variavel resto recebe a divisão 76/50 ou seja 26

            nota = 20;
            resultado = resto / nota;
            // variavel resultado recebe 26/20

            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;
            //resto recebe o resto da divisão 26/20 ou seja 6

            nota = 10;
            resultado = resto / nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            resultado = resto / nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            resultado = resto / nota;
            Console.WriteLine(resultado + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");

        }
    }
}
