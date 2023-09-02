create database escola;
use escola;
create table tbl_professor(
cpf_prof varchar(11) primary key not null,
nome varchar(50) not null,
endereco varchar(70),
data_nascimento datetime not null
);
create table tbl_aluno(
cpf_aluno varchar(11) primary key not null,
nome varchar(50) not null,
endereco varchar(70),
telefone varchar(13)
);
create table tbl_materia(
cod_materia int auto_increment not null primary key, 
nome varchar(30) not null,
carga_horaria int not null
);
create table tbl_turma(
cod_turma int auto_increment not null primary key,
nomenclatura varchar (15) not null,
quant_alunos int not null 
);
create table tbl_matricula(
cpf_aluno varchar(11) not null,
ano_letivo varchar(4) not null,
cod_turma int not null
);
create table tbl_boletim(
cpf_aluno varchar(11) not null primary key,
cod_turma int not null,
ano_letivo varchar(4) not null,
nota_unidade01 double,
nota_unidade02 double,
nota_unidade03 double,
nota_unidade04 double,
media double,
recuperacao double,
media_final double
); 




