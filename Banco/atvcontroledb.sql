CREATE DATABASE atvcontroledb;

USE atvcontroledb;

CREATE TABLE usuarios(
id INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(70) NOT NULL,
cpf VARCHAR(11) NOT NULL UNIQUE,
senha VARCHAR(32) NOT NULL,
tipousuario VARCHAR (20) NOT NULL,
PRIMARY KEY(id)
);

-- ALTER TABLE usuarios ADD COLUMN
-- entrada BIT(1) NOT NULL;
-- ALTER TABLE usuarios
-- DROP COLUMN entrada;

INSERT INTO atvcontroledb.usuarios (nome, cpf, senha, tipousuario)
VALUES ('Marcell', '1234', md5('1234'), 'Administrador'
);

-- ALTER TABLE usuarios
-- MODIFY COLUMN cpf VARCHAR(11) NOT NULL UNIQUE; 
-- UPDATE usuarios SET cpf = '1234' WHERE id = 2;

DESC usuarios;

SELECT * FROM usuarios;


-- -----------------------------------------------------
-- Table `atvcontroledb`.`registros`
-- -----------------------------------------------------
CREATE TABLE registros(
id INT NOT NULL AUTO_INCREMENT,
id_usuario INT NOT NULL,
data_hora TIMESTAMP NULL, 
tipo_operacao ENUM('Entrada','Saida') DEFAULT 'Saida',
PRIMARY KEY(id),
FOREIGN KEY(id_usuario) REFERENCES usuarios(id)
);


-- update registros set data_hora = current_timestamp(), tipo_operacao = 'Entrada' WHERE id = 2;

-- ARRUMAR o comando de registro para colocar 'INSERT' e não 'UPDATE'.


INSERT INTO atvcontroledb.registros (id_usuario, data_hora, tipo_operacao)
VALUES (1, current_timestamp(), 'Entrada');

SELECT * FROM registros;
-- SELECT 'Entrada' FROM registros;





