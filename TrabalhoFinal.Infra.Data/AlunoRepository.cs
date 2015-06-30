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
    public class AlunoRepository : IAlunoRepository
    {

        AlunoContext context = new AlunoContext();

        public Aluno Save(Aluno aluno)
        {
            var newAluno = context.Alunos.Add(aluno);
            context.SaveChanges();
            return newAluno;
        }


        public Aluno Get(int id)
        {
            return context.Alunos.Find(id);
        }


        public Aluno Update(Aluno aluno)
        {
            DbEntityEntry entry = context.Entry(aluno);
            entry.State = EntityState.Modified;
            context.SaveChanges();
            return aluno;
        }


        public Aluno Delete(int id)
        {
            Aluno aluno = context.Alunos.Find(id);
            Aluno deletedAluno = context.Alunos.Remove(aluno);
            context.SaveChanges();
            return deletedAluno;
        }

        public List<Aluno> GetAll()
        {
            return context.Alunos.ToList();
        }
    }
    

    public class AlunoContext : DbContext
    {
        public AlunoContext() : base("AlunoContext") { }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
