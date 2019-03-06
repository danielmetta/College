namespace Infra.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        AlunoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Matricula = c.String(nullable: false, maxLength: 250, unicode: false),
                        DataInclusao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlunoId);
            
            CreateTable(
                "dbo.DisciplinaAluno",
                c => new
                    {
                        DisciplinaAlunoId = c.Int(nullable: false, identity: true),
                        DisciplinaId = c.Int(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ForeignKey",
                                    new AnnotationValues(oldValue: null, newValue: "DisciplinaId")
                                },
                            }),
                        AlunoId = c.Int(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ForeignKey",
                                    new AnnotationValues(oldValue: null, newValue: "AlunoId")
                                },
                            }),
                        Nota = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInclusao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DisciplinaAlunoId)
                .ForeignKey("dbo.Aluno", t => t.AlunoId)
                .ForeignKey("dbo.Disciplina", t => t.DisciplinaId)
                .Index(t => t.DisciplinaId)
                .Index(t => t.AlunoId);
            
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        DisciplinaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        ProfessorId = c.Int(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ForeignKey",
                                    new AnnotationValues(oldValue: null, newValue: "Professor")
                                },
                            }),
                        CursoId = c.Int(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ForeignKey",
                                    new AnnotationValues(oldValue: null, newValue: "Curso")
                                },
                            }),
                        DataInclusao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DisciplinaId)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .ForeignKey("dbo.Professor", t => t.ProfessorId)
                .Index(t => t.ProfessorId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        DataInclusao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        ProfessorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInclusao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProfessorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Disciplina", "ProfessorId", "dbo.Professor");
            DropForeignKey("dbo.DisciplinaAluno", "DisciplinaId", "dbo.Disciplina");
            DropForeignKey("dbo.Disciplina", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.DisciplinaAluno", "AlunoId", "dbo.Aluno");
            DropIndex("dbo.Disciplina", new[] { "CursoId" });
            DropIndex("dbo.Disciplina", new[] { "ProfessorId" });
            DropIndex("dbo.DisciplinaAluno", new[] { "AlunoId" });
            DropIndex("dbo.DisciplinaAluno", new[] { "DisciplinaId" });
            DropTable("dbo.Professor");
            DropTable("dbo.Curso");
            DropTable("dbo.Disciplina",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "CursoId",
                        new Dictionary<string, object>
                        {
                            { "ForeignKey", "Curso" },
                        }
                    },
                    {
                        "ProfessorId",
                        new Dictionary<string, object>
                        {
                            { "ForeignKey", "Professor" },
                        }
                    },
                });
            DropTable("dbo.DisciplinaAluno",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AlunoId",
                        new Dictionary<string, object>
                        {
                            { "ForeignKey", "AlunoId" },
                        }
                    },
                    {
                        "DisciplinaId",
                        new Dictionary<string, object>
                        {
                            { "ForeignKey", "DisciplinaId" },
                        }
                    },
                });
            DropTable("dbo.Aluno");
        }
    }
}
