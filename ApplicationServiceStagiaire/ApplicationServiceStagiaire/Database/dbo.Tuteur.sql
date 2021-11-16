CREATE TABLE [dbo].[Tuteur]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] VARCHAR(MAX) NULL, 
    [Prenom] VARCHAR(MAX) NULL, 
    [Adresse] VARCHAR(MAX) NULL, 
    [CodePostal] INT NULL, 
    [Telephone] INT NULL
)
