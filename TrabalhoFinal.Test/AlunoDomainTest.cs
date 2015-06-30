using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoFinal.Domain.Entity;
using TrabalhoFinal.Domain.Exceptions;
using TrabalhoFinal.Infra;

namespace TrabalhoFinal.Test
{
    [TestClass]
    public class AlunoDomainTest
    {
        [TestMethod]
        public void CreateAAlunoTest()
        {
            Aluno aluno = new Aluno();
            aluno.Id = 1;
            aluno.Nome = "Elyacir Moro";
            aluno.Cpf = "000.000.000-00";
            aluno.Matricula = "123";
            aluno.QtdeCredito = 20;            
            aluno.Curso = new Curso
            {
                Nome = "Sistemas de Informação",
                Turno = "Noturno",
                QtdeMinimaCreditos = 12                
            };

            Assert.AreEqual("", string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void AlunoNomeInvalidTest()
        {
            Aluno aluno = new Aluno();
            Validator.Validate(aluno);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void AlunoCreatedInvalidTest()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Elyacir Moro";
            Validator.Validate(aluno);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void AlunoQtdeCreditoInvalidTest()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Elyacir Moro";
            aluno.QtdeCredito = 10;
            Validator.Validate(aluno);
        }
    }
}
