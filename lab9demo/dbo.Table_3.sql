CREATE TABLE [dbo].[coachinginfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] VARCHAR(50) NOT NULL, 
    [level] VARCHAR(10) NOT NULL, 
    [modules] NCHAR(10) NULL
)
