using AutoMapper;
using Dominio.Argumentos;
using Dominio.Entidades;

namespace CollegeAngular
{
    public class MapperConfig
    {
        public static void CreateMap()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Aluno, AlunoResponse>()
                    .ForMember(x => x.DataNascimento, opt => opt.MapFrom(src => src.DataNascimento.ToShortDateString()));
                cfg.CreateMap<Professor, ProfessorResponse>()
                    .ForMember(x => x.DataNascimento, opt => opt.MapFrom(src => src.DataNascimento.ToShortDateString()));
                cfg.CreateMap<Curso, CursoResponse>();
                cfg.CreateMap<Disciplina, DisciplinaResponse>();
                cfg.CreateMap<DisciplinaAluno, DisciplinaAlunoResponse>();
            });
        }
    }
}