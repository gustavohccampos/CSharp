using System;

namespace Revisao_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcao = ObterOpcao();
            var indiceAluno=0;

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        //to do: Adicionar aluno
                         Aluno aluno = new Aluno();
                          Console.WriteLine("Informe o Nome:");
                          aluno.Nome = Console.ReadLine();
                          Console.WriteLine("Informe a Nota:");
                          var nota = decimal.Parse(Console.ReadLine());
                          aluno.Nota = nota;
                        alunos[indiceAluno] = aluno;
                        indiceAluno++; 

                        break;
                    case "2":
                        //to do: Listar alunos
                        foreach(var x in alunos)
                        {
                            if(!string.IsNullOrEmpty(x.Nome))
                            {
                            Console.WriteLine($"Anulo:{x.Nome} - Nota:{x.Nota}");
                            }
                        }

                        break;
                    case "3":
                        //to do: Calcular Media geral
                        decimal notaTotal = 0;
                        var alunoTotal = 0;
                        for(int i=0; i<alunos.Length;i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                alunoTotal++;
                           }
                        }
                    var mediaGeral = notaTotal / alunoTotal;
                    
                    ConceitoEnum conceitoGeral;
                    if(mediaGeral<2)
                    {
                        conceitoGeral =ConceitoEnum.E;
                    }else if(mediaGeral<4)
                    {
                        conceitoGeral =ConceitoEnum.D;
                    }else if(mediaGeral<6)
                    {
                        conceitoGeral =ConceitoEnum.C;
                    }else if(mediaGeral<8)
                    {
                        conceitoGeral =ConceitoEnum.B;
                    }else 
                    {
                        conceitoGeral =ConceitoEnum.A;
                    }

                    Console.WriteLine($"Media Geral - {mediaGeral}");
                    Console.WriteLine($"Conceito Geral - {conceitoGeral}");

                    break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção não existe");
                }
                opcao = ObterOpcao();

            }

        }

        private static string ObterOpcao()
        {
            Console.WriteLine("|--Lista de Alunos--|");
            Console.WriteLine("Informe a Opção desejada:");
            Console.WriteLine("1 - Inserir Novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular Media Geral");
            Console.WriteLine("x - Sair");

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}
