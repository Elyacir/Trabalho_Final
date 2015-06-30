using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Entity;
using TrabalhoFinal.Domain.Repository;

namespace TrabalhoFinal.Infra.Data
{
    public class CursoRepository : ICursoRepository
    {

        CursoContext context = new CursoContext();

        public Curso Save(Curso curso)
        {
            var newCurso = context.Cursos.Add(curso);
            context.SaveChanges();
            return newCurso;
        }


        public Curso Get(int id)
        {
            return context.Cursos.Find(id);
        }


        public Curso Update(Curso curso)
        {
            DbEntityEntry entry = context.Entry(curso);
            entry.State = EntityState.Modified;
            context.SaveChanges();
            return curso;
        }


        public Curso Delete(int id)
        {
            Curso curso = context.Cursos.Find(id);
            Curso deletedCurso = context.Cursos.Remove(curso);
            context.SaveChanges();
            return deletedCurso;
        }


        public List<Curso> GetAll()
        {
            return context.Cursos.ToList();
        }
    }

    public class CursoContext : DbContext
    {
        public CursoContext() : base("AlunoContext") { }

        public DbSet<Curso> Cursos { get; set; }

    }
}
