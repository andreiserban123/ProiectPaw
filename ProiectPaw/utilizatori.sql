CREATE TABLE [dbo].Utilizatori
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nume] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [password] VARCHAR(1000) NULL, 
    [cnp] VARCHAR(50) NULL, 
    [data_nastere] DATETIME NULL
)
