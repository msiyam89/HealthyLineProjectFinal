
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2020 23:58:21
-- Generated from EDMX file: C:\Users\user\source\repos\HealthyLineProjectFinal\DataAccessLayer\HealtyLineDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HealthyLinee];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserDeseases_Diseases]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserDeseases] DROP CONSTRAINT [FK_UserDeseases_Diseases];
GO
IF OBJECT_ID(N'[dbo].[FK_RecipesIngredients_Recipes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecipesIngredients] DROP CONSTRAINT [FK_RecipesIngredients_Recipes];
GO
IF OBJECT_ID(N'[dbo].[FK_RecipesSteps_Recipes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecipesSteps] DROP CONSTRAINT [FK_RecipesSteps_Recipes];
GO
IF OBJECT_ID(N'[dbo].[FK_UserDeseases_UserProfile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserDeseases] DROP CONSTRAINT [FK_UserDeseases_UserProfile];
GO
IF OBJECT_ID(N'[dbo].[FK_FoodSubCategories_FoodMainCategories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FoodSubCategories] DROP CONSTRAINT [FK_FoodSubCategories_FoodMainCategories];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ContactUs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContactUs];
GO
IF OBJECT_ID(N'[dbo].[Diseases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Diseases];
GO
IF OBJECT_ID(N'[dbo].[FoodMainCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FoodMainCategories];
GO
IF OBJECT_ID(N'[dbo].[FoodSubCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FoodSubCategories];
GO
IF OBJECT_ID(N'[dbo].[Recipes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recipes];
GO
IF OBJECT_ID(N'[dbo].[RecipesIngredients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RecipesIngredients];
GO
IF OBJECT_ID(N'[dbo].[RecipesSteps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RecipesSteps];
GO
IF OBJECT_ID(N'[dbo].[UserDeseases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserDeseases];
GO
IF OBJECT_ID(N'[dbo].[UserProfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProfiles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ContactUs'
CREATE TABLE [dbo].[ContactUs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserEmail] nvarchar(500)  NULL,
    [UserFullNameArabic] nvarchar(500)  NULL,
    [UserFullNameEnglish] nvarchar(500)  NULL,
    [UserName] nvarchar(500)  NULL,
    [Message] nvarchar(max)  NULL,
    [IsRegistered] bit  NULL,
    [CreatedBy] nvarchar(500)  NULL,
    [CreatedDate] datetime  NULL
);
GO

-- Creating table 'Diseases'
CREATE TABLE [dbo].[Diseases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameArabic] nvarchar(500)  NULL,
    [NameEnglish] nvarchar(500)  NULL
);
GO

-- Creating table 'FoodMainCategories'
CREATE TABLE [dbo].[FoodMainCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameArabic] nvarchar(500)  NULL,
    [NameEnglish] nvarchar(500)  NULL
);
GO

-- Creating table 'FoodSubCategories'
CREATE TABLE [dbo].[FoodSubCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FoodMainCategoryId] int  NULL,
    [NameArabic] nvarchar(500)  NULL,
    [NameEnglish] nvarchar(500)  NULL
);
GO

-- Creating table 'Recipes'
CREATE TABLE [dbo].[Recipes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameArabic] nvarchar(500)  NULL,
    [NameEnglish] nvarchar(500)  NULL
);
GO

-- Creating table 'RecipesIngredients'
CREATE TABLE [dbo].[RecipesIngredients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RecipeId] int  NULL,
    [Ingredients] nvarchar(500)  NULL
);
GO

-- Creating table 'RecipesSteps'
CREATE TABLE [dbo].[RecipesSteps] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RecipeId] int  NULL,
    [Details] nvarchar(max)  NULL
);
GO

-- Creating table 'UserDeseases'
CREATE TABLE [dbo].[UserDeseases] (
    [Id] int  NOT NULL,
    [ProfileId] int  NULL,
    [DiseasesId] int  NULL
);
GO

-- Creating table 'UserProfiles'
CREATE TABLE [dbo].[UserProfiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullNameArabic] nvarchar(500)  NULL,
    [FullNameEnglish] nvarchar(500)  NULL,
    [Gender] bit  NULL,
    [Birthdate] datetime  NULL,
    [Email] nvarchar(200)  NULL,
    [MobileNumber] nvarchar(200)  NULL,
    [CurrentWeight] float  NULL,
    [TargetWeight] float  NULL,
    [Height] float  NULL,
    [IdealWeight] float  NULL,
    [CreateBy] nvarchar(100)  NULL,
    [CreateDate] datetime  NULL,
    [UpdatedBy] nvarchar(100)  NULL,
    [UpdateDate] datetime  NULL,
    [UserName] nvarchar(50)  NULL,
    [Password] nvarchar(500)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ContactUs'
ALTER TABLE [dbo].[ContactUs]
ADD CONSTRAINT [PK_ContactUs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Diseases'
ALTER TABLE [dbo].[Diseases]
ADD CONSTRAINT [PK_Diseases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FoodMainCategories'
ALTER TABLE [dbo].[FoodMainCategories]
ADD CONSTRAINT [PK_FoodMainCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FoodSubCategories'
ALTER TABLE [dbo].[FoodSubCategories]
ADD CONSTRAINT [PK_FoodSubCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recipes'
ALTER TABLE [dbo].[Recipes]
ADD CONSTRAINT [PK_Recipes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RecipesIngredients'
ALTER TABLE [dbo].[RecipesIngredients]
ADD CONSTRAINT [PK_RecipesIngredients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RecipesSteps'
ALTER TABLE [dbo].[RecipesSteps]
ADD CONSTRAINT [PK_RecipesSteps]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserDeseases'
ALTER TABLE [dbo].[UserDeseases]
ADD CONSTRAINT [PK_UserDeseases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [PK_UserProfiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DiseasesId] in table 'UserDeseases'
ALTER TABLE [dbo].[UserDeseases]
ADD CONSTRAINT [FK_UserDeseases_Diseases]
    FOREIGN KEY ([DiseasesId])
    REFERENCES [dbo].[Diseases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDeseases_Diseases'
CREATE INDEX [IX_FK_UserDeseases_Diseases]
ON [dbo].[UserDeseases]
    ([DiseasesId]);
GO

-- Creating foreign key on [RecipeId] in table 'RecipesIngredients'
ALTER TABLE [dbo].[RecipesIngredients]
ADD CONSTRAINT [FK_RecipesIngredients_Recipes]
    FOREIGN KEY ([RecipeId])
    REFERENCES [dbo].[Recipes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecipesIngredients_Recipes'
CREATE INDEX [IX_FK_RecipesIngredients_Recipes]
ON [dbo].[RecipesIngredients]
    ([RecipeId]);
GO

-- Creating foreign key on [RecipeId] in table 'RecipesSteps'
ALTER TABLE [dbo].[RecipesSteps]
ADD CONSTRAINT [FK_RecipesSteps_Recipes]
    FOREIGN KEY ([RecipeId])
    REFERENCES [dbo].[Recipes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecipesSteps_Recipes'
CREATE INDEX [IX_FK_RecipesSteps_Recipes]
ON [dbo].[RecipesSteps]
    ([RecipeId]);
GO

-- Creating foreign key on [ProfileId] in table 'UserDeseases'
ALTER TABLE [dbo].[UserDeseases]
ADD CONSTRAINT [FK_UserDeseases_UserProfile]
    FOREIGN KEY ([ProfileId])
    REFERENCES [dbo].[UserProfiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDeseases_UserProfile'
CREATE INDEX [IX_FK_UserDeseases_UserProfile]
ON [dbo].[UserDeseases]
    ([ProfileId]);
GO

-- Creating foreign key on [FoodMainCategoryId] in table 'FoodSubCategories'
ALTER TABLE [dbo].[FoodSubCategories]
ADD CONSTRAINT [FK_FoodSubCategories_FoodMainCategories]
    FOREIGN KEY ([FoodMainCategoryId])
    REFERENCES [dbo].[FoodMainCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FoodSubCategories_FoodMainCategories'
CREATE INDEX [IX_FK_FoodSubCategories_FoodMainCategories]
ON [dbo].[FoodSubCategories]
    ([FoodMainCategoryId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------