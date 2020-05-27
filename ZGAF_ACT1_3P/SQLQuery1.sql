/**********************************************************************
 *      BASE DE DATOS ZGAF_ACT1_3P                          *
 *																	  *
 *      Archivo de Definición y Manipulación de Datos (DDL y DML)     *
 *																	  *
 **********************************************************************/
 
 /*
    Fecha:          20/05/2019
    Autor:          Fabricio Zacarías Guzmán
    Comentarios:    1. Crea la base de datos

					2. Ponla en uso

					3. Crea las tablas en orden de Entidades Fuertes y entidades débiles

					4. Inserta  4 usuarios, 2 para clientes  y 2 para empleados, 2 categorías y 2 autos, 2 solicitudes de compra. (INSERT)

					5. Muestra la información de cada tabla (SELECT)

					6. Sube el archivo con la extensión sql
 */

CREATE DATABASE ZGAF_ACT1_3P;
GO

USE ZGAF_ACT1_3P;
GO

CREATE TABLE Usuario(IdUsuario	INT IDENTITY PRIMARY KEY, NombreUsuario VARCHAR(30), ContraseniaUsuario VARCHAR(30));
GO

INSERT INTO Usuario (NombreUsuario, ContraseniaUsuario) VALUES ('JuanLopez', 'laweafome00');

SELECT * FROM Usuario;

SELECT NombreUsuario, ContraseniaUsuario FROM Usuario WHERE NombreUsuario = 'JuanLopez' AND ContraseniaUsuario = 'laweafome00';