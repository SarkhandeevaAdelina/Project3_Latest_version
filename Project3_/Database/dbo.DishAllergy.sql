CREATE TABLE [dbo].[DishAllergy] (
    [IdDish]    INT NOT NULL,
    [IdAllergy] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdDish] ASC, [IdAllergy] ASC),
    FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dish] ([Id]),
    FOREIGN KEY ([IdAllergy]) REFERENCES [dbo].[Allergy] ([Id])
);

