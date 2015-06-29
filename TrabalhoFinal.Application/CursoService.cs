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
    public class CursoService : ICursoService
    {
        private ICursoRepository _repository;

        public CursoService() { }

        public CursoService(ICursoRepository repository)
        {
            _repository = repository;
        }

        public Curso Create(Curso curso)
        {
            Validator.Validate(curso);

            _repository.Save(curso);

            return curso;
        }

        public Curso Delete(int id)
        {
            return _repository.Delete(id);
        }

        public List<Curso> RetrieveAll()
        {
            return _repository.GetAll();
        }

        public Curso Retrieve(int id)
        {
            return _repository.Get(id);
        }


        public Curso Update(Curso curso)
        {
            Validator.Validate(curso);

            var updatedCurso = _repository.Update(curso);

            return updatedCurso;
        }

        
    }
}
