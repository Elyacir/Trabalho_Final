using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Entity;

namespace TrabalhoFinal.Domain.Repository
{
    public interface IAlunoRepository
    {
        Aluno Save(Aluno aluno);
        Aluno Get(int id);
        Aluno Update(Aluno aluno);
        Aluno Delete(int id);        
        List<Aluno> GetAll();
    }
}
