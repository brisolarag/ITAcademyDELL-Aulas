-- 1. Escreva comandos SELECT para os itens abaixo:
--    o título, o ano e o diretor de todos os filmes.
        select titulo, ano, diretor from filmes;

--    os filmes de horror de 2010.
        select * from filmes
            where genero = 'Horror' AND
            ano = 2010;

--    o título e o ano dos filmes com duração maior do que 2 horas.
        select titulo, ano from filmes
            where duracao > 120;

--    o título e a duração das comédias lançadas na década de 1990 com
--    pelo menos 1 hora e 20 minutos de duração, dos diretores cujos
--    nomes começam pela letra ‘J’. Pesquise sobre o operador LIKE.
        select titulo, duracao from filmes WHERE
        genero like '%Comedy%' AND
        ano BETWEEN 1990 and 1999 and
        duracao > 80 AND
        diretor like 'J%';

--    o título, o gênero e o valor do ingresso dos filmes a partir de 2006,
        select titulo, genero, valorIngresso from Filmes
            where ano > 2006;

--    mostrando os valores inflacionados em 8,63%.
        select titulo, genero, valorIngresso, valorIngresso * 1.0863 as valorInflacionado from filmes
            where ano > 2006;

--    a quantidade de filmes de ação com ingressos que custam mais do
--    que R$ 20,00.
        select count(*) from filmes where valorIngresso > 20 and genero like '%Action%';

--    os nomes de todos os diretores cadastrados, sem repetir, e em
--    ordem alfabética.
        select DISTINCT diretor from filmes ORDER BY diretor asc;