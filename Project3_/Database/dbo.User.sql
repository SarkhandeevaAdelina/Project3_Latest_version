CREATE TABLE [dbo].[User] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Email]      NVARCHAR (30) NOT NULL,
    [Login]      NVARCHAR (30) NOT NULL,
    [Password]   NVARCHAR (30) NOT NULL,
    [SecondName] NVARCHAR (30) NOT NULL,
    [FirstName]  NVARCHAR (30) NOT NULL,
    [Patronymic] NVARCHAR (30) NULL,
    [Gender]     NVARCHAR (10) NULL,
    [Weight]     INT           NULL,
    [Goal]       NVARCHAR (20) NULL,
    [Height]     INT           NULL,
    [BMI]        INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

