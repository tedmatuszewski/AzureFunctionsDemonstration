CREATE TABLE [dbo].[Weather]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Text] VARCHAR(255) NULL,
	[DateAdded] [datetime2](7) NOT NULL,
	[AddedBy] VARCHAR(15) NOT NULL,
	[DateUpdated] [datetime2](7) NOT NULL,
	[UpdatedBy] VARCHAR(15) NOT NULL,
    [Deleted] BIT NOT NULL DEFAULT 0, 
)
