using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EM.Repository.Repositorios;
using EM.Domain.Classes;
using Usuario;

namespace ProjetoEM
{
    public partial class Frm_CadastroAlunos : Form 
    {
        private Acoes<Aluno> usuario = new Acoes<Aluno>();
        private BindingSource bindingListaAlunos = new BindingSource();
        public Frm_CadastroAlunos()
        {
            InitializeComponent();
            cb_Sexo.DataSource = Enum.GetValues(typeof(EnumeradorSexo));
            bindingListaAlunos.DataSource = usuario.ObterAlunos();
            dgv_Alunos.DataSource = bindingListaAlunos;

            bindingListaAlunos.ResetBindings(false);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            if(btn_Limpar.Text == "Limpar")
            {
                tb_Matricula.Text = "";
                tb_Nome.Text = "";
                mtb_dtNascimento.Text = "";
                tb_CPF.Text = "";
                tb_Pesquisa.Text = "";
                tb_Matricula.Focus();
            }
            if(btn_Limpar.Text == "Cancelar")
            {
                btn_Editar_Click(sender,e);
            }

            bindingListaAlunos.DataSource = usuario.ObterAlunos();
            dgv_Alunos.ClearSelection();
        }

        private void Frm_CadastroAlunos_Load(object sender, EventArgs e)
        {
            if (dgv_Alunos.SelectedRows.Count > 0)
            {
                dgv_Alunos.ClearSelection();
                dgv_Alunos.Columns[0].Width = 65;
                dgv_Alunos.Columns[1].Width = 235;
                dgv_Alunos.Columns[2].Width = 85;
                dgv_Alunos.Columns[3].Width = 110;
            }              
            tb_Matricula.Select();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            EnumeradorSexo sexo = cb_Sexo.Text == "Masculino" ? EnumeradorSexo.Masculino : EnumeradorSexo.Feminino;
            Aluno aluno;


            if (string.IsNullOrWhiteSpace(tb_Matricula.Text))
            {
                MessageBox.Show("O campo Matrícula é obrigatório!");
                tb_Matricula.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tb_Nome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório!");
                tb_Nome.Focus();
                return;
            }
            try
            {
                aluno = new Aluno(Convert.ToInt32(tb_Matricula.Text), tb_Nome.Text, sexo.ToString(), mtb_dtNascimento.Text, tb_CPF.Text);

            }
            catch (Exception erro)
            {
                //Apresentar mensagem de erro
                MessageBox.Show(erro.Message);
                return;
            }
            try
            {
                if (btn_Adicionar.Text == "Adicionar")
                {
                    usuario.InserirAluno(aluno);
                }

                if (btn_Adicionar.Text == "Modificar")
                {
                    usuario.AtualizarDados(aluno);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }
            if (btn_Adicionar.Text == "Modificar")
            {
                MessageBox.Show("Modificação Realizada!");
                btn_Limpar_Click(sender, e);
                return;
            }
            if (btn_Adicionar.Text == "Adicionar")
            {
                MessageBox.Show("Cadastro Realizado!");
                btn_Limpar_Click(sender, e);
            }
            bindingListaAlunos.DataSource = usuario.ObterAlunos();
            dgv_Alunos.DataSource = bindingListaAlunos;
            dgv_Alunos.ClearSelection();


        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int linha = dgv_Alunos.SelectedRows.Count;
            if (linha> 0)
            {
                if (MessageBox.Show("Confirmar exclusão do aluno?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        usuario.RemoverAluno((Aluno)bindingListaAlunos.Current);

                        MessageBox.Show("Aluno excluido com sucesso!");

                        btn_Limpar_Click(sender, e);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        return;
                    }
                    bindingListaAlunos.DataSource = usuario.ObterAlunos();
                    dgv_Alunos.ClearSelection();
                    tb_Matricula.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nenhum aluno selecionado para exclusão");
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (btn_Editar.Text == "Novo")
            {
                btn_Editar.Text = "Editar";
                btn_Limpar.Text = "Limpar";
                btn_Adicionar.Text = "Adicionar";
                tb_Matricula.Text = "";
                tb_Nome.Text = "";
                tb_CPF.Text = "";
                mtb_dtNascimento.Text = "";
                cb_Sexo.SelectedItem = "";
                tb_Pesquisa.Text = "";
                tb_Matricula.Enabled = true;
                tb_Matricula.Focus();
                return;
            }
            if (btn_Editar.Text == "Editar")
            {
                int linha = dgv_Alunos.SelectedRows.Count;
                Aluno aluno = (Aluno)bindingListaAlunos.Current;

                if (linha <= 0)
                {
                    MessageBox.Show("Selecione um aluno");
                }
                else
                {
                    tb_Matricula.Text = aluno.Matricula.ToString();
                    tb_Nome.Text = aluno.Nome;
                    cb_Sexo.SelectedItem = aluno.Sexo;
                    mtb_dtNascimento.Text = aluno.Nascimento.ToString();
                    tb_CPF.Text = aluno.CPF;
                    gb_Aluno.Text = "Editando Aluno";
                    tb_Matricula.Enabled = false;
                    btn_Editar.Text = "Novo";
                    btn_Limpar.Text = "Cancelar";
                    btn_Adicionar.Text = "Modificar";
                    tb_Nome.Focus();
                    return;
                }
            }
        }

        private void tb_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_Alunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_Editar.Text == "Novo")
            {
                Aluno aluno = (Aluno)bindingListaAlunos.Current;

                tb_Matricula.Text = aluno.Matricula.ToString();
                tb_Nome.Text = aluno.Nome;
                tb_CPF.Text = aluno.CPF;
                mtb_dtNascimento.Text = aluno.Nascimento.ToString();
                cb_Sexo.SelectedItem = aluno.Sexo;
            }
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            IEnumerable<Aluno> alunosPesquisa = null;
            if (string.IsNullOrWhiteSpace(tb_Pesquisa.Text))
            {
                MessageBox.Show("Digite uma Matricula ou um Nome para realizar a pesquisa");
                bindingListaAlunos.DataSource = usuario.ObterAlunos();
                dgv_Alunos.DataSource = bindingListaAlunos;
                return;
            }
            try
            {
                alunosPesquisa = usuario.PesquisarAlunos(tb_Pesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (!alunosPesquisa.Any())
            {
                MessageBox.Show("Nenhum dado encontrado!");
                tb_Pesquisa.Text = "";
            }
            else
            {
                bindingListaAlunos.DataSource = alunosPesquisa;
                dgv_Alunos.ClearSelection();
            }
        }

        private void tb_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
