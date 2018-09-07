create DATABASE LibrosDB
GO
USE LibrosDB
GO
CREATE TABLE Libros
(
LibroId int primary key identity,
Descripcion varchar(50),
Siglas varchar(20),
TipoId varchar(40),
);

select * from Libros