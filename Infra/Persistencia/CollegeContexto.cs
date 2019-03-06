using Dominio.Entidades;
using Infra.Persistencia.Map;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Infra.Persistencia
{
    public class CollegeContexto : DbContext
    { 

        public CollegeContexto()
            : base("Contexto")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer(new MyCustomDbInit<CollegeContexto>());
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<DisciplinaAluno> DisciplinaAluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            //Remove a pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //Caso eu esqueça de informar o tamanho do campo ele irá colocar varchar de 250
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(250));

            //Mapeia as entidades
            modelBuilder.Configurations.Add(new MapAluno());
            modelBuilder.Configurations.Add(new MapCurso());
            modelBuilder.Configurations.Add(new MapDisciplina());
            modelBuilder.Configurations.Add(new MapDisciplinaAluno());
            modelBuilder.Configurations.Add(new MapProfessor());


            base.OnModelCreating(modelBuilder);
        }
    }
}