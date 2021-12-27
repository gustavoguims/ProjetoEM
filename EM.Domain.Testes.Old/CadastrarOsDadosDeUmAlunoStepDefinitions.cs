using EM.Repository.Repositorios;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace EM.Domain.Testes
{
    [Binding]
    public class CadastrarOsDadosDeUmAlunoStepDefinitions
    {
        Aluno _aluno;
        RepositorioAluno _repositorioAluno = new RepositorioAluno();
        [Given(@"que o secretario esteja cadastrando a matricula do aluno")]
        public void GivenQueOSecretarioEstejaCadastrandoAMatriculaDoAluno()
        {
            _aluno = new Aluno(_aluno.Matricula, _aluno.Nome, _aluno.CPF, _aluno.Nascimento.ToString(), _aluno.Sexo.ToString());
        }

        [Given(@"no campo matricula informa '([^']*)'")]
        public void GivenNoCampoMatriculaInforma(int matricula)
        {
            _aluno.Matricula = matricula;
        }

        [Given(@"no campo nome informa '([^']*)'")]
        public void GivenNoCampoNomeInforma(string nome)
        {
            _aluno.Nome = nome;
        }

        [Given(@"no campo CPF informa '([^']*)'")]
        public void GivenNoCampoCPFInforma(string cpf)
        {
            _aluno.CPF = cpf;
        }

        [Given(@"no campo Nascimento informa '([^']*)'")]
        public void GivenNoCampoNascimentoInforma(DateTime nascimento)
        {
            _aluno.Nascimento = nascimento;
        }

        [Given(@"seleciona o sexo '([^']*)'")]
        public void GivenSelecionaOSexo(EnumeradorSexo sexo)
        {
            _aluno.Sexo = sexo;
        }

        [When(@"clicar em '([^']*)'")]
        public void WhenClicarEm()
        {
            _repositorioAluno.Add(_aluno.Matricula, _aluno.Nome, _aluno.CPF, _aluno.Nascimento.ToString(), _aluno.Sexo.ToString());
        }

        [Then(@"o sistema apresentará uma mensagem informando que a matricula já foi cadastrada")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueAMatriculaJaFoiCadastrada()
        {
            throw new PendingStepException();
        }

        [Given(@"no campo nome deixa em branco")]
        public void GivenNoCampoNomeDeixaEmBranco()
        {
            throw new PendingStepException();
        }

        [Then(@"o sistema apresentará uma mensagem informando que o nome deve ser informado")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueONomeDeveSerInformado()
        {
            throw new PendingStepException();
        }

        [Then(@"o sistema apresentará uma mensagem informando que o CPF é invalido")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueOCPFEInvalido()
        {
            throw new PendingStepException();
        }

        [Then(@"o sistema apresentará uma mensagem informando que a data de nascimento deve ser menor que a data atual")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueADataDeNascimentoDeveSerMenorQueADataAtual()
        {
            throw new PendingStepException();
        }

        [Then(@"o sistema apresentará uma mensagem informando que o cadastro foi realizado com sucesso")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueOCadastroFoiRealizadoComSucesso()
        {
            Assert.
        }
    }
}
