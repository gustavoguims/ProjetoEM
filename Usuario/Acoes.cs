using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EM.Repository.Repositorios;
using EM.Domain.Classes;

namespace Usuario
{
    public class Acoes<T> where T : Aluno
    {
        RepositorioAluno repositorioAluno = new RepositorioAluno();
        public void InserirAluno(T objeto)
        {
            repositorioAluno.Add(objeto);
        }
        public void RemoverAluno(T objeto)
        {
            repositorioAluno.Remove(objeto);
        }
        public void AtualizarDados(T objeto)
        {
            repositorioAluno.Update(objeto);
        }
        public IEnumerable<Aluno> ObterAlunos()
        {
            return repositorioAluno.GetAll().OrderBy(a => a.Nome);
        }
        public IEnumerable<Aluno> PesquisarAlunos(string pesquisa)
        {
            int matricula;
            Aluno alunoEncontrado;
            IEnumerable<Aluno> alunosEncontradosPeloNome;

            if (int.TryParse(pesquisa, out matricula))
            {
                alunoEncontrado = repositorioAluno.GetByMatricula(matricula);
                List<Aluno> alunoEncontradoPelaMatricula = new List<Aluno>();
                if (!(alunoEncontrado == null))
                    alunoEncontradoPelaMatricula.Add(alunoEncontrado);

                return alunoEncontradoPelaMatricula;
            }
            else
            {
                alunosEncontradosPeloNome = repositorioAluno.GetByContendoNoNome(pesquisa).OrderBy(a => a.Matricula);
                return alunosEncontradosPeloNome;
            }
        }
    }
}
