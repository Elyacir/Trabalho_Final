using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal.Domain.Entity;
using TrabalhoFinal.Domain.Repository;
using TrabalhoFinal.Infra;

namespace TrabalhoFinal.Application
{
    public class AlunoService : IAlunoService
    {
        private IAlunoRepository _repository;

        public AlunoService() { }

        public AlunoService(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public Aluno Create(Aluno aluno)
        {
            Validator.Validate(aluno);

            _repository.Save(aluno);

            return aluno;
        }

        public Aluno Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Aluno Retrieve(int id)
        {
            return _repository.Get(id);
        }

        public Aluno Update(Aluno aluno)
        {
            Validator.Validate(aluno);

            var updatedAluno = _repository.Update(aluno);

            return updatedAluno;
        }

        public List<Aluno> RetrieveAll()
        {
            return _repository.GetAll();
        }
    }
}

