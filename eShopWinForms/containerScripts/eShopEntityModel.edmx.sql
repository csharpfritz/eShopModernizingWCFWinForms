
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/13/2017 18:05:28
-- Generated from EDMX file: C:\Users\crwilhit.REDMOND\Documents\Visual Studio 2017\Projects\eshop\eShopWinForms\eShopServiceLibrary\eShopEntityModel.edmx
-- --------------------------------------------------
CREATE DATABASE eShopDatabase;
GO


SET QUOTED_IDENTIFIER OFF;
GO
USE [eShopDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CatalogBrand]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CatalogBrand];
GO
IF OBJECT_ID(N'[dbo].[CatalogItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CatalogItem];
GO
IF OBJECT_ID(N'[dbo].[CatalogType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CatalogType];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CatalogBrands'
CREATE TABLE [dbo].[CatalogBrands] (
    [Id] int  NOT NULL,
    [Brand] varchar(50)  NULL
);
GO

-- Creating table 'CatalogItems'
CREATE TABLE [dbo].[CatalogItems] (
    [Id] int  NOT NULL,
    [AvailableStock] int  NOT NULL,
    [Description] varchar(50)  NULL,
    [Name] varchar(50)  NULL,
    [Price] decimal(10,4)  NULL,
    [PictureFileName] varchar(50)  NULL,
    [CatalogBrandId] int  NOT NULL,
    [CatalogTypeId] int  NOT NULL
);
GO

-- Creating table 'CatalogTypes'
CREATE TABLE [dbo].[CatalogTypes] (
    [Id] int  NOT NULL,
    [Type] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CatalogBrands'
ALTER TABLE [dbo].[CatalogBrands]
ADD CONSTRAINT [PK_CatalogBrands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CatalogItems'
ALTER TABLE [dbo].[CatalogItems]
ADD CONSTRAINT [PK_CatalogItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CatalogTypes'
ALTER TABLE [dbo].[CatalogTypes]
ADD CONSTRAINT [PK_CatalogTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CatalogBrandId] in table 'CatalogItems'
ALTER TABLE [dbo].[CatalogItems]
ADD CONSTRAINT [FK_CatalogBrandCatalogItem]
    FOREIGN KEY ([CatalogBrandId])
    REFERENCES [dbo].[CatalogBrands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatalogBrandCatalogItem'
CREATE INDEX [IX_FK_CatalogBrandCatalogItem]
ON [dbo].[CatalogItems]
    ([CatalogBrandId]);
GO

-- Creating foreign key on [CatalogTypeId] in table 'CatalogItems'
ALTER TABLE [dbo].[CatalogItems]
ADD CONSTRAINT [FK_CatalogTypeCatalogItem]
    FOREIGN KEY ([CatalogTypeId])
    REFERENCES [dbo].[CatalogTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatalogTypeCatalogItem'
CREATE INDEX [IX_FK_CatalogTypeCatalogItem]
ON [dbo].[CatalogItems]
    ([CatalogTypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------