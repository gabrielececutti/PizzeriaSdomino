CREATE DATABASE Sdomino
GO
USE Sdomino
GO

CREATE TABLE [Order] (
Id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Description nvarchar(500) NOT NULL,
TotalPrice INT NOT NULL
)

CREATE TABLE Receipt (
Id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
OrderId INT NOT NULL FOREIGN KEY REFERENCES [Order](Id),
Date DateTime NOT NULL
)
delete from [Order]
delete from Receipt

select * from [Order]
select * from Receipt