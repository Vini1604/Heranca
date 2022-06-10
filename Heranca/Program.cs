using Heranca.Entities;
using System;
using System.Collections.Generic;

namespace Heranca
{
    class Program
    {
        static NotaFiscal GeradorDeNotas(Cliente cliente, List<Produto> produtos)
        {
            Cabecalho cabecalho = new Cabecalho() { NumeroNota = Guid.NewGuid(), Cliente = cliente };
            decimal valorTotal = 0;
            foreach (Produto produto in produtos)
                valorTotal += produto.Preco * produto.Quantidade;

            Rodape rodape = new Rodape() { ValorTotal = valorTotal };
            NotaFiscal notaFiscal = new NotaFiscal() { Cabecalho = cabecalho, Produtos = produtos, Rodape = rodape };
            return notaFiscal;
        }
        
        
        static void Main(string[] args)
        {

            Cliente cliente1 = new PessoaFisica() { Nome = "Vinicius", Cpf = "XXX.XXX.XXX-YY" };
            Cliente cliente2 = new PessoaJuridica() { Nome = "IBM", Cnpj = "XX.YYY.ZZZ/0000-11" };
            
            List<Produto> produtos1 = new List<Produto>()
            {
                new Produto(){ Nome = "Mouse Logitech", Preco = 40.0M, Quantidade = 1},
                new Produto(){ Nome = "Teclado Mec", Preco = 60.0M, Quantidade = 2},
                new Produto(){ Nome = "Monitor LED", Preco = 1540.0M, Quantidade = 1},
                new Produto(){ Nome = "Pen Drive 16Gb", Preco = 30.0M, Quantidade = 5},
            };

            List<Produto> produtos2 = new List<Produto>()
            {
                new Produto(){ Nome = "Thinkpad T14", Preco = 18000.0M, Quantidade = 8},
                new Produto(){ Nome = "MacBook MacOS", Preco = 15000.0M, Quantidade = 10},
            };
 
            NotaFiscal notaFiscal1 = GeradorDeNotas(cliente1, produtos1);
            notaFiscal1.Imprimir();

            Console.WriteLine();
            NotaFiscal notaFiscal2 = GeradorDeNotas(cliente2, produtos2);
            notaFiscal2.Imprimir();
        }
    }
}
