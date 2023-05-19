CREATE TABLE [dbo].[Dish] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (80) NOT NULL,
    [Kal]      INT           NOT NULL,
    [DishType] NVARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

