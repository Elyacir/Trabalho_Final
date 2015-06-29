using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Exceptions;
using TrabalhoFinal.Infra;

namespace TrabalhoFinal.Domain.Entity
{
    public class Curso : IObjectValidation
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public string Turno { get; set; }
        public int QtdeMinimaCreditos { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new DomainException("Nome inválido.");            
        }
    }
}
