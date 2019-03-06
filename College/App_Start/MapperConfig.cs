using AutoMapper;
using Dominio.Argumentos;
using Dominio.Entidades;

namespace College
{
    public class MapperConfig
    {
        public static void CreateMap()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Aluno, AlunoResponse>();
                cfg.CreateMap<Professor, ProfessorResponse>();
                cfg.CreateMap<Curso, CursoResponse>();
                cfg.CreateMap<Disciplina, DisciplinaResponse>();
                cfg.CreateMap<DisciplinaAluno, DisciplinaAlunoResponse>();
            });
        }
    }
}