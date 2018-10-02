-- Júlio César de O.Vaz RM: 18846 - Info 3° Noturno

CREATE DATABASE consulta_medica;

use consulta_medica;



----	INSERTS

INSERT INTO setor(nome_setor) VALUES ('Saúde');
INSERT INTO cargo(nome_cargo, setorID) VALUES('Atendimento', 0), ('Médico Fisioterapeuta', 0);
INSERT INTO funcionario(nome_funcionario, data_nasc, cpf,endereco,salari, cargoID) VALUES('Alberto Silva Souza', '2001-11-11', '123.456.789-70', 'Avenida Águia de Haia, 568',1221.50, 5);
INSERT INTO especialista(nome_especialista, data_nasc, cpf, endereco, salari, cargoID) VALUES('Van hon de Oliveira', '1973-10-05', '321.544.987-50', 'Avenida Paulista, 11', 20650.99, 6);
INSERT INTO especialidades(nome_espec, id_especialista) VALUES ('Fisioterapia', 2);
INSERT INTO clientes(nome_cliente, data_nasc, cpf, endereco, cep, email, funcionarioID) VALUES('Maria Zenzovich', '1992-05-10', '654.897.689-60', 'Avenida Paraiso, 659', '12358-70', 'maria@email.com.br', 2);
INSERT INTO consulta(clienteID, funcionarioID, hora_consult, especialidadeID) VALUES (1,2,'2008-11-11 13:23:44',5);

-----   TABLES


CREATE TABLE clientes(
	id_cliente integer NOT NULL PRIMARY KEY IDENTITY(0,1),
	nome_cliente varchar(255) NOT NULL,
	data_nasc date,
	cpf varchar(255) NOT NULL,
	endereco varchar(255),
	cep varchar(255),
	email varchar(255),
	funcionarioID integer NOT NULL FOREIGN KEY REFERENCES funcionario(id_funcionario)
);

CREATE TABLE funcionario(
	id_funcionario integer NOT NULL PRIMARY KEY IDENTITY(0,1),
	nome_funcionario varchar(255) NOT NULL,
	data_nasc date,	
	cpf varchar(255) NOT NULL,
	endereco varchar(255),
	salari smallmoney,
	cargoID integer NOT NULL FOREIGN KEY REFERENCES cargo(id_cargo)
)

CREATE TABLE cargo(
	id_cargo integer NOT NULL PRIMARY KEY IDENTITY(0,1),
	nome_cargo varchar(255),
	setorID integer NOT NULL FOREIGN KEY REFERENCES setor(id_setor)
)

CREATE TABLE setor(
	id_setor integer NOT NULL PRIMARY KEY IDENTITY(0,1),
	nome_setor varchar(255)
)

CREATE TABLE consulta(
	id_consulta integer NOT NULL PRIMARY KEY IDENTITY(0,1),
	clienteID integer NOT NULL FOREIGN KEY REFERENCES clientes(id_cliente),
	funcionarioID integer NOT NULL FOREIGN KEY REFERENCES funcionario(id_funcionario),
	hora_consult datetime,
	especialidadeID integer NOT NULL FOREIGN KEY REFERENCES especialidades(id_especialidade)
)

CREATE TABLE especialidades(
	id_especialidade integer NOT NULL PRIMARY KEY IDENTITY(0,1),
	nome_espec varchar(255),
	id_especialista integer NOT NULL FOREIGN KEY REFERENCES especialista(id_especialista)
)

CREATE TABLE especialista(
	id_especialista integer NOT NULL PRIMARY KEY IDENTITY(0,1),
	nome_especialista varchar(255) NOT NULL,
	data_nasc date,	
	cpf varchar(255) NOT NULL,
	endereco varchar(255),
	salari smallmoney,
	cargoID integer NOT NULL FOREIGN KEY REFERENCES cargo(id_cargo)
)

----- SELECTS

SELECT * FROM setor;
SELECT * FROM cargo;
SELECT * FROM funcionario;
SELECT * FROM especialista;
SELECT * FROM especialidades;
SELECT * FROM clientes;
SELECT * FROM consulta;

