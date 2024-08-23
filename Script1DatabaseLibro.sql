create table categoria(
	categoriaId int not null Identity,
	nombre nvarchar(120) not null
);

alter table categoria add constraint pk_categoria primary key (categoriaId);

create table libro(
	libroId int not null identity,
	titulo nvarchar(120) not null,
	descripcion nvarchar(120) not null,
	publicado datetime2 not null,
	precio numeric(7,2) not null,
	categoriaId int not null
);

alter table libro add constraint pk_libro primary key(LibroId);

alter table libro add constraint fk_libro_categoriaId foreign key (categoriaId)
references categoria(categoriaId) on delete cascade;

alter table libro add constraint uc_libro_titulo Unique(titulo);--restriccion para evitar repetir los nombres

-- Categoria
insert into categoria(nombre) values ('Cientificos');
insert into categoria(nombre) values ('Didacticos');
insert into categoria(nombre) values ('Programacion');
insert into categoria(nombre) values ('Estadisitca');
insert into categoria(nombre) values ('Algebra Lineal');

-- Libros
insert into libro(titulo, descripcion, publicado,	precio, categoriaId) values ('El origen de las especies',
'libros de la evolucion','07-31-1859',35,1);
insert into libro(titulo, descripcion, publicado,precio, categoriaId) values ('Breve historia del tiempo',
'libro acerca del tiempo','07-31-1988',38,1);
insert into libro(titulo, descripcion, publicado,precio, categoriaId) values ('Clean Code',
'Buenas Practicas de Programacion','07-31-2005',40,3);
INSERT INTO Libro (Titulo, Descripcion, Publicado, Precio,CategoriaId)VALUES ('El programador Pragmatico','Buenas Practicas de Programacion','07-31-2015',43,3);