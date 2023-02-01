create database LOGIN12
 use LOGIN12

 CREATE TABLE Usuario(
Usuario VARCHAR(25) PRIMARY KEY NOT NULL,
CONTRASEÑA VARCHAR(25),
ROLL VARCHAR(25)
)

INSERT USUARIO VALUES
('josh@gmail.com','1234','Administrador')
INSERT USUARIO VALUES
('jose@gmail.com','12346','usuario')
INSERT USUARIO VALUES
('fercho@gmail.com','12346','usuario')
INSERT USUARIO VALUES
('sergio@gmail.com','12347','secretario')

CREATE TABLE ADMINISTRADOR
(ID INT NOT NULL PRIMARY KEY,
USUARIO VARCHAR(25),
CONTRASEÑA VARCHAR(25),
ROL VARCHAR(25))

INSERT ADMINISTRADOR VALUES
('01', 'sergio@gmail.com', 12345, 'administrador')
INSERT ADMINISTRADOR VALUES
('02', 'pepe@gmail.com', 123456, 'cliente')
INSERT ADMINISTRADOR VALUES
('03', 'jorge@gmail.com', 123457, 'secretario')

select * from Usuario