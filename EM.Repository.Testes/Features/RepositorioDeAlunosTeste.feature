#language:pt-br

Funcionalidade: Realizar manipulações com os dados de um aluno
	COMO secretario da escola
	QUERO poder manipular os dados cadastrados do aluno
	PARA controlar os dados atraves do repositorio

	DEVE adicionar um aluno ao repositorio
	DEVE remover um aluno do repositorio
	DEVE atualizar os dados de um aluno do repositorio
	DEVE conseguir consultar os dados do aluno

Cenario: Adicionar Aluno ao Repositorio
	Dado que o secretario tenha os dados do aluno
	E digite o nome 'João da Silva'
	E digite o CPF '70499770129'
	E digite a matricula '998877'
	E digite o nascimento '30/03/2005'
	E selecione o sexo 'Masculino'
	Quando o secretario clicar em adicionar
	Entao o aluno sera adicionado

Cenario: Remover Aluno do Repositorio
	Dado que o secretario tenha os dados do aluno
	E digite o nome 'João da Silva'
	E digite o CPF '70499770129'
	E digite a matricula '998877'
	E digite o nascimento '30/03/2005'
	E selecione o sexo 'Masculino'
	Quando o secretario confirmar a exlusao 
	Entao o aluno sera removido de repositorio

Cenario: Atualizando dados de um aluno do Repositorio
	Dado que o secretario tenha os dados do aluno para atualizar
	E digite o nome 'João da Silva'
	E digite o CPF '70499770129'
	E digite a matricula '998877'
	E digite o nascimento '30/03/2005'
	E selecione o sexo 'Masculino'
	Quando o secretario localizar os dados do aluno para atualizar
	Entao os dados serao atualizados

Cenario: Consultando dados de Alunos atraves do Nome
	Dado que varios alunos estao no repositorio
	E o secretario deseja pesquisar alunos que tenha a letra 'a'
	Quando o secretario realizar a busca
	Entao sera listado os alunos

Cenario: Consultando dados de Alunos atraves da Matricula
	Dado que varios alunos estao no repositorio
	E o secretario deseja pesquisar o aluno com a matricula '998877'
	Quando o secretario realizar a busca
	Entao sera listado os alunos