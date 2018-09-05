-- Júlio Vaz Rm: 18846 Téc.informatica 3° Módulo

CREATE DATABASE consulta_automatizada;
USE consulta_automatizada;
CREATE TABLE cliente(
	id_cliente INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome_cliente varchar(255),
	desc_cliente varchar(500),
	dt_nascimento datetime
)
INSERT INTO cliente (nome_cliente, desc_cliente, dt_nascimento) VALUES ('Teste', 'Teste datetime', convert(datetime,'18-06-12 10:34:00 PM', 5));
SELECT * FROM cliente;


/******************************************/
-- Criar procedure para SELECT cliete
CREATE PROCEDURE todos_clientes
as
SELECT * FROM cliente

todos_clientes

/******************************************/

ALTER PROCEDURE todos_clientes
@id_cliente int as SELECT * FROM cliente
WHERE id_cliente = @id_cliente

todos_clientes 2

SELECT * FROM cliente;

/******************************************/

CREATE TABLE cliente_endereco(
	id_endereco INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	endereco varchar(500),
	nr_filial integer,
	clienteID integer FOREIGN KEY REFERENCES cliente(id_cliente)
)

/****************************/

ALTER PROCEDURE todos_clientes
@id_cliente int, @endereco as SELECT * FROM cliente
WHERE id_cliente = @id_cliente AND endereco = @endereco

todos_clientes 2

/****************************/

ALTER PROCEDURE todos_clientes
@id_cliente int,
@clienteID int as SELECT * FROM cliente INNER JOIN cliente_endereco ON id_cliente = @id_cliente AND clienteID = @clienteID

todos_clientes 2,2

/****************************/

INSERT INTO cliente_endereco(endereco, nr_filial, clienteID) VALUES ('Avenida Águia de Haia, 123', 3, 3);


/**************  teste INNER JOIN  **************/

SELECT cliente.nome_cliente as Cliente, cliente_endereco.endereco as Endereço, cliente_endereco.nr_filial as Filial FROM cliente INNER JOIN cliente_endereco ON cliente.id_cliente = cliente_endereco.clienteID;