/**********************************************************************
 *      BASE DE DATOS ZGAF_EX2P                          *
 *																	  *
 *      Archivo de Definici�n y Manipulaci�n de Datos (DDL y DML)     *
 *																	  *
 **********************************************************************/
 
 /*
    Fecha:          06/05/2019
    Nombre:         Fabricio Zacar�as Guzm�n
	Matr�cula		67664
 */

CREATE DATABASE ZGAF_EX2P
	GO

USE ZGAF_EX2P
	GO

CREATE TABLE Producto(Nombre VARCHAR(30), Precio INT, Cantidad INT);

INSERT INTO Producto VALUES ('Nombre', 1, 1);

SELECT * FROM Producto;