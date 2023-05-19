CREATE TABLE [dbo].[UserAllergy] (
    [IdUser]    INT NOT NULL,
    [IdAllergy] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUser] ASC, [IdAllergy] ASC),
    FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([Id]),
    FOREIGN KEY ([IdAllergy]) REFERENCES [dbo].[Allergy] ([Id])
);

