using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoFinal.Domain.Repository;
using TrabalhoFinal.Domain.Entity;
using TrabalhoFinal.Infra.Data;
using System.Data.Entity;

namespace TrabalhoFinal.Test
{
    /// <summary>
    /// Summary description for AlunoRepositoryTest
    /// </summary>
    [TestClass]
    public class AlunoRepositoryTest
    {
        private IAlunoRepository _repository;
        private Aluno _aluno;

        [TestInitialize]
        public void Setup()
        {            
            Database.SetInitializer(new DropCreateDatabaseAlways<AlunoContext>());
            
            _repository = new AlunoRepository();
            _aluno = ObjectMother.GetAluno();
            
            AlunoContext context = new AlunoContext();
            _aluno = context.Alunos.Add(_aluno);
            context.SaveChanges();
        }

        [TestMethod]
        public void CreateAlunoPersistenceTest()
        {
            //ACTION
            Aluno alunoPersisted = _repository.Save(_aluno);

            //ASSERT
            Assert.IsTrue(alunoPersisted.Id > 0);
        }

        [TestMethod]
        public void RetrieveAlunoPersistedTest()
        {
            //ACTION
            Aluno persistedAluno = _repository.Get(1);

            //ASSERT
            Assert.IsTrue(persistedAluno.Id == 1);
            Assert.AreEqual("Elyacir Moro", persistedAluno.Nome);
        }

        [TestMethod]
        public void UpdateAlunoPersistedTest()
        {
            //ARRANGE
            Aluno persistedAluno = _repository.Get(1);
            persistedAluno.Nome = "Elyacir Moro";
            persistedAluno.Cpf = "111.111.111-11";

            //ACTION
            Aluno updatedAluno = _repository.Update(persistedAluno);

            //ASSERT
            Aluno aluno = _repository.Get(1);
            Assert.AreEqual(aluno.Nome, updatedAluno.Nome);
            Assert.AreEqual(aluno.Cpf, updatedAluno.Cpf);
        }

        [TestMethod]
        public void DeleteAlunoPersistedTest()
        {
            //ACTION
            Aluno deletedAluno = _repository.Delete(1);

            //ASSERT
            Aluno aluno = _repository.Get(1);
            Assert.IsNull(aluno);
        }
    }
}
