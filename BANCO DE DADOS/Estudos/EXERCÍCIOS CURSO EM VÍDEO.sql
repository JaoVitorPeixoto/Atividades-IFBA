-- [ 1º QUESTÃO ] Uma lista com o nome de todas as pessoas do sexo feminino.
select nome from pessoa
where sexo = 'F'
order by nome;

-- [ 2º QUESTÃO ] Uma lista com os dados de todos aqueles que nasceram entre 1/Jan/2000 e 31/Dez/2015.
select * from pessoa
where nascimento between '2000-01-01' and '2015-12-31'
order by nome;

-- [ 3º QUESTÃO ] Uma lista com o nome de todos os homens que trabalham como Proframadores.
select nome from pessoa
where sexo = 'M' and profissao = 'Programador'
order by nome;

-- [ 4º QUESTÃO ] Uma lista com os dados de todas as mulheres que nasceram no Brasil e que têm seu nome iniciando com a letra 'J'.
select * from pessoa
where sexo = 'F' and nacionalidade = 'Brasil' and nome LIKE 'J%'
order by nome;

-- [ 5º QUESTÃO ] Uma lista com o nome e nacionalidade de todos os homens que têm "Silva" no nome, não nasceram no Brasil e pesam menos de 100Kg.
select nome, nacionalidade from pessoa
where nome LIKE '%Silva%' and nacionalidade != 'Brasil' and peso < 100 and sexo = 'M'
order by nome;

-- [ 6º QUESTÃO ] Qual é a maior altura entre os homens que moram no Brasil.
select max(altura) from pessoa
where sexo = 'M' and nacionalidade = 'Brasil'
order by nome;

-- [ 7º QUESTÃO ] Qual é a média de peso das pessoas cadastradas.
select avg(peso) from pessoa;

-- [ 8º QUESTÃO ] Qual é o menor peso entre as mulheres que nasceram fora do Brasil entre 01/Jan/1990 e 31/Dez/2000.
select min(peso) from pessoa
where sexo = 'F' and nacionalidade = 'Brasil' and nascimento between '1990-01-01' and '2000-12-31';

-- [ 9º QUESTÃO ] Quantas mulheres têm mais de 1.90m de altura.
select count(altura) from pessoa
where sexo = 'F' and altura > 1.90;

-- ==================== LISTA 2 DO CURSO EM VÍDEO ====================

-- [ 1º QUESTÃO ] Uma lista com as profissões das pessoas e seus respectivos quantitativos.
select count(*), profissao
 from pessoa
group by profissao
order by count(profissao) desc;

-- [ 2º QUESTÃO ] Quantos homens e quantas mulheres nasceram após 01/Jan/2005.
select sexo, count(*) from pessoa
 where nascimento > '2005-01-01'
group by sexo;

-- [ 3º QUESTÃO ] Uma lista com as pessoas que nasceram fora do Brasil, mostrando o país de origem
-- e o total de pessoas nascidas lá. Só nos interessam os países que tiverem mais de 3 pessoas com
-- essa nacionalidade.
select count(*), nacionalidade from pessoa
group by nacionalidade
having  nacionalidade != 'Brasil' and count(*) > 3
order by count(*) desc;

-- [ 4º QUESTÃO ] Uma lista agrupada pela altura das pessoas, mostrando quantas pessoas pesam mais
-- de 100Kg e que estão acima da média de altura de todos cadastrados.
select count(*), altura from pessoa where peso > 100 and altura
group by altura
having altura > (select avg(altura) from pessoa);

