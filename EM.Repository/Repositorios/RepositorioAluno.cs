using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EM.Domain.Classes;
using FirebirdSql.Data.FirebirdClient;
using System.Globalization;
using System.Linq;
using System.Configuration;
using EM.Repository.Verificação;

namespace EM.Repository.Repositorios
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        public FbConnection ConectarBanco()
        {
            string conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();
            return new FbConnection(conexao);
        }
        public override void Add(Aluno objeto)
        {
            FbConnection conexao = ConectarBanco();
            conexao.Open();

            try
            {
                string dataNascimento = objeto.Nascimento.ToString("d", CultureInfo.CreateSpecificCulture("pt-BR"));
                string sql = $@"INSERT INTO TBALUNOS(ALNMATRICULA, ALNNOME, ALNCPF, ALNSEXO, ALNNASCIMENTO) VALUES (" + objeto.Matricula + ", '" + objeto.Nome + "', " + objeto.CPF +
                    ", " + (int)objeto.Sexo + ", '" + dataNascimento + "');";
                FbCommand cmd = new FbCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
            catch (FbException fbex)
            {

                throw fbex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {
            return GetAll().Where(predicate.Compile());
        }

        public override IEnumerable<Aluno> GetAll()
        {
            FbConnection conexao = ConectarBanco();
            var listadeAlunos = new List<Aluno>();
            try
            {
                conexao.Open();
                string comando = "SELECT * FROM TBALUNOS";
                FbCommand cmd = new FbCommand(comando, conexao);
                FbDataReader dtr = cmd.ExecuteReader();

                listadeAlunos = FabricaDeAlunos(dtr);
            }
            catch (FbException fbex)
            {
                throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return listadeAlunos;
        }

        public override void Remove(Aluno objeto)
        {
            FbConnection conexao = ConectarBanco();
            try
            {
                conexao.Open();
                string comando = String.Format(@"DELETE FROM TBALUNOS WHERE ALNMATRICULA = @Matricula");
                FbCommand cmd = new FbCommand(comando, conexao);
                cmd.Parameters.Add("Matricula", objeto.Matricula);
                cmd.ExecuteNonQuery();
            }
            catch (FbException fbex)
            {
                throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public override void Update(Aluno objeto)
        {
            FbConnection conexao = ConectarBanco();
            try
            {
                conexao.Open();
                string dataNascimento = objeto.Nascimento.ToString("d", CultureInfo.CreateSpecificCulture("pt-BR"));
                string comando = String.Format(@"UPDATE TBALUNOS SET ALNNOME = @Nome, ALNCPF = @Cpf, ALNNASCIMENTO = @Nascimento, ALNSEXO = @Sexo WHERE ALNMATRICULA = @Matricula");
                FbCommand cmd = new FbCommand(comando, conexao);
                cmd.Parameters.Add("Nome", objeto.Nome);
                cmd.Parameters.Add("Cpf", objeto.CPF);
                cmd.Parameters.Add("Nascimento", dataNascimento);
                cmd.Parameters.Add("Sexo", (int)objeto.Sexo);
                cmd.Parameters.Add("Matricula", objeto.Matricula);
                cmd.ExecuteNonQuery();
            }
            catch (FbException fbex)
            {
                if (fbex.Message.Contains("Problematic key value is (\"ALNMATRICULA\""))
                {
                    throw new MatriculaCadastrada("Matrícula já Cadastrada no Sistema!", null);
                }

                if (fbex.Message.Contains("Problematic key value is (\"ALNCPF\""))
                {
                    throw new CPFCadastrado("CPF já Cadastrado no Sistema!", null);
                }
                else
                    throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<Aluno> FabricaDeAlunos(FbDataReader dtr)
        {
            var listaDeAlunos = new List<Aluno>();
            while (dtr.Read())
            {
                var aluno = new Aluno(Convert.ToInt32(dtr["ALNMATRICULA"]), dtr["ALNNOME"].ToString(), dtr["ALNSEXO"].ToString(), dtr["ALNNASCIMENTO"].ToString(), dtr["ALNCPF"].ToString());

                listaDeAlunos.Add(aluno);
            }
            return listaDeAlunos;
        }
        public Aluno GetByMatricula(int matricula)
        {
            FbConnection conexao = ConectarBanco();
            Aluno aluno = null;
            try
            {
                conexao.Open();
                string comando = String.Format(@"SELECT * FROM TBALUNOS WHERE ALNMATRICULA = @Matricula");
                FbCommand cmd = new FbCommand(comando, conexao);
                cmd.Parameters.Add("Matricula", matricula);
                FbDataReader dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    aluno = new Aluno(Convert.ToInt32(dtr["ALNMATRICULA"]), dtr["ALNNOME"].ToString(), dtr["ALNSEXO"].ToString(), dtr["ALNNASCIMENTO"].ToString(), dtr["ALNCPF"].ToString());
                }
            }
            catch (FbException fbex)
            {
                throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return aluno;
        }
        public IEnumerable<Aluno> GetByContendoNoNome(string nome)
        {
            FbConnection conexao = ConectarBanco();
            var colecaoAlunos = new List<Aluno>();
            try
            {
                conexao.Open();
                string comando = String.Format(@"SELECT * FROM TBALUNOS WHERE ALNNOME LIKE '%{0}%'", nome);
                FbCommand cmd = new FbCommand(comando, conexao);
                FbDataReader dtr = cmd.ExecuteReader();

                colecaoAlunos = FabricaDeAlunos(dtr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return colecaoAlunos;
        }
    }
}
