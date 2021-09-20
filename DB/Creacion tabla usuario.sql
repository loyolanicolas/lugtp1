

CREATE TABLE Usuario(
	IdUsuario int IDENTITY(1,1) NOT NULL,
	NombreUsuario varchar(50) NOT NULL,
	Pass nvarchar(300) NOT NULL,
 CONSTRAINT PK_Usuario PRIMARY KEY CLUSTERED (IdUsuario)
)
