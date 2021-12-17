using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;

namespace ProjetoEM
{
    public class Banco
    {
        private static readonly Banco Instancia = new Banco();

        private Banco() { }

        public static Banco PegarInstancia()
        {
            return Instancia;
        }

        public FbConnection PegarConexao()
        {
            string con = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();
            return new FbConnection(con);
        }

        public static bool TestarConexao()
        {
            bool resposta = true;
            using (FbConnection Conexao = Banco.PegarInstancia().PegarConexao())
            {
                try
                {
                    Conexao.Open();
                }
                catch
                {
                    resposta = false;
                }
                finally
                {
                    Conexao.Close();
                }
            }
            return resposta;
        }

        public static DataTable BuscarAlunos()
        {
            using(FbConnection conexaoFireBird = Banco.PegarInstancia().PegarConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string SQL = "SELECT * FROM TBALUNOS";
                    FbCommand cmd = new FbCommand(SQL,conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);   
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();  
                }
            }
        }

        public static void InserirAluno(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = Banco.PegarInstancia().PegarConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string sql = $@"INSERT INTO TBALUNOS (ALNMATRICULA, ALNNOME, ALNCPF, ALNSEXO) VALUES ({aluno.Matricula}, '{aluno.Nome}', 
                    {aluno.CPF}, {(int)aluno.Sexo});";
                    FbCommand cmd = new FbCommand(sql,conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void ExcluirAluno(int id)
        {
            using (FbConnection conexaoFireBird = Banco.PegarInstancia().PegarConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string SQL = "DELETE FROM TBALUNOS WHERE ALNMATRICULA = " + id;

                    FbCommand cmd = new FbCommand(SQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {

                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static Aluno PesquisarAluno(int id)
        {
            using (FbConnection conexaoFireBird = Banco.PegarInstancia().PegarConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string SQL = "SELECT * FROM TBALUNOS WHERE ALNMATRICULA = " + id;
                    FbCommand cmd = new FbCommand(SQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Aluno aluno = new Aluno();
                    while (dr.Read())
                    {
                        
                    }
                    return aluno;
                }
                catch (FbException fbex)
                {

                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void AlterarDadosAluno(Aluno aluno)
        {
            using (FbConnection conexaoFireBird = Banco.PegarInstancia().PegarConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string SQL = @"UPDATE TBALUNOS set ALNNOME= '" + aluno.Nome + "', ALNCPF= '" + aluno.CPF + "', ALNDTNASCIMENTO = " + aluno.Nascimento + 
                        ", ALNSEXO= " + aluno.Sexo + " WHERE ALNMATRICULA= " + aluno.Matricula;
                    FbCommand cmd = new FbCommand(SQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {

                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
    }   
}
