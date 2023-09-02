desc pessoa;
desc curso;

-- DEFININDO OS PADRÕES DO DATABASE
create database cadastro
default character set utf8
default collate utf8_general_ci;


-- CRIANDO TABELA PESSOA
create table pessoa(
id int not null auto_increment,
nome varchar(30),
nascimento date,
sexo enum('M', 'F'),
peso decimal(5,2),
altura decimal(3,2),
nacionalidade varchar(20) default 'Brasil',
primary key(id)
)default charset = utf8;


-- CRIANDO A TABELA CURSO
create table if not exists curso(
nome varchar(30) not null unique,
descricao text,
cargas int unsigned,
totaula int unsigned,
ano year default '2022'
)default charset = utf8;

alter table curso
add column id_curso int first;

alter table curso
add primary key(id_curso);

alter table curso
modify column id_curso int auto_increment;


-- ADICIONANDO NOVA COLUNA PROFISSÃO NA TABELA PESSOA E COLOCANDO DEPOIS DA COLUNA NOME, ALÉM DE FAZER MODIFICAÇÕES
alter table pessoa
add column profissao varchar(10);

alter table pessoa
drop column profissao;

alter table pessoa
add column profissao varchar(10) after nome;

alter table pessoa
modify column profissao varchar(20) default '';

alter table pessoa
change column profissao prof varchar(20) default '';


-- ADICIONANDO VALORES NA TABELA PESSOA
insert into pessoa
(id, nome, nascimento, sexo, peso, altura, nacionalidade)
values
(default, 'Maria', '1999-04-20', 'F', '70.6', '1.80', default);


-- ADICIONANDO VALORESS A TABELA CURSO
insert into curso values
(default, 'HTML4', 'Curso de HTML 5', '40', '37', '2014'),
(default, 'Jarva', 'Curso de Java', '10', '29', '2000'),
(default, 'PGP', 'Curso de PHP', '40', '20', '2010'),
(default, 'Photoshop', 'Curso de Photoshop', '10', '8', '2014');


-- ARRUMANDO OS DADOS ERRADOS DA TABELA CURSO
update curso
set nome = 'HTML5'
where id_curso = 1 ;

update curso
set nome = 'Java', carga = 40, ano = 2015 
where id_curso = 2
limit 1;

update curso
set nome = 'PHP',  ano = 2015
where id_curso = 3
limit 1;


-- UTILIZANDO O COMANDO SELECT PARTE 1
select * from curso
order by nome desc;

select  ano, nome, descricao, carga  from curso
order by ano, nome;

select * from curso
where ano <= 2016
order by ano, nome;

select * from curso
where ano < 2016 and ano > 2010
order by ano, nome;

select * from curso
where totaula between 20 and 30
order by nome;

select nome, descricao, ano from curso
where ano in (2014, 2016, 2018)
order by ano desc, nome;


-- UTILIZANDO O COMANDO SELECT PATE 2
select nome, descricao, ano from curso
where nome LIKE '%T'
order by ano desc, nome;

select nome, descricao, ano from curso
where nome LIKE 'P%'
order by ano desc, nome;

select nome, descricao, ano from curso
where nome LIKE '%S%'
order by ano desc, nome;

select nome, descricao, ano from curso
where nome LIKE 'PH%P%'
order by ano desc, nome;
 
 select nome, descricao, ano from curso
where nome LIKE 'P_P%'
order by ano desc, nome;

select distinct nacionalidade from pessoa
order by nacionalidade;


-- UTILIZANDO O COMANDO SELECT PARTE 3
select carga, count(carga) from curso
group by carga;

select totaula, count(totaula) from curso
group by totaula
order by totaula;

select carga, count(*) from curso where totaula = 30
group by carga;

select ano, count(ano) from curso where carga > 20
group by ano
having count(ano) > 3
order by count(*) desc;

select carga, count(*) from curso where ano > 2015
group by carga
having carga > (select avg(carga) from curso);


-- FUNÇÕES DE AGREGAÇÃO
select count(*) from curso
where carga = 30;

select max(totaula) from curso where ano = 2018;

select nome, min(carga) from curso where nome LIKE 'P%';

select sum(carga) from curso;

select avg(totaula) from curso;


-- ADICIONANDO CHAVES ESTRANGEIRAS
alter table pessoa
add column curso_escolha int;

alter table pessoa
add foreign key(curso_escolha) references curso(id_curso);

-- Adicionando valores a chave estrangeira.
update pessoa set curso_escolha = 6 where id = 1;

-- Utilizando select para mostrar nome da pessoa com seu curso.
select pessoa.nome, curso.nome, curso.ano from pessoa join curso
on curso.id_curso = curso_escolha 
order by pessoa.nome;

select p.nome'Pessoa', p.sexo, p.profissao, c.nome'Nome do curso', c.descricao'Descrição do curso', c.ano from pessoa as p right outer join curso as c
on p.curso_escolha = c.id_curso
order by p.nome;



-- CRIANDA NOVA TABELA PARA FAZER RELAÇÃO DE 'N' PARA 'N' DAS TABELAS 'Pessoa' E 'Curso'
create table assiste(
id_assiste int auto_increment,
data date,
id_cursoEst int,
idEst int,
primary key(id_assiste),
foreign key (idEst) references pessoa (id),
foreign key (id_cursoEst) references curso (id_curso)
)default charset = utf8;


-- CÓDIGOS UTILIZADOS PARA ALGO NOS ESTUDOS
desc pessoa;

select * from pessoa;

select * from curso;

delete from pessoa where id = 7;
