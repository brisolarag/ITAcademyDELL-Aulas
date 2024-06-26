-- Parabéns! Você aprendeu um pouco sobre sistemas gerenciadores de bancos de dados 
-- relacionais e sobre a linguagem SQL. Mas tem muito mais pela frente! Aqui vão alguns 
-- desafios e perguntas para instigar a sua curiosidade:

--      1. Faz sentido usar a cláusula DISTINCT para a coluna “placa” da tabela VEICULOS?
--          R: Não faz sentido, visto que a placa é única para cada veículo.

--      2. O que acontece se for inserido um valor negativo para a coluna KM?
--          R: Nada acontece, pois neste banco não temos uma validação para isso.
            insert into veiculos (placa, ano, km, marca, modelo) values ('AZD123', 2024, -1234, 'Carro' 'Negativo');

--      3. Até o momento temos apenas uma tabela no banco de dados. Crie uma tabela 
--      de  PESSOAS,  contendo  CPF,  Nome,  Idade  e  Sexo.  Insira  alguns  registros  e  faça 
--      algumas consultas.
        create table PESSOAS ( 
            cpf NUMBER(11),
            nome VARCHAR(75),
            idade number(3),
            sexo CHAR(1)
        )

        insert into pessoas (cpf, nome, idade, sexo) values (12312312311, 'Reginaldo da Silva', 54, 'M');
        insert into pessoas (cpf, nome, idade, sexo) values (32132132155, 'Claudirene Correa', 79, 'F');
        insert into pessoas (cpf, nome, idade, sexo) values (98765432144, 'Osvaldo Peres', 45, 'M');
        insert into pessoas (cpf, nome, idade, sexo) values (32132132111, 'Fabricio Alves', 25, 'M');
        insert into pessoas (cpf, nome, idade, sexo) values (98951321355, 'Roberta Almeida', 22, 'F');
        insert into pessoas (cpf, nome, idade, sexo) values (98798795111, 'Reginaldo Diagonis', 88, 'M');
        insert into pessoas (cpf, nome, idade, sexo) values (15293576541, 'Oscar Schmidt', 66, 'M');


        select * from pessoas where (idade > 50);
        select cpf, nome from pessoas
            where (sexo = 'M' and idade <30);




CREATE TABLE VEICULOS (
    placa CHAR(8),
    ano NUMBER(4),
    km NUMBER(6),
    marca VARCHAR(50),
    modelo VARCHAR(50)
)

INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('ABC1234', 2019, 30000, 'Chevrolet', 'Onix');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('DEF5678', 2020, 25000, 'Volkswagen', 'Gol');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('GHI9101', 2018, 45000, 'Ford', 'Ka');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('JKL1121', 2017, 60000, 'Toyota', 'Corolla');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('MNO3141', 2016, 75000, 'Honda', 'Civic');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('PQR5161', 2015, 80000, 'Hyundai', 'HB20');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('STU7182', 2014, 90000, 'Renault', 'Sandero');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('VWX9232', 2013, 100000, 'Fiat', 'Uno');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('YZA2343', 2012, 120000, 'Nissan', 'Versa');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('BCD3454', 2011, 150000, 'Chevrolet', 'Prisma');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('EFG4565', 2010, 180000, 'Volkswagen', 'Fox');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('HIJ5676', 2009, 200000, 'Ford', 'Fiesta');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('KLM6787', 2008, 220000, 'Toyota', 'Etios');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('NOP7898', 2007, 240000, 'Honda', 'Fit');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('QRS8909', 2006, 260000, 'Hyundai', 'Creta');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('TUV9010', 2005, 280000, 'Renault', 'Duster');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('WXY0121', 2004, 300000, 'Fiat', 'Palio');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('ZAB1232', 2003, 320000, 'Nissan', 'Sentra');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('CDE2343', 2002, 350000, 'Chevrolet', 'S10');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('FGH3454', 2001, 380000, 'Volkswagen', 'Saveiro');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('IJK4565', 2000, 400000, 'Ford', 'Ranger');
INSERT INTO VEICULOS (placa, ano, km, marca, modelo) VALUES ('LMN5676', 1999, 420000, 'Toyota', 'Hilux');