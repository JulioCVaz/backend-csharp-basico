use master
drop database dbAluno
create database dbAluno
use dbAluno

create table Aluno(
	--idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
	idAluno int primary key identity(1,1),
	rgAluno varchar(30),
	cpfAluno varchar(30),
	dsEndereco varchar(255),
	nmAluno varchar(255),
	foneAluno varchar(25),
	curso varchar(50)
)

alter PROCEDURE sp_RetornarAluno
@nmAluno varchar(255) = null
as
SELECT idAluno 'Código Aluno', nmAluno 'Nome', cpfAluno 'CPF Aluno', dsEndereco 'Endereço', rgAluno 'RG', foneAluno 'Telefone', curso 'Curso' FROM Aluno
where @nmAluno is null or nmAluno like '%' + @nmAluno + '%'

insert into Aluno values ('11.111.111-1','111.111.111-11','Rua do Aluno Exemplo','Aluno Exemplo','(11)2577-8899','Informática')
insert into Aluno values ('22.222.222-2','222.222.222-22','Rua do Aluno Exemplo2','Aluno Exemplo2','(11)2177-8892','Administração de Empresas')

select*from Aluno