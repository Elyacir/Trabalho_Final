using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Entity;

namespace TrabalhoFinal.Domain.Repository
{
    public interface ICursoRepository
    {
        Curso Save(Curso curso);
        Curso Get(int id);
        Curso Update(Curso curso);
        Curso Delete(int id);
        List<Curso> GetAll();
    }

}
