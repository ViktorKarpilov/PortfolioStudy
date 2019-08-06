CREATE TABLE [dbo].[Works] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Number]      INT            NOT NULL DEFAULT 1,
    [Url]         NVARCHAR (MAX) NOT NULL DEFAULT '/images/error.png',
    [Description] NVARCHAR (MAX) NOT NULL DEFAULT 'No description',
    CONSTRAINT [PK_Works] PRIMARY KEY CLUSTERED ([Id] ASC)
);

