create database escola3;
use escola3;

create table Materia(
cod_materia int  auto_increment not null,
nome varchar (100) not null,
carga_horar int,
primary key (cod_materia)
);

insert into Materia(nome, carga_horar) values ("Trato das Criaturas", 10), ("Desefa contra a magia das trevas",20),
("Transfiguração",10),("Feitiços",15),("Porções",20);

select * from Materia;


create table Prof(
cpf_prof char(11) not null,
nome varchar (100) not null,
nascimento_data date,
endereco varchar (100),
primary key (cpf_prof)
);

insert into Prof(cpf_prof, nome,nascimento_data,endereco) values ('11111111111','Albus Dumbledore','1990-01-01','EUA'),
('22222222222','Minerva McGonagall','1995-02-02','França'),
('33333333333','Rubeus Hagrid','1980-03-03','Inglaterra'),
('44444444444','Severo Snape','1995-05-05','Canada'),('48181818181','Flitwick','1995-08-05','Canada'),('4819999909',' Quirrell','1995-08-01','Canada');

select * from Prof;

create table Turma(
cod_turma int  auto_increment not null,
nomeclatura varchar (100) not null,
primary key (cod_turma)
);

insert into Turma(nomeclatura) values ('Grifinória'),('Corvinal'),('Sonserina'),('Lufa-Lufa');

select * from Turma;

create table Aluno(
cpf_alun char(11) not null,
nome_alun varchar (30) not null,
telefone int,
primary key (cpf_alun)
);

insert into Aluno(cpf_alun,nome_alun,telefone) values ('55555555555', 'Harry Potter',2222),('66666666666','Hermione Granger',1111),('77777777777','Rony Weasley',3333),
('88888888888','Draco Malfoy',4444),('99999999999','Neville Longbottom',5555),('10101010101','Luna Lovegood',6666),('12121212','João Vitor',0000),('14141414','Priscilla Soares',0909),('323232','Edric',434343),('131313','Aliria',1515),('565656','Sthefani',989898);

select * from Aluno;

create table Matricula(
cpf_alun2 char(11),
ano_letivo int,
cod_turma int
);

alter table Matricula add foreign key (cpf_alun2) references Aluno (cpf_alun);
alter table Matricula add foreign key (cod_turma) references Turma (cod_turma);

insert into Matricula(cpf_alun2,ano_letivo,cod_turma) values ('55555555555',2021,1),('66666666666',2021,1),('77777777777',2021,1),('88888888888',2021,3),('99999999999',2021,4),('10101010101',2021,2),('12121212',2021,1),('14141414',2021,3),('323232',2021,4),('131313',2021,2),('565656',2021,2);

select * from Matricula;


create table Config_Discip_AnoLetivo(
cod_materia int,
cod_turma int,
cpf_prof char(11)
);


alter table Config_Discip_AnoLetivo add foreign key (cod_materia) references Materia (cod_materia);
alter table Config_Discip_AnoLetivo add foreign key (cod_turma) references Turma (cod_turma);
alter table Config_Discip_AnoLetivo add foreign key (cpf_prof) references Prof (cpf_prof);


insert into Config_Discip_AnoLetivo(cod_materia,cod_turma,cpf_prof) values (5,3,'44444444444'),(5,4,'33333333333'),(3,4,'22222222222'),(4,1,'11111111111'),(2,1,'44444444444'),(5,3,'48181818181'),(1,6,'4819999909');

select * from Config_Discip_AnoLetivo;



-- 1 .Liste a quantidade de alunos que estão matriculados em cada turmas. (Priscilla)

select cod_turma"Código da turma", count(cpf_alun2)"Quantidade de alunos matriculados"
from Matricula
where cod_turma = cod_turma
group by cod_turma;


-- 2 . Liste quantos professores há em cada Endereço. (João Vitor)

select endereco"Endereço", count(endereco)"Quantidade de professores"
from Prof
where endereco = endereco
group by endereco;


-- 3 . Liste quantas matérias há com carga horária maior ou igual a 10. (Edric Guilherme)

select carga_horar"Carga horária", count(carga_horar)"Quantidade em cada carga horária"
from Materia
where carga_horar = carga_horar
group by carga_horar
having carga_horar >= 10;


-- 4. Liste as matérias pelo número de carga horária do maior para o menor. (Sthefani)

select nome"Materia", carga_horar"Carga horária"
from Materia
where carga_horar = carga_horar
order by carga_horar DESC;

-- 5. Liste a quantidade de matérias ministradas por cada professor


select Prof.nome, count(Materia.nome)
from Prof, Materia, Config_Discip_AnoLetivo
where Prof.cpf_prof = Config_Discip_AnoLetivo.cpf_prof 
and Materia.cod_materia = Config_Discip_AnoLetivo.cod_materia
group by Prof.nome;




-- Join inner


select Turma.nomeclatura"nome da turma com inner", Config_Discip_AnoLetivo.cod_materia"materia"
from Turma 
inner join Config_Discip_AnoLetivo
on Turma.cod_turma= Config_Discip_AnoLetivo.cod_turma;


-- Join left


select Turma.nomeclatura"nome da turma com left", Config_Discip_AnoLetivo.cod_materia"materia"
from Turma 
left outer join Config_Discip_AnoLetivo on Turma.cod_turma= Config_Discip_AnoLetivo.cod_turma;



-- Join right


select Turma.nomeclatura"nome da turma com right", Config_Discip_AnoLetivo.cod_materia"materia"
from Turma 
right outer join Config_Discip_AnoLetivo
on Turma.cod_turma= Config_Discip_AnoLetivo.cod_turma;

-- Cross

select Turma.nomeclatura"nome da turma com cross", Config_Discip_AnoLetivo.cod_materia"materia"
from Turma 
cross join Config_Discip_AnoLetivo;




-- ==================== VIEWS ====================


-- View para mostrar dados do professor de forma resumida.
create view Dados_prof as
select nome'Nome do Professor', nascimento_data'Data de nascimento' from Prof
order by nome;

select * from Dados_prof;

-- View para mostrar nome e telefone de aluno.
create view Dados_aluno as
select nome_alun'Nome do aluno', telefone'Telefone do aluno' from Aluno 
order by nome_alun;

select * from Dados_aluno;

-- View para mostrar o nome e a carga horária da matéria.
create view Dados_materia as
select nome'Nome da matéria', carga_horar'Carga horária' from Materia
order by nome;

select * from Dados_materia;

-- View para mostrar todas as cidade onde moram os professores, e quantos professores tem em cada uma delas.
create view Endere_quant as
select count(*)'Quantidade de professores', endereco'Cidade' from Prof
group by endereco
order by count(*);

select * from Endere_quant;

-- ==================== PROCEDURES ====================

-- Procedure para adicionar linha de um aluno.
DELIMITER //
Create procedure Adicionar_alun(cpf char(11), nome varchar(30), telefone int)
Begin

insert into Aluno values(cpf, nome, telefone);

End //
DELIMITER  ;

-- Procedure para ler como parametro um código de máteria e mostrar todos seus dados.
DELIMITER //
Create procedure Ler_inform_materia(cod int)
Begin

select * from Materia where cod_materia = cod;

End //
DELIMITER ;


-- ==================== TRIGGERS ====================

-- Trigger para backup da tabela aluno.
DELIMITER //
create trigger Backup_alun AFTER insert
on Aluno
for each row
begin
    insert into AlunoBackup 
    select * from Aluno;
end
//
DELIMITER ;

-- Trigger para backup da tabela professor.
DELIMITER //
create trigger Backup_Prof AFTER insert
on Prof
for each row
begin
	insert into ProfBackup 
    select * from Prof;
end
//
DELIMITER ;


-- =================== AGREGAÇÂO ========================
-- Agregação para saber qual a maior carga horária de todas as matérias usando a função max.                                                                                                                                                                              
select carga_horar, nome from Materia where carga_horar = (select max(carga_horar) from Materia);

-- Agregação para saber qual a menor carga horária de todas as matérias usando a função min.
select carga_horar, nome from Materia where carga_horar = (select min(carga_horar) from Materia);

-- Agregação para saber qual a média da carga horária de todas as matérias usando a função avg.
select avg(carga_horar) from Materia;

-- Agregação para saber a quantidade de alunos
select count(nome_alun) from Aluno;