using EM.Domain.Classes;
using EM.Repository.Repositorios;
using EM.Repository.Verificação;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace EM.Domain.Testes
{
    [Binding]
    public class CadastrarOsDadosDeUmAlunoStepDefinitions
    {
        private Aluno aluno;
        private RepositorioAluno repositorio;
        [Given(@"que o secretario esteja cadastrando a matricula do aluno")]
        public void GivenQueOSecretarioEstejaCadastrandoAMatriculaDoAluno()
        {
            aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString());
        }

        [Given(@"no campo matricula informa '([^']*)'")]
        public void GivenNoCampoMatriculaInforma(int matricula)
        {
            aluno.Matricula = matricula;
        }

        [Given(@"no campo nome informa '([^']*)'")]
        public void GivenNoCampoNomeInforma(string nome)
        {
            aluno.Nome = nome;
        }

        [Given(@"no campo CPF informa '([^']*)'")]
        public void GivenNoCampoCPFInforma(string cpf)
        {
            aluno.CPF = cpf;
        }

        [Given(@"no campo Nascimento informa '([^']*)'")]
        public void GivenNoCampoNascimentoInforma(DateTime nascimento)
        {
            aluno.Nascimento = nascimento;
        }

        [Given(@"seleciona o sexo '([^']*)'")]
        public void GivenSelecionaOSexo(EnumeradorSexo sexo)
        {
            aluno.Sexo = sexo;
        }

        [When(@"clicar em '([^']*)'")]
        public void WhenClicarEm(string adicionar)
        {
            repositorio.Add(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString()));
        }

        [Then(@"o sistema apresentará uma mensagem informando que a matricula já foi cadastrada")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueAMatriculaJaFoiCadastrada()
        {
            Assert.Catch<MatriculaCadastrada>(() => repositorio.Add(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString())));
        }

        [Given(@"no campo nome deixa em branco")]
        public void GivenNoCampoNomeDeixaEmBranco()
        {
            aluno.Nome = "";
        }

        [Then(@"o sistema apresentará uma mensagem informando que o nome deve ser informado")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueONomeDeveSerInformado(string nomeAluno)
        {
            aluno.ValidarNome(nomeAluno);
        }

        [Then(@"o sistema apresentará uma mensagem informando que o CPF é invalido")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueOCPFEInvalido()
        {
            Assert.Catch<CPFCadastrado>(() => repositorio.Add(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString())));

        }

        [Then(@"o sistema apresentará uma mensagem informando que a data de nascimento deve ser menor que a data atual")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueADataDeNascimentoDeveSerMenorQueADataAtual(string dtNascimento)
        {
            aluno.ValidarNascimento(dtNascimento);
        }

        [Then(@"o sistema apresentará uma mensagem informando que o cadastro foi realizado com sucesso")]
        public void ThenOSistemaApresentaraUmaMensagemInformandoQueOCadastroFoiRealizadoComSucesso()
        {
            repositorio.Add(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString()));
        }
    }
}
