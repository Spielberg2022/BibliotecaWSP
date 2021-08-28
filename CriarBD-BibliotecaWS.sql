CREATE DATABASE BibliotecaWS;

USE BibliotecaWS;

CREATE TABLE Usuario(
	Codigo int AUTO_INCREMENT NOT NULL,
	Nome varchar(150) NOT NULL,
	Identificador varchar(20) NOT NULL,
	Senha varchar(50) NOT NULL,
	CEP varchar(8) NULL,
	UF varchar(2) NULL,
	Bairro varchar(100) NULL,
	Cidade varchar(100) NULL,
	Logradouro varchar(100) NULL,
	PRIMARY KEY (Codigo)
);

CREATE TABLE Aluno(
	Codigo int AUTO_INCREMENT NOT NULL,
	Matricula varchar(7) NOT NULL,
	Nome varchar(150) NOT NULL,
	CPF varchar(11) NOT NULL,
	Celular varchar(11) NOT NULL,
	CEP varchar(8) NULL,
	UF varchar(2) NULL,
	Bairro varchar(100) NULL,
	Cidade varchar(100) NULL,
	Logradouro varchar(100) NULL,
	PRIMARY KEY (Codigo)
);

CREATE TABLE Livro(
	Codigo int AUTO_INCREMENT NOT NULL,
	ISBN varchar(20) NOT NULL,
	Autores varchar(200) NOT NULL,
	Titulo varchar(150) NOT NULL,
	Editora varchar(50) NULL,
	Ano int NULL,
	QtdTotal int NULL,
	Disponivel int NULL,
	PRIMARY KEY (Codigo)
);

CREATE TABLE Emprestimo(
	CodAluno int NOT NULL,
	CodLivro int NOT NULL,
	DataEmprestimo date NOT NULL,
	DataParaDevolucao date NOT NULL,
	DataDevolucao date NULL,
	CodUsuario int NOT NULL,
	Multa DECIMAL(10,2) NULL,
	CONSTRAINT FK_Emprestimo_Aluno FOREIGN KEY(CodAluno)
		REFERENCES Aluno(Codigo),
	CONSTRAINT FK_Emprestimo_Livro FOREIGN KEY(CodLivro)
		REFERENCES Livro(Codigo),
	CONSTRAINT FK_Emprestimo_Usuario FOREIGN KEY(CodUsuario)
		REFERENCES Usuario(Codigo)
);

CREATE TABLE Opcoes(
	DiasDevolucao int NOT NULL,
	MultaDiaria DECIMAL(5,2) NOT NULL
);