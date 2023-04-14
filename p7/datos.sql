create DATABASE mibasesamuelalegre2;
use mibasesamuelalegre2;

CREATE TABLE USUARIO (
  CI INT PRIMARY KEY,
  Usuario VARCHAR(50),
  Password VARCHAR(50),
  Rol VARCHAR(50)
);

CREATE TABLE PERSONA (
  CI INT PRIMARY KEY,
  Nombre_comp VARCHAR(50),
  Fecha_nac DATE,
  Telefono VARCHAR(20),
  Departamento CHAR(3)
);

CREATE TABLE INSCRIPCION (
    CIestudiante INT,
    Sigla VARCHAR(10),
    nota1 INT,
    nota2 INT,
    nota3 INT,
    notafinal INT,
    PRIMARY KEY (CIestudiante, Sigla)
);

INSERT INTO usuario (CI, Password, Usuario, Rol) VALUES ('1000', '123456','samuel1', 'director');
INSERT INTO usuario (CI, Password, Usuario, Rol) VALUES ('1001', '123456','alejandro1', 'estudiante');
INSERT INTO usuario (CI, Password, Usuario, Rol) VALUES ('1002', '123456','juan1', 'profesor');
INSERT INTO usuario (CI, Password, Usuario, Rol) VALUES ('1003', '123456','maria1', 'estudiante');
INSERT INTO usuario (CI, Password, Usuario, Rol) VALUES ('1004', '123456','pedro1', 'profesor');
INSERT INTO usuario (CI, Password, Usuario, Rol) VALUES ('1005', '123456','luis1', 'director');

INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono, Departamento) VALUES ('1000', 'Samuel Alegre','2002-04-29','(591)72568949', '02');
INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono, Departamento) VALUES ('1001', 'Alejandro Lopez','2000-08-01','(591)73045678', '02');
INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono, Departamento) VALUES ('1002', 'Juan Chavez','1998-11-29','(591)71547204', '01');
INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono, Departamento) VALUES ('1003', 'Maria Garcia','2003-06-19','(591)74017824', '03');
INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono, Departamento) VALUES ('1004', 'Pedro Flores','2000-12-26','(591)69824510', '03');
INSERT INTO persona (CI, Nombre_comp, Fecha_nac, Telefono, Departamento) VALUES ('1005', 'Luis Paredes','1995-03-04','(591)73047894', '07');

INSERT INTO inscripcion (CIestudiante, Sigla, nota1, nota2, nota3, notafinal) VALUES ('1000', 'INF-111','20','40', '10', '70');
INSERT INTO inscripcion (CIestudiante, Sigla, nota1, nota2, nota3, notafinal) VALUES ('1001', 'INF-324','25','30', '5', '60');
INSERT INTO inscripcion (CIestudiante, Sigla, nota1, nota2, nota3, notafinal) VALUES ('1002', 'INF-111','30','20', '10', '60');
INSERT INTO inscripcion (CIestudiante, Sigla, nota1, nota2, nota3, notafinal) VALUES ('1003', 'INF-131','32','42', '11', '85');
INSERT INTO inscripcion (CIestudiante, Sigla, nota1, nota2, nota3, notafinal) VALUES ('1004', 'MAT-114','10','10', '20', '40');
INSERT INTO inscripcion (CIestudiante, Sigla, nota1, nota2, nota3, notafinal) VALUES ('1005', 'INF-131','15','25', '10', '50');