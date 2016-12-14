
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/14/2016 00:59:05
-- Generated from EDMX file: C:\Users\Andrius\Documents\GitHub\VisualStudio\PartShop\PartShop\ER\Model1.edmx
-- --------------------------------------------------

/*SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ItemCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemSet] DROP CONSTRAINT [FK_ItemCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSet] DROP CONSTRAINT [FK_ProductItem];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductSet] DROP CONSTRAINT [FK_UserProduct];
GO*/

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

/*IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[CategorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategorySet];
GO
IF OBJECT_ID(N'[dbo].[ItemSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemSet];
GO
IF OBJECT_ID(N'[dbo].[ProductSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductSet];*/
GO
IF OBJECT_ID(N'[dbo].[BoughtStuffSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BoughtStuffSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

/*-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [IsAdmin] bit  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CategorySet'
CREATE TABLE [dbo].[CategorySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ItemSet'
CREATE TABLE [dbo].[ItemSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] float  NOT NULL,
    [Make] nvarchar(max)  NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [ReleaseDate] datetime  NULL,
    [CountInStorage] int  NULL,
    [CategoryId] int  NOT NULL
);
GO

-- Creating table 'ProductSet'
CREATE TABLE [dbo].[ProductSet] (
    [Article] int  NOT NULL,
    [ItemId] int  NOT NULL,
    [UserId] int  NULL
);
GO*/

-- Creating table 'BoughtStuffSet'
CREATE TABLE [dbo].[BoughtStuffSet] (
    [Nr] int IDENTITY(1,1) NOT NULL,
    [Price] float  NOT NULL,
    [Make] nvarchar(max)  NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [ReleaseDate] datetime  NOT NULL,
    [Users] int  NOT NULL
);
GO

/*-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategorySet'
ALTER TABLE [dbo].[CategorySet]
ADD CONSTRAINT [PK_CategorySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemSet'
ALTER TABLE [dbo].[ItemSet]
ADD CONSTRAINT [PK_ItemSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Article] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [PK_ProductSet]
    PRIMARY KEY CLUSTERED ([Article] ASC);
GO*/

-- Creating primary key on [Nr] in table 'BoughtStuffSet'
ALTER TABLE [dbo].[BoughtStuffSet]
ADD CONSTRAINT [PK_BoughtStuffSet]
    PRIMARY KEY CLUSTERED ([Nr] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

/*-- Creating foreign key on [CategoryId] in table 'ItemSet'
ALTER TABLE [dbo].[ItemSet]
ADD CONSTRAINT [FK_ItemCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[CategorySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemCategory'
CREATE INDEX [IX_FK_ItemCategory]
ON [dbo].[ItemSet]
    ([CategoryId]);
GO

-- Creating foreign key on [ItemId] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [FK_ProductItem]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[ItemSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductItem'
CREATE INDEX [IX_FK_ProductItem]
ON [dbo].[ProductSet]
    ([ItemId]);
GO

-- Creating foreign key on [UserId] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [FK_UserProduct]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProduct'
CREATE INDEX [IX_FK_UserProduct]
ON [dbo].[ProductSet]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------*/