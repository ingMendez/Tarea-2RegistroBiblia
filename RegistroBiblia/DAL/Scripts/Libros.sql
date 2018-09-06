CREATE DATABASE LibrosDB
go
use LibrosDB
go
CREATE TABLE Libros
(
libroId int primary key identity,
descripcion varchar(50),
siglas varchar(20),
tipoId varchar(40),
);