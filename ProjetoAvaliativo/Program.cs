using System;
using System.Collections;
using System.Collections.Generic;
namespace Trabalho
{
    class Program
    {
        public class produto
        {
            public string nome;
            public string modelo;
            public string marca;
            public double ano;
            public double valor;
        }
        static List<produto> produtos = new List<produto>();

        static void Main(string[] args)
        {
            EscolherOPC();
            Console.WriteLine("....................................");
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.WriteLine("....................................");
            Console.ReadKey();
        }
        static void EscolherOPC()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo! \n");
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("....................................");
                Console.WriteLine("(1) Cadastrar");
                Console.WriteLine("(2) Alterar");
                Console.WriteLine("(3) Consultar");
                Console.WriteLine("(4) Listar");
                Console.WriteLine("(5) Remover");
                Console.WriteLine("....................................");
                int opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        produto p = new produto();
                        Cadastrar(p);
                        Console.WriteLine("Cadastro Realizado!");
                        break;
                    case 2:
                        Alterar();
                        Console.WriteLine("Alteracao feita com sucesso");
                        break;
                    case 3: Console.WriteLine("Informe o que deseja encontrar: "); bool encontrado = Consultar(Console.ReadLine()); break;
                    case 4: Listar(); break;
                    case 5:
                        Remover();

                        break;

                }
                Console.WriteLine("Deseja continuar no sistema? 1 - Sim | 0 - Não");
                continuar = (int.Parse(Console.ReadLine()) == 1 ? true : false);
            }
        }
        static void Cadastrar(produto p)
        {
            Console.WriteLine("Informe o nome:");
            p.nome = Console.ReadLine();
            Console.WriteLine("Informe o modelo:");
            p.modelo = Console.ReadLine();
            Console.WriteLine("Informe o marca:");
            p.marca = Console.ReadLine();
            Console.WriteLine("Informe a ano:");
            p.ano = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor:");
            p.valor = double.Parse(Console.ReadLine());
            produtos.Add(p);
        }
        static void Alterar()
        {

            if (produtos.Count > 0)
            {
                Console.WriteLine("digite o numero para edicao");
                var c = 0;
                foreach (var p in produtos)
                {
                    Console.WriteLine("{0} - Nome: {1} | ano: {2} | valor: {3} | moldelo: {4} | marca {5}", c, p.nome, p.ano, p.valor, p.modelo, p.marca);
                    c++;
                }

                var num = int.Parse(Console.ReadLine());

                if (num >= 0 && num < produtos.Count)
                {
                    Console.WriteLine("Informe os dados para alteração");
                    Console.WriteLine("Informe o nome:");
                    produtos[c - 1].nome = Console.ReadLine();
                    Console.WriteLine("Informe o modelo:");
                    produtos[c - 1].modelo = Console.ReadLine();
                    Console.WriteLine("Informe o marca:");
                    produtos[c - 1].marca = Console.ReadLine();
                    Console.WriteLine("Informe a ano:");
                    produtos[c - 1].ano = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor:");
                    produtos[c - 1].valor = double.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("não há produtos cadastrados");
            }

        }
        static bool Consultar(string nome)
        {
            bool encontrado = false;
            foreach (produto p in produtos)
            {
                if (p.nome.ToLower().Contains(nome.ToLower()))
                {
                    Console.WriteLine("Nome: {0} | ano: {1} | valor: {2} | modelo: {3} | marca: {4}", p.nome, p.ano, p.valor, p.modelo, p.marca);
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("produto não encontrado!");
            }
            return encontrado;
        }
        static void Listar()
        {
            foreach (produto p in produtos)
            {
                Console.WriteLine("Nome: {0} | ano: {1} | valor: {2} | modelo: {3} | marca: {4}", p.nome, p.ano, p.valor, p.modelo, p.marca);
            }
        }
        static void Remover()
        {
            if (produtos.Count > 0)
            {
                Console.WriteLine("digite o numero para Exclusão");
                var c = 0;
                foreach (var p in produtos)
                {
                    Console.WriteLine("{0} - Nome: {1} | ano: {2} | valor: {3} | modelo: {4} | marca: {5}", c, p.nome, p.ano, p.valor, p.modelo, p.marca);
                    c++;
                }

                var num = int.Parse(Console.ReadLine());

                produtos.Remove(produtos[c - 1]);
                Console.WriteLine("exclusao feita com sucesso");
            }
            else
            {
                Console.WriteLine("não há produtos cadastrados");
            }
        }
    }
}