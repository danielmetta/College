using System.Data.Entity;
using System.Web.Mvc;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using Dominio.Servicos;
using Infra.Persistencia;
using Infra.Persistencia.Repositorio;
using Microsoft.Practices.Unity.Mvc;
using Unity;

namespace IoC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here 
            // it is NOT necessary to register your controllers 

            // e.g. container.RegisterType<ITestService, TestService>(); 

            container.RegisterType<DbContext, CollegeContexto>();

            //UnitOfWork
            //container.RegisterType<IUnitOfWork, UnitOfWork>();
            //container.RegisterType<INotifiable, Notifiable>();
            container.RegisterType<IRepositorioAluno, RepositorioAluno>();
            container.RegisterType<IRepositorioCurso, RepositorioCurso>();
            container.RegisterType<IRepositorioProfessor, RepositorioProfessor>();
            container.RegisterType<IRepositorioDisciplina, RepositorioDisciplina>();

            container.RegisterType<IRepositorioDisciplinaAluno, RepositorioDisciplinaAluno>();

            container.RegisterType<IServicoAluno, ServicoAluno>();
            container.RegisterType<IServicoCurso, ServicoCurso>();
            container.RegisterType<IServicoProfessor, ServicoProfessor>();
            container.RegisterType<IServicoDisciplina, ServicoDisciplina>();
            container.RegisterType<IServicoDisciplinaAluno, ServicoDisciplinaAluno>();

            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
