using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class NotaFiscal
    {
        public Cabecalho Cabecalho { get; set; }
        public List<Produto> Produtos { get; set; }
        public Rodape Rodape { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("******************************* NOTA FISCAL DE SAIDA *******************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Cabecalho);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Produto\t\t\t\tQuantidade\t\tPreco");
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine($"{produto.Nome}\t\t\t\t{produto.Quantidade}\t\tR${produto.Preco:F2}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Rodape);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("************************************************************************************");
        }

    }
}
