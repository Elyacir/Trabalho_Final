using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Entity;

namespace TrabalhoFinal.Application
{
    public interface IAlunoService
    {        
        Aluno Create(Aluno aluno);
        Aluno Delete(int id);
        Aluno Retrieve(int id);
        Aluno Update(Aluno aluno);        
        List<Aluno> RetrieveAll();
    }
}
