CREATE TABLE [dbo].[Stagiaire] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Nom]         VARCHAR (MAX) NULL,
    [Prenom]      VARCHAR (MAX) NULL,
    [Adresse]     VARCHAR (MAX) NULL,
    [CodePostal] INT           NULL,
    [Ville]       VARCHAR (MAX) NULL,
    [Age]         INT           NULL,
    [Sexe]        VARCHAR (1)   NULL,
    [TuteurId]    INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Stagiaire_ToTuteur] FOREIGN KEY ([TuteurId]) REFERENCES [dbo].[Tuteur] ([Id])
);

