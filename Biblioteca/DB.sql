--Tabla libro
CREATE TABLE libro(
	idlibro integer primary key identity,
	isbm nvarchar(30)null,
	titulo nvarchar(200) null,
	autor nvarchar(200) null,
	editorial nvarchar(200) null,
	anioEdicion year(4) null,
	numeroEdicion nvarchar(20)null,
	pais nvarchar(30),
	idioma nvarchar(20),
	materia nvarchar(30),
	numeroPaginas int(10),
	ubicacionEstante nvarchar(10),
	descripcion nvarchar(300),
	estado bit default(1)
);

--Tabla Rol
CREATE TABLE rol(
	idrol integer primary key identity,
	nombre varchar(20)not null,
	descripcion varchar(200) null,
	estado bit default(1)
);

--Tabla Persona
CREATE TABLE persona (
	idpersona integer primary key identity,
	nombre varchar(50) not null,
	apellido varchar(50)not null,
	edad integer null,
	telefono varchar(20) null,
	idrol integer null,
	FOREIGN KEY (idrol) references rol(idrol)
);

--Tabla Prestamos
CREATE TABLE prestamo(
	idpersona integer not null,
	idlibro integer not null,
	fechaPrestamo date,
	fechaDevolucion date,
	estado bit default(1),
	FOREIGN KEY (idpersona) references persona(idpersona),
	FOREIGN KEY (idlibro) references libro(idlibro),
);

--Procedimiento Listar persona
create proc persona_listar
as
select idpersona as Codigo, nombre as Nombre, apellido as Apellido, telefono as Telefono, edad as Edad
from persona
order by idpersona desc
go

--Procedimiento Buscar persona
create proc persona_buscar
@valor varchar(50)
as
select idpersona as ID, nombre as Nombre, apellido as Apellido, telefono as Telefono, edad as Edad
from persona
where nombre like '%' + @valor + '%' or apellido like '%' + @valor + '%'
order by nombre desc
go

--Procedimiento Insertar persona
create proc persona_insertar
@nombre varchar(50),
@apellido varchar(255),
@telefono varchar(20),
@edad integer
as
insert into persona (nombre,apellido,telefono,edad) values (@nombre,@apellido,@telefono,@edad)
go

--Procedimiento Actualizar persona
create proc persona_actualizar
@idpersona int,
@nombre varchar(50),
@apellido varchar(255),
@telefono varchar(20),
@edad integer
as
update persona set nombre=@nombre, apellido=@apellido, telefono=@telefono, edad=@edad
where idpersona=@idpersona
go

--Procedimiento Eliminar persona
create proc persona_eliminar
@idpersona int
as
delete from persona
where idpersona=@idpersona
go

--Para ver si la persona ya existe
create proc persona_existe
@valor varchar(100),
@valor2 varchar(100),
@existe bit output
as
	if exists (select nombre from persona where nombre = ltrim(rtrim(@valor)) and apellido = ltrim(rtrim(@valor2)))
		begin
			set @existe = 1
		end
	else
		begin
			set @existe = 0
		end

--Procedimiento Listar libro
create proc libro_listar
as
select idlibro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, isbm as ISBM, anioEdicion as Anio_de_Edicion, numeroEdicion as Numero_de_Edicion,
	pais as Pais, idioma as Idioma, materia as Materia, numeroPaginas as Numero_Paginas, ubicacionEstante as Ubicacion,descripcion as Descripcion
from libro
where estado = 1
order by idlibro desc
go

--Procedimiento Buscar libro
create proc libro_buscar
@valor varchar(50)
as
select idlibro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, isbm as ISBM, anioEdicion as Anio_de_Edicion, numeroEdicion as Numero_de_Edicion,
	pais as Pais, idioma as Idioma, materia as Materia, numeroPaginas as Numero_Paginas, ubicacionEstante as Ubicacion,descripcion as Descripcion
from libro
where titulo like '%' + @valor + '%' or autor like '%' + @valor + '%'
order by idlibro desc
go


--Procedimiento Insertar libro
create proc libro_insertar
@isbm nvarchar(30)null,
@titulo nvarchar(200) null,
@autor nvarchar(200) null,
@editorial nvarchar(200) null,
@anioEdicion nvarchar(5) null,
@numeroEdicion nvarchar(20)null,
@pais nvarchar(30),
@idioma nvarchar(20),
@materia nvarchar(30),
@numeroPaginas nvarchar(10),
@ubicacionEstante nvarchar(10),
@descripcion nvarchar(300)
as
insert into libro (isbm,titulo,autor,editorial,anioEdicion,numeroEdicion,pais,idioma,materia,numeroPaginas,ubicacionEstante,descripcion) values (@isbm,@titulo,@autor,@editorial,@anioEdicion,@numeroEdicion,@pais,@idioma,@materia,@numeroPaginas,@ubicacionEstante,@descripcion)
go


--Procedimiento actualizar libro
create proc libro_actualizar
@idlibro int,
@isbm nvarchar(30) null,
@titulo nvarchar(200) null,
@autor nvarchar(200) null,
@editorial nvarchar(200) null,
@anioEdicion nvarchar(5) null,
@numeroEdicion nvarchar(20)null,
@pais nvarchar(30),
@idioma nvarchar(20),
@materia nvarchar(30),
@numeroPaginas nvarchar(10),
@ubicacionEstante nvarchar(10),
@descripcion nvarchar(300),
@estado bit
as
update libro set isbm=@isbm, titulo=@titulo, autor=@autor, editorial=@editorial, anioEdicion=@anioEdicion,
	numeroEdicion=@numeroEdicion,pais=@pais,idioma=@idioma,materia=@materia,numeroPaginas=@numeroPaginas,ubicacionEstante=@ubicacionEstante,
	descripcion=@descripcion,estado=@estado	
where idlibro=@idlibro
go

--Procedimiento Eliminar libro
create proc libro_eliminar
@idlibro int
as
delete from libro
where idlibro=@idlibro
go

--Para ver si el libro ya existe
create proc libro_existe
@valor varchar(100),
@valor2 varchar(100),
@existe bit output
as
	if exists (select titulo from libro where titulo = ltrim(rtrim(@valor)) and autor = ltrim(rtrim(@valor2)))
		begin
			set @existe = 1
		end
	else
		begin
			set @existe = 0
		end

--Procedimiento Listar prestamo
create proc prestamo_listar
as
select persona.idpersona as Profesor, libro.titulo as Libro, fechaDevolucion as Fecha_Prestamo, fechaDevolucion as Fecha_Devolucion
from prestamo inner join persona on prestamo.idpersona = persona.idpersona inner join libro on prestamo.idlibro = libro.idlibro
where prestamo.estado = 1
order by persona.idpersona desc
go

--Procedimiento Buscar prestamo
create proc prestamo_buscar
@valor varchar(50),
@valor2 varchar(50)
as
select persona.idpersona as Profesor, libro.titulo as Libro, fechaDevolucion as Fecha_Prestamo, fechaDevolucion as Fecha_Devolucion
from prestamo inner join persona on prestamo.idpersona = persona.idpersona inner join libro on prestamo.idlibro = libro.idlibro
where persona.idpersona like '%' + @valor + '%' and prestamo.idlibro like '%' + @valor2
order by persona.idpersona desc
go

--Procedimiento Insertar prestamo
create proc prestamo_insertar
@idpersona integer,
@idlibro integer,
@fechaPrestamo date,
@fechaDevolucion date
as
insert into prestamo(idpersona,idlibro,fechaPrestamo,fechaDevolucion) values (@idpersona,@idlibro,@fechaPrestamo,@fechaDevolucion)
go

--Procedimiento Actualizar prestamo
create proc prestamo_actualizar
@idpersona int,
@idlibro int,
@prestamo varchar(255),
@devol varchar(20),
@estado integer
as
update prestamo set idpersona=@idpersona, idlibro=@idlibro, fechaDevolucion=@devol, fechaPrestamo=@prestamo, estado=@estado
where idpersona=@idpersona and idlibro=@idlibro
go

--Procedimiento Eliminar prestamo
--Este nunca se va a usar
create proc prestamo_eliminar
@idlibro int,
@idpersona int
as
delete from prestamo
where idlibro=@idlibro and idpersona=@idpersona
go


--Para ver si prestamo ya existe
create proc prestamo_existe
@valor varchar(100),
@valor2 varchar(100),
@existe bit output
as
	if exists (select idpersona,idlibro from prestamo where idlibro = ltrim(rtrim(@valor)) and idpersona = ltrim(rtrim(@valor2)))
		begin
			set @existe = 1
		end
	else
		begin
			set @existe = 0
		end


--Activar libro
create proc libro_activar
@IdLibro int
as 
update libro set estado=1
where idlibro = @IdLibro
go

--Desactivar libro
create proc libro_desactivar
@IdLibro int
as 
update libro set estado=0
where idlibro = @IdLibro
go

--Desactivar prestamo
create proc prestamo_desactivar
@IdLibro int,
@Idpersona int
as 
update prestamo set estado=0
where idlibro = @IdLibro and idpersona = @Idpersona
go