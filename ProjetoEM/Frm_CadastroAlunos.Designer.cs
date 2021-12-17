namespace ProjetoEM
{
    partial class Frm_CadastroAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Matricula = new System.Windows.Forms.TextBox();
            this.tb_Pesquisa = new System.Windows.Forms.TextBox();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.dgv_Alunos = new System.Windows.Forms.DataGridView();
            this.gb_Aluno = new System.Windows.Forms.GroupBox();
            this.mtb_dtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).BeginInit();
            this.gb_Aluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(497, 86);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(95, 23);
            this.btn_Adicionar.TabIndex = 5;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(396, 86);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(95, 23);
            this.btn_Limpar.TabIndex = 11;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // tb_CPF
            // 
            this.tb_CPF.Location = new System.Drawing.Point(256, 86);
            this.tb_CPF.MaxLength = 11;
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(121, 20);
            this.tb_CPF.TabIndex = 4;
            this.tb_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CPF_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nascimento";
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_Sexo.Location = new System.Drawing.Point(3, 87);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_Sexo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(140, 34);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(452, 20);
            this.tb_Nome.TabIndex = 1;
            this.tb_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula";
            // 
            // tb_Matricula
            // 
            this.tb_Matricula.Location = new System.Drawing.Point(3, 34);
            this.tb_Matricula.MaxLength = 9;
            this.tb_Matricula.Name = "tb_Matricula";
            this.tb_Matricula.Size = new System.Drawing.Size(121, 20);
            this.tb_Matricula.TabIndex = 0;
            this.tb_Matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Matricula_KeyPress);
            // 
            // tb_Pesquisa
            // 
            this.tb_Pesquisa.Location = new System.Drawing.Point(15, 140);
            this.tb_Pesquisa.Name = "tb_Pesquisa";
            this.tb_Pesquisa.Size = new System.Drawing.Size(491, 20);
            this.tb_Pesquisa.TabIndex = 1;
            this.tb_Pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pesquisa_KeyPress);
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.Location = new System.Drawing.Point(512, 137);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(95, 23);
            this.btn_Pesquisa.TabIndex = 13;
            this.btn_Pesquisa.Text = "Pesquisar";
            this.btn_Pesquisa.UseVisualStyleBackColor = true;
            this.btn_Pesquisa.Click += new System.EventHandler(this.btn_Pesquisa_Click);
            // 
            // dgv_Alunos
            // 
            this.dgv_Alunos.AllowUserToAddRows = false;
            this.dgv_Alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alunos.EnableHeadersVisualStyles = false;
            this.dgv_Alunos.Location = new System.Drawing.Point(15, 167);
            this.dgv_Alunos.MultiSelect = false;
            this.dgv_Alunos.Name = "dgv_Alunos";
            this.dgv_Alunos.ReadOnly = true;
            this.dgv_Alunos.RowHeadersVisible = false;
            this.dgv_Alunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Alunos.Size = new System.Drawing.Size(592, 180);
            this.dgv_Alunos.TabIndex = 14;
            this.dgv_Alunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alunos_CellClick);
            // 
            // gb_Aluno
            // 
            this.gb_Aluno.Controls.Add(this.mtb_dtNascimento);
            this.gb_Aluno.Controls.Add(this.btn_Adicionar);
            this.gb_Aluno.Controls.Add(this.tb_Nome);
            this.gb_Aluno.Controls.Add(this.btn_Limpar);
            this.gb_Aluno.Controls.Add(this.tb_Matricula);
            this.gb_Aluno.Controls.Add(this.tb_CPF);
            this.gb_Aluno.Controls.Add(this.label1);
            this.gb_Aluno.Controls.Add(this.label5);
            this.gb_Aluno.Controls.Add(this.label2);
            this.gb_Aluno.Controls.Add(this.label3);
            this.gb_Aluno.Controls.Add(this.label4);
            this.gb_Aluno.Controls.Add(this.cb_Sexo);
            this.gb_Aluno.Location = new System.Drawing.Point(15, 15);
            this.gb_Aluno.Name = "gb_Aluno";
            this.gb_Aluno.Size = new System.Drawing.Size(599, 119);
            this.gb_Aluno.TabIndex = 15;
            this.gb_Aluno.TabStop = false;
            this.gb_Aluno.Text = "Novo Aluno";
            // 
            // mtb_dtNascimento
            // 
            this.mtb_dtNascimento.Location = new System.Drawing.Point(140, 88);
            this.mtb_dtNascimento.Mask = "00/00/0000";
            this.mtb_dtNascimento.Name = "mtb_dtNascimento";
            this.mtb_dtNascimento.Size = new System.Drawing.Size(100, 20);
            this.mtb_dtNascimento.TabIndex = 3;
            this.mtb_dtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(411, 353);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 23);
            this.btn_Editar.TabIndex = 17;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(512, 353);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_Excluir.TabIndex = 18;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // Frm_CadastroAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 382);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.gb_Aluno);
            this.Controls.Add(this.dgv_Alunos);
            this.Controls.Add(this.btn_Pesquisa);
            this.Controls.Add(this.tb_Pesquisa);
            this.MaximizeBox = false;
            this.Name = "Frm_CadastroAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Frm_CadastroAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).EndInit();
            this.gb_Aluno.ResumeLayout(false);
            this.gb_Aluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Pesquisa;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.DataGridView dgv_Alunos;
        public System.Windows.Forms.ComboBox cb_Sexo;
        public System.Windows.Forms.TextBox tb_Nome;
        public System.Windows.Forms.TextBox tb_Matricula;
        public System.Windows.Forms.TextBox tb_CPF;
        private System.Windows.Forms.GroupBox gb_Aluno;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.MaskedTextBox mtb_dtNascimento;
    }
}

