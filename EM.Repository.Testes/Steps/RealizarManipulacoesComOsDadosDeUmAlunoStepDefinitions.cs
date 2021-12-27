using EM.Domain.Classes;
using EM.Repository.Repositorios;
using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace EM.Repository.Testes
{
    [Binding]
    public class RealizarManipulacoesComOsDadosDeUmAlunoStepDefinitions
    {
        private Aluno aluno;
        private RepositorioAluno repositorio;
        private string pesquisaNome;
        private int pesquisaMatricula;
        [Given(@"que o secretario tenha os dados do aluno")]
        public void GivenQueOSecretarioTenhaOsDadosDoAluno()
        {
            repositorio = new RepositorioAluno();
        }

        [Given(@"digite o nome '([^']*)'")]
        public void GivenDigiteONome(string nomeAluno)
        {
            aluno.Nome = nomeAluno;
        }

        [Given(@"digite o CPF '([^']*)'")]
        public void GivenDigiteOCPF(string cpfAluno)
        {
            aluno.CPF = cpfAluno;
        }

        [Given(@"digite a matricula '([^']*)'")]
        public void GivenDigiteAMatricula(int matriculaAluno)
        {
            aluno.Matricula = matriculaAluno;

        }

        [Given(@"digite o nascimento '([^']*)'")]
        public void GivenDigiteONascimento(DateTime nascimento)
        {
            aluno.Nascimento = nascimento;
        }

        [Given(@"selecione o sexo '([^']*)'")]
        public void GivenSelecioneOSexo(EnumeradorSexo sexoAluno)
        {
            aluno.Sexo = sexoAluno;
        }

        [When(@"o secretario clicar em adicionar")]
        public void WhenOSecretarioClicarEmAdicionar()
        {
            repositorio.Add(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString()));
        }

        [Then(@"o aluno sera adicionado")]
        public void ThenOAlunoSeraAdicionado()
        {
            Assert.DoesNotThrow(() => repositorio.Add(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString())));
        }

        [When(@"o secretario confirmar a exlusao")]
        public void WhenOSecretarioConfirmarAExlusao()
        {
          
        }

        [Then(@"o aluno sera removido de repositorio")]
        public void ThenOAlunoSeraRemovidoDeRepositorio()
        {
            Assert.DoesNotThrow(() => repositorio.Remove(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString())));
        }

        [Given(@"que o secretario tenha os dados do aluno para atualizar")]
        public void GivenQueOSecretarioTenhaOsDadosDoAlunoParaAtualizar()
        {
            repositorio = new RepositorioAluno();
        }

        [When(@"o secretario localizar os dados do aluno para atualizar")]
        public void WhenOSecretarioLocalizarOsDadosDoAlunoParaAtualizar()
        {
            
        }

        [Then(@"os dados serao atualizados")]
        public void ThenOsDadosSeraoAtualizados()
        {
            Assert.DoesNotThrow(() => repositorio.Update(aluno = new Aluno(aluno.Matricula, aluno.Nome, aluno.CPF, aluno.Nascimento.ToString(), aluno.Sexo.ToString())));
        }

        [Given(@"que varios alunos estao no repositorio")]
        public void GivenQueVariosAlunosEstaoNoRepositorio()
        {
            repositorio = new RepositorioAluno();
        }

        [Given(@"o secretario deseja pesquisar alunos que tenha a letra '([^']*)'")]
        public void GivenOSecretarioDesejaPesquisarAlunosQueTenhaALetra(string pesquisa)
        {
            pesquisaNome = pesquisa;
        }

        [When(@"o secretario realizar a busca")]
        public void WhenOSecretarioRealizarABusca()
        {
            repositorio.GetByContendoNoNome(pesquisaNome);
        }

        [Then(@"sera listado os alunos")]
        public void ThenSeraListadoOsAlunos()
        {
            Assert.IsTrue(repositorio.GetByContendoNoNome(pesquisaNome).Any());
        }

        [Given(@"o secretario deseja pesquisar o aluno com a matricula '([^']*)'")]
        public void GivenOSecretarioDesejaPesquisarOAlunoComAMatricula(int pesquisa)
        {
            pesquisaMatricula = pesquisa;
        }
    }
}
