CREATE TABLE [dbo].[Inzerat]
(
	[IdInzerat] INT NOT NULL PRIMARY KEY identity, 
    [NazevInzeratu] NVARCHAR(200) NOT NULL, 
    [CisloInzeratu] INT NOT NULL, 
    [DatumVytvoreni] DATETIME2 NOT NULL
)
