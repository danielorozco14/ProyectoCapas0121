--Tabla libro
CREATE TABLE libro(
	idlibro integer primary key identity,
	isbm nvarchar(30)null,
	titulo nvarchar(200) null,
	autor nvarchar(200) null,
	editorial nvarchar(200) null,
	anioEdicion nvarchar(5) null,
	numeroEdicion nvarchar(20)null,
	pais nvarchar(30),
	idioma nvarchar(20),
	materia nvarchar(30),
	numeroPaginas nvarchar(10),
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

insert into rol(nombre,descripcion) values('Administrador','Personal encargado de la administracion del sistema.')
insert into rol(nombre,descripcion) values('Profesor','Personal que tiene la habilidad de prestar libros en el sistema.')


--Tabla Persona
CREATE TABLE persona (
	idpersona integer primary key identity,
	nombre varchar(50) not null,
	apellido varchar(50)not null,
	edad integer null,
	telefono varchar(20) null,
	email varchar(50),
	clave varchar(MAX)not null,
	estado bit default (1),
	idrol integer null,
	FOREIGN KEY (idrol) references rol(idrol)
);

drop table persona
drop table prestamo

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
create proc all_persons
as
select idpersona as Codigo, nombre as Nombre, apellido as Apellido, telefono as Telefono, edad as Edad
from persona
order by idpersona desc
go

--Procedimiento Buscar persona
create proc find_person
@paramm varchar(50)
as
select idpersona as ID, nombre as Nombre, apellido as Apellido, telefono as Telefono, edad as Edad
from persona
where nombre like '%' + @paramm + '%' or apellido like '%' + @paramm + '%'
order by nombre desc
go

--Procedimiento Insertar persona
create proc add_person
@nombre varchar(50),
@apellido varchar(255),
@telefono varchar(20),
@edad integer
as
insert into persona (nombre,apellido,telefono,edad) values (@nombre,@apellido,@telefono,@edad)
go

--Procedimiento Actualizar persona
create proc update_person
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
create proc delete_person
@idpersona int
as
delete from persona
where idpersona=@idpersona
go

--Para ver si la persona ya existe
create proc if_person_exists
@paramm varchar(100),
@paramm1 varchar(100),
@exist bit output
as
	if exists (select nombre from persona where nombre = ltrim(rtrim(@paramm)) and apellido = ltrim(rtrim(@paramm1)))
		begin
			set @exist = 1
		end
	else
		begin
			set @exist = 0
		end

--Procedimiento Listar libro
create proc all_books
as
select idlibro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, isbm as ISBM, anioEdicion as Anio_de_Edicion, numeroEdicion as Numero_de_Edicion,
	pais as Pais, idioma as Idioma, materia as Materia, numeroPaginas as Numero_Paginas, ubicacionEstante as Ubicacion,descripcion as Descripcion, estado as Estado
from libro
order by idlibro desc
go

--Procedimiento Listar libro
create proc get_book_state_asTrue
as
select idlibro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, isbm as ISBM, anioEdicion as Anio_de_Edicion, numeroEdicion as Numero_de_Edicion,
	pais as Pais, idioma as Idioma, materia as Materia, numeroPaginas as Numero_Paginas, ubicacionEstante as Ubicacion,descripcion as Descripcion, estado as Estado
from libro
where estado = 1
order by idlibro desc
go


--Procedimiento Buscar libro
create proc find_book
@paramm varchar(50)
as
select idlibro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, isbm as ISBM, anioEdicion as Anio_de_Edicion, numeroEdicion as Numero_de_Edicion,
	pais as Pais, idioma as Idioma, materia as Materia, numeroPaginas as Numero_Paginas, ubicacionEstante as Ubicacion,descripcion as Descripcion
from libro
where titulo like '%' + @paramm + '%' or autor like '%' + @paramm + '%' 
order by idlibro desc
go

--Procedimiento Buscar libro por titulo
create proc find_book_by_title
@paramm varchar(50)
as
select idlibro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, isbm as ISBM, anioEdicion as Anio_de_Edicion, numeroEdicion as Numero_de_Edicion,
	pais as Pais, idioma as Idioma, materia as Materia, numeroPaginas as Numero_Paginas, ubicacionEstante as Ubicacion,descripcion as Descripcion
from libro
where titulo like '%' + @paramm + '%'
order by idlibro desc
go

--Procedimiento Buscar libro por autor
create proc find_book_by_author
@paramm varchar(50)
as
select idlibro as Codigo, titulo as Titulo, autor as Autor, editorial as Editorial, isbm as ISBM, anioEdicion as Anio_de_Edicion, numeroEdicion as Numero_de_Edicion,
	pais as Pais, idioma as Idioma, materia as Materia, numeroPaginas as Numero_Paginas, ubicacionEstante as Ubicacion,descripcion as Descripcion
from libro
where autor like '%' + @paramm + '%' 
order by idlibro desc
go

--Procedimiento Insertar libro
create proc add_book
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
create proc update_book
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
create proc delete_book
@idlibro int
as
delete from libro
where idlibro=@idlibro
go

--Para ver si el libro ya existe
create proc book_existence
@paramm int,
@exists bit output
as
	if exists (select idlibro from libro where idlibro = ltrim(rtrim(@paramm)))
		begin
			set @exists = 1
		end
	else
		begin
			set @exists = 0
		end
select * from libro


--Procedimiento Listar prestamo
create proc all_loans
as
select prestamo.idpersona as CodigoProfesor,prestamo.idLibro as CodigoLibro,libro.titulo as Libro,persona.nombre + ' '+persona.apellido as Profesor, fechaPrestamo as Fecha_Prestamo, fechaDevolucion as Fecha_Devolucion
from prestamo inner join persona on prestamo.idpersona = persona.idpersona inner join libro on prestamo.idlibro = libro.idlibro
where prestamo.estado = 1
order by persona.idpersona desc
go

--Procedimiento Listar prestamo por profesor
create proc list_proffesor_loans
@paramm int
as
select prestamo.idpersona as CodigoProfesor,prestamo.idLibro as CodigoLibro,libro.titulo as Libro,persona.nombre + ' '+persona.apellido as Profesor,
	fechaPrestamo as Fecha_Prestamo, 
	fechaDevolucion as Fecha_Devolucion
from prestamo inner join persona on prestamo.idpersona = persona.idpersona inner join libro on prestamo.idlibro = libro.idlibro
where prestamo.estado = 1 and prestamo.idpersona = @paramm
order by persona.idpersona desc
go


--Procedimiento Buscar prestamo
create proc find_loan
@paramm1 varchar(50),
@paramm2 varchar(50)
as
select persona.idpersona as Profesor, libro.titulo as Libro, fechaDevolucion as Fecha_Prestamo, fechaDevolucion as Fecha_Devolucion
from prestamo inner join persona on prestamo.idpersona = persona.idpersona inner join libro on prestamo.idlibro = libro.idlibro
where persona.idpersona like '%' + @paramm1 + '%' and prestamo.idlibro like '%' + @paramm2
order by persona.idpersona desc
go

--Procedimiento Insertar prestamo
create proc add_loan
@idpersona integer,
@idlibro integer,
@fechaPrestamo date,
@fechaDevolucion date
as
insert into prestamo(idpersona,idlibro,fechaPrestamo,fechaDevolucion) values (@idpersona,@idlibro,@fechaPrestamo,@fechaDevolucion)
go

--Procedimiento Actualizar prestamo
create proc update_loan
@idpersona int,
@idlibro int,
@prestamo varchar(255),
@devol varchar(20),
@estado integer
as
update prestamo set idpersona=@idpersona, idlibro=@idlibro, fechaDevolucion=@devol, fechaPrestamo=@prestamo, estado=@estado
where idpersona=@idpersona and idlibro=@idlibro
go


--Para ver si prestamo ya existe
create proc if_loan_exist
@paramm1 varchar(100),
@paramm2 varchar(100),
@exists bit output
as
	if exists (select idpersona,idlibro from prestamo where idlibro = ltrim(rtrim(@paramm1)) and idpersona = ltrim(rtrim(@paramm2)))
		begin
			set @exists = 1
		end
	else
		begin
			set @exists = 0
		end


--Activar libro
create proc activate_book
@IdLibro int
as 
update libro set estado=1
where idlibro = @IdLibro
go

--Desactivar libro
create proc deactivate_book
@IdLibro int
as 
update libro set estado=0
where idlibro = @IdLibro
go

--Desactivar prestamo
create proc deactivate_loan
@IdLibro int,
@Idpersona int
as 
update prestamo set estado=0
where idlibro = @IdLibro and idpersona = @Idpersona
go

SELECT * FROM PRESTAMO;

--Usuario login
create proc person_login
@email varchar(50),
@clave varchar(50)
as select persona.idpersona, persona.idrol,rol.nombre as rol,persona.nombre, persona.estado
from persona inner join rol on persona.idrol = rol.idrol
where persona.email=@email and persona.clave=HASHBYTES('SHA2_256',@clave)
go



insert into libro(isbm,autor,titulo) values('AEC-3423','John K.K Willems','Another Day in Hell')
insert into persona(nombre,apellido,idrol,email,clave) values('Jorge','Oliva','1','jorge@gmail.com',HASHBYTES('SHA2_256','dummy'))
insert into persona(nombre,apellido,idrol,email,clave) values('Daniel','Orozco','2','daniel@gmail.com',HASHBYTES('SHA2_256','dummy'))
insert into persona(nombre,apellido,idrol,email,clave) values('Diego','Gomez','1','diego@gmail.com',HASHBYTES('SHA2_256','dummy'))


insert into persona(nombre,apellido) values('Ssandro','Ortiz')
insert into persona(nombre,apellido) values('Daniel','Orozco')
insert into persona(nombre,apellido) values('Diego','Gomez')

exec prestamo_desactivar 6,7;

select * from prestamo

create database ProyectoCapas;
