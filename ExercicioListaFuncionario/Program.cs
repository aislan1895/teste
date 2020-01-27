using System;
using System.Collections.Generic;
using System.Globalization;
namespace ExercicioListaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados? ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < qtdFuncionarios; i++)
            {
                Console.Write("Informe o id do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o salário do funcionário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario func = new Funcionario (id, nome, salario);
                funcionarios.Add(func);
            }

            Console.Write("Informe o id do funcionário que receberá aumento: ");
            Funcionario funcionario = funcionarios.Find(x => x.Id == int.Parse(Console.ReadLine()));

            if (funcionario != null)
            {
                Console.Write("Informe o percentual de aumento do funcionário: ");
                funcionario.AumentaSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Id não foi encontrado!");
            }
            

            Console.WriteLine("Lista de funcionários atualizada:");
            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine(f);
            }
        }
    }
}
