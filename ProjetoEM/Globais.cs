using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEM
{
    internal class Globais
    {
        public void Limpa()
        {
            Frm_CadastroAlunos cadastroAlunos = new Frm_CadastroAlunos();

            cadastroAlunos.tb_Nome.Text = "";
            cadastroAlunos.tb_CPF.Text = "";
            cadastroAlunos.cb_Sexo.Text = "";
        }
    }
}
