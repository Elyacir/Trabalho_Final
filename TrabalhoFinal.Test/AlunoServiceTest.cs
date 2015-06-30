using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoFinal.Domain.Entity;
using TrabalhoFinal.Domain.Repository;
using Moq;
using TrabalhoFinal.Application;
using TrabalhoFinal.Infra;

namespace TrabalhoFinal.Test
{
    /// <summary>
    /// Summary description for AlunoServiceTest
    /// </summary>
    [TestClass]
    public class AlunoServiceTest
    {
        private Aluno _aluno;

        [TestInitialize]
        public void Setup()
        {
            _aluno = ObjectMother.GetAluno();
        }


        [TestMethod]
        public void CreateAlunoValidateServiceTest()
        {
            //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
            var repository = new Mock<IAlunoRepository>();

            repository.Setup(r => r.Save(_aluno)).Returns(_aluno);

            //ARRANGE - Instancia do serviço a ser testado
            IAlunoService service = new AlunoService(repository.Object);

            //ARRANGE - Criado Mock para simular a validação do Aluno
            var validation = new Mock<Aluno>();

            validation.As<IObjectValidation>().Setup(aluno => aluno.Validate());

            //ACTION
            service.Create(validation.Object);

            //ASSERT
            validation.As<IObjectValidation>().Verify(x => x.Validate());
        }

        [TestMethod]
        public void CreateAlunoSaveServiceTest()
        {
            //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
            var validation = new Mock<IAlunoRepository>();

            validation.Setup(r => r.Save(_aluno)).Returns(_aluno);

            //ARRANGE - Instancia do serviço a ser testado
            IAlunoService service = new AlunoService(validation.Object);

            //ACTION
            service.Create(_aluno);

            //ASSERT
            validation.Verify(r => r.Save(_aluno));
        }

    }
}
