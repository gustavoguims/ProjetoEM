using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EM.Domain.Validacao;

namespace EM.Domain.Classes
{
    public class Aluno : IEntidade
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public EnumeradorSexo Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public Aluno(int matricula, string nome, string sexo, string dataNascimento, string cpf)
        {
            Matricula = ValidaMatricula(matricula);
            Nome = ValidarNome(nome);
            Sexo = (EnumeradorSexo)Enum.Parse(typeof(EnumeradorSexo), sexo);
            Nascimento = ValidarNascimento(dataNascimento);
            CPF = ValidarCpf(cpf);
        }
        public DateTime ValidarNascimento(string dataNascimento)
        {
            DateTime database = new DateTime(1969, 12, 31);
            //DateTime.Today.Year - Nascimento.Year > 50;

            try
            {
                Nascimento = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            catch
            {
                throw new DataNascimentoInvalida("O campo Nascimento não é valido!", null);
            }

            if (Nascimento.Date >= DateTime.Today)
            {
                throw new DataNascimentoInvalida("Data informada deve ser menor que a data atual!", null);
            }

            if (DateTime.Compare(Nascimento, database) <= 0)
            {
                throw new DataNascimentoInvalida("NAO E PERMITIDO ALUNOS ACIMA DOS 50 ANOS", null);
            }

            return Nascimento;
        }
        public string ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return null;
            }

            string novePrimeirosDigitos;
            string doisUltimosDigitos;
            int resultado = 0;
            int resto = 0;
            int verifica = 0;
            int[] verificadorPrimeiroDigito = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] verificadorSegundoDigito = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Equals("00000000000") || cpf.Equals("11111111111") || cpf.Equals("22222222222") || cpf.Equals("33333333333")
                || cpf.Equals("44444444444") || cpf.Equals("55555555555") || cpf.Equals("66666666666") ||
                cpf.Equals("77777777777") || cpf.Equals("88888888888") || cpf.Equals("99999999999"))
            {
                throw new CpfInvalido("Informe um CPF válido!", null);
            }

            var test = cpf.Length;
            if (cpf.Length != 11)
            {
                throw new CpfInvalido("O CPF informado deve ter 11 dígitos", null);
            }

            novePrimeirosDigitos = cpf.Substring(0, 9);
            doisUltimosDigitos = cpf.Substring(9);
            for (int indice = 0; indice < 9; indice++)
            {
                resultado += Convert.ToInt32(cpf[indice].ToString()) * verificadorPrimeiroDigito[indice];
            }
            resto = resultado % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            if (resto == Convert.ToInt32(doisUltimosDigitos[doisUltimosDigitos.Length - 2].ToString()))
            {
                verifica++;
            }

            resultado = 0;

            for (int indice = 0; indice < 10; indice++)
            {
                resultado += Convert.ToInt32(cpf[indice].ToString()) * verificadorSegundoDigito[indice];
            }
            resto = resultado % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            if (resto == Convert.ToInt32(doisUltimosDigitos[doisUltimosDigitos.Length - 1].ToString()))
            {
                verifica++;
            }

            if (!(verifica == 2))
            {
                throw new CpfInvalido("Informe um CPF Válido!", null);
            }

            return Convert.ToInt64(cpf).ToString();
        }
        public string ValidarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length > 100)
                throw new NomeInvalido("O campo nome deve ter no máximo 100 caracteres", null);
            return nome;
        }
        public int ValidaMatricula(int matricula)
        {
            if (!(matricula >= 1 && matricula <= 999999999))
                throw new MatriculaInvalida("Matrícula precisar ter no máximo 9 dígitos!", null);
            return matricula;
        }
    }
}
