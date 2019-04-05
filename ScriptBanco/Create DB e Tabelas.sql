--create database ACELERAPIZZA

use ACELERAPIZZA

CREATE TABLE Cliente(
	IdCliente uniqueidentifier CONSTRAINT [PK_IdCliente] PRIMARY KEY, 
	Nome varchar(100) NOT NULL,
	CPF varchar(14) NOT NULL,
	Telefone varchar(11) NOT NULL,
	DataNascimento smalldatetime NOT NULL,
	Endereco varchar(500) NULL
	);

	CREATE TABLE Ingredientes(
	IdIngredientes uniqueidentifier CONSTRAINT [PK_IdIngredientes] PRIMARY KEY, 
	Descricao varchar(100) NOT NULL,
	Valor decimal NOT NULL	
	);

	CREATE TABLE Pedido(
	IdPedido uniqueidentifier CONSTRAINT [PK_IdPedido] PRIMARY KEY, 
	Descricao varchar(100) NOT NULL,
	Valor decimal NOT NULL	
	);