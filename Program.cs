using CursoByteBank.Utilitarios;
using System;


namespace CursoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Console.WriteLine("Bem Vindo");
            Funcionario Joao = new Funcionario("60526145", 3000.00);
            Joao.Nome = "João";

            Console.WriteLine("Total de Funcionários: " + Funcionario.totalDeFuncionarios);

            Diretor paula = new Diretor("60526532", 5000.00);
            paula.Nome = "Paula";
            

            Console.WriteLine("Total de Funcionários: " + Funcionario.totalDeFuncionarios);

            Funcionario andre = new Diretor("60525959", 4000.00);
            andre.Nome = "André";

            Console.WriteLine("Total de Funcionários: " + Funcionario.totalDeFuncionarios);

            Console.WriteLine("Nome: " + Joao.Nome);
            Console.WriteLine("CPF: " + Joao.CPF);
            Console.WriteLine("Salario: " + Joao.Salario);
            Console.WriteLine("Bonificação: " + Joao.Bonificacao());

            Console.WriteLine("Nome: " + paula.Nome);
            Console.WriteLine("CPF: " + paula.CPF);
            Console.WriteLine("Salario: " + paula.Salario);
            Console.WriteLine("Bonificação: " + paula.Bonificacao());

            Console.WriteLine("Nome: " + andre.Nome);
            Console.WriteLine("CPF: " + andre.CPF);
            Console.WriteLine("Salario: " + andre.Salario);
            Console.WriteLine("Bonificação: " + andre.Bonificacao());

            gerenciador.Registrar(Joao);
            gerenciador.Registrar(paula);
            Console.WriteLine("Bonificação total: " + gerenciador.Bonificacao());

            andre.AumentarSalario();
            Console.WriteLine("Salário novo do André: " + andre.Salario);

            Joao.AumentarSalario();
            Console.WriteLine("Salário novo do João: " + Joao.Salario);

        }
    }
}
