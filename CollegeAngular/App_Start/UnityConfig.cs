using System.Data.Entity;
using System.Web.Mvc;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using Dominio.Servicos;
using Infra.Persistencia;
using Infra.Persistencia.Repositorio;
using Unity;
using Unity.Mvc5;

namespace CollegeAngular
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<DbContext, CollegeContexto>();

            container.RegisterType<IServicoAluno, ServicoAluno>();
            container.RegisterType<IServicoProfessor, ServicoProfessor>();
            container.RegisterType<IServicoCurso, ServicoCurso>();
            container.RegisterType<IServicoDisciplina, ServicoDisciplina>();
            container.RegisterType<IServicoDisciplinaAluno, ServicoDisciplinaAluno>();

            container.RegisterType<IRepositorioAluno, RepositorioAluno>();
            container.RegisterType<IRepositorioCurso, RepositorioCurso>();
            container.RegisterType<IRepositorioProfessor, RepositorioProfessor>();
            container.RegisterType<IRepositorioDisciplina, RepositorioDisciplina>();
            container.RegisterType<IRepositorioDisciplinaAluno, RepositorioDisciplinaAluno>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}