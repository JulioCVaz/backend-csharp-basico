CREATE DATABASE somdegaragem;

use somdegaragem;


CREATE TABLE usuario(
	id integer not null primary key identity(1,1),
	nome varchar(255),
	cpf varchar(255),
	ccredito varchar(255),
	datanascimento datetime
)


CREATE TABLE logins(
	id integer not null primary key identity(1,1),
	email varchar(255) NOT NULL,
	senha varchar(255) NOT NULL,
	usuarioID integer FOREIGN KEY REFERENCES usuario(id)
)
	

CREATE TABLE musicas(
	id integer not null primary key identity(1,1),
	nomemusica varchar(255) NOT NULL,
	artista varchar(255) NOT NULL,
	album varchar(255) NOT NULL
)


CREATE TABLE playlist(
	id integer not null primary key identity(1,1),
	musicaID integer FOREIGN KEY REFERENCES musicas(id),
	usuarioID integer FOREIGN KEY REFERENCES usuario(id)
)


INSERT INTO usuario(nome, cpf, ccredito, datanascimento) VALUES ('sysadmin', '123.456.789-89', '1234.1231.4564.7899', GETDATE());
SELECT * FROM usuario;

INSERT INTO logins(email,senha,usuarioID) VALUES ('sysadmin@etec.com.br', 'admin', 1);
