CREATE DATABASE db3camadas; 
USE db3camadas; 

CREATE TABLE tbl_video
(
	id        INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	filme	  VARCHAR(40) NOT NULL,
	duracao	  TIME NOT NULL
);

CREATE TABLE tbl_categoria
(
	id		   INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
   descricao		   VARCHAR(45),
   
	FOREIGN KEY(idcategoria)) REFERENCES tbl_video(id)
);

