CREATE TABLE [dbo].[Ration]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdUser] INT NOT NULL, 
    [IdDayWeek] INT NOT NULL, 
    [IdDishBreakfast] INT NOT NULL, 
    [IdDishLunch] INT NOT NULL, 
    [IdDishDinner] INT NOT NULL, 
    [Kal] INT NOT NULL,
	FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([Id]),
	FOREIGN KEY ([IdDayWeek]) REFERENCES [dbo].[DayWeek] ([Id]),
	FOREIGN KEY ([IdDishBreakfast]) REFERENCES [dbo].[Dish] ([Id]),
	FOREIGN KEY ([IdDishLunch]) REFERENCES [dbo].[Dish] ([Id]),
	FOREIGN KEY ([IdDishDinner]) REFERENCES [dbo].[Dish] ([Id]),
)
