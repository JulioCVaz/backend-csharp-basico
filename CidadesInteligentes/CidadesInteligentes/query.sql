CREATE DATABASE cidadeinteligente;

use cidadeinteligente;

CREATE TABLE loginUser(
	id_login integer not null primary key identity(1,1),
	user_login varchar(500) NOT NULL,
	password_login varchar(500),
	pessoaID integer FOREIGN KEY REFERENCES pessoa(id_pessoa)
)

SELECT user_login, password_login FROM loginUser WHERE user_login='admin';

INSERT INTO loginUser(user_login, password_login, pessoaID) VALUES ('admin', '123', 1);
-- criar tabela estados
CREATE TABLE tbEstado(
	idEstado integer not null primary key identity(1,1),
	nmEstado varchar(255),
	nHabitante integer
)


SELECT * FROM tbEstado;

INSERT INTO tbEstado(nmEstado, nHabitante) VALUES('São Paulo', 123456), ('Rio de Janeiro', 164867), ('Bahia', 123564787), 
('Minas Gerais', 216748), ('Rio Grande do Sul', 165495674), ('Paraná', 1256745), ('Pernambuco', 5646798);

CREATE PROCEDURE sp_RetornaEstado
@nmEstado varchar(50)
as 
SELECT * FROM tbEstado
WHERE nmEstado = @nmEstado

sp_RetornaEstado 'São Paulo';

INSERT INTO pessoa(nome_pessoa, endereco_pessoa, estadoc_pessoa, datanasc_pessoa) VALUES ('Administrador', 'admin de haia, 500', 1, '17-09-2018')

-- criar table pessoa
CREATE TABLE pessoa(
	id_pessoa INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome_pessoa VARCHAR(255),
	endereco_pessoa VARCHAR(500),
	estadoc_pessoa integer NOT NULL FOREIGN KEY REFERENCES pessoa(id_pessoa),
	datanasc_pessoa datetime
)
-- criar table pessoa documento
CREATE TABLE pessoadocumento(
	id_doc INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	pessoaID INTEGER FOREIGN KEY REFERENCES pessoa(id_pessoa),
	rg VARCHAR(60),
	cpf VARCHAR(60),
	reservista VARCHAR(60),
	carteira_trab VARCHAR(60),
	cnh VARCHAR(60)
)

-- criar table pessoa documento
CREATE TABLE funcionario(
	id_funcionario integer NOT NULL PRIMARY KEY IDENTITY(1,1),
	pessoaID INTEGER FOREIGN KEY REFERENCES pessoa(id_pessoa),
	cargoID INTEGER FOREIGN KEY REFERENCES cargo(id_cargo),
	salario decimal(10,2),
	ramalID INTEGER FOREIGN KEY REFERENCES ramais(id_ramal)
)

-- criar table cargo
CREATE TABLE cargo(
	id_cargo INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome_cargo VARCHAR(60)
)

-- criar table ramais
CREATE TABLE ramais(
	id_ramal INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	numero INTEGER
)

-- criar table cliente
CREATE TABLE cliente(
	id_cliente INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	pessoaID INTEGER FOREIGN KEY REFERENCES pessoa(id_pessoa),
	data_conclusao datetime
)

ALTER TABLE pessoa
ADD estadocivil varchar(255);
