/*
   sábado, 5 de noviembre de 202218:24:29
   User: 
   Server: DESKTOP-5C837BA\SQLEXPRESS01
   Database: ProyectoWeb3
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Usuarios SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Partido ADD
	Usuario int NULL
GO
ALTER TABLE dbo.Partido ADD CONSTRAINT
	FK_Usuario FOREIGN KEY
	(
	Usuario
	) REFERENCES dbo.Usuarios
	(
	IdUsuario
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Partido SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
