CREATE DATABASE BATTLESHIP
GO

CREATE TABLE BOARD
(
	RowNo varchar(10),
	ColNo nchar(10),
	BoardID int,
	CellValue int,
	CONSTRAINT PK_BOARD PRIMARY KEY (RowNo, ColNo, BoardID)	
)
GO

CREATE UNIQUE NONCLUSTERED INDEX IX_Matrices ON dbo.BOARD
    (ColNo, RowNo); 
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
	BoardID int REFERENCES BOARD(BOARDID), 
	StratID int REFERENCES STRATEGIES(STRATID),
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
	BoardID int REFERENCES BOARD(BOARDID), 
	StratID int REFERENCES STRATEGIES(STRATID),
	Shots smallint,
	Failed smallint,
	Hits smallint,
	ShotHistory varchar(200),
	SunkShips smallint,
	Turns smallint,
	Result char(1)

	CONSTRAINT PK_OFFENSEEXPERIENCE PRIMARY KEY (BOARDID, STRATID)
)
