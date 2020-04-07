CREATE TABLE [dbo].[Inzerat]
(
	[IdInzerat] INT NOT NULL PRIMARY KEY identity, 
    [NazevInzeratu] NVARCHAR(200) NOT NULL, 
    [CisloInzeratu] INT NOT NULL, 
    [DatumVytvoreni] DATETIME2 NOT NULL, 
    [KategorieId] SMALLINT NOT NULL, 
    CONSTRAINT [FK_Inzerat_ToKategorie] FOREIGN KEY ([KategorieId]) REFERENCES [Kategorie]([IdKategorie])
)
