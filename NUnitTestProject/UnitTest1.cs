using Business.Business;
using Domain.Models;
using Moq;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        private Alunos aluno;
        private IAlunos _alunos;
        Mock<IAlunos> mockRepo;
         [SetUp]
        public void Setup()
        {
            aluno = new Alunos()
            {
                Nome = "Teste",
                DataNascimento = "1993-05-25",
                Email = "teste@tete.com",
                Senha = "1234"
            }; 
            mockRepo = new Mock<IAlunos>();
        }

        [Test]
        public void Create()
        {
            var retorno= mockRepo.Setup(p=>p.Create(aluno));
            //var retorno = _alunos.Create(aluno);

            Assert.AreNotEqual(aluno, retorno);
        }
    }
}