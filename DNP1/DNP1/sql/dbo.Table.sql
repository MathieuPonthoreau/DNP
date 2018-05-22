CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [password] VARCHAR(50) NOT NULL, 
    [level] SMALLINT NOT NULL, 
    [pseudo] VARCHAR(50) NOT NULL, 
    [firstName] VARCHAR(50) NOT NULL, 
    [lastName] VARCHAR(50) NOT NULL, 
    [date_of_birth] DATE NOT NULL, 
    [sex] CHAR(1) NOT NULL , 
    
)
