CREATE TABLE [dbo].[Kategorie]
(
	[IdKategorie] SMALLINT NOT NULL PRIMARY KEY identity, 
    [Nazev] VARCHAR(255) NOT NULL, 
    [ParentId] SMALLINT NULL, 
    CONSTRAINT [FK_Kategorie_ToKategorie] FOREIGN KEY ([ParentId]) REFERENCES [Kategorie]([IdKategorie]) 
)
