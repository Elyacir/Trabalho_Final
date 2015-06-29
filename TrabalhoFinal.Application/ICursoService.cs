using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Entity;

namespace TrabalhoFinal.Application
{
    public interface ICursoService
    {
        Curso Create(Curso curso);
        Curso Delete(int id);        
        Curso Retrieve(int id);
        Curso Update(Curso curso);        
        List<Curso> RetrieveAll();
    }
}
