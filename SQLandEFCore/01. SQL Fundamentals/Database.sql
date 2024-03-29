--CREATE DATABASE SQLFundamentals

USE SQLFundamentals

--CREATE TABLE [Users](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Name] NVARCHAR(100) NOT NULL,
--	[Age] INT NOT NULL, 
--	[Gender] NVARCHAR(5) NOT NULL,
--	[Email] NVARCHAR(100) NOT NULL,
--	[PhoneNumber] NVARCHAR(20) NOT NULL,
--	[Weight] FLOAT NOT NULL,
--	[Height] FLOAT NOT NULL
--)

--CREATE TABLE [Trainers](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Name] NVARCHAR(100) NOT NULL,
--	[Age] INT NOT NULL, 
--	[Bio] NVARCHAR(1000) NOT NULL,
--	[Picture] NVARCHAR(500) NOT NULL,
--	[Rating] INT, 
--	[PhoneNumber] NVARCHAR (20) NOT NULL
--)

--CREATE TABLE [Locations](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[City] NVARCHAR(100) NOT NULL,
--	[Region] NVARCHAR(100) NOT NULL,
--	[Street] NVARCHAR(100) NOT NULL,
--	[Number] INT,
--	[ZIPCode] NVARCHAR(100) NOT NULL
--)

--CREATE TABLE [Schedules](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Date] DATETIME NOT NULL,
--	[LocationId] INT NOT NULL FOREIGN KEY REFERENCES [Locations]([Id])
--)


--CREATE TABLE [WorkoutCategories](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Name] NVARCHAR(100) NOT NULL
--)

--CREATE TABLE [Workouts](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Title] NVARCHAR(100) NOT NULL,
--	[Description] NVARCHAR(1000) NOT NULL,
--	[EquipmentNeeded] NVARCHAR(100),
--	[Duration] DATETIME NOT NULL,
--	[Gender] NVARCHAR(20) NOT NULL,
--	[IntensityLevel] INT NOT NULL,
--	[MaxCapacity] INT NOT NULL,
--	[Picture] NVARCHAR(200),
--	[Price] MONEY NOT NULL,
--	[WorkoutCategoryId] INT NOT NULL FOREIGN KEY REFERENCES [WorkoutCategories]([Id]),
--	[RecommendedFrequency] NVARCHAR(50),
--)

--CREATE TABLE [Payments](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Amount] MONEY NOT NULL,
--	[Date] DATETIME,
--	[Method] NVARCHAR(50) NOT NULL,
--	[UserId] INT NOT NULL FOREIGN KEY REFERENCES [Users]([Id]),
--	[WorkoutId] INT NOT NULL FOREIGN KEY REFERENCES [Workouts]([Id]),
--)

--CREATE TABLE [Ratings](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Date] DATETIME DEFAULT GETDATE(),
--	[Rating] INT NOT NULL CHECK ([Rating] >= 1 AND [Rating] <= 5),
--	[UserId] INT NOT NULL FOREIGN KEY REFERENCES [Users]([Id]),
--	[WorkoutId] INT NOT NULL FOREIGN KEY REFERENCES [Workouts]([Id]),

--)

--CREATE TABLE [Comments](
--	[Id] INT PRIMARY KEY IDENTITY,
--	[Content] NVARCHAR(500) NOT NULL,
--	[Date] DATETIME NOT NULL,
--	[UserId] INT NOT NULL FOREIGN KEY REFERENCES [Users]([Id]),
--	[WorkoutId] INT NOT NULL FOREIGN KEY REFERENCES [Workouts]([Id]),
--)

--CREATE TABLE [WorkoutsTrainersMapping](
--	[WorkoutId] INT NOT NULL FOREIGN KEY REFERENCES [Workouts]([Id]),
--	[TrainerId] INT NOT NULL FOREIGN KEY REFERENCES [Trainers]([Id]),
--    PRIMARY KEY ([WorkoutId], [TrainerId])
--)

--CREATE TABLE [WorkoutsSchedulesMapping](
--	[WorkoutId] INT NOT NULL FOREIGN KEY REFERENCES [Workouts]([Id]),
--	[ScheduleId] INT NOT NULL FOREIGN KEY REFERENCES [Schedules]([Id]),
--    PRIMARY KEY ([WorkoutId], [ScheduleId])
--)

--CREATE TABLE [LocationsWorkoustMapping](
--	[WorkoutId] INT NOT NULL FOREIGN KEY REFERENCES [Workouts]([Id]),
--	[LocationId] INT NOT NULL FOREIGN KEY REFERENCES [Locations]([Id]),
--    PRIMARY KEY ([WorkoutId], [LocationId])
--)
