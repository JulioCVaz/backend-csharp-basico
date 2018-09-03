/*
*	Description: Database cidadesInteligentes
*	Author: Júlio Vaz RGM: 18846
*	Disc: DSII
*/

-- criacao do banco de dados
CREATE DATABASE cidadesinteligentes;

-- usar banco de dados
use cidadesinteligentes;

-- criar table pessoa
CREATE TABLE pessoa(
	id_pessoa INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome_pessoa VARCHAR(255),
	endereco_pessoa VARCHAR(500),
	estadoc_pessoa VARCHAR(15),
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