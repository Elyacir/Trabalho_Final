using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Exceptions;
using TrabalhoFinal.Infra;

namespace TrabalhoFinal.Domain.Entity
{
    public class Aluno : IObjectValidation
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public int QtdeCredito { get; set; }        
        public Curso Curso { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new DomainException("Nome inválido.");            

            if (QtdeCredito < 12)
                throw new DomainException("Qtde de Créditos não pode ser menor que 12.");
        }
    }
}
