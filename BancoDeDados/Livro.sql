CREATE TABLE Livro (
id int PRIMARY KEY auto_increment,
titulo varchar (100) NOT NULL,
genero VARCHAR (30) NOT NULL,
editora varchar (50) NOT NULL,
isbn varchar (15) NOT NULL UNIQUE,
autor varchar (100) NOT NULL
);