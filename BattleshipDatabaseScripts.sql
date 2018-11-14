CREATE DATABASE BATTLESHIP
GO

USE BATTLESHIP
GO
CREATE TABLE BOARD
(
	RowNo binary(1),
	Value1 bit,
	Value2 bit,
	Value3 bit,
	Value4 bit,
	Value5 bit,
	Value6 bit,
	Value7 bit,
	Value8 bit,
	Value9 bit,
	Value10 bit,
	BoardID int,
	CONSTRAINT PK_BOARD PRIMARY KEY (RowNo, BoardID)
)
GO

CREATE UNIQUE NONCLUSTERED INDEX IX_Matrices ON dbo.BOARD
    (RowNo); 
GO

CREATE TABLE STRATEGIES
(
	StratID smallint PRIMARY KEY,
	Name varchar(20),
	Performance smallint
)
GO

CREATE TABLE OFFENSEEXPERIENCE
(
	StratID smallint Not NULL,
	BoardID int Not NULL,
	Shots smallint,
	Failed smallint,
	Hits smallint,
	ShotHistory varchar(200),
	SunkShips smallint,
	Turns smallint,
	Result char(1)
	CONSTRAINT PK_OFFENSEEXPERIENCE PRIMARY KEY (BOARDID, STRATID)
)
GO

CREATE TABLE DEFENSEEXPERIENCE
(
	BoardID int NOT NULL, 
	StratID smallint NOT NULL,
	Shots smallint,
	Failed smallint,
	Hits smallint,
	ShotHistory varchar(200),
	SunkShips smallint,
	Turns smallint,
	Result char(1)

	CONSTRAINT PK_DEFENSEEXPERIENCE PRIMARY KEY (BOARDID, STRATID)
)

DROP DATABASE BATTLESHIP
