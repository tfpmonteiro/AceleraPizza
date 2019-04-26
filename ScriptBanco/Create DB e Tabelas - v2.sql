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
	IdIngrediente uniqueidentifier CONSTRAINT [PK_IdIngrediente] PRIMARY KEY, 
	Descricao varchar(100) NOT NULL,
	Valor decimal NOT NULL	
	);

	CREATE TABLE Pizza(
	IdPizza uniqueidentifier NOT NULL CONSTRAINT [PK_IdPizza] PRIMARY KEY,
	IdCliente uniqueidentifier NOT NULL CONSTRAINT FK_IdCliente FOREIGN KEY REFERENCES Cliente (IdCliente),
	Tamanho int NOT NULL,
	Borda int NOT NULL,
	);
	
	CREATE TABLE Pedido(
	IdPedido uniqueidentifier CONSTRAINT [PK_IdPedido] PRIMARY KEY, 
	IdCliente uniqueidentifier NOT NULL CONSTRAINT [FK_IdCliente] FOREIGN KEY REFERENCES Cliente (IdCliente),
	IdPizza uniqueidentifier NOT NULL CONSTRAINT [FK_IdPizza] FOREIGN KEY REFERENCES Pizza (IdPizza),
	DataPedido smalldatetime NOT NULL,
	);

	
	CREATE TABLE PizzaIngrediente(
	IdPizIng uniqueidentifier NOT NULL CONSTRAINT [PK_IdPizIng] PRIMARY KEY,
	IdPizza uniqueidentifier NOT NULL CONSTRAINT [FK_IdPizza] FOREIGN KEY REFERENCES Pizza (IdPizza),
	IdIngrediente uniqueidentifier NOT NULL CONSTRAINT [FK_Ingrediente] FOREIGN KEY REFERENCES Ingredientes (Idingrediente),
	QtdIng decimal NOT NULL,
	);


	