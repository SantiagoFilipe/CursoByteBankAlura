﻿using CursoByteBank.Utilitarios;
using System;


namespace CursoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Console.WriteLine("Bem Vindo");
            Funcionario Joao = new Funcionario();
            Joao.Nome = "João";
            Joao.CPF = "60526145";
            Joao.Salario = 3000.00;

            Diretor paula = new Diretor();
            paula.Nome = "Paula";
            paula.CPF = "605266532";
            paula.Salario = 5000.00;

            Funcionario andre = new Diretor();
            andre.Nome = "André";
             


            Console.WriteLine("Nome: " + Joao.Nome);
            Console.WriteLine("CPF: " + Joao.CPF);
            Console.WriteLine("Salario: " + Joao.Salario);
            Console.WriteLine("Bonificação: " + Joao.Bonificacao());

            Console.WriteLine("Nome: " + paula.Nome);
            Console.WriteLine("CPF: " + paula.CPF);
            Console.WriteLine("Salario: " + paula.Salario);
            Console.WriteLine("Bonificação: " + paula.Bonificacao());

            gerenciador.Registrar(Joao);
            gerenciador.Registrar(paula);
            Console.WriteLine("Bonificação total: " + gerenciador.Bonificacao());

        }
    }
}
