CREATE TABLE [dbo].[DishIngredint]
(
	[IdDish] INT NOT NULL , 
    [IdIngredient] INT NOT NULL, 
    PRIMARY KEY ([IdIngredient], [IdDish]),
	FOREIGN KEY ([IdDish]) REFERENCES [dbo].[Dish] ([Id]),
    FOREIGN KEY ([IdIngredient]) REFERENCES [dbo].[Ingredient] ([Id])
)
