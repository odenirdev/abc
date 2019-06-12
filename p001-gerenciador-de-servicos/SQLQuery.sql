CREATE DATABASE GSDB
GO

USE GSDB
GO

CREATE TABLE FUNCIONARIOS(
	FUNC_COD		INT			IDENTITY,
	FUNC_NOME		VARCHAR(50) NOT NULL,
	FUNC_SNOME		VARCHAR(50) NOT NULL,
	FUNC_CPF		VARCHAR(20)	NOT NULL,
	FUNC_EMAIL		VARCHAR(50) NOT NULL,
	FUNC_TELEFONE	VARCHAR(20)	NULL,
	FUNC_CELULAR	VARCHAR(20)	NOT NULL,
	FUNC_CARGO		VARCHAR(20)	NOT NULL CHECK(FUNC_CARGO IN('ADMINISTRADOR', 'MODERADOR')),
	FUNC_SENHA		VARCHAR(50) NOT NULL,
	FUNC_ESTADO		VARCHAR(15)		CHECK (FUNC_ESTADO IN('REGISTRADO', 'DELETADO')) NOT NULL,
	CONSTRAINT PK_FUNCIONARIOS PRIMARY KEY(FUNC_COD))
GO

INSERT INTO FUNCIONARIOS VALUES ('admin', 'admin', '11111111','admin@admin', null, 'admin', 'ADMINISTRADOR', 'admin', 'REGISTRADO')
GO

CREATE TABLE CLIENTES(
	CLI_COD			INT				IDENTITY,
	FUNC_COD		INT				NOT NULL,
	CLI_NOME		VARCHAR(50)		NOT NULL,
	CLI_SNOME		VARCHAR(50)		NOT NULL,
	CLI_CPF			VARCHAR(20)		NOT NULL,
	CLI_EMAIL		VARCHAR(50)		NOT NULL,
	CLI_TELEFONE	VARCHAR(20)		NULL,
	CLI_CELULAR		VARCHAR(20)		NOT NULL,
	CLI_CIDADE		VARCHAR(50)		NOT NULL,
	CLI_ENDERECO	VARCHAR(100)	NOT NULL,
	CLI_NUMERO		VARCHAR(10)		NOT NULL,
	CLI_COMPLEMENTO VARCHAR(10)		NULL,
	CLI_ESTADO		VARCHAR(15)		CHECK (CLI_ESTADO IN('REGISTRADO', 'DELETADO')) NOT NULL,
	CONSTRAINT PK_CLIENTE PRIMARY KEY(CLI_COD),
	CONSTRAINT FK_CLI_FUNCIONARIO FOREIGN KEY(FUNC_COD) REFERENCES FUNCIONARIOS(FUNC_COD)
	)
GO

INSERT INTO CLIENTES VALUES ('1', 'Manuel',		'Vieira',		 '420.025.820-09', 'manuelvieira@care-br.com',			'(63) 3616-0788', '(63) 98305-5778', 'Aragua�na',		'Rua 21',						'243', null, 'REGISTRADO'),
							('1', 'Heloise',	'Fernandes',	 '735.246.080-27', 'heloise78@fernandaleal.com.br',		'(83) 3544-8235', '(83) 98323-0927', 'Jo�o Pessoa',		'Vila Nossa Senhora das Neves', '877', null, 'REGISTRADO'),
							('1', 'Vitor',		'Paulo Almada',  '767.780.360-10', 'vitorpauloalmada@cteep.com.br',		'(82) 3747-9016', '(82) 99761-5074', 'Arapiraca',		'Rua Am�lia Gonzaga Lima',		'775', null, 'REGISTRADO'),
							('1', 'Valentina',  'Nat�lia Ramos', '348.234.380-27', 'valentinaramos@maorifilmes.com.br', '(95) 3613-0467', '(95) 98686-0114', 'Boa Vista',		'Rua do Muricizeiro',			'627', null, 'REGISTRADO'),
							('1', 'Enrico',		'Drumond',		 '275.626.360-52', 'enricodrumond@yazigi.com',			'(65) 2927-4857', '(65) 99647-9269', 'Cuiab�',			'Rua Generoso Cir�aco Maciel',  '625', null, 'REGISTRADO')
GO

CREATE TABLE PROFISSIONAIS(
	PROF_COD			INT				IDENTITY,
	FUNC_COD			INT				NOT NULL,
	PROF_NOME			VARCHAR(50)		NOT NULL,
	PROF_SNOME			VARCHAR(50)		NOT NULL,
	PROF_CPF			VARCHAR(20)		NOT NULL,
	PROF_EMAIL			VARCHAR(50)		NOT NULL,
	PROF_TELEFONE		VARCHAR(20)		NULL,
	PROF_CELULAR		VARCHAR(20)		NOT NULL,
	PROF_CIDADE			VARCHAR(50)		NOT NULL,
	PROF_ENDERECO		VARCHAR(100)	NOT NULL,
	PROF_NUMERO			VARCHAR(10)		NOT NULL,
	PROF_COMPLEMENTO	VARCHAR(10)		NULL,
	PROF_ESTADO		VARCHAR(15)		CHECK (PROF_ESTADO IN('REGISTRADO', 'DELETADO')) NOT NULL,
	CONSTRAINT PK_PROFISSIONAL PRIMARY KEY(PROF_COD),
	CONSTRAINT FK_PROF_FUNCIONARIO FOREIGN KEY(FUNC_COD) REFERENCES FUNCIONARIOS(FUNC_COD))
GO

INSERT INTO PROFISSIONAIS VALUES ('1', 'Jaqueline', 'Isis Peixoto',			'312.076.580-57', 'jaquelineisispeixoto@ehotmail.com.br', '(85) 3702-9015', '(85) 99893-4992', 'Fortaleza',		'Vila Sarney',				'947', null,  'REGISTRADO'),
								 ('1', 'Melissa',	'Alves',				'493.633.600-91', 'melissaalves@grupoitamaraty.com.br',	  '(27) 3890-6995', '(27) 99233-8979', 'Viana',			'Rodovia BR-262',			'164', null,  'REGISTRADO'),
								 ('1', 'Benjamin',	'Arag�o',				'020.528.740-97', 'benjaminaragao@iacit.com.br',		  '(67) 3688-8841', '(67) 99378-9146', 'Campo Grande',	'Rua Canabr�s',				'506',  null, 'REGISTRADO'),
								 ('1', 'Thiago',	'Martin da Concei��o',  '243.468.050-00', 'thiagoconceicao@signa.net.br',		  '(44) 2638-7093', '(44) 99130-8235', 'Campo Mour�o',	'Rua Bel�m',				'854', null,  'REGISTRADO'),
								 ('1', 'Fabiana',	'Larissa Assun��o',		'058.442.690-98', 'fabianalarissaassuncao_@urbam.com.br', '(14) 2738-4695', '(14) 99581-0934', 'Lins',			'Rua Agenor Dantas Grion',  '457', null,  'REGISTRADO')
GO

CREATE TABLE SERVICOS(
	SERV_COD			INT			IDENTITY,
	FUNC_COD			INT			NOT NULL,
	SERV_NOME			VARCHAR(50) NOT NULL,
	SERV_AREA_ATUACAO	VARCHAR(20) NOT NULL,
	SERV_DESCRICAO		TEXT		NULL,
	SERV_ESTADO		VARCHAR(15)		CHECK (SERV_ESTADO IN('REGISTRADO', 'DELETADO')) NOT NULL,
	CONSTRAINT PK_SERVICOS PRIMARY KEY(SERV_COD),
	CONSTRAINT FK_SERV_FUNC_COD FOREIGN KEY(FUNC_COD) REFERENCES FUNCIONARIOS(FUNC_COD))
GO

INSERT INTO SERVICOS VALUES ('1', 'Encanador',	 'Hidr�ulica',	'Um Encanador ou Bombeiro Hidr�ulico  � um profissional na �rea da constru��o civil respons�vel pela instala��o e manuten��o de sistemas usados para �gua pot�vel, esgoto e drenagem em sistemas de encanamento.',							 'REGISTRADO'),
							('1', 'Eletricista', 'Eletrico',	'O Eletricista � o especialista em instala��es el�tricas residenciais e industriais. Eletricistas podem ser empregados em instala��o de novas componentes el�tricas ou em manuten��o e repara��o de infra-estruturas el�tricas existentes.', 'REGISTRADO'),
							('1', 'Pedreiro',	 'Constru��o',	'O Pedreiro � o profissional que constr�i ou reveste muros, paredes, escadas, vigas, lajes, tectos, telhados, chamin�s, etc., em edif�cios e outras obras de constru��o geralmente orientado pelo engenheiro ou Mestre de obras.',			 'REGISTRADO'),
							('1', 'Jardineiro',	 'Reparos',		'O Jardineiro � o profissional respons�vel por cuidar do jardim dos pr�dios, casas, empresas, parques, condom�nios, escolas e etc. � essencial que tenha conhecimentos b�sicos em rela��o o meio ambiente e esp�cies de plantas.',			 'REGISTRADO'),
							('1', 'Chaveiro',	 'Gerais',		'O Chaveiro � o profissional respons�vel por fabricar e fazer c�pias de chaves, trocar segredos e realizar manuten��o de fechaduras, al�m de vender equipamentos de seguran�a (cadeados, travas, chaves personalizadas etc.).',				 'REGISTRADO')
GO

CREATE TABLE SERVICOS_PROMOCIONAIS(
	SPROM_COD			INT			IDENTITY,
	FUNC_COD			INT			NOT NULL,
	SPROM_NOME			VARCHAR(50) NOT NULL,
	SPROM_AREA_ATUACAO	VARCHAR(20) NOT NULL,
	SPROM_DESCRICAO		TEXT		NULL,
	SPROM_DATA_INICIO	DATE		NOT NULL,
	SPROM_DATA_FIM		DATE		NOT NULL,
	SPROM_ESTADO		VARCHAR(15)		CHECK (SPROM_ESTADO IN('REGISTRADO', 'DELETADO')) NOT NULL,
	CONSTRAINT PK_SERVICOS_PROMOCIONAIS PRIMARY KEY(SPROM_COD),
	CONSTRAINT FK_SPROM_FUNC_COD FOREIGN KEY(FUNC_COD) REFERENCES FUNCIONARIOS(FUNC_COD))
GO



CREATE TABLE TRABALHOS(
	TRAB_COD			INT			 IDENTITY,
	FUNC_COD			INT			 NOT NULL,
	PROF_COD			INT			 NOT NULL,
	CLI_COD				INT			 NOT NULL,
	SERV_COD			INT			 NOT NULL,
	TRAB_DESCRICAO		TEXT		 NULL,
	TRAB_VALOR			DECIMAL(8,2) NOT NULL,
	TRAB_DATA_INICIO	DATE		 NOT NULL,
	TRAB_DATA_FIM		DATE		 NULL,
	TRAB_ESTADO		VARCHAR(15)		CHECK (TRAB_ESTADO IN('REGISTRADO', 'DELETADO')) NOT NULL,
	CONSTRAINT PK_TRABALHO PRIMARY KEY(TRAB_COD),
	CONSTRAINT FK_TRAB_FUNC_COD FOREIGN KEY(FUNC_COD) REFERENCES FUNCIONARIOS(FUNC_COD),
	CONSTRAINT FK_TRAB_PROF_COD FOREIGN KEY(PROF_COD) REFERENCES PROFISSIONAIS(PROF_COD),
	CONSTRAINT FK_TRAB_CLI_COD  FOREIGN KEY(CLI_COD)  REFERENCES CLIENTES(CLI_COD),
	CONSTRAINT FK_TRAN_SERV_COD FOREIGN KEY(SERV_COD) REFERENCES SERVICOS(SERV_COD))
GO

INSERT INTO TRABALHOS VALUES    ('1', '2', '1', '2', 'Trocar Lampada',		 '20.00',	'2019-05-28', '2019-05-28', 'REGISTRADO'),
								('1', '1', '1', '1', 'Desentupir pia.',		 '20.00',	'2019-05-29', null,  		'REGISTRADO'),
								('1', '3', '3', '4', 'Aparar todo o jardim', '100.00',	'2019-05-28', '2019-05-29', 'REGISTRADO'),
								('1', '1', '4', '3', 'Reforma no banheiro',  '2000.00', '2019-05-29', null,			'REGISTRADO'),
								('1', '4', '5', '2', 'Trocar Lampada',		 '15.00',	'2019-05-28', '2019-05-28', 'REGISTRADO')
GO

-- VERIFICANDO TABELAS

SELECT * FROM FUNCIONARIOS
GO

SELECT * FROM CLIENTES
GO

SELECT * FROM PROFISSIONAIS
GO

SELECT * FROM SERVICOS
GO

SELECT * FROM TRABALHOS
GO

-- QUERYS


-- Rela��o de profissionais com os servi�os
CREATE PROCEDURE sp_r_profissional_servi�os AS
SELECT P.PROF_COD, P.PROF_NOME, S.SERV_NOME 
FROM TRABALHOS AS T 
INNER JOIN PROFISSIONAIS AS P ON P.PROF_COD = T.PROF_COD 
INNER JOIN SERVICOS AS S ON S.SERV_COD = T.SERV_COD
ORDER BY P.PROF_COD
GO

-- Trabalhos concluidos
CREATE PROCEDURE sp_trabalhos_concluidos AS
SELECT * FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NOT NULL
GO

-- Trabalhos pendentes
CREATE PROCEDURE sp_trabalhos_pendentes AS
SELECT * FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NULL
GO

-- Quantidade de trabalhos
CREATE PROCEDURE sp_q_trabalhos AS
SELECT COUNT(TRAB_COD) AS 'Total de trabalhos' 
FROM TRABALHOS
GO

-- Quantidade de trabalhos concluidos
CREATE PROCEDURE sp_q_trabalhos_concluidos AS
SELECT COUNT(TRAB_COD) AS 'Trabalhos concluidos' 
FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NOT NULL
GO


-- Quantidade de trabalhos pendentes
CREATE PROCEDURE sp_q_tabalhos_pendentes AS
SELECT COUNT(TRAB_COD) AS 'Trabalhos pendentes' 
FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NULL
GO

-- Receita virtual(total a ser acumulada)
CREATE PROCEDURE sp_receita_vitual AS
SELECT SUM(TRAB_VALOR) AS 'Receita virtual' 
FROM TRABALHOS
GO

-- Receita real(total acumulada)
CREATE PROCEDURE sp_receita_real AS
SELECT SUM(TRAB_VALOR) AS 'Receita real'
FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NOT NULL
GO

-- Receita pendente
CREATE PROCEDURE sp_receita_pendente AS
SELECT SUM(TRAB_VALOR) AS 'Receita pendente' 
FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NULL
GO

-- Receita vitual de cada cliente
CREATE PROCEDURE sp_cliente_receita_virtual AS
SELECT C.CLI_COD, C.CLI_NOME, SUM(T.TRAB_VALOR) AS 'Receita virtual' 
FROM CLIENTES AS C LEFT JOIN TRABALHOS AS T ON T.CLI_COD = C.CLI_COD
GROUP BY C.CLI_COD, C.CLI_NOME
ORDER BY C.CLI_COD
GO

-- Receita real de cada cliente
CREATE VIEW TRAB_CONC AS
SELECT * FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NOT NULL
GO

CREATE PROCEDURE sp_cliente_receita_real AS
SELECT C.CLI_COD, C.CLI_NOME, SUM(T.TRAB_VALOR) AS 'Receita real'
FROM CLIENTES AS C LEFT JOIN TRAB_CONC AS T ON T.CLI_COD = C.CLI_COD
GROUP BY C.CLI_COD, C.CLI_NOME 
GO

-- Receita pendente de cada cliente
CREATE VIEW TRAB_PEN AS
SELECT * FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NULL
GO

CREATE PROCEDURE sp_cliente_receita_pendente AS
SELECT C.CLI_COD, C.CLI_NOME, SUM(T.TRAB_VALOR) AS 'Receita pendente'
FROM CLIENTES AS C LEFT JOIN TRAB_PEN AS T ON T.CLI_COD = C.CLI_COD
GROUP BY C.CLI_COD, C.CLI_NOME 
GO

-- Receita virtual de cada profissional
CREATE PROCEDURE sp_profissional_receita_virtual AS
SELECT P.PROF_COD, P.PROF_NOME, SUM(T.TRAB_VALOR) AS 'Receita virtual'
FROM PROFISSIONAIS AS P LEFT JOIN TRABALHOS AS T ON T.PROF_COD = P.PROF_COD
GROUP BY P.PROF_COD, P.PROF_NOME
GO

exec sp_profissional_receita_virtual
go

-- Receita real de cada profissional
CREATE VIEW TRAB_CONC AS
SELECT * FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NOT NULL
GO

CREATE PROCEDURE sp_profissional_receita_real AS
SELECT P.PROF_COD, P.PROF_NOME, SUM(T.TRAB_VALOR) AS 'Receita real'
FROM PROFISSIONAIS AS P LEFT JOIN TRAB_CONC AS T ON T.PROF_COD = P.PROF_COD
GROUP BY P.PROF_COD, P.PROF_NOME
GO

-- Receita pendente
CREATE VIEW TRAB_PEN AS
SELECT * FROM TRABALHOS
WHERE TRAB_DATA_FIM IS NULL
GO

CREATE PROCEDURE sp_profissional_receita_pendente AS
SELECT P.PROF_COD, P.PROF_NOME, SUM(T.TRAB_VALOR) AS 'Receita pendente'
FROM PROFISSIONAIS AS P LEFT JOIN TRAB_PEN AS T ON T.PROF_COD = P.PROF_COD
GROUP BY P.PROF_COD, P.PROF_NOME
GO

