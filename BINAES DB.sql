--CREACION DE BASE--
CREATE DATABASE BINAES;

--USO DE BASE--
USE BINAES;

--CREACION DE TABLAS--
CREATE TABLE ADMINISTRADOR(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Usuario VARCHAR(30) NOT NULL,
	Contraseña VARCHAR(30) NOT NULL
);

CREATE TABLE PISO(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Numero INT NOT NULL
);

CREATE TABLE AREA(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(40) NOT NULL,
	Descripcion VARCHAR(200) NOT NULL,
	Horario VARCHAR(30) NOT NULL,
	Responsable VARCHAR(40) NOT NULL,
	Id_Piso INT FOREIGN KEY REFERENCES PISO(Id)
);

CREATE TABLE EVENTO(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Titulo VARCHAR(50) NOT NULL,
	Imagen VARCHAR(50),
	FechaHora_Inicio DATETIME NOT NULL,
	FechaHora_Fin DATETIME NOT NULL,
	CantidadParticipantes INT NOT NULL,
	Id_Area INT FOREIGN KEY REFERENCES AREA(Id)
);

CREATE TABLE OBJETIVO(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Objectivo VARCHAR(200) NOT NULL,
	Id_Evento INT FOREIGN KEY REFERENCES EVENTO(Id)
);

CREATE TABLE COLECCION(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(40) NOT NULL,
	Tipo VARCHAR(40) NOT NULL,
	Genero VARCHAR(40) NOT NULL,
	Id_Area INT FOREIGN KEY REFERENCES Area(Id)
);

CREATE TABLE FORMATO(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Tipo VARCHAR(7) NOT NULL
);

CREATE TABLE MATERIAL(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(80) NOT NULL,
	Portada VARCHAR(50) NOT NULL,
	Autor VARCHAR(40) NOT NULL,
	Idioma VARCHAR(25) NOT NULL,
	Editorial VARCHAR(40) NOT NULL,
	Fecha_Publicacion DATE NOT NULL,
	Id_Formato INT FOREIGN KEY REFERENCES FORMATO(Id) NOT NULL,
	Id_Coleccion INT FOREIGN KEY REFERENCES COLECCION(Id) NOT NULL
);

CREATE TABLE ETIQUETA(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Codigo VARCHAR(4) NOT NULL,
	Id_Material INT FOREIGN KEY REFERENCES MATERIAL(Id) NOT NULL
);

CREATE TABLE PALABRAS(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Palabra VARCHAR(40) NOT NULL,
	Id_Material INT FOREIGN KEY REFERENCES MATERIAL(id) NOT NULL
);

CREATE TABLE USUARIO(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(40) NOT NULL,
	Direccion VARCHAR(100) NOT NULL,
	Institucion VARCHAR(80) NOT NULL,
	Telefono VARCHAR(9) NOT NULL CHECK(Telefono LIKE '[2|6|7][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
	Correo VARCHAR(80) CHECK(correo LIKE '%@%.%'),
	Fotografia VARCHAR(50) NOT NULL,
	Ocupacion VARCHAR(30) NOT NULL
);

CREATE TABLE PRESTAMO(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FechaHora_Prestamo DATETIME NOT NULL,
	FechaHora_Devolucion DATETIME NOT NULL,
	Id_Material INT FOREIGN KEY REFERENCES MATERIAL(Id) NOT NULL,
	Id_Usuario INT FOREIGN KEY REFERENCES USUARIO(Id) NOT NULL
);

CREATE TABLE RESERVA(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FechaHora_Reserva DATETIME NOT NULL,
	FechaHora_Prestamo DATETIME NOT NULL,
	FechaHora_Devolucion DATETIME NOT NULL,
	Id_Material INT FOREIGN KEY REFERENCES MATERIAL(Id) NOT NULL,
	Id_Usuario INT FOREIGN KEY REFERENCES USUARIO(Id) NOT NULL
);

--DATOS INICIALES--

			--PISOS--
INSERT INTO PISO
	VALUES (1);

INSERT INTO PISO
	VALUES (2);

INSERT INTO PISO
	VALUES (3);

INSERT INTO PISO
	VALUES (4);

--
			--AREAS--
--PISO 1--
INSERT INTO AREA
    VALUES ('Salon lúdico 1','Area de libros y entretenimiento para niños','7:00 AM a 10:00 PM','Javier Barrera',1);

INSERT INTO AREA
    VALUES ('Auditorium','Sala reservada para lecturas Publicas, conferencias y presentaciones','8:00 AM a 8:00PM','Gilberto San Roman',1);

INSERT INTO AREA
    VALUES ('Area de computacion 1A','Sala de computacion para prestamos de equipos informaticos','7:00 AM a 10:00PM','Juan Gonzalo',1);

INSERT INTO AREA
    VALUES ('Area de computacion 1B','Sala de computacion para prestamos de equipos informaticos','7:00 AM a 10:00PM','Núria Eva',1);

INSERT INTO AREA
    VALUES ('Area de Biblioteca 1A','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00 AM a 10:00PM','Benito Galeano',1);

INSERT INTO AREA
    VALUES ('Area de Biblioteca 1B','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00 AM a 10:00PM','Guilermo Peinado',1);

INSERT INTO AREA
    VALUES ('Area de promocion a la inclusion','Área de promoción de la autonomía personal e inclusión social','7:00AM a 10:00PM','Nacho Ocana',1);
    
INSERT INTO AREA
    VALUES ('Area de promocion a la inclusion','Área de promoción de la autonomía personal e inclusión social ','7:00AM a 10:00PM','Mercedes Deliz',1);
--PISO 2--
INSERT INTO AREA
    VALUES ('Salon lúdico 2','Area de libros y entretenimiento para niños','7:00AM a 10:00PM','Noelia Gonsales',2);

INSERT INTO AREA
    VALUES ('Sala de proyeccion 1','Sala para la exhibición de películas compuesto por lo general de una pantalla de proyección y un patio de butacas.','7:00 AM a 10:00PM','Aina Gaona',2);

INSERT INTO AREA
    VALUES ('Area de computacion 2A','Sala de computacion para prestamos de equipos informaticos','7:00 AM a 10:00PM','Marcela Escoto',2);

INSERT INTO AREA
    VALUES ('Area de computacion 2B','Sala de computacion para prestamos de equipos informaticos','7:00 AM a 10:00PM','Aina Gaona',2);

INSERT INTO AREA
    VALUES ('Area de biblioteca 2A','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00 AM a 10:00PM','Rosita Duenas',2);

INSERT INTO AREA
    VALUES ('Area de biblioteca 2B','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00 AM a 10:00PM','Leocadio De Santiago',2);

--PISO 3--
INSERT INTO AREA
    VALUES ('Sala de proyeccion 2','Sala para la exhibición de películas compuesto por lo general de una pantalla de proyección y un patio de butacas.','7:00AM a 10:00PM','Ricarda Tijerina',3);

INSERT INTO AREA
    VALUES ('Area de computacion 3A','Sala de computacion para prestamos de equipos informaticos','7:00AM a 10:00PM','Estela Caba',3);

INSERT INTO AREA
    VALUES ('Area de computacion 3B','Sala de computacion para prestamos de equipos informaticos','7:00AM a 10:00PM','Estela Caba',3);

INSERT INTO AREA
    VALUES ('Area de biblioteca 3A','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00 M a 10:00PM','Roque Bailon',3);

INSERT INTO AREA
    VALUES ('Area de biblioteca 3B','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00 M a 10:00PM','Roque Bailon',3);

--PISO 4--
INSERT INTO AREA
    VALUES ('Sala de proyeccion 3','Sala para la exhibición de películas compuesto por lo general de una pantalla de proyección y un patio de butacas.','7:00AM a 10:00PM','Ricarda Tijerina',4);

INSERT INTO AREA
    VALUES ('Area de computacion 4A','Sala de computacion para prestamos de equipos informaticos','7:00AM a 10:00PM','Nacho Ocana',4);

INSERT INTO AREA
    VALUES ('Area de computacion 4B','Sala de computacion para prestamos de equipos informaticos','7:00AM a 10:00PM','Nacho Ocana',4);

INSERT INTO AREA
    VALUES ('Sala de Investigacion 1','Sala de desarrollos para investigaciones','7:00AM a 10:00PM','Juan Gonzalo',4);

INSERT INTO AREA
    VALUES ('Sala de Investigacion 2','Sala de desarrollos para investigaciones','7:00AM a 10:00PM','Benito Galeano',4);

INSERT INTO AREA
    VALUES ('Area de biblioteca 4A','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00AM a 10:00PM','Aina Gaona',4);


INSERT INTO AREA
    VALUES ('Area de biblioteca 4B','Sala de lectura individual con la mayor cantidad de materiales y ejemplares','7:00AM a 10:00PM','Aina Gaona',4);


--
			--EVENTOS--
INSERT INTO EVENTO
	VALUES ('Lectura Infantil by Alberto Bonilla','./Resouces/src_EVENT/lectura_infantil_by_alberto_bonilla.png',CONVERT(datetime,'23-07-22 4:00 PM',5),CONVERT(datetime,'23-07-22 5:00 PM',5),50,9);

INSERT INTO EVENTO
	VALUES ('Competencia de programacion','',CONVERT(datetime,'25-06-22 1:00 PM',5),CONVERT(datetime,'25-06-22 3:00 PM',5),65,21);

INSERT INTO EVENTO
	VALUES ('Conferencia de Becas Internacionales','',CONVERT(datetime,'26-07-22 9:00 AM',5),CONVERT(datetime,'26-07-22 11:00 AM',5),150,2);

--
			--COLECCION--
INSERT INTO COLECCION
	VALUES ('Libros de ficcion','libros','Ciencia Ficcion',6);

INSERT INTO COLECCION
	VALUES ('Audios en ingles','Audios','Vocabulario',6);

INSERT INTO COLECCION
	VALUES ('Mangas de shounen','Mangas','Accion',6);

--


SELECT id, nombre
FROM AREA;
