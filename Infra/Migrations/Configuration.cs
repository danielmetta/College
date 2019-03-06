using System.Collections.Generic;

namespace Infra.Migrations
{
    using Dominio.Entidades;
    using Infra.Persistencia;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CollegeContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CollegeContexto context)
        {
            var curso = new Curso("Analise de Sistemas", true);
            curso.Disciplinas = new List<Disciplina>
            {
                new Disciplina
                {
                    Nome = "Banco de dados",
                    Ativo = true,
                    Professor = new Professor("Professor 1", DateTime.Now.AddYears(-20), 6000, true),
                    DisciplinaAlunos = new List<DisciplinaAluno>
                    {
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 1", DateTime.Now, "12304", true),
                            Nota = 10
                        },
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 2", DateTime.Now, "12341", true),
                            Nota = 5
                        },
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 3", DateTime.Now, "12342", true),
                            Nota = 8.5M
                        },
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 4", DateTime.Now, "12343", true),
                            Nota = 8.5M
                        },
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 5", DateTime.Now, "12344", true),
                            Nota = 6
                        }
                    }
                },
                new Disciplina
                {
                    Nome = "Logica da programacao",
                    Ativo = true,
                    Professor = new Professor("Professor 2", DateTime.Now.AddYears(-20), 7000, true),
                    DisciplinaAlunos = new List<DisciplinaAluno>
                    {
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 6", DateTime.Now, "123422", true),
                            Nota = 9.5M
                        },
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 7", DateTime.Now, "123431", true),
                            Nota = 3.5M
                        },
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno 8", DateTime.Now, "123443", true),
                            Nota = 7
                        }
                    }
                }
            };
            context.Curso.AddOrUpdate(curso);

            curso = new Curso("Direito", true);
            curso.Disciplinas = new List<Disciplina>
            {
                new Disciplina
                {
                    Nome = "Codigo Penal",
                    Ativo = true,
                    Professor = new Professor("Professor Direito", DateTime.Now.AddYears(-40), 4000, true),
                    DisciplinaAlunos = new List<DisciplinaAluno>
                    {
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno Direito 1", DateTime.Now, "12304", true),
                            Nota = 10
                        },
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno Direito 2", DateTime.Now, "12341", true),
                            Nota = 5
                        }
                    }
                },
                new Disciplina
                {
                    Nome = "Civil",
                    Ativo = true,
                    Professor = new Professor("Professor Direito 2", DateTime.Now.AddYears(-20), 7000, true),
                    DisciplinaAlunos = new List<DisciplinaAluno>
                    {
                        new DisciplinaAluno
                        {
                            Ativo = true,
                            Aluno = new Aluno("Aluno Direito 6", DateTime.Now, "123422", true),
                            Nota = 9.5M
                        }
                    }
                }
            };
            context.Curso.AddOrUpdate(curso);
            context.SaveChanges();
        }
    }
}
