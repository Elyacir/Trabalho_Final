using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Entity;

namespace TrabalhoFinal.Test
{
    public static class ObjectMother
    {
        public static Aluno GetAluno()
        {
            Aluno _aluno = new Aluno();
            //_aluno.Id = 1;
            _aluno.Nome = "Elyacir Moro";
            _aluno.Cpf = "000.000.000-00";
            _aluno.Matricula = "123";
            _aluno.QtdeCredito = 20;            
            _aluno.Curso = new Curso
            {
                //Id = 1,
                Nome = "Sistemas de Informação",
                Turno = "Noturno",
                QtdeMinimaCreditos = 12                
            };

            return _aluno;
        }
    }
}
