CREATE TABLE [dbo].[Stagiaire] (
    [Id]         INT           NOT NULL IDENTITY PRIMARY KEY,
    [Nom]        VARCHAR (MAX) NULL,
    [Prenom]     VARCHAR (MAX) NULL,
    [Adresse]    VARCHAR (MAX) NULL,
    [CodePostal] INT           NULL,
    [Ville]      VARCHAR (MAX) NULL,
    [Age]        INT           NULL,
    [Sexe]       VARCHAR (50)  NULL
);

