CREATE DATABASE db_testes

USE db_testes

CREATE TABLE Usuarios (
	ID INT IDENTITY PRIMARY KEY,
	NOME VARCHAR(255),
	EMAIL VARCHAR(255),
	SENHA VARCHAR (255)
);

INSERT INTO Usuarios
VALUES ('NomeTeste','nome@teste.com','123123');

SELECT * FROM Usuarios

--Scaffold-DbContext "Server=localhost\SQLEXPRESS; Database=db_testes; Trusted_Connection=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Domains -ContextDir Contexts -Context TesteEFContext