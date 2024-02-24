using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lista_De_Funcionarios { 
    public class Programa {
           static void Main(string[] args) {
            List<Funcionario> funcionarios = new List<Funcionario>();
            int incremetacoes;

            Console.WriteLine("Quantos funcionarios serao registrados? ");
            incremetacoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= incremetacoes; i++) {
                Console.WriteLine("\nFuncionario #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                if (funcionarios.Find(x => x.Id == id) == null)
                    funcionarios.Add(new Funcionario(id, nome, salario));
                else
                    Console.WriteLine("ERRO: O Id ja existe!");
            }

            Console.Write("Deseja reajustar algum salario(s/n)? ");
            string confirmacao = Console.ReadLine();

            if(confirmacao == "s") {
                Console.Write("Quantos salarios deseja reajustar? ");
                int quantidade = int.Parse(Console.ReadLine());
                
                for (int i = 1; i <= quantidade; i++) { 
                    Console.WriteLine("Digite o Id da pessoa deseja reajustar o salario: ");
                    int id = int.Parse(Console.ReadLine());
                    Funcionario aux = funcionarios.Find(x => x.Id == id);
                    int pos = funcionarios.FindIndex (x => x.Id == id);
                        Console.WriteLine("Qual a porcentagem de reajuste? ");
                    if (aux != null) {
                        double reajuste = double.Parse(Console.ReadLine());                       
                        aux.ReajusteSalarial(reajuste);
                        funcionarios[pos] = aux;
                    } else {
                            Console.WriteLine("O id nao Existe");
                    }
                }
            }

            Console.WriteLine("\nLista atualizada dos funcionários:");
            foreach (var funcionario in funcionarios) { Console.WriteLine(funcionario); }

            //fazer os ids serem unicos, inserir a opção de aumento, encapsular salario.

        }
    }
}