#language:pt-br

Funcionalidade: Cadastrar os dados de um aluno
	COMO secretario
	QUERO cadastrar os dados de um aluno
	Para que seja gravado no sistema

	DEVE identificar se o nome do aluno é valido
	DEVE identificar de a matricula é valida
	DEVE identificar se o CPF é valido
	DEVE identificar se a data de nascimento é valida

Cenario: Aluno com matricula já cadastrada
	Dado que o secretario esteja cadastrando a matricula do aluno
	E no campo matricula informa '123'		
	E no campo nome informa 'João da Silva'
	E no campo CPF informa '70499770129'
	E no campo Nascimento informa '20/03/2000'
	E seleciona o sexo 'Masculino'
	Quando clicar em 'Adicionar'
	Entao o sistema apresentará uma mensagem informando que a matricula já foi cadastrada

Cenario: Aluno com nome invalido
	Dado que o secretario esteja cadastrando a matricula do aluno
	E no campo matricula informa '200387'
	E no campo nome deixa em branco
	E no campo CPF informa '70499770129'
	E no campo Nascimento informa '20/03/2000'
	E seleciona o sexo 'Masculino'
	Quando clicar em 'Adicionar'
	Entao o sistema apresentará uma mensagem informando que o nome deve ser informado

Cenario: Aluno com CPF invalido
	Dado que o secretario esteja cadastrando a matricula do aluno
	E no campo matricula informa '200388'		
	E no campo nome informa 'João da Silva'
	E no campo CPF informa '70499770128'
	E no campo Nascimento informa '20/03/2000'
	E seleciona o sexo 'Masculino'
	Quando clicar em 'Adicionar'
	Entao o sistema apresentará uma mensagem informando que o CPF é invalido

Cenario: Aluno com data de nascimento invalida
	Dado que o secretario esteja cadastrando a matricula do aluno
	E no campo matricula informa '200389'		
	E no campo nome informa 'João da Silva'
	E no campo CPF informa '70499770129'
	E no campo Nascimento informa '20/03/2022'
	E seleciona o sexo 'Masculino'
	Quando clicar em 'Adicionar'
	Entao o sistema apresentará uma mensagem informando que a data de nascimento deve ser menor que a data atual

Cenario: Aluno com todos os dados valido
	Dado que o secretario esteja cadastrando a matricula do aluno
	E no campo matricula informa '200399'		
	E no campo nome informa 'João da Silva'
	E no campo CPF informa '70499770129'
	E no campo Nascimento informa '20/03/2000'
	E seleciona o sexo 'Masculino'
	Quando clicar em 'Adicionar'
	Entao o sistema apresentará uma mensagem informando que o cadastro foi realizado com sucesso
