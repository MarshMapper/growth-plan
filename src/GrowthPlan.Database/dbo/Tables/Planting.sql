CREATE TABLE [dbo].[Planting]
(
	[PlantingId] INT NOT NULL PRIMARY KEY, 
    [PlantId] INT NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [Count] INT NULL, 
    [SeedPlanted] DATE NULL, 
    [Notes] NVARCHAR(MAX) NULL,
    CONSTRAINT FK_Plant_Planting FOREIGN KEY (PlantId)
        REFERENCES dbo.Plant(PlantId)
)
