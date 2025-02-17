CREATE TABLE [dbo].[Plant]
(
	[PlantId] INT NOT NULL PRIMARY KEY, 
    [CommonName] NVARCHAR(200) NULL, 
    [ScientificName] NVARCHAR(200) NULL, 
    [GerminationDays] INT NULL, 
    [DaysToPot] INT NULL, 
    [DaysToOutdoors] INT NULL
)
